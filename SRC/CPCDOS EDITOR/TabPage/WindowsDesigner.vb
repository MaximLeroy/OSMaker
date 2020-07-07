Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel.Design
Imports VelerSoftware.SZC.Properties

Namespace OSMaker
    Public Class MenuCommandServiceImpl
        Inherits MenuCommandService

        Private m_globalVerbs As DesignerVerbCollection = New DesignerVerbCollection()

        Public Sub New(ByVal serviceProvider As IServiceProvider)
            MyBase.New(serviceProvider)
            m_globalVerbs.Add(StandartVerb("Cut", StandardCommands.Cut))
            m_globalVerbs.Add(StandartVerb("Copy", StandardCommands.Copy))
            m_globalVerbs.Add(StandartVerb("Paste", StandardCommands.Paste))
            m_globalVerbs.Add(StandartVerb("Delete", StandardCommands.Delete))
            m_globalVerbs.Add(StandartVerb("Select All", StandardCommands.SelectAll))
        End Sub

        Private Function StandartVerb(ByVal text As String, ByVal commandID As CommandID) As DesignerVerb
            Return New DesignerVerb(text, Sub(ByVal o As Object, ByVal e As EventArgs)
                                              Dim ms As IMenuCommandService = TryCast(GetService(GetType(IMenuCommandService)), IMenuCommandService)
                                              Debug.Assert(ms IsNot Nothing)
                                              ms.GlobalInvoke(commandID)
                                          End Sub)
        End Function

        Class MenuItem
            Inherits ToolStripMenuItem

            Private verb As DesignerVerb

            Public Sub New(ByVal verb As DesignerVerb)
                MyBase.New(verb.Text)
                Enabled = verb.Enabled
                Me.verb = verb
                AddHandler Click, AddressOf InvokeCommand
            End Sub

            Private Sub InvokeCommand(ByVal sender As Object, ByVal e As EventArgs)
                Try
                    verb.Invoke()
                Catch ex As Exception
                    Trace.Write("MenuCommandServiceImpl: " & ex.ToString())
                End Try
            End Sub
        End Class

        Private Function BuildMenuItems() As ToolStripItem()
            Dim items As List(Of ToolStripItem) = New List(Of ToolStripItem)()

            For Each verb As DesignerVerb In m_globalVerbs
                items.Add(New MenuItem(verb))
            Next

            Return items.ToArray()
        End Function

        Public Overrides Sub ShowContextMenu(ByVal menuID As CommandID, ByVal x As Integer, ByVal y As Integer)
            Dim cm As ContextMenuStrip = New ContextMenuStrip()
            cm.Items.AddRange(BuildMenuItems())
            Dim ss As ISelectionService = TryCast(GetService(GetType(ISelectionService)), ISelectionService)
            Debug.Assert(ss IsNot Nothing)
            Dim ps As Control = TryCast(ss.PrimarySelection, Control)
            Debug.Assert(ps IsNot Nothing)
            Dim s As Point = ps.PointToScreen(New Point(0, 0))
            cm.Show(ps, New Point(x - s.X, y - s.Y))
        End Sub
    End Class
End Namespace
