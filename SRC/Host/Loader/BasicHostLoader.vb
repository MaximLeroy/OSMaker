Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.ComponentModel.Design.Serialization
Imports System.Collections
Imports System.Diagnostics
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Windows.Forms
Imports System.Xml
Imports System.Runtime.InteropServices

Namespace Loader

    ''' <summary>
    ''' Inherits from BasicDesignerLoader. It can persist the HostSurface
    ''' to an Xml file and can also parse the Xml file to re-create the
    ''' RootComponent and all the components that it hosts.
    ''' </summary>
    Public Class BasicHostLoader
        Inherits BasicDesignerLoader

        Private root As IComponent
        Private dirty As Boolean = True
        Private unsaved As Boolean
        Private fileName As String
        Private host As IDesignerLoaderHost
        Private xmlDocument As XmlDocument
        Private Shared ReadOnly propertyAttributes As Object = New Attribute() {DesignOnlyAttribute.No}
        Private rootComponentType As Type


#Region "Constructors"

        ''' Empty constructor simply creates a new form.
        Public Sub New(ByVal rootComponentType As Type)
            Me.rootComponentType = rootComponentType
            Modified = True
        End Sub


        ''' <summary>
        ''' This constructor takes a file name.  This file
        ''' should exist on disk and consist of XML that
        ''' can be read by a data set.
        ''' </summary>
        Public Sub New(ByVal fileName As String)
            If Equals(fileName, Nothing) Then
                Throw New ArgumentNullException("fileName")
            End If

            Me.fileName = fileName
        End Sub

#End Region

#Region "Overriden methods of BasicDesignerLoader"

        ' Called by the host when we load a document.
        Protected Overrides Sub PerformLoad(ByVal designerSerializationManager As IDesignerSerializationManager)
            host = LoaderHost

            If host Is Nothing Then
                Throw New ArgumentNullException("BasicHostLoader.BeginLoad: Invalid designerLoaderHost.")
            End If


            ' The loader will put error messages in here.
            Dim errors As ArrayList = New ArrayList()
            Dim successful = True
            Dim baseClassName As String


            ' If no filename was passed in, just create a form and be done with it.  If a file name
            ' was passed, read it.
            If Equals(fileName, Nothing) Then

                If rootComponentType Is GetType(Form) Then
                    host.CreateComponent(GetType(Form))
                    baseClassName = "Form1"
                ElseIf rootComponentType Is GetType(UserControl) Then
                    host.CreateComponent(GetType(UserControl))
                    baseClassName = "UserControl1"
                ElseIf rootComponentType Is GetType(Component) Then
                    host.CreateComponent(GetType(Component))
                    baseClassName = "Component1"
                Else
                    Throw New Exception("Undefined Host Type: " & rootComponentType.ToString())
                End If
            Else
                baseClassName = ReadFile(fileName, errors, xmlDocument)
            End If


            ' Now that we are done with the load work, we need to begin to listen to events.
            ' Listening to event notifications is how a designer "Loader" can also be used
            ' to save data.  If we wanted to integrate this loader with source code control,
            ' we would listen to the "ing" events as well as the "ed" events.
            Dim cs As IComponentChangeService = TryCast(host.GetService(GetType(IComponentChangeService)), IComponentChangeService)

            If cs IsNot Nothing Then
                AddHandler cs.ComponentChanged, New ComponentChangedEventHandler(AddressOf OnComponentChanged)
                AddHandler cs.ComponentAdded, New ComponentEventHandler(AddressOf OnComponentAddedRemoved)
                AddHandler cs.ComponentRemoved, New ComponentEventHandler(AddressOf OnComponentAddedRemoved)
            End If


            ' Let the host know we are done loading.
            host.EndLoad(baseClassName, successful, errors)

            ' We've just loaded a document, so you can bet we need to flush changes.
            dirty = True
            unsaved = False
        End Sub


        ''' <summary>
        ''' This method is called by the designer host whenever it wants the
        ''' designer loader to flush any pending changes.  Flushing changes
        ''' does not mean the same thing as saving to disk.  For example,
        ''' In Visual Studio, flushing changes causes new code to be generated
        ''' and inserted into the text editing window.  The user can edit
        ''' the new code in the editing window, but nothing has been saved
        ''' to disk.  This sample adheres to this separation between flushing
        ''' and saving, since a flush occurs whenever the code windows are
        ''' displayed or there is a build. Neither of those items demands a save.
        ''' </summary>
        Protected Overrides Sub PerformFlush(ByVal designerSerializationManager As IDesignerSerializationManager)
            ' Nothing to flush if nothing has changed.
            If Not dirty Then
                Return
            End If

            PerformFlushWorker()
        End Sub

        Public Overrides Sub Dispose()
            ' Always remove attached event handlers in Dispose.
            Dim cs As IComponentChangeService = TryCast(host.GetService(GetType(IComponentChangeService)), IComponentChangeService)

            If cs IsNot Nothing Then
                RemoveHandler cs.ComponentChanged, New ComponentChangedEventHandler(AddressOf OnComponentChanged)
                RemoveHandler cs.ComponentAdded, New ComponentEventHandler(AddressOf OnComponentAddedRemoved)
                RemoveHandler cs.ComponentRemoved, New ComponentEventHandler(AddressOf OnComponentAddedRemoved)
            End If
        End Sub


#End Region

#Region "Helper methods"

        ''' <summary>
        ''' Simple helper method that returns true if the given type converter supports
        ''' two-way conversion of the given type.
        ''' </summary>
        Private Function GetConversionSupported(ByVal converter As TypeConverter, ByVal conversionType As Type) As Boolean
            Return converter.CanConvertFrom(conversionType) AndAlso converter.CanConvertTo(conversionType)
        End Function


        ''' <summary>
        ''' As soon as things change, we're dirty, so Flush()ing will give us a new
        ''' xmlDocument and codeCompileUnit.
        ''' </summary>
        Private Sub OnComponentChanged(ByVal sender As Object, ByVal ce As ComponentChangedEventArgs)
            dirty = True
            unsaved = True
        End Sub

        Private Sub OnComponentAddedRemoved(ByVal sender As Object, ByVal ce As ComponentEventArgs)
            dirty = True
            unsaved = True
        End Sub


        ''' <summary>
        ''' This method prompts the user to see if it is OK to dispose this document.  
        ''' The prompt only happens if the user has made changes.
        ''' </summary>
        Friend Function PromptDispose() As Boolean
            If dirty OrElse unsaved Then

                Select Case MessageBox.Show("Save changes to existing designer?", "Unsaved Changes", MessageBoxButtons.YesNoCancel)
                    Case DialogResult.Yes
                        Save(False)
                    Case DialogResult.Cancel
                        Return False
                End Select
            End If

            Return True
        End Function


#End Region

#Region "Serialize - Flush"
        ''' <summary>
        ''' This will recussively go through all the objects in the tree and
        ''' serialize them to Xml
        ''' </summary>
        Public Sub PerformFlushWorker()
            Dim document As XmlDocument = New XmlDocument()
            document.AppendChild(document.CreateElement("DOCUMENT_ELEMENT"))
            Dim idh = CType(host.GetService(GetType(IDesignerHost)), IDesignerHost)
            root = idh.RootComponent
            Dim nametable As Hashtable = New Hashtable(idh.Container.Components.Count)
            Dim manager As IDesignerSerializationManager = TryCast(host.GetService(GetType(IDesignerSerializationManager)), IDesignerSerializationManager)
            document.DocumentElement.AppendChild(WriteObject(document, nametable, root))

            For Each comp As IComponent In idh.Container.Components

                If comp IsNot root AndAlso Not nametable.ContainsKey(comp) Then
                    document.DocumentElement.AppendChild(WriteObject(document, nametable, comp))
                End If
            Next

            xmlDocument = document
        End Sub

        Private Function WriteObject(ByVal document As XmlDocument, ByVal nametable As IDictionary, ByVal value As Object) As XmlNode
            Dim idh = CType(host.GetService(GetType(IDesignerHost)), IDesignerHost)
            Debug.Assert(value IsNot Nothing, "Should not invoke WriteObject with a null value")
            Dim node As XmlNode = document.CreateElement("Object")
            Dim typeAttr = document.CreateAttribute("type")
            typeAttr.Value = value.GetType().AssemblyQualifiedName
            node.Attributes.Append(typeAttr)
            Dim component As IComponent = TryCast(value, IComponent)

            If component IsNot Nothing AndAlso component.Site IsNot Nothing AndAlso Not Equals(component.Site.Name, Nothing) Then
                Dim nameAttr = document.CreateAttribute("name")
                nameAttr.Value = component.Site.Name
                node.Attributes.Append(nameAttr)
                Debug.Assert(nametable(component) Is Nothing, "WriteObject should not be called more than once for the same object.  Use WriteReference instead")
                nametable(value) = component.Site.Name
            End If

            Dim isControl = TypeOf value Is Control

            If isControl Then
                Dim childAttr = document.CreateAttribute("children")
                childAttr.Value = "Controls"
                node.Attributes.Append(childAttr)
            End If

            If component IsNot Nothing Then

                If isControl Then

                    For Each child As Control In CType(value, Control).Controls

                        If child.Site IsNot Nothing AndAlso child.Site.Container Is idh.Container Then
                            node.AppendChild(WriteObject(document, nametable, child))
                        End If
                    Next
                End If ' if isControl
                Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(value, propertyAttributes)

                If isControl Then
                    Dim controlProp = properties("Controls")

                    If controlProp IsNot Nothing Then
                        Dim propArray = New PropertyDescriptor(properties.Count - 1 - 1) {}
                        Dim idx = 0

                        For Each p As PropertyDescriptor In properties

                            If p IsNot controlProp Then
                                propArray(Math.Min(Threading.Interlocked.Increment(idx), idx - 1)) = p
                            End If
                        Next

                        properties = New PropertyDescriptorCollection(propArray)
                    End If
                End If

                WriteProperties(document, properties, value, node, "Property")
                Dim events As EventDescriptorCollection = TypeDescriptor.GetEvents(value, propertyAttributes)
                Dim bindings As IEventBindingService = TryCast(host.GetService(GetType(IEventBindingService)), IEventBindingService)

                If bindings IsNot Nothing Then
                    properties = bindings.GetEventProperties(events)
                    WriteProperties(document, properties, value, node, "Event")
                End If
            Else
                WriteValue(document, value, node)
            End If

            Return node
        End Function

        Private Sub WriteProperties(ByVal document As XmlDocument, ByVal properties As PropertyDescriptorCollection, ByVal value As Object, ByVal parent As XmlNode, ByVal elementName As String)
            For Each prop As PropertyDescriptor In properties

                If Equals(prop.Name, "AutoScaleBaseSize") Then
                    Dim _DEBUG_ = prop.Name
                End If

                If prop.ShouldSerializeValue(value) Then
                    Dim compName = parent.Name
                    Dim node As XmlNode = document.CreateElement(elementName)
                    Dim attr = document.CreateAttribute("name")
                    attr.Value = prop.Name
                    node.Attributes.Append(attr)
                    Dim visibility = CType(prop.Attributes(GetType(DesignerSerializationVisibilityAttribute)), DesignerSerializationVisibilityAttribute)

                    Select Case visibility.Visibility
                        Case DesignerSerializationVisibility.Visible

                            If Not prop.IsReadOnly AndAlso WriteValue(document, prop.GetValue(value), node) Then
                                parent.AppendChild(node)
                            End If

                        Case DesignerSerializationVisibility.Content
                            Dim propValue = prop.GetValue(value)

                            If GetType(IList).IsAssignableFrom(prop.PropertyType) Then
                                WriteCollection(document, CType(propValue, IList), node)
                            Else
                                Dim props = TypeDescriptor.GetProperties(propValue, propertyAttributes)
                                WriteProperties(document, props, propValue, node, elementName)
                            End If

                            If node.ChildNodes.Count > 0 Then
                                parent.AppendChild(node)
                            End If

                        Case Else
                    End Select
                End If
            Next
        End Sub

        Private Function WriteReference(ByVal document As XmlDocument, ByVal value As IComponent) As XmlNode
            Dim idh = CType(host.GetService(GetType(IDesignerHost)), IDesignerHost)
            Debug.Assert(value IsNot Nothing AndAlso value.Site IsNot Nothing AndAlso value.Site.Container Is idh.Container, "Invalid component passed to WriteReference")
            Dim node As XmlNode = document.CreateElement("Reference")
            Dim attr = document.CreateAttribute("name")
            attr.Value = value.Site.Name
            node.Attributes.Append(attr)
            Return node
        End Function

        Private Function WriteValue(ByVal document As XmlDocument, ByVal value As Object, ByVal parent As XmlNode) As Boolean
            Dim idh = CType(host.GetService(GetType(IDesignerHost)), IDesignerHost)


            ' For empty values, we just return.  This creates an empty node.
            If value Is Nothing Then
                Return True
            End If

            Dim converter = TypeDescriptor.GetConverter(value)

            If GetConversionSupported(converter, GetType(String)) Then
                parent.InnerText = CStr(converter.ConvertTo(Nothing, CultureInfo.InvariantCulture, value, GetType(String)))
            ElseIf GetConversionSupported(converter, GetType(Byte())) Then
                Dim data = CType(converter.ConvertTo(Nothing, CultureInfo.InvariantCulture, value, GetType(Byte())), Byte())
                parent.AppendChild(WriteBinary(document, data))
            ElseIf GetConversionSupported(converter, GetType(InstanceDescriptor)) Then
                Dim id = CType(converter.ConvertTo(Nothing, CultureInfo.InvariantCulture, value, GetType(InstanceDescriptor)), InstanceDescriptor)
                parent.AppendChild(WriteInstanceDescriptor(document, id, value))
            ElseIf TypeOf value Is IComponent AndAlso CType(value, IComponent).Site IsNot Nothing AndAlso CType(value, IComponent).Site.Container Is idh.Container Then
                parent.AppendChild(WriteReference(document, CType(value, IComponent)))
            ElseIf value.GetType().IsSerializable Then
                Dim formatter As BinaryFormatter = New BinaryFormatter()
                Dim stream As MemoryStream = New MemoryStream()
                formatter.Serialize(stream, value)
                Dim binaryNode As XmlNode = WriteBinary(document, stream.ToArray())
                parent.AppendChild(binaryNode)
            Else
                Return False
            End If

            Return True
        End Function

        Private Sub WriteCollection(ByVal document As XmlDocument, ByVal list As IList, ByVal parent As XmlNode)
            For Each obj In list
                Dim node As XmlNode = document.CreateElement("Item")
                Dim typeAttr = document.CreateAttribute("type")
                typeAttr.Value = obj.GetType().AssemblyQualifiedName
                node.Attributes.Append(typeAttr)
                WriteValue(document, obj, node)
                parent.AppendChild(node)
            Next
        End Sub

        Private Function WriteBinary(ByVal document As XmlDocument, ByVal value As Byte()) As XmlNode
            Dim node As XmlNode = document.CreateElement("Binary")
            node.InnerText = Convert.ToBase64String(value)
            Return node
        End Function

        Private Function WriteInstanceDescriptor(ByVal document As XmlDocument, ByVal desc As InstanceDescriptor, ByVal value As Object) As XmlNode
            Dim node As XmlNode = document.CreateElement("InstanceDescriptor")
            Dim formatter As BinaryFormatter = New BinaryFormatter()
            Dim stream As MemoryStream = New MemoryStream()
            formatter.Serialize(stream, desc.MemberInfo)
            Dim memberAttr = document.CreateAttribute("member")
            memberAttr.Value = Convert.ToBase64String(stream.ToArray())
            node.Attributes.Append(memberAttr)

            For Each arg In desc.Arguments
                Dim argNode As XmlNode = document.CreateElement("Argument")

                If WriteValue(document, arg, argNode) Then
                    node.AppendChild(argNode)
                End If
            Next

            If Not desc.IsComplete Then
                Dim props = TypeDescriptor.GetProperties(value, propertyAttributes)
                WriteProperties(document, props, value, node, "Property")
            End If

            Return node
        End Function


#End Region

#Region "DeSerialize - Load"

        ''' <summary>
        ''' This method is used to parse the given file.  Before calling this 
        ''' method the host member variable must be setup.  This method will
        ''' create a data set, read the data set from the XML stored in the
        ''' file, and then walk through the data set and create components
        ''' stored within it.  The data set is stored in the persistedData
        ''' member variable upon return.
        ''' 
        ''' This method never throws exceptions.  It will set the successful
        ''' ref parameter to false when there are catastrophic errors it can't
        ''' resolve (like being unable to parse the XML).  All error exceptions
        ''' are added to the errors array list, including minor errors.
        ''' </summary>
        Private Function ReadFile(ByVal fileName As String, ByVal errors As ArrayList, <Out> ByRef document As XmlDocument) As String
            Dim baseClass As String = Nothing


            ' Anything unexpected is a fatal error.
            '
            Try
                ' The main form and items in the component tray will be at the
                ' same level, so we have to create a higher super-root in order
                ' to construct our XmlDocument.
                Dim sr As StreamReader = New StreamReader(fileName)
                Dim cleandown As String = sr.ReadToEnd()
                cleandown = "<DOCUMENT_ELEMENT>" & cleandown & "</DOCUMENT_ELEMENT>"
                Dim doc As XmlDocument = New XmlDocument()
                doc.LoadXml(cleandown)


                ' Now, walk through the document's elements.
                '
                For Each node As XmlNode In doc.DocumentElement.ChildNodes

                    If Equals(baseClass, Nothing) Then
                        baseClass = node.Attributes("name").Value
                    End If

                    If node.Name.Equals("Object") Then
                        ReadObject(node, errors)
                    Else
                        errors.Add(String.Format("Node type {0} is not allowed here.", node.Name))
                    End If
                Next

                document = doc
            Catch ex As Exception
                document = Nothing
                errors.Add(ex)
            End Try

            Return baseClass
        End Function

        Private Sub ReadEvent(ByVal childNode As XmlNode, ByVal instance As Object, ByVal errors As ArrayList)
            Dim bindings As IEventBindingService = TryCast(host.GetService(GetType(IEventBindingService)), IEventBindingService)

            If bindings Is Nothing Then
                errors.Add("Unable to contact event binding service so we can't bind any events")
                Return
            End If

            Dim nameAttr = childNode.Attributes("name")

            If nameAttr Is Nothing Then
                errors.Add("No event name")
                Return
            End If

            Dim methodAttr = childNode.Attributes("method")

            If methodAttr Is Nothing OrElse Equals(methodAttr.Value, Nothing) OrElse methodAttr.Value.Length = 0 Then
                errors.Add(String.Format("Event {0} has no method bound to it"))
                Return
            End If

            Dim evt = TypeDescriptor.GetEvents(instance)(nameAttr.Value)

            If evt Is Nothing Then
                errors.Add(String.Format("Event {0} does not exist on {1}", nameAttr.Value, instance.GetType().FullName))
                Return
            End If

            Dim prop = bindings.GetEventProperty(evt)
            Debug.Assert(prop IsNot Nothing, "Bad event binding service")

            Try
                prop.SetValue(instance, methodAttr.Value)
            Catch ex As Exception
                errors.Add(ex.Message)
            End Try
        End Sub

        Private Function ReadInstanceDescriptor(ByVal node As XmlNode, ByVal errors As ArrayList) As Object
            ' First, need to deserialize the member
            '
            Dim memberAttr = node.Attributes("member")

            If memberAttr Is Nothing Then
                errors.Add("No member attribute on instance descriptor")
                Return Nothing
            End If

            Dim data = Convert.FromBase64String(memberAttr.Value)
            Dim formatter As BinaryFormatter = New BinaryFormatter()
            Dim stream As MemoryStream = New MemoryStream(data)
            Dim mi = CType(formatter.Deserialize(stream), MemberInfo)
            Dim args As Object() = Nothing


            ' Check to see if this member needs arguments.  If so, gather
            ' them from the XML.
            If TypeOf mi Is MethodBase Then
                Dim paramInfos As ParameterInfo() = CType(mi, MethodBase).GetParameters()
                args = New Object(paramInfos.Length - 1) {}
                Dim idx = 0

                For Each child As XmlNode In node.ChildNodes

                    If child.Name.Equals("Argument") Then
                        Dim value As Object

                        If Not ReadValue(child, TypeDescriptor.GetConverter(paramInfos(idx).ParameterType), errors, value) Then
                            Return Nothing
                        End If

                        args(Math.Min(Threading.Interlocked.Increment(idx), idx - 1)) = value
                    End If
                Next

                If idx <> paramInfos.Length Then
                    errors.Add(String.Format("Member {0} requires {1} arguments, not {2}.", mi.Name, args.Length, idx))
                    Return Nothing
                End If
            End If

            Dim id As InstanceDescriptor = New InstanceDescriptor(mi, args)
            Dim instance As Object = id.Invoke()


            ' Ok, we have our object.  Now, check to see if there are any properties, and if there are, 
            ' set them.
            '
            For Each prop As XmlNode In node.ChildNodes

                If prop.Name.Equals("Property") Then
                    ReadProperty(prop, instance, errors)
                End If
            Next

            Return instance
        End Function

        ''' Reads the "Object" tags. This returns an instance of the
        ''' newly created object. Returns null if there was an error.
        Private Function ReadObject(ByVal node As XmlNode, ByVal errors As ArrayList) As Object
            Dim typeAttr = node.Attributes("type")

            If typeAttr Is Nothing Then
                errors.Add("<Object> tag is missing required type attribute")
                Return Nothing
            End If

            Dim type = System.Type.GetType(typeAttr.Value)

            If type Is Nothing Then
                errors.Add(String.Format("Type {0} could not be loaded.", typeAttr.Value))
                Return Nothing
            End If


            ' This can be null if there is no name for the object.
            '
            Dim nameAttr = node.Attributes("name")
            Dim instance As Object

            If GetType(IComponent).IsAssignableFrom(type) Then

                If nameAttr Is Nothing Then
                    instance = host.CreateComponent(type)
                Else
                    instance = host.CreateComponent(type, nameAttr.Value)
                End If
            Else
                instance = Activator.CreateInstance(type)
            End If


            ' Got an object, now we must process it.  Check to see if this tag
            ' offers a child collection for us to add children to.
            '
            Dim childAttr = node.Attributes("children")
            Dim childList As IList = Nothing

            If childAttr IsNot Nothing Then
                Dim childProp = TypeDescriptor.GetProperties(instance)(childAttr.Value)

                If childProp Is Nothing Then
                    errors.Add(String.Format("The children attribute lists {0} as the child collection but this is not a property on {1}", childAttr.Value, instance.GetType().FullName))
                Else
                    childList = TryCast(childProp.GetValue(instance), IList)

                    If childList Is Nothing Then
                        errors.Add(String.Format("The property {0} was found but did not return a valid IList", childProp.Name))
                    End If
                End If
            End If


            ' Now, walk the rest of the tags under this element.
            '
            For Each childNode As XmlNode In node.ChildNodes

                If childNode.Name.Equals("Object") Then

                    ' Another object.  In this case, create the object, and
                    ' parent it to ours using the children property.  If there
                    ' is no children property, bail out now.
                    If childAttr Is Nothing Then
                        errors.Add("Child object found but there is no children attribute")
                        Continue For
                    End If


                    ' no sense doing this if there was an error getting the property.  We've already reported the
                    ' error above.
                    If childList IsNot Nothing Then
                        Dim childInstance = ReadObject(childNode, errors)
                        childList.Add(childInstance)
                    End If
                ElseIf childNode.Name.Equals("Property") Then
                    ' A property.  Ask the property to parse itself.
                    '
                    ReadProperty(childNode, instance, errors)
                ElseIf childNode.Name.Equals("Event") Then
                    ' An event.  Ask the event to parse itself.
                    '
                    ReadEvent(childNode, instance, errors)
                End If
            Next

            Return instance
        End Function

        ''' Parses the given XML node and sets the resulting property value.
        Private Sub ReadProperty(ByVal node As XmlNode, ByVal instance As Object, ByVal errors As ArrayList)
            Dim nameAttr = node.Attributes("name")

            If nameAttr Is Nothing Then
                errors.Add("Property has no name")
                Return
            End If

            Dim prop = TypeDescriptor.GetProperties(instance)(nameAttr.Value)

            If prop Is Nothing Then
                errors.Add(String.Format("Property {0} does not exist on {1}", nameAttr.Value, instance.GetType().FullName))
                Return
            End If


            ' Get the type of this property.  We have three options:
            ' 1.  A normal read/write property.
            ' 2.  A "Content" property.
            ' 3.  A collection.
            '
            Dim isContent = prop.Attributes.Contains(DesignerSerializationVisibilityAttribute.Content)

            If isContent Then
                Dim value = prop.GetValue(instance)


                ' Handle the case of a content property that is a collection.
                '
                If TypeOf value Is IList Then

                    For Each child As XmlNode In node.ChildNodes

                        If child.Name.Equals("Item") Then
                            Dim item As Integer
                            Dim typeAttr = child.Attributes("type")

                            If typeAttr Is Nothing Then
                                errors.Add("Item has no type attribute")
                                Continue For
                            End If

                            Dim type = System.Type.GetType(typeAttr.Value)

                            If type Is Nothing Then
                                errors.Add(String.Format("Item type {0} could not be found.", typeAttr.Value))
                                Continue For
                            End If

                            If ReadValue(child, TypeDescriptor.GetConverter(type), errors, item) Then

                                Try
                                    CType(value, IList).Add(item)
                                Catch ex As Exception
                                    errors.Add(ex.Message)
                                End Try
                            End If
                        Else
                            errors.Add(String.Format("Only Item elements are allowed in collections, not {0} elements.", child.Name))
                        End If
                    Next
                Else

                    ' Handle the case of a content property that consists of child properties.
                    '
                    For Each child As XmlNode In node.ChildNodes

                        If child.Name.Equals("Property") Then
                            ReadProperty(child, value, errors)
                        Else
                            errors.Add(String.Format("Only Property elements are allowed in content properties, not {0} elements.", child.Name))
                        End If
                    Next
                End If
            Else
                Dim value As Integer

                If ReadValue(node, prop.Converter, errors, value) Then

                    ' ReadValue succeeded.  Fill in the property value.
                    '
                    Try
                        prop.SetValue(instance, value)
                    Catch ex As Exception
                        errors.Add(ex.Message)
                    End Try
                End If
            End If
        End Sub

        ''' Generic function to read an object value.  Returns true if the read
        ''' succeeded.
        Private Function ReadValue(ByVal node As XmlNode, ByVal converter As TypeConverter, ByVal errors As ArrayList, <Out> ByRef value As Object) As Boolean
            Try

                For Each child As XmlNode In node.ChildNodes

                    If child.NodeType = XmlNodeType.Text Then
                        value = converter.ConvertFromInvariantString(node.InnerText)
                        Return True
                    ElseIf child.Name.Equals("Binary") Then
                        Dim data = Convert.FromBase64String(child.InnerText)


                        ' Binary blob.  Now, check to see if the type converter
                        ' can convert it.  If not, use serialization.
                        '
                        If GetConversionSupported(converter, GetType(Byte())) Then
                            value = converter.ConvertFrom(Nothing, CultureInfo.InvariantCulture, data)
                            Return True
                        Else
                            Dim formatter As BinaryFormatter = New BinaryFormatter()
                            Dim stream As MemoryStream = New MemoryStream(data)
                            value = formatter.Deserialize(stream)
                            Return True
                        End If
                    ElseIf child.Name.Equals("InstanceDescriptor") Then
                        value = ReadInstanceDescriptor(child, errors)
                        Return value IsNot Nothing
                    Else
                        errors.Add(String.Format("Unexpected element type {0}", child.Name))
                        value = Nothing
                        Return False
                    End If
                Next


                ' If we get here, it is because there were no nodes.  No nodes and no inner
                ' text is how we signify null.
                '
                value = Nothing
                Return True
            Catch ex As Exception
                errors.Add(ex.Message)
                value = Nothing
                Return False
            End Try
        End Function


#End Region

#Region "Public methods"

        ''' This method writes out the contents of our designer in XML.
        ''' It writes out the contents of xmlDocument.
        Public Function GetCode() As String
            Flush()
            Dim sw As StringWriter
            sw = New StringWriter()
            Dim xtw As XmlTextWriter = New XmlTextWriter(sw)
            xtw.Formatting = Formatting.Indented
            xmlDocument.WriteTo(xtw)
            Dim cleanup As String = sw.ToString().Replace("<DOCUMENT_ELEMENT>", "")
            cleanup = cleanup.Replace("</DOCUMENT_ELEMENT>", "")
            sw.Close()
            Return cleanup
        End Function

        Public Sub Save()
            Save(False)
        End Sub


        ''' <summary>
        ''' Save the current state of the loader. If the user loaded the file
        ''' or saved once before, then he doesn't need to select a file again.
        ''' Unless this is being called as a result of "Save As..." being clicked,
        ''' in which case forceFilePrompt will be true.
        ''' </summary>
        Public Sub Save(ByVal forceFilePrompt As Boolean)
            Try
                Flush()
                Dim filterIndex = 3

                If Equals(fileName, Nothing) OrElse forceFilePrompt Then
                    Dim dlg As SaveFileDialog = New SaveFileDialog()
                    dlg.DefaultExt = "xml"
                    dlg.Filter = "XML Files|*.xml"

                    If dlg.ShowDialog() = DialogResult.OK Then
                        fileName = dlg.FileName
                        filterIndex = dlg.FilterIndex
                    End If
                End If

                If Not Equals(fileName, Nothing) Then

                    Select Case filterIndex
                        Case 1
                            ' Write out our xmlDocument to a file.
                            Dim sw As StringWriter = New StringWriter()
                            Dim xtw As XmlTextWriter = New XmlTextWriter(sw)
                            xtw.Formatting = Formatting.Indented
                            xmlDocument.WriteTo(xtw)

                            ' Get rid of our artificial super-root before we save out
                            ' the XML.
                            '
                            Dim cleanup As String = sw.ToString().Replace("<DOCUMENT_ELEMENT>", "")
                            cleanup = cleanup.Replace("</DOCUMENT_ELEMENT>", "")
                            xtw.Close()
                            Dim file As StreamWriter = New StreamWriter(fileName)
                            file.Write(cleanup)
                            file.Close()
                    End Select

                    unsaved = False
                End If

            Catch ex As Exception
                MessageBox.Show("Error during save: " & ex.ToString())
            End Try
        End Sub

#End Region

    End Class ' class
End Namespace ' namespace
