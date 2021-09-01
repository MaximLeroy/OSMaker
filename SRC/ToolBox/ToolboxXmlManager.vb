Imports System
Imports System.Xml
Imports System.Windows.Forms
Imports DevComponents.DotNetBar

Namespace ToolboxLibrary
    ''' <summary>
    ''' ToolboxXmlManager - Reads an XML file and populates the toolbox.
    ''' </summary>
    Public Class ToolboxXmlManager
        Private m_toolbox As Toolbox = Nothing
        Private cpcdosFormsToolTypes As Type() = New Type() {GetType(Button), GetType(CheckBox), GetType(TextBlock), GetType(TextBox), GetType(PictureBox), GetType(ProgressBar), GetType(Window), GetType(ListBox), GetType(Explorer)}
        'Private componentsToolTypes As Type() = New Type() {GetType(System.IO.FileSystemWatcher), GetType(System.Diagnostics.Process), GetType(Timers.Timer)}
        'Private dataToolTypes As Type() = New Type() {GetType(Data.OleDb.OleDbCommandBuilder), GetType(Data.OleDb.OleDbConnection), GetType(Data.SqlClient.SqlCommandBuilder), GetType(Data.SqlClient.SqlConnection)}
        'Private userControlsToolTypes As Type() = New Type() {GetType(UserControl)}

        Public Sub New(ByVal toolbox As Toolbox)
            m_toolbox = toolbox
        End Sub

        Public Function PopulateToolboxInfo() As ToolboxTabCollection
            Try
                If Equals(Toolbox.FilePath, Nothing) OrElse Equals(Toolbox.FilePath, "") OrElse Equals(Toolbox.FilePath, String.Empty) Then Return PopulateToolboxTabs()
                Dim xmlDocument As XmlDocument = New XmlDocument()
                xmlDocument.Load(Toolbox.FilePath)
                Return PopulateToolboxTabs(xmlDocument)
            Catch ex As Exception
                MessageBox.Show("Error occured in reading Toolbox.xml file." & Microsoft.VisualBasic.Constants.vbLf & ex.ToString())
                Return Nothing
            End Try
        End Function

        Private ReadOnly Property Toolbox As Toolbox
            Get
                Return m_toolbox
            End Get
        End Property

        Private Function PopulateToolboxTabs() As ToolboxTabCollection
            Dim toolboxTabs As ToolboxTabCollection = New ToolboxTabCollection()
            Dim tabNames = {Strings.CpcdosForms} 'Strings.Components, Strings.Data, Strings.UserControls}

            For i = 0 To tabNames.Length - 1
                Dim toolboxTab As ToolboxTab = New ToolboxTab()
                toolboxTab.Name = tabNames(i)
                PopulateToolboxItems(toolboxTab)
                toolboxTabs.Add(toolboxTab)
            Next

            Return toolboxTabs
        End Function

        Private Sub PopulateToolboxItems(ByVal toolboxTab As ToolboxTab)
            If toolboxTab Is Nothing Then Return
            Dim typeArray As Type() = Nothing

            Select Case toolboxTab.Name
                Case Strings.CpcdosForms
                    typeArray = cpcdosFormsToolTypes
                    '  Case Strings.Components
                    ' typeArray = componentsToolTypes
                    '  Case Strings.Data
                    ' typeArray = dataToolTypes
                    ' Case Strings.UserControls
                    '  typeArray = userControlsToolTypes
                    'Case Else
            End Select

            Dim toolboxItems As ToolboxItemCollection = New ToolboxItemCollection()

            For i = 0 To typeArray.Length - 1
                Dim toolboxItem As ToolboxItem = New ToolboxItem()
                toolboxItem.Type = typeArray(i)
                toolboxItem.Name = typeArray(i).Name
                toolboxItems.Add(toolboxItem)
            Next

            toolboxTab.ToolboxItems = toolboxItems
        End Sub

        Private Function PopulateToolboxTabs(ByVal xmlDocument As XmlDocument) As ToolboxTabCollection
            If xmlDocument Is Nothing Then Return Nothing
            Dim toolboxNode = xmlDocument.FirstChild
            If toolboxNode Is Nothing Then Return Nothing
            Dim tabCollectionNode = toolboxNode.FirstChild
            If tabCollectionNode Is Nothing Then Return Nothing
            Dim tabsNodeList = tabCollectionNode.ChildNodes
            If tabsNodeList Is Nothing Then Return Nothing
            Dim toolboxTabs As ToolboxTabCollection = New ToolboxTabCollection()

            For Each tabNode As XmlNode In tabsNodeList
                If tabNode Is Nothing Then Continue For
                Dim propertiesNode = tabNode.FirstChild
                If propertiesNode Is Nothing Then Continue For
                Dim nameNode As XmlNode = propertiesNode(Strings.Name)
                If nameNode Is Nothing Then Continue For
                Dim toolboxTab As ToolboxTab = New ToolboxTab()
                toolboxTab.Name = nameNode.InnerXml.ToString()
                PopulateToolboxItems(tabNode, toolboxTab)
                toolboxTabs.Add(toolboxTab)
            Next

            If toolboxTabs.Count = 0 Then Return Nothing
            Return toolboxTabs
        End Function

        Private Sub PopulateToolboxItems(ByVal tabNode As XmlNode, ByVal toolboxTab As ToolboxTab)
            If tabNode Is Nothing Then Return
            Dim toolboxItemCollectionNode As XmlNode = tabNode(Strings.ToolboxItemCollection)
            If toolboxItemCollectionNode Is Nothing Then Return
            Dim toolboxItemNodeList = toolboxItemCollectionNode.ChildNodes
            If toolboxItemNodeList Is Nothing Then Return
            Dim toolboxItems As ToolboxItemCollection = New ToolboxItemCollection()

            For Each toolboxItemNode As XmlNode In toolboxItemNodeList
                If toolboxItemNode Is Nothing Then Continue For
                Dim typeNode As XmlNode = toolboxItemNode(Strings.Type)
                If typeNode Is Nothing Then Continue For
                Dim found = False
                Dim loadedAssemblies As System.Reflection.Assembly() = AppDomain.CurrentDomain.GetAssemblies()
                Dim i = 0

                While i < loadedAssemblies.Length AndAlso Not found
                    Dim assembly = loadedAssemblies(i)
                    Dim types As Type() = assembly.GetTypes()
                    Dim j = 0

                    While j < types.Length AndAlso Not found
                        Dim type = types(j)

                        If Equals(type.FullName, typeNode.InnerXml.ToString()) Then
                            Dim toolboxItem As ToolboxItem = New ToolboxItem()
                            toolboxItem.Type = type
                            toolboxItems.Add(toolboxItem)
                            found = True
                        End If

                        j += 1
                    End While

                    i += 1
                End While
            Next

            toolboxTab.ToolboxItems = toolboxItems
            Return
        End Sub

        Private Class Strings
            Public Const Toolbox = "Toolbox"
            Public Const TabCollection = "TabCollection"
            Public Const Tab = "Tab"
            Public Const Properties = "Properties"
            Public Const Name = "Name"
            Public Const ToolboxItemCollection = "ToolboxItemCollection"
            Public Const ToolboxItem = "ToolboxItem"
            Public Const Type = "Type"
            Public Const CpcdosForms = "Objets Cpcdos"
            Public Const Components = "Components"
            'Public Const Data = "Data"
            Public Const UserControls = "User Controls"
        End Class
    End Class ' class
End Namespace ' namespace

