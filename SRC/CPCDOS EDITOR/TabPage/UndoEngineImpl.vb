Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel.Design

Namespace OSMaker
    Public Class UndoEngineImpl
        Inherits UndoEngine

        Private undoUnitList As List(Of UndoEngine.UndoUnit) = New List(Of UndoUnit)()
        Private currentPos As Integer = 0

        Public Sub New(ByVal provider As IServiceProvider)
            MyBase.New(provider)
        End Sub

        Public Sub DoUndo()
            If currentPos > 0 Then
                Dim undoUnit As UndoEngine.UndoUnit = undoUnitList(currentPos - 1)
                undoUnit.Undo()
                currentPos -= 1
            End If

            UpdateUndoRedoMenuCommandsStatus()
        End Sub

        Public Sub DoRedo()
            If currentPos < undoUnitList.Count Then
                Dim undoUnit As UndoEngine.UndoUnit = undoUnitList(currentPos)
                undoUnit.Undo()
                currentPos += 1
            End If

            UpdateUndoRedoMenuCommandsStatus()
        End Sub

        Private Sub UpdateUndoRedoMenuCommandsStatus()
            Dim menuCommandService As MenuCommandService = TryCast(GetService(GetType(MenuCommandService)), MenuCommandService)
            Dim undoMenuCommand As MenuCommand = menuCommandService.FindCommand(StandardCommands.Undo)
            Dim redoMenuCommand As MenuCommand = menuCommandService.FindCommand(StandardCommands.Redo)
            If undoMenuCommand IsNot Nothing Then undoMenuCommand.Enabled = currentPos > 0
            If redoMenuCommand IsNot Nothing Then redoMenuCommand.Enabled = currentPos < Me.undoUnitList.Count
        End Sub

        Protected Overrides Sub AddUndoUnit(ByVal unit As UndoEngine.UndoUnit)
            undoUnitList.RemoveRange(currentPos, undoUnitList.Count - currentPos)
            undoUnitList.Add(unit)
            currentPos = undoUnitList.Count
        End Sub

        Protected Overrides Function CreateUndoUnit(ByVal name As String, ByVal primary As Boolean) As UndoEngine.UndoUnit
            Return MyBase.CreateUndoUnit(name, primary)
        End Function

        Protected Overrides Sub DiscardUndoUnit(ByVal unit As UndoEngine.UndoUnit)
            undoUnitList.Remove(unit)
            MyBase.DiscardUndoUnit(unit)
        End Sub

        Protected Overrides Sub OnUndoing(ByVal e As EventArgs)
            MyBase.OnUndoing(e)
        End Sub

        Protected Overrides Sub OnUndone(ByVal e As EventArgs)
            MyBase.OnUndone(e)
        End Sub
    End Class
End Namespace

