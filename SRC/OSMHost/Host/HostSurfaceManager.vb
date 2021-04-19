Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.ComponentModel.Design.Serialization
Imports System.Windows.Forms
Imports System.IO
Imports System.Windows.Forms.Design
Imports ToolBox
Imports System.CodeDom


Namespace OSMaker
    Public Enum LoaderType
        BasicDesignerLoader = 1
        CodeDomDesignerLoader = 2
        NoLoader = 3
    End Enum


    ''' <summary>
    ''' Manages numerous HostSurfaces. Any services added to HostSurfaceManager
    ''' will be accessible to all HostSurfaces
    ''' </summary>
    Friend Class HostSurfaceManager
        Inherits DesignSurfaceManager

        Public Sub New()
            MyBase.New()
            AddService(GetType(INameCreationService), New NameCreationService())
            AddHandler ActiveDesignSurfaceChanged, New ActiveDesignSurfaceChangedEventHandler(AddressOf HostSurfaceManager_ActiveDesignSurfaceChanged)
        End Sub

        Protected Overrides Function CreateDesignSurfaceCore(ByVal parentProvider As IServiceProvider) As DesignSurface
            Return New HostSurface(parentProvider)

        End Function


        ''' <summary>
        ''' Gets a new HostSurface and loads it with the appropriate type of
        ''' root component. 
        ''' </summary>
        Private Function GetNewHost(ByVal rootComponentType As Type) As HostControl
            Dim hostSurface = CType(CreateDesignSurface(ServiceContainer), HostSurface)


            If rootComponentType Is GetType(Form) Then
                hostSurface.BeginLoad(GetType(Form))
            ElseIf rootComponentType Is GetType(UserControl) Then
                hostSurface.BeginLoad(GetType(UserControl))
            ElseIf rootComponentType Is GetType(Component) Then
                hostSurface.BeginLoad(GetType(Component))
            ElseIf rootComponentType Is GetType(MyTopLevelComponent) Then
                hostSurface.BeginLoad(GetType(MyTopLevelComponent))
            Else
                Throw New Exception("Undefined Host Type: " & rootComponentType.ToString())
            End If

            hostSurface.Initialize()
            ActiveDesignSurface = hostSurface
            Return New HostControl(hostSurface)
        End Function


        ''' <summary>
        ''' Gets a new HostSurface and loads it with the appropriate type of
        ''' root component. Uses the appropriate Loader to load the HostSurface.
        ''' </summary>
        Public Function GetNewHost(ByVal rootComponentType As Type, ByVal loaderType As LoaderType) As HostControl
            If loaderType = LoaderType.NoLoader Then Return GetNewHost(rootComponentType)
            Dim hostSurface = CType(CreateDesignSurface(ServiceContainer), HostSurface)
            Dim host = CType(hostSurface.GetService(GetType(IDesignerHost)), IDesignerHost)

            Select Case loaderType

                Case LoaderType.BasicDesignerLoader
                    Dim basicHostLoader As Loader.BasicHostLoader = New Loader.BasicHostLoader(rootComponentType)
                    hostSurface.BeginLoad(basicHostLoader)
                    hostSurface.Loader = basicHostLoader
                Case LoaderType.CodeDomDesignerLoader
                    Dim codeDomHostLoader As Loader.CodeDomHostLoader = New Loader.CodeDomHostLoader()
                    hostSurface.BeginLoad(codeDomHostLoader)
                    hostSurface.Loader = codeDomHostLoader
                Case Else
                    Throw New Exception("Loader is not defined: " & loaderType.ToString())
            End Select

            hostSurface.Initialize()
            Return New HostControl(hostSurface)
        End Function


        ''' <summary>
        ''' Opens an Xml file and loads it up using BasicHostLoader (inherits from
        ''' BasicDesignerLoader)
        ''' </summary>
        Public Function GetNewHost(ByVal fileName As String) As HostControl
            If Equals(fileName, Nothing) OrElse Not File.Exists(fileName) Then MessageBox.Show("FileName is incorrect: " & fileName)
            Dim loaderType As LoaderType = LoaderType.NoLoader
            If fileName.EndsWith("xml") Then loaderType = LoaderType.BasicDesignerLoader

            If loaderType = LoaderType.NoLoader OrElse loaderType = LoaderType.CodeDomDesignerLoader Then
                Throw New Exception("File cannot be opened. Please check the type or extension of the file. Supported format is Xml")
            End If

            Dim hostSurface = CType(CreateDesignSurface(ServiceContainer), HostSurface)
            Dim host = CType(hostSurface.GetService(GetType(IDesignerHost)), IDesignerHost)

            Dim basicHostLoader As Loader.BasicHostLoader = New Loader.BasicHostLoader(fileName)

            hostSurface.BeginLoad(basicHostLoader)
            hostSurface.Loader = basicHostLoader
            hostSurface.Initialize()
            Return New HostControl(hostSurface)
        End Function

        Public Sub AddService(ByVal type As Type, ByVal serviceInstance As Object)
            ServiceContainer.AddService(type, serviceInstance)

        End Sub


        ''' <summary>
        ''' Uses the OutputWindow service and writes out to it.
        ''' </summary>
        Private Sub HostSurfaceManager_ActiveDesignSurfaceChanged(ByVal sender As Object, ByVal e As ActiveDesignSurfaceChangedEventArgs)
            ' Dim o As ToolWindows.OutputWindow = TryCast(GetService(GetType(ToolWindows.OutputWindow)), ToolWindows.OutputWindow)
            'o.RichTextBox.Text += "New host added." & Microsoft.VisualBasic.Constants.vbLf
        End Sub
    End Class ' class
End Namespace ' namespace


