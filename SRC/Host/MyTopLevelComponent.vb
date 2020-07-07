Imports System.ComponentModel
Imports System.ComponentModel.Design

Namespace Host
    ''' <summary>
    ''' Uses the custom RootDesigner (MyRootDesigner)
    ''' </summary>
    <Designer(GetType(MyRootDesigner), GetType(IRootDesigner))>
    <Designer(GetType(ComponentDesigner))>
    Public Class MyTopLevelComponent
        Inherits Component

        Public Sub New()
        End Sub
    End Class
End Namespace ' namespace


