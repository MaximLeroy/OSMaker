Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel.Design
Imports System.Windows.Forms
Imports System.Drawing.Design
Imports Microsoft.Tools.Graphs
Imports Microsoft.Tools.Graphs.Bars
Imports Microsoft.Tools.Graphs.Pies
Imports Microsoft.Tools.Graphs.Legends
Imports System.Drawing.Drawing2D
Imports System.Diagnostics

Namespace OSMaker
    ''' <summary>
    ''' Demonstrates how to write a custom RootDesigner. This designer has a View
    ''' of a Graph - it shows the number of components added to the designer
    ''' in a pie/bar chart.
    ''' </summary>
    Public Class MyRootDesigner
        Inherits ComponentDesigner
        Implements IRootDesigner, IToolboxUser

        Private _rootView As MyRootControl


#Region "Implementation of IRootDesigner"
        Public Function GetView(ByVal technology As ViewTechnology) As Object Implements IRootDesigner.GetView
            Dim monmenustrip As New ContextMenuStrip
            _rootView = New MyRootControl(Me)
            Return _rootView

        End Function

        Public ReadOnly Property SupportedTechnologies As ViewTechnology() Implements IRootDesigner.SupportedTechnologies
            Get
                Return New ViewTechnology() {ViewTechnology.Default}
            End Get
        End Property

#End Region

#Region "Implementation of IToolboxUser"
        Public Sub ToolPicked(ByVal tool As ToolboxItem) Implements IToolboxUser.ToolPicked
            _rootView.InvokeToolboxItem(tool)
        End Sub

        Public Function GetToolSupported(ByVal tool As ToolboxItem) As Boolean Implements IToolboxUser.GetToolSupported
            Return True
        End Function

#End Region

        Public Overloads Function GetService(ByVal type As Type) As Object
            Return MyBase.GetService(type)
        End Function



#Region "MyRootControl"
        ''' <summary>
        ''' This is the View of the RootDesigner.
        ''' </summary>
        Public Class MyRootControl
            Inherits ScrollableControl

            Friend Enum GraphStype
                Pie = 1
                Bar = 2
            End Enum

            Private _displayString As String = "Pie Graph Representation of components added."
            Private _rootDesigner As MyRootDesigner
            Private _componentInfoTable As Hashtable
            Private _totalComponents As Int32 = 0
            Private _linkLabel As LinkLabel
            Private _graphStyle As Int32 = GraphStype.Pie

            Public Sub New(ByVal rootDesigner As MyRootDesigner)
                _rootDesigner = rootDesigner
                _componentInfoTable = New Hashtable()
                _linkLabel = New LinkLabel()
                _linkLabel.Text = "Graph Style"
                _linkLabel.Location = New Point(10, 5)
                _linkLabel.Visible = False
                AddHandler _linkLabel.Click, New EventHandler(AddressOf _linkLabel_Click)
                Controls.Add(_linkLabel)
                AddHandler Resize, New EventHandler(AddressOf MyRootControl_Resize)

                For i = 1 To _rootDesigner.Component.Site.Container.Components.Count - 1
                    UpdateTable(_rootDesigner.Component.Site.Container.Components(i).GetType())
                Next

                Invalidate()
            End Sub

            Protected Overrides Sub OnPaint(ByVal pe As PaintEventArgs)
                Try

                    If _componentInfoTable.Count = 0 Then
                        _linkLabel.Visible = False
                        Dim s = "Add objects from the toolbox on to this custom Graphical RootDesigner"
                        Dim sf As StringFormat = New StringFormat()
                        sf.Alignment = StringAlignment.Center
                        sf.LineAlignment = StringAlignment.Center
                        pe.Graphics.FillRectangle(New LinearGradientBrush(Bounds, Color.White, Color.Orange, 45.0F), Bounds)
                        pe.Graphics.DrawString(s, MyBase.Font, New SolidBrush(Color.Black), Bounds, sf)
                    Else
                        _linkLabel.Visible = True
                        pe.Graphics.FillRectangle(New SolidBrush(Color.White), Bounds)
                        Dim image As Image = Nothing

                        If _graphStyle = GraphStype.Pie Then
                            image = GetPieGraph()
                        Else
                            image = GetBarGraph()
                        End If

                        pe.Graphics.DrawImage(image, Bounds)
                    End If

                Catch ex As Exception
                    Trace.WriteLine(ex.ToString())
                End Try
            End Sub ' OnPaint
            Public Sub InvokeToolboxItem(ByVal tool As ToolboxItem)
                Dim newComponents = tool.CreateComponents(DesignerHost)
                _displayString = "Last Component added: " & newComponents(0).GetType().ToString()
                UpdateTable(newComponents(0).GetType())
                Invalidate()
            End Sub

            Private Sub UpdateTable(ByVal type As Type)
                If _componentInfoTable(type) Is Nothing Then
                    Dim ci As ComponentInfo = New ComponentInfo()
                    Dim ru As RandomUtil = New RandomUtil()
                    ci.Type = type
                    ci.Color = ru.GetColor()
                    ci.Count = 1
                    _componentInfoTable.Add(type, ci)
                    _totalComponents += 1
                Else
                    Dim ci = CType(_componentInfoTable(type), ComponentInfo)
                    _componentInfoTable.Remove(type)
                    ci.Count += 1
                    _componentInfoTable.Add(type, ci)
                End If
            End Sub

            Public ReadOnly Property DesignerHost As IDesignerHost
                Get
                    Return CType(_rootDesigner.GetService(GetType(IDesignerHost)), IDesignerHost)
                End Get
            End Property

            Public ReadOnly Property ToolboxService As IToolboxService
                Get
                    Return CType(_rootDesigner.GetService(GetType(IToolboxService)), IToolboxService)
                End Get
            End Property

            Private Function GetPieGraph() As Image
                Dim ru As RandomUtil = New RandomUtil()
                Dim pg As PieGraph = New PieGraph(Size)
                pg.Color = Color.White
                pg.ColorGradient = Color.Orange
                Dim legend As Legend = New Legend(Width, 70)
                legend.Text = String.Empty
                pg.Text = _displayString & " Total: " & _totalComponents.ToString()
                Dim keys = _componentInfoTable.Keys
                Dim ie As IEnumerator = keys.GetEnumerator()

                While ie.MoveNext()
                    Dim key = CType(ie.Current, Type)
                    Dim ci = CType(_componentInfoTable(key), ComponentInfo)
                    Dim ps As PieSlice = New PieSlice(ci.Count, ci.Color)
                    pg.Slices.Add(ps)
                    Dim le As LegendEntry = New LegendEntry(ci.Color, ci.Type.Name.ToString().Trim())
                    legend.LegendEntryCollection.Add(le)
                End While

                Return GraphRenderer.DrawGraphAndLegend(pg, legend, Size)
            End Function

            Private Function GetBarGraph() As Image
                Dim ru As RandomUtil = New RandomUtil()
                Dim bg As BarGraph = New BarGraph(Size)
                bg.Color = Color.White
                bg.ColorGradient = Color.Orange
                Dim legend As Legend = New Legend(Width, 70)
                legend.Text = String.Empty
                bg.Text = CType(_displayString & " Total: " & _totalComponents.ToString(), String)
                Dim keys = _componentInfoTable.Keys
                Dim ie As IEnumerator = keys.GetEnumerator()

                While ie.MoveNext()
                    Dim key = CType(ie.Current, Type)
                    Dim ci = CType(_componentInfoTable(key), ComponentInfo)
                    Dim bs As BarSlice = New BarSlice(ci.Count, ci.Color)
                    bg.BarSliceCollection.Add(bs)
                    Dim le As LegendEntry = New LegendEntry(ci.Color, ci.Type.Name.ToString().Trim())
                    legend.LegendEntryCollection.Add(le)
                End While

                Return GraphRenderer.DrawGraphAndLegend(bg, legend, Size)
            End Function

            Private Class ComponentInfo
                Public Type As Type
                Public Color As Color
                Public Count As Integer
            End Class

            Private Sub MyRootControl_Resize(ByVal sender As Object, ByVal e As EventArgs)
                Invalidate()
            End Sub

            Private Sub _linkLabel_Click(ByVal sender As Object, ByVal e As EventArgs)
                If _graphStyle = GraphStype.Pie Then
                    _graphStyle = GraphStype.Bar
                Else
                    _graphStyle = GraphStype.Pie
                End If

                Invalidate()
            End Sub
        End Class ' class MyRootControl
#End Region

    End Class ' class MyRootDesigner
End Namespace ' namespace


