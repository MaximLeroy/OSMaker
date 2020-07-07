Public Class Objets
    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub Objets_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Objets_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Opacity = 1.0
    End Sub

    Private Sub ButtonX14_Click(sender As Object, e As EventArgs) Handles ButtonX14.Click
        Dim bouton As New Button()
        bouton.Location = New Point(147, 121)
        bouton.Size = New Size(90, 100)
        bouton.Visible = True
        Fenetre.Controls.Add(bouton)
    End Sub


End Class
