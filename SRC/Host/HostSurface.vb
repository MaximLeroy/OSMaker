Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.ComponentModel.Design.Serialization
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Diagnostics
Imports DevComponents.DotNetBar

Namespace Host
    ''' <summary>
    ''' Inherits from DesignSurface and hosts the RootComponent and 
    ''' all other designers. It also uses loaders (BasicDesignerLoader
    ''' or CodeDomDesignerLoader) when required. It also provides various
    ''' services to the designers. Adds MenuCommandService which is used
    ''' for Cut, Copy, Paste, etc.
    ''' </summary>
    Public Class HostSurface
        Inherits DesignSurface

        Private _loader As BasicDesignerLoader
        Private _selectionService As ISelectionService

        Public Sub New()
            MyBase.New()
            AddService(GetType(IMenuCommandService), New MenuCommandService(Me))
        End Sub

        Public Sub New(ByVal parentProvider As IServiceProvider)
            MyBase.New(parentProvider)
            AddService(GetType(IMenuCommandService), New MenuCommandService(Me))
        End Sub

        Friend Sub Initialize()
            Dim control As Control = Nothing
            Dim host = CType(GetService(GetType(IDesignerHost)), IDesignerHost)
            If host Is Nothing Then Return

            Try
                ' Set the backcolor
                Dim hostType As Type = host.RootComponent.GetType()

                If hostType Is GetType(Form) Then
                    control = TryCast(View, Control)
                    control.BackColor = Color.White
                ElseIf hostType Is GetType(UserControl) Then
                    control = TryCast(View, Control)
                    control.BackColor = Color.White
                ElseIf hostType Is GetType(Component) Then
                    control = TryCast(View, Control)
                    control.BackColor = Color.FloralWhite
                Else
                    Throw New Exception("Undefined Host Type: " & hostType.ToString())
                End If


                ' Set SelectionService - SelectionChanged event handler
                _selectionService = CType(ServiceContainer.GetService(GetType(ISelectionService)), ISelectionService)
                AddHandler _selectionService.SelectionChanged, New EventHandler(AddressOf selectionService_SelectionChanged)
            Catch ex As Exception
                Trace.WriteLine(ex.ToString())
            End Try
        End Sub

        Public Property Loader As BasicDesignerLoader
            Get
                Return _loader
            End Get
            Set(ByVal value As BasicDesignerLoader)
                _loader = value
            End Set
        End Property


        ''' <summary>
        ''' When the selection changes this sets the PropertyGrid's selected component 
        ''' </summary>
        Private Sub selectionService_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _selectionService IsNot Nothing Then
                Dim selectedComponents As ICollection = _selectionService.GetSelectedComponents()
                Dim propertyGrid = CType(GetService(GetType(DevComponents.DotNetBar.AdvPropertyGrid)), DevComponents.DotNetBar.AdvPropertyGrid)
                Dim comps = New Object(selectedComponents.Count - 1) {}
                Dim i = 0

                For Each o In selectedComponents
                    comps(i) = o
                    i += 1
                Next

                propertyGrid.SelectedObjects = comps
            End If
        End Sub

        Public Sub AddService(ByVal type As Type, ByVal serviceInstance As Object)
            ServiceContainer.AddService(type, serviceInstance)
        End Sub
    End Class ' class
End Namespace ' namespace

