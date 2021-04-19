Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace OSMaker

    Public Class Designer
        Inherits System.ComponentModel.Design.DesignSurface

        ' Gestion des options de design
        Public designerOptionService As System.Windows.Forms.Design.WindowsFormsDesignerOptionService = New System.Windows.Forms.Design.WindowsFormsDesignerOptionService

        ' Menu
        Public Menu As MenuCommandServiceImpl

        Public ReadOnly Property _ServiceContainer As System.ComponentModel.Design.ServiceContainer
            Get
                Return Me.ServiceContainer
            End Get
        End Property

        Public Sub New()
            Me.New(False, True, True, True, True, True, True)

        End Sub

        Public Sub New(ByVal ShowGrid As Boolean, ByVal EnableInSituEditing As Boolean, ByVal UseSnapLines As Boolean, ByVal UseOptimizedCodeGeneration As Boolean, ByVal UseSmartTags As Boolean, ByVal ObjectBoundSmartTagAutoShow As Boolean, ByVal SnapToGrid As Boolean)
            MyBase.New
            ' Service de gestion du toolbox
            ServiceContainer.AddService(GetType(System.Drawing.Design.IToolboxService), New ToolBox.ToolboxLibrary.Toolbox)
            'ServiceContainer.AddService(typeof(System.ComponentModel.Design.IResourceService), new DesignerResourceService(this.resourceStore));
            ServiceContainer.AddService(GetType(System.Windows.Forms.AmbientProperties), New System.Windows.Forms.AmbientProperties)
            ' Service de vue du concepteur
            'ServiceContainer.AddService(typeof(ViewService), new ViewService());
            ' Service de gestion des menus
            Me.Menu = New MenuCommandServiceImpl(Me.ServiceContainer)
            '  AddHandler Me.Menu.OnExecuteViewCode, AddressOf Me.Menu_OnExecuteViewCode
            ' AddHandler Me.Menu.OnExecuteViewProperty, AddressOf Me.Menu_OnExecuteViewProperty
            ' AddHandler Me.Menu.OnExecuteCreateEvent, AddressOf Me.Menu_OnExecuteCreateEvent
            ' AddHandler Me.Menu.OnSelectComponentEvent, AddressOf Me.Menu_OnSelectComponentEvent
            ' Me.Menu.Designer = Me
            ServiceContainer.AddService(GetType(System.ComponentModel.Design.IMenuCommandService), Me.Menu)
            ' On sp�cifie qu'on va utilser la grille pour placer les composants
            Me.designerOptionService.CompatibilityOptions.ShowGrid = ShowGrid
            Me.designerOptionService.CompatibilityOptions.EnableInSituEditing = EnableInSituEditing
            Me.designerOptionService.CompatibilityOptions.UseSnapLines = UseSnapLines
            Me.designerOptionService.CompatibilityOptions.UseOptimizedCodeGeneration = UseOptimizedCodeGeneration
            Me.designerOptionService.CompatibilityOptions.UseSmartTags = UseSmartTags
            Me.designerOptionService.CompatibilityOptions.ObjectBoundSmartTagAutoShow = ObjectBoundSmartTagAutoShow
            Me.designerOptionService.CompatibilityOptions.SnapToGrid = SnapToGrid
            ServiceContainer.AddService(GetType(System.ComponentModel.Design.DesignerOptionService), Me.designerOptionService)
        End Sub

        Public Sub Menu_OnExecuteViewCode(ByVal sender As Object, ByVal e As EventArgs)
            RaiseEvent OnExecuteViewCode(sender, e)
        End Sub

        Public Delegate Sub OnExecuteViewCodeEventHandler(ByVal sender As Object, ByVal e As EventArgs)
        Public Event OnExecuteViewCode As OnExecuteViewCodeEventHandler

        Public Sub Menu_OnExecuteViewProperty(ByVal sender As Object, ByVal e As EventArgs)
            RaiseEvent OnExecuteViewProperty(sender, e)
        End Sub

        Public Delegate Sub OnExecuteViewPropertyEventHandler(ByVal sender As Object, ByVal e As EventArgs)
        Public Event OnExecuteViewProperty As OnExecuteViewPropertyEventHandler

        Public Sub Menu_OnExecuteCreateEvent(ByVal sender As Object, ByVal e As EventArgs)
            RaiseEvent OnExecuteCreateEvent(sender, e)
        End Sub

        Public Delegate Sub OnExecuteCreateEventEventHandler(ByVal sender As Object, ByVal e As EventArgs)
        Public Event OnExecuteCreateEvent As OnExecuteCreateEventEventHandler

        Public Sub Menu_OnSelectComponentEvent(ByVal sender As Object, ByVal e As EventArgs)
            RaiseEvent OnSelectComponentEvent(sender, e)
        End Sub

        Public Delegate Sub OnSelectComponentEventEventHandler(ByVal sender As Object, ByVal e As EventArgs)
        Public Event OnSelectComponentEvent As OnSelectComponentEventEventHandler
    End Class
End Namespace