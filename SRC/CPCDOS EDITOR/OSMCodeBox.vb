Imports FarsiLibrary.Win
Imports FastColoredTextBoxNS
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Windows.Forms
Imports ToolBox
Imports System.Drawing.Design
Class OSMCodeBox
    Private _hostSurfaceManager As OSMaker.HostSurfaceManager = Nothing
    Private _formCount As Integer = 0
    Private explorerList As List(Of ExplorerItem) = New List(Of ExplorerItem)()

    ''SolidBrush
    Dim SolidGreen As SolidBrush = New SolidBrush(Color.FromArgb(87, 166, 74))
    Dim SolidBlue As SolidBrush = New SolidBrush(Color.FromArgb(86, 156, 214))
    Dim SolidBlueLight As SolidBrush = New SolidBrush(Color.FromArgb(156, 220, 254))
    Dim SolidEqual As SolidBrush = New SolidBrush(Color.FromArgb(180, 180, 180))
    Dim SolidRose As SolidBrush = New SolidBrush(Color.FromArgb(216, 160, 223))
    Dim SolidVert As SolidBrush = New SolidBrush(Color.FromArgb(78, 201, 176))
    Dim SolidVertFonce As SolidBrush = New SolidBrush(Color.FromArgb(55, 146, 124))
    Dim SolidJaune As SolidBrush = New SolidBrush(Color.FromArgb(220, 220, 170))
    Dim SolidNumber As SolidBrush = New SolidBrush(Color.FromArgb(181, 206, 168))
    ''Brushes
    Dim SpringGreenStyle As TextStyle = New TextStyle(Brushes.SpringGreen, Nothing, FontStyle.Regular)
    Dim BlueStyle As TextStyle = New TextStyle(SolidBlue, Nothing, FontStyle.Regular)
    Dim OrangeStyle As TextStyle = New TextStyle(SolidBlueLight, Nothing, FontStyle.Regular)
    Dim RedStyle As TextStyle = New TextStyle(Brushes.LightCoral, Nothing, FontStyle.Regular)
    Dim VertLightStyle As TextStyle = New TextStyle(SolidVert, Nothing, FontStyle.Regular)
    Dim BoldStyle As TextStyle = New TextStyle(Nothing, Nothing, FontStyle.Bold Or FontStyle.Underline)
    Dim Gras As TextStyle = New TextStyle(Nothing, Nothing, FontStyle.Bold)
    Dim GrayStyle As TextStyle = New TextStyle(Brushes.Gray, Nothing, FontStyle.Regular)
    Dim MagentaStyle As TextStyle = New TextStyle(SolidNumber, Nothing, FontStyle.Regular)
    Dim YellowStyle As TextStyle = New TextStyle(SolidJaune, Nothing, FontStyle.Regular)
    Dim GreenStyle As TextStyle = New TextStyle(SolidGreen, Nothing, FontStyle.Regular)
    Dim BrownStyle As TextStyle = New TextStyle(Brushes.Brown, Nothing, FontStyle.Italic)
    Dim MaroonStyle As TextStyle = New TextStyle(Brushes.Maroon, Nothing, FontStyle.Regular)
    Dim RoseStyle As TextStyle = New TextStyle(SolidRose, Nothing, FontStyle.Regular)
    Dim EqualStyle As TextStyle = New TextStyle(SolidEqual, Nothing, FontStyle.Regular)
    Dim SameWordsStyle As MarkerStyle = New MarkerStyle(New SolidBrush(Color.FromArgb(40, Color.Gray)))


    Public Sub New()
        InitializeComponent()

    End Sub


    Private Sub CPCDOSSyntaxHighlight(ByVal e As TextChangedEventArgs)

        'clear style of changed range
        e.ChangedRange.ClearStyle(BlueStyle, BoldStyle, GrayStyle, MagentaStyle, GreenStyle, BrownStyle, RedStyle)
        'string highlighting


        'comment highlighting
        e.ChangedRange.SetStyle(GreenStyle, "//.*$", RegexOptions.Multiline)
        e.ChangedRange.SetStyle(GreenStyle, "rem/.*$", RegexOptions.Multiline)
        e.ChangedRange.SetStyle(GreenStyle, "'.*$", RegexOptions.Multiline)

        e.ChangedRange.SetStyle(GreenStyle, "(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline)
        e.ChangedRange.SetStyle(GreenStyle, "(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline Or RegexOptions.RightToLeft)
        e.ChangedRange.SetStyle(VertLightStyle, "%.+?%")
        'number highlighting
        e.ChangedRange.SetStyle(MagentaStyle, "\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b")

        e.ChangedRange.SetStyle(RoseStyle, "(TYPE:|CTN:|BORD:|OMBRE:|IMGAUTO:|EDIT:|MULTILINE:|\,|fonction\/|function\/|End\/ Function|Fin\/ Fonction|Si\/|If\/|Fin\/ si|End\/ If|alors\:|Txt\/|Fin\/ Fonction|then:|sinon:|else:)", RegexOptions.IgnoreCase)
        e.ChangedRange.SetStyle(EqualStyle, "\=")

        e.ChangedRange.SetStyle(OrangeStyle, "(\.Parametres|\.titlecolor|\.PX|\.PY|\.SX|\.SY|\.Valeur|\.BackColor|\.CouleurText|\.Icone|\.ImgTitre|\.Opacite|\.titre|\.CouleurFenetre|\.CouleurTitre|\.px|\.py|\.tx|\.ty|\.opacite|\.Text|\.Image|\.evenement|\.texte|\.Handle|\.pid|\.nom|\.name|\.title|\.parameters|\.opacity|\.image|\.evenement|\.couleurfenetre|\.windowcolor|\.couleurtitre|\.couleurtexte|\.textcolor|\.handle|\.icone|\.icon|\.imgtitre|\.titleimg|fenetre\/|fin\/ fenetre|\.event|\.couleurfond)", RegexOptions.IgnoreCase)

        e.ChangedRange.SetStyle(BlueStyle, "(End\/ window|window\/|End\/ button|button\/|End\/ textbox|textbox\/|End\/ textblock|textblock\/|End\/ progressbar|progressbar\/|End\/ picturebox|picturebox\/|End\/ checkbox|checkbox\/|sys\/|\/processus|exe\/|\/pid\:|ccp\/|\/SET.LEVEL)", RegexOptions.IgnoreCase)

        e.ChangedRange.SetStyle(BlueStyle, "(debut_section_critique|begin_critical_section|fin_section_critique|end_critical_section|\/INIT|\/menu|\/touche|\/key|\/INIT|\/atouche|\/wkey|\/pause|\/tcp|\/udp|\/attendre|\/wait|\/recevoir|\/receive|\/envoyer|\/send|\/mode|\/stop|\/temp|\/tempr|\/debug|\/cpinticore|\/thread|\/thread[MIN]|\/thread[STD]|\/thread[MAX]|\/optimisation|\/optimization|\/lang|\/change|\/pause|\/bin|\/app|\/mem|\/lang|\/ecran|\/screen|\/ccp)", RegexOptions.IgnoreCase)

        e.ChangedRange.SetStyle(YellowStyle, "@#.*$", RegexOptions.Multiline)
        e.ChangedRange.SetStyle(RoseStyle, "fix\/|declare\/|declarer\/|set\/|txt\/|goto\/|aller\/|Client\/|serveur\/|server\/|pos\/|stop\/|cls\/|aide\/|help\/|ouvrir\/|open\/|ecrire\/|write\/|return\/|ping\/|telecharger\/|download\/|iug\/|demarrer\/|start\/|close\/|fermer\/|creer\/|create\/", RegexOptions.IgnoreCase)
        e.ChangedRange.SetStyle(YellowStyle, "/.*$", RegexOptions.Multiline)
        e.ChangedRange.SetStyle(RedStyle, """.*?""|'.+?'")


        'attribute highlighting
        e.ChangedRange.SetStyle(GrayStyle, "^\s*(?<range>\[.+?\])\s*$", RegexOptions.Multiline)
        'class name highlighting
        e.ChangedRange.SetStyle(BoldStyle, "\b(class|struct|enum)\s+(?<range>\w+?)\b")
        'keyword highlighting
        e.ChangedRange.SetStyle(BlueStyle, "\b(abstract|as|base|bool|break|byte|case|catch|char|class|const|continue|decimal|default|delegate|do|double|else|enum|explicit|extern|false|finally|fixed|float|for|foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|void|volatile|while|add|alias|ascending|descending|dynamic|from|get|global|group|into|join|let|orderby|partial|remove|select|set|value|var|where|yield)\b|#region\b|#endregion\b|")






        'CE QUE JE TEST @# DEVELOPPEZ.NET


        'clear folding markers
        e.ChangedRange.ClearFoldingMarkers()
        'set folding markers

        e.ToString.ToUpper()
        'allow to collapse region blocks
        e.ChangedRange.SetFoldingMarkers("Window\/", "End\/ Window", RegexOptions.IgnoreCase)
        e.ChangedRange.SetFoldingMarkers("picturebox\/", "End\/ picturebox", RegexOptions.IgnoreCase)
        e.ChangedRange.SetFoldingMarkers("Texteblock\/", "End\/ Texteblock", RegexOptions.IgnoreCase)
        e.ChangedRange.SetFoldingMarkers("Button\/", "End\/ Button", RegexOptions.IgnoreCase)
        e.ChangedRange.SetFoldingMarkers("Imagebox\/", "End\/ Imagebox", RegexOptions.IgnoreCase)
        e.ChangedRange.SetFoldingMarkers("Textbox\/", "End\/ Textbox", RegexOptions.IgnoreCase)
        e.ChangedRange.SetFoldingMarkers("Checkbox\/", "End\/ Checkbox", RegexOptions.IgnoreCase)
        e.ChangedRange.SetFoldingMarkers("Progressbar\/", "End\/ Progressbar", RegexOptions.IgnoreCase)
        e.ChangedRange.SetFoldingMarkers("Function\/", "End\/ Function", RegexOptions.IgnoreCase)
        e.ChangedRange.SetFoldingMarkers("Fonction\/", "Fin\/ Fonction", RegexOptions.IgnoreCase)

        e.ChangedRange.SetFoldingMarkers("fenetre\/", "fin\/ fenetre", RegexOptions.IgnoreCase)
        e.ChangedRange.SetFoldingMarkers("imagebox\/", "fin\/ imagebox", RegexOptions.IgnoreCase)
        e.ChangedRange.SetFoldingMarkers("Textebloc\/", "Fin\/ Textebloc", RegexOptions.IgnoreCase)
        e.ChangedRange.SetFoldingMarkers("Bouton\/", "Fin\/ Bouton", RegexOptions.IgnoreCase)

        e.ChangedRange.SetFoldingMarkers("Textebox\/", "fin\/ Textebox", RegexOptions.IgnoreCase)
        e.ChangedRange.SetFoldingMarkers("Checkbox\/", "fin\/ Checkbox", RegexOptions.IgnoreCase)
        e.ChangedRange.SetFoldingMarkers("BarreProgression\/", "fin\/ Barreprogression", RegexOptions.IgnoreCase)
        e.ChangedRange.SetFoldingMarkers("si\/", "fin\/ si", RegexOptions.IgnoreCase)
        e.ChangedRange.SetFoldingMarkers("if\/", "end\/ if", RegexOptions.IgnoreCase)

    End Sub

    Private Enum ExplorerItemType
        [Class]
        Method
        [Property]
        [Event]
        [Bouton]
        [Imagebox]
        [Comment]
        [Textbox]
        [Textbloc]
        [Checkbox]
        [Fin]
        [Creer]
        [Fonction]
    End Enum

    '  Private Class ExplorerItem
    'Public type As PowerfulCSharpEditor.ExplorerItemType

    'Public title As String

    'Public position As Integer
    'End Class

    ' Private Class ExplorerItemComparer
    'Implements IComparer(Of PowerfulCSharpEditor.ExplorerItem)

    'Public Function Compare(x As PowerfulCSharpEditor.ExplorerItem, y As PowerfulCSharpEditor.ExplorerItem) As Integer Implements IComparer(Of PowerfulCSharpEditor.ExplorerItem).Compare
    'Return x.title.CompareTo(y.title)
    'End Function
    'End Class

    Private Class DeclarationSnippet
        Inherits SnippetAutocompleteItem

        Public Sub New(snippet As String)
            MyBase.New(snippet)
        End Sub

        Public Overrides Function Compare(fragmentText As String) As CompareResult
            Dim pattern As String = Regex.Escape(fragmentText)
            Dim result As CompareResult
            If Regex.IsMatch(Me.Text, "\b" + pattern, RegexOptions.IgnoreCase) Then
                result = CompareResult.Visible
            Else
                result = CompareResult.Hidden
            End If
            Return result
        End Function
    End Class

    Private Class InsertSpaceSnippet
        Inherits AutocompleteItem

        Private pattern As String

        Public Overrides Property ToolTipTitle() As String
            Get
                Return Me.Text
            End Get
            Set(value As String)

            End Set
        End Property

        Public Sub New(pattern As String)
            MyBase.New("")
            Me.pattern = pattern
        End Sub

        Public Sub New()
            Me.New("^(\d+)([a-zA-Z_]+)(\d*)$")
        End Sub

        Public Overrides Function Compare(fragmentText As String) As CompareResult
            Dim result As CompareResult
            If Regex.IsMatch(fragmentText, Me.pattern) Then
                Me.Text = Me.InsertSpaces(fragmentText)
                If Me.Text <> fragmentText Then
                    result = CompareResult.Visible
                    Return result
                End If
            End If
            result = CompareResult.Hidden
            Return result
        End Function

        Public Function InsertSpaces(fragment As String) As String
            Dim i As Match = Regex.Match(fragment, Me.pattern)
            Dim result As String
            If i Is Nothing Then
                result = fragment
            Else
                If i.Groups(1).Value = "" AndAlso i.Groups(3).Value = "" Then
                    result = fragment
                Else
                    result = String.Concat(New String() {i.Groups(1).Value, " ", i.Groups(2).Value, " ", i.Groups(3).Value}).Trim()
                End If
            End If
            Return result
        End Function
    End Class

    Private Class InsertEnterSnippet
        Inherits AutocompleteItem

        Private enterPlace As Place = Place.Empty

        Public Overrides Property ToolTipTitle() As String
            Get
                Return "Insert line break after '}'"
            End Get
            Set(value As String)

            End Set
        End Property

        Public Sub New()
            MyBase.New("[Line break]")
        End Sub

        Public Overrides Function Compare(fragmentText As String) As CompareResult
            Dim r As Range = MyBase.Parent.Fragment.Clone()
            Dim result As CompareResult
            While r.Start.iChar > 0
                If r.CharBeforeStart = "}" Then
                    Me.enterPlace = r.Start
                    result = CompareResult.Visible
                    Return result
                End If
                r.GoLeftThroughFolded()
            End While
            result = CompareResult.Hidden
            Return result
        End Function

        Public Overrides Function GetTextForReplace() As String
            Dim r As Range = MyBase.Parent.Fragment
            Dim [end] As Place = r.[End]
            r.Start = Me.enterPlace
            r.[End] = r.[End]
            Return Environment.NewLine + r.Text
        End Function

        Public Overrides Sub OnSelected(popupMenu As AutocompleteMenu, e As SelectedEventArgs)
            MyBase.OnSelected(popupMenu, e)
            If MyBase.Parent.Fragment.tb.AutoIndent Then
                MyBase.Parent.Fragment.tb.DoAutoIndent()
            End If
        End Sub
    End Class

    Public Class BookmarkInfo
        Public iBookmark As Integer
        Public tb As FastColoredTextBox

    End Class

    'Private components As IContainer = Nothing

    Private WithEvents ssMain As StatusStrip

    'Private WithEvents tsFiles3 As FATabStrip


    Private WithEvents sfdMain As SaveFileDialog

    Private WithEvents ofdMain As OpenFileDialog

    Private WithEvents cmMain As ContextMenuStrip

    Private WithEvents cutToolStripMenuItem As ToolStripMenuItem

    Private WithEvents copyToolStripMenuItem As ToolStripMenuItem

    Private WithEvents pasteToolStripMenuItem As ToolStripMenuItem

    Private WithEvents selectAllToolStripMenuItem As ToolStripMenuItem

    Private WithEvents toolStripMenuItem2 As ToolStripSeparator

    Private WithEvents undoToolStripMenuItem As ToolStripMenuItem

    Private WithEvents redoToolStripMenuItem As ToolStripMenuItem

    Private WithEvents tmUpdateInterface As System.Windows.Forms.Timer

    Private WithEvents toolStripSeparator As ToolStripSeparator

    Private WithEvents toolStripSeparator1 As ToolStripSeparator

    Private WithEvents toolStripSeparator2 As ToolStripSeparator

    Private WithEvents toolStripMenuItem3 As ToolStripSeparator

    Private WithEvents findToolStripMenuItem As ToolStripMenuItem

    Private WithEvents replaceToolStripMenuItem As ToolStripMenuItem

    Private WithEvents dgvObjectExplorer As DataGridView

    Private WithEvents clImage As DataGridViewImageColumn

    Private WithEvents clName As DataGridViewTextBoxColumn

    Private WithEvents lbWordUnderMouse As ToolStripStatusLabel

    Private WithEvents toolStripMenuItem4 As ToolStripSeparator

    Private WithEvents autoIndentSelectedTextToolStripMenuItem As ToolStripMenuItem

    Private WithEvents commentSelectedToolStripMenuItem As ToolStripMenuItem

    Private WithEvents uncommentSelectedToolStripMenuItem As ToolStripMenuItem

    Private WithEvents cloneLinesToolStripMenuItem As ToolStripMenuItem

    Private WithEvents cloneLinesAndCommentToolStripMenuItem As ToolStripMenuItem

    Private keywords As String() = New String() {"abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock", "long", "namespace", "new", "null", "object", "operator", "out", "override", "params", "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual", "void", "volatile", "while", "add", "alias", "ascending", "descending", "dynamic", "from", "get", "global", "group", "into", "join", "let", "orderby", "partial", "remove", "select", "set", "value", "var", "where", "yield", "cpcdoscesttropbien"}

    Private methods As String() = New String() {"Equals()", "GetHashCode()", "GetType()", "ToString()", "Maxime", "GetMaxou()"}

    Private snippets As String() = New String() {"if(^)" & vbLf & "{" & vbLf & ";" & vbLf & "}", "if(^)" & vbLf & "{" & vbLf & ";" & vbLf & "}" & vbLf & "else" & vbLf & "{" & vbLf & ";" & vbLf & "}", "for(^;;)" & vbLf & "{" & vbLf & ";" & vbLf & "}", "while(^)" & vbLf & "{" & vbLf & ";" & vbLf & "}", "do" & vbLf & "{" & vbLf & "^;" & vbLf & "}while();", "switch(^)" & vbLf & "{" & vbLf & "case : break;" & vbLf & "}"}

    Private declarationSnippets As String() = New String() {"public class ^" & vbLf & "{" & vbLf & "}", "private class ^" & vbLf & "{" & vbLf & "}", "internal class ^" & vbLf & "{" & vbLf & "}", "public struct ^" & vbLf & "{" & vbLf & ";" & vbLf & "}", "private struct ^" & vbLf & "{" & vbLf & ";" & vbLf & "}", "internal struct ^" & vbLf & "{" & vbLf & ";" & vbLf & "}", "public void ^()" & vbLf & "{" & vbLf & ";" & vbLf & "}", "" & vbLf & "fenetre/^" & vbLf & "creer/" & vbLf & "Fin/ fenetre", "internal void ^()" & vbLf & "{" & vbLf & ";" & vbLf & "}", "protected void ^()" & vbLf & "{" & vbLf & ";" & vbLf & "}", "public ^{ get; set; }", "private ^{ get; set; }", "internal ^{ get; set; }", "protected ^{ get; set; }"}

    '  Private invisibleCharsStyle As Style = New InvisibleCharsRenderer(Pens.Gray)

    Private currentLineColor As Color = Color.FromArgb(100, 210, 210, 255)

    Private changedLineColor As Color = Color.FromArgb(255, 230, 230, 255)

    'Private explorerList As List(Of PowerfulCSharpEditor.ExplorerItem) = New List(Of PowerfulCSharpEditor.ExplorerItem)()

    Private tbFindChanged As Boolean = False


    Private lastNavigatedDateTime As DateTime = DateTime.Now

    Private Sub tb_TextChangedDelayed(sender As Object, e As TextChangedEventArgs) Handles tb.TextChangedDelayed
        Dim text As String = TryCast(sender, FastColoredTextBox).Text
        ThreadPool.QueueUserWorkItem(Sub(o As Object)
                                         Me.ReBuildObjectExplorer(text)
                                     End Sub)
        CPCDOSSyntaxHighlight(e)
        tb.AutoScroll = False

        tb.Font = New Font("Consolas", 9.75F)
        tb.Dock = DockStyle.Fill


        tb.LeftBracket = "("
        tb.RightBracket = ")"
        tb.LeftBracket2 = "\x0"
        tb.RightBracket2 = "\x0"

        tb.DoCaretVisible()
        tb.IsChanged = False
        tb.ClearUndo()
        tb.Focus()
        tb.DelayedTextChangedInterval = 1000
        tb.DelayedEventsInterval = 1000
    End Sub


    Private Class ExplorerItem
        Public type As ExplorerItemType

        Public title As String

        Public position As Integer
    End Class

    Private Class ExplorerItemComparer
        Implements IComparer(Of ExplorerItem)

        Public Function Compare(x As ExplorerItem, y As ExplorerItem) As Integer Implements IComparer(Of ExplorerItem).Compare
            Return x.title.CompareTo(y.title)
        End Function
    End Class
    Private Sub ReBuildObjectExplorer(text As String)
        Try
            'LISTE GENERALE//////////////////////////////////////////////////////////////////////////////////////////////////////
            Dim list As List(Of ExplorerItem) = New List(Of ExplorerItem)()
            Dim lastClassIndex As Integer = -1
            Dim regex As Regex = New Regex("^(?<range>[\w\s]+\b(struct|enum|interface)\s+[\w<>,\s]+)|^\s*(public|private|internal|protected|window\/|Texteblock\/|Button\/|Fix/|Checkbox\/|picturebox\/|Imagebox\/|Textbox\/|Checkbox\/|Textblock\/|rem\/|Rem\/|fonction\/|function\/|si\/|if\/)[^\n]+(\n?\s*{|;)?", RegexOptions.Multiline Or RegexOptions.IgnoreCase)
            For Each r As Match In regex.Matches(text)
                Try
                    Dim s As String = r.Value
                    Dim i As Integer = s.IndexOfAny(New Char() {"=", "{", ";"})
                    If i >= 0 Then
                        s = s.Substring(0, i)
                    End If
                    'FENETRE/////////////////////////////////////////////////////////////////
                    s = s.Trim()
                    Dim item As ExplorerItem = New ExplorerItem() With {.title = s, .position = r.Index}
                    If regex.IsMatch(item.title, "\b(class|fenetre|enum|interface)\b") Then
                        item.title = item.title.Substring(item.title.LastIndexOf(" ")).Trim()
                        item.type = ExplorerItemType.[Class]
                        list.Sort(lastClassIndex + 1, list.Count - (lastClassIndex + 1), New ExplorerItemComparer())
                        lastClassIndex = list.Count

                    Else
                        'VARIABLE////////////////////////////////////////////////////////////
                        'SYNTAXE FRANCAISE
                        If item.title.ToLower.Contains("fix") Then 'si contient
                            Dim ii As Integer = item.title.LastIndexOf(" ")
                            item.title = item.title.Substring(ii).Trim()
                            item.type = ExplorerItemType.[Event] 'image
                        Else
                            'CHECKBOX/////////////////////////////////////////////////////
                            'SYNTAXE FRANCAISE
                            If item.title.ToLower.Contains("checkbox") Then 'si contient
                                Dim ii As Integer = item.title.LastIndexOf(" ")
                                item.title = item.title.Substring(ii).Trim()
                                item.type = ExplorerItemType.Checkbox 'image
                            Else
                                'BOUTON///////////////////////////////////////////////////
                                'SYNTAXE FRANCAISE
                                If item.title.ToLower.Contains("bouton") Then 'si contient
                                    Dim ii As Integer = item.title.LastIndexOf(" ")
                                    item.title = item.title.Substring(ii).Trim()
                                    item.type = ExplorerItemType.Bouton 'TYPE
                                Else

                                    If item.title.ToLower.Contains("button") Then 'si contient
                                        Dim ii As Integer = item.title.LastIndexOf(" ")
                                        item.title = item.title.Substring(ii).Trim()
                                        item.type = ExplorerItemType.Bouton 'TYPE
                                    Else
                                        'TEXTEBOX/////////////////////////////////////////////
                                        'SYNTAXE FRANCAISE

                                        If item.title.ToLower.Contains("textebox") Then 'si contient
                                            Dim ii As Integer = item.title.LastIndexOf(" ")
                                            item.title = item.title.Substring(ii).Trim()
                                            item.type = ExplorerItemType.Textbox 'TYPE
                                        Else 'SYNTAXE ANGLAISE
                                            If item.title.ToLower.Contains("textbox") Then 'si contient
                                                Dim ii As Integer = item.title.LastIndexOf(" ")
                                                item.title = item.title.Substring(ii).Trim()
                                                item.type = ExplorerItemType.Textbox 'TYPE
                                            Else

                                                'TEXTEBLOC//////////////////////////////////////////
                                                'SYNTAXE FRANCAISE
                                                If item.title.ToLower.Contains("textebloc") Then 'si contient
                                                    Dim ii As Integer = item.title.LastIndexOf(" ")
                                                    item.title = item.title.Substring(ii).Trim()
                                                    item.type = ExplorerItemType.Textbloc 'TYPE
                                                Else

                                                    If item.title.ToLower.Contains("textblock") Then 'si contient
                                                        Dim ii As Integer = item.title.LastIndexOf(" ")
                                                        item.title = item.title.Substring(ii).Trim()
                                                        item.type = ExplorerItemType.Textbloc 'TYPE
                                                    Else

                                                        ' IMAGEBOX//////////////////////////////////
                                                        'SYNTAXE FRANCAISE

                                                        If item.title.ToLower.Contains("imagebox") Then 'si contient
                                                            Dim ii As Integer = item.title.LastIndexOf(" ")
                                                            item.title = item.title.Substring(ii).Trim()
                                                            item.type = ExplorerItemType.Imagebox 'TYPE
                                                        Else 'SYNTAXE ANGLAISE
                                                            If item.title.ToLower.Contains("picturebox") Then 'si contient
                                                                Dim ii As Integer = item.title.LastIndexOf(" ")
                                                                item.title = item.title.Substring(ii).Trim()
                                                                item.type = ExplorerItemType.Imagebox 'TYPE
                                                            Else


                                                                'COMMENTAIRE///////////////////////////////////////////////////
                                                                If item.title.ToLower.Contains("rem") Then 'si contient
                                                                    Dim ii As Integer = item.title.LastIndexOf(" ")
                                                                    item.title = item.title.Substring(ii).Trim()
                                                                    item.type = ExplorerItemType.Comment 'TYPE
                                                                Else
                                                                    'Fonction///////////////////////////////////////////////////
                                                                    If item.title.ToLower.Contains("fonction") Then 'si contient
                                                                        Dim ii As Integer = item.title.LastIndexOf(" ")
                                                                        item.title = item.title.Substring(ii).Trim()
                                                                        item.type = ExplorerItemType.Fonction 'TYPE
                                                                    Else
                                                                        'COMMENTAIRE///////////////////////////////////////////////////
                                                                        If item.title.ToLower.Contains("function") Then 'si contient
                                                                            Dim ii As Integer = item.title.LastIndexOf(" ")
                                                                            item.title = item.title.Substring(ii).Trim()
                                                                            item.type = ExplorerItemType.Fonction 'TYPE
                                                                        Else


                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If

                        End If
                    End If
                    list.Add(item)
                Catch ex_2BF As Exception
                    Console.WriteLine(ex_2BF)
                End Try
            Next
            list.Sort(lastClassIndex + 1, list.Count - (lastClassIndex + 1), New ExplorerItemComparer())
            MyBase.BeginInvoke(Sub()
                                   Me.explorerList = list
                                   Me.dgvObjectExplorer2.RowCount = Me.explorerList.Count
                                   Me.dgvObjectExplorer2.Invalidate()
                               End Sub)
        Catch ex_332 As Exception
            Console.WriteLine(ex_332)
        End Try
    End Sub
    Private Sub ButtonItem9_Click(sender As Object, e As EventArgs) Handles ButtonItem9.Click

    End Sub

    Private Sub dgvObjectExplorer2_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvObjectExplorer2.CellMouseDoubleClick
        If Me.tb IsNot Nothing Then
            Dim item As ExplorerItem = Me.explorerList(e.RowIndex)
            Me.tb.GoEnd()
            Me.tb.SelectionStart = item.position
            Me.tb.DoSelectionVisible()
            Me.tb.Focus()
        End If
    End Sub

    Private Sub dgvObjectExplorer2_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvObjectExplorer2.CellValueNeeded
        Try
            Dim item As ExplorerItem = Me.explorerList(e.RowIndex)
            If e.ColumnIndex = 1 Then
                e.Value = item.title
            Else
                Select Case item.type
                    Case ExplorerItemType.[Class]
                        e.Value = My.Resources.class_libraries
                    Case ExplorerItemType.Method
                        e.Value = My.Resources.box
                    Case ExplorerItemType.[Property]
                        e.Value = My.Resources.Bouton
                    Case ExplorerItemType.[Event]
                        e.Value = My.Resources.light16
                    Case ExplorerItemType.Bouton
                        e.Value = My.Resources.Bouton
                    Case ExplorerItemType.Checkbox
                        e.Value = My.Resources.checkbox
                    Case ExplorerItemType.Comment
                        e.Value = My.Resources.Comment
                    Case ExplorerItemType.Creer
                        e.Value = My.Resources.creer
                    Case ExplorerItemType.Fin
                        e.Value = My.Resources.fin
                    Case ExplorerItemType.Textbox
                        e.Value = My.Resources.textebox
                    Case ExplorerItemType.Textbloc
                        e.Value = My.Resources.textebloc
                    Case ExplorerItemType.Imagebox
                        e.Value = My.Resources.imagebox
                    Case ExplorerItemType.Fonction
                        e.Value = My.Resources.diamond16

                End Select
            End If
        Catch ex_8D As Exception
        End Try
    End Sub

    Private Sub OSMCodeBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim text As String = Me.tb.Text
        ThreadPool.QueueUserWorkItem(Sub(o As Object)
                                         Me.ReBuildObjectExplorer(text)
                                     End Sub)
    End Sub

    Private Sub tb_Load(sender As Object, e As EventArgs) Handles tb.Load

    End Sub
End Class
