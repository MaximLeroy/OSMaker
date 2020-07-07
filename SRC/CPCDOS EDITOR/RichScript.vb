Imports System.Runtime.InteropServices


Public Class RichScript



    <DllImport("user32.dll")>
    Private Shared Function LockWindowUpdate(ByVal hWndLock As IntPtr) As Boolean
    End Function
    Public WithEvents MyRichScript As RichTextBox
    Private Structure _PaintWords
        Dim WordsColor As Color
        Dim WordsToFind() As String
    End Structure
    Private MyRichWords As List(Of _PaintWords)
    Private MyRichComments As _PaintWords

    ''' <summary>
    ''' Initialise une instance qui permet d'utiliser d'enrichir un RichTextBox en RichScript.
    ''' </summary>
    ''' <param name="LinkedRichText">Objet RichTextBox à prendre le contrôle</param>
    ''' <param name="BackColor">Couleur d'arrière plan</param>
    ''' <param name="ForeColor">Couleur du texte</param>
    ''' <remarks></remarks>
    Sub New(ByRef LinkedRichText As RichTextBox, ByVal BackColor As Color, ByVal ForeColor As Color)
        MyRichWords = New List(Of _PaintWords)
        MyRichComments = Nothing
        MyRichScript = LinkedRichText
        MyRichScript.BackColor = BackColor
        MyRichScript.ForeColor = ForeColor
        MyRichScript.TabStop = False
    End Sub

    ''' <summary>
    ''' Ferme l'instance du RichScript.
    ''' </summary>
    ''' <remarks></remarks>
    Sub Disposed()
        MyRichComments = Nothing
        MyRichWords.Clear()
        MyRichScript.Clear()
        MyBase.Finalize()
    End Sub

    ''' <summary>
    ''' Force le RichScript à repeindre les mots.
    ''' </summary>
    ''' <returns>Retourne le nombre d'élements contenus dans la liste des mots</returns>
    ''' <remarks></remarks>
    Public Function RefreshWords() As Integer
        Call RichScriptColors()
        If MyRichWords IsNot Nothing Then
            Return MyRichWords.Count
        Else
            Return 0
        End If
    End Function

    ''' <summary>
    ''' Ajouter un ou plusieurs mots colorés au contrôle RichScript.
    ''' </summary>
    ''' <param name="WordsColor">Couleur qui sera utilisé pour peindre le mot</param>
    ''' <param name="WordsToFind">Tableau des mots à peindre</param>
    ''' <returns>Retourne le nombre d'élements contenus dans la liste des mots</returns>
    ''' <remarks>Exemple: AddWords(Color.Green, "Pomme", "Herbe", "Arbre")</remarks>
    Public Function AddWords(ByVal WordsColor As Color, ByVal ParamArray WordsToFind() As String) As Integer
        Dim nEntry As New _PaintWords With {.WordsColor = WordsColor, .WordsToFind = WordsToFind}
        MyRichWords.Add(nEntry)
        Return MyRichWords.Count
    End Function

    ''' <summary>
    ''' Colore une ligne entière selon les premiers caractères. 
    ''' </summary>
    ''' <param name="CommentsColor">Couleur qui sera utilisé pour peindre la ligne</param>
    ''' <param name="CommentsToFind">Tableau des premiers caractères de la ligne à peindre</param>
    ''' <remarks>Exemple: SetComments(Color.Green, "''' ", ";")</remarks>
    Public Sub SetComments(ByVal CommentsColor As Color, ByVal ParamArray CommentsToFind() As String)
        Dim nEntry As New _PaintWords With {.WordsColor = CommentsColor, .WordsToFind = CommentsToFind}
        MyRichComments = nEntry
    End Sub

    ''' <summary>
    ''' Fonction qui regroupe les procédures à éffectuer sur les mots sans scintillement.
    ''' </summary>
    ''' <remarks>Pour tester le problème de scintillement, mettez en commentaire les lignes executant LockWindowUpdate</remarks>
    Private Sub RichScriptColors()
        Call LockWindowUpdate(MyRichScript.Handle)

        Dim i As Integer = MyRichScript.SelectionStart

        'Liste de mots à colorer
        For j As Integer = 0 To MyRichWords.Count - 1
            PaintWords(MyRichWords(j).WordsColor, MyRichWords(j).WordsToFind)
        Next

        'Colore une ligne entière comme commentaire
        If MyRichComments.WordsColor <> Nothing Then
            For k As Integer = 0 To MyRichScript.Lines.Count - 1
                If MyRichScript.Lines(k).Length > 0 Then
                    For m As Integer = 0 To MyRichComments.WordsToFind.Count - 1
                        If MyRichScript.Lines(k).Length >= MyRichComments.WordsToFind(m).Length Then
                            If MyRichScript.Lines(k).Substring(0, MyRichComments.WordsToFind(m).Length) = MyRichComments.WordsToFind(m) Then
                                MyRichScript.SelectionStart = MyRichScript.GetFirstCharIndexFromLine(k)
                                MyRichScript.SelectionLength = MyRichScript.Lines(k).Length
                                MyRichScript.SelectionColor = MyRichComments.WordsColor
                            End If
                        End If
                    Next
                End If
            Next
        End If

        MyRichScript.SelectionLength = 0
        MyRichScript.SelectionStart = i
        Call LockWindowUpdate(IntPtr.Zero)
    End Sub


    ''' <summary>
    ''' Fonction principale qui selectionne un mot et le paint.
    ''' </summary>
    ''' <param name="WordsColor">Couleur qui sera utilisé pour peindre le mot</param>
    ''' <param name="WordsToFind">Tableau des mots à peindre</param>
    ''' <remarks></remarks>
    Private Sub PaintWords(ByVal WordsColor As Color, ByVal ParamArray WordsToFind() As String)
        For Each Word As String In WordsToFind
            Dim idx As Integer = MyRichScript.Find(Word, 0, RichTextBoxFinds.None)
            While idx > -1
                If MyRichScript.Text.Substring(idx, Word.Length) = Word Then
                    MyRichScript.SelectionStart = idx
                    MyRichScript.SelectionLength = Word.Length
                    MyRichScript.SelectionColor = WordsColor
                ElseIf MyRichScript.Text.Substring(idx, Word.Length).ToUpper = Word.ToUpper Then
                    MyRichScript.SelectionStart = idx
                    MyRichScript.SelectionLength = Word.Length
                    MyRichScript.SelectionColor = WordsColor
                    'FORCE TYPE
                    MyRichScript.SelectedText = Word
                End If
                If (idx + Word.Length) >= MyRichScript.TextLength Then
                    idx = -1
                Else
                    idx = MyRichScript.Find(Word, idx + Word.Length, RichTextBoxFinds.None)
                End If
            End While
        Next
    End Sub

    ''' <summary>
    ''' Handle KeyPress: pour remettre la couleur de l'écriture à l'origine.
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">KeyPressEventArgs</param>
    ''' <remarks></remarks>
    Private Sub RichScript_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyRichScript.KeyPress
        MyRichScript.SelectionColor = MyRichScript.ForeColor
    End Sub

    ''' <summary>
    ''' Handle TextChanged: pour appliquer la couleur à chaque changements.
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    ''' <remarks></remarks>
    Private Sub RichScript_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyRichScript.TextChanged
        If MyRichWords.Count = 0 Then Exit Sub
        If MyRichScript.SelectionLength > 0 Then Exit Sub
        Call RichScriptColors()
    End Sub


End Class

