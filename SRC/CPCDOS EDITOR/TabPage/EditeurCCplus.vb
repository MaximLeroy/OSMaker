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
Imports System.Xml
Imports System.Text


Public Class EditeurCCplus
    Private _hostSurfaceManager As OSMaker.HostSurfaceManager
    Private _formCount As Integer = 0
    Private HostC As OSMaker.HostControl
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
        CustomInitialize()
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
        e.ChangedRange.SetStyle(RoseStyle, "(TYPE:|CTN:|BORD:|OMBRE:|IMGAUTO:|EDIT:|MULTILINE:|\,)")
        e.ChangedRange.SetStyle(EqualStyle, "\=")

        e.ChangedRange.SetStyle(BlueStyle, "(Create\/|create\/|End\/ window|window\/|End\/ button|button\/|End\/ textbox|textbox\/|End\/ textblock|textblock\/|End\/ progressbar|progressbar\/|End\/ picturebox|picturebox\/|End\/ checkbox|checkbox\/)", RegexOptions.IgnoreCase)
        e.ChangedRange.SetStyle(YellowStyle, "@#.*$", RegexOptions.Multiline)
        e.ChangedRange.SetStyle(YellowStyle, "/.*$", RegexOptions.Multiline)
        e.ChangedRange.SetStyle(RedStyle, """.*?""|'.+?'")


        'attribute highlighting
        e.ChangedRange.SetStyle(GrayStyle, "^\s*(?<range>\[.+?\])\s*$", RegexOptions.Multiline)
        'class name highlighting
        e.ChangedRange.SetStyle(BoldStyle, "\b(class|struct|enum)\s+(?<range>\w+?)\b")
        'keyword highlighting
        e.ChangedRange.SetStyle(BlueStyle, "\b(abstract|as|base|bool|break|byte|case|catch|char|class|const|continue|decimal|default|delegate|do|double|else|enum|explicit|extern|false|finally|fixed|float|for|foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|void|volatile|while|add|alias|ascending|descending|dynamic|from|get|global|group|into|join|let|orderby|partial|remove|select|set|value|var|where|yield)\b|#region\b|#endregion\b|")


        e.ChangedRange.SetStyle(OrangeStyle, "(\.Parametres|\.PX|\.PY|\.SX|\.SY|\.Valeur|\.BackColor|\.CouleurText|\.Event|\.event|\.Icone|\.ImgTitre|\.Opacite|\.titre|\.CouleurFenetre|\.CouleurTitre|\.px|\.py|\.tx|\.ty|\.opacite|\.Text|\.Image|\.evenement|\.texte|\.Handle|\.handle)", RegexOptions.IgnoreCase)
        e.ChangedRange.SetStyle(Gras, "fenetre\/", RegexOptions.IgnoreCase)
        e.ChangedRange.SetStyle(Gras, "Fin\/ fenetre", RegexOptions.IgnoreCase)



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

    End Sub
    Private Class Strings
        Public Const Design = "Design"
        Public Const Code = "Code"
    End Class



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

    '  Private WithEvents tsFiles3 As FATabStrip


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


    <CLSCompliant(False)> Public Designer As OSMaker.Designer = New OSMaker.Designer(My.Settings.Afficher_La_Griller, True, My.Settings.Aimentation_Intelligente, True, My.Settings.Smart_Tags, True, My.Settings.Afficher_La_Griller)

    Public componentChangeService As System.ComponentModel.Design.IComponentChangeService
    Private Sub EditeurCCplus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _formCount += 1
            HostC = _hostSurfaceManager.GetNewHost(GetType(Form), OSMaker.LoaderType.BasicDesignerLoader)
            ' AddTabForNewHost("Form" & _formCount.ToString() & " - " & Strings.Design)
            HostC.Parent = Panel1
            HostC.Dock = DockStyle.Fill
        Catch
            MessageBox.Show("Error in creating new host", "Shell Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    <CLSCompliant(False)> Public undoEngine As OSMaker.UndoEngineImpl

    Private Sub CustomInitialize()
        _hostSurfaceManager = New OSMaker.HostSurfaceManager()
        _hostSurfaceManager.AddService(GetType(IToolboxService), Form2.Toolbox)
        _hostSurfaceManager.AddService(GetType(DevComponents.DotNetBar.AdvPropertyGrid), Form2.AdvPropertyGrid1)

    End Sub
    Private Sub AddTabForNewHost(ByVal tabText As String)
        Dim serviceContainer As System.ComponentModel.Design.IServiceContainer
        Form2.Toolbox.DesignerHost = HostC.DesignerHost
        ' Dim tabpage As TabPage = New TabPage(tabText)
        'TabPage.Tag = CurrentMenuSelectionLoaderType
        HostC.Parent = Panel1
        HostC.Dock = DockStyle.Fill


        'tabControl1.TabPages.Add(tabpage)
        ' tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1
        _hostSurfaceManager.ActiveDesignSurface = HostC.HostSurface
        serviceContainer = DirectCast(_hostSurfaceManager.GetService(GetType(System.ComponentModel.Design.ServiceContainer)), System.ComponentModel.Design.IServiceContainer)
        Me.MenuCommandService = New OSMaker.MenuCommandServiceImpl(serviceContainer)
        HostC.DesignerHost.AddService(GetType(System.ComponentModel.Design.MenuCommandService), Me.MenuCommandService)

        ' Ajout du service Annuler/Retablir
        Me.undoEngine = New OSMaker.UndoEngineImpl(serviceContainer)
        Me.undoEngine.Enabled = False
        _hostSurfaceManager.AddService(GetType(System.ComponentModel.Design.UndoEngine), Me.undoEngine)

    End Sub
    Public Sub Coller()
        Dim ims As System.ComponentModel.Design.IMenuCommandService = TryCast(HostC.HostSurface.GetService(GetType(System.ComponentModel.Design.IMenuCommandService)), System.ComponentModel.Design.IMenuCommandService)
        If My.Computer.Clipboard.GetDataObject().GetDataPresent("CF_DESIGNERCOMPONENTS_V2", True) Then ' On vérifie que des contrôles soient dans le Presse-papiers
            Dim a As System.ComponentModel.Design.CommandID = System.ComponentModel.Design.StandardCommands.Paste
            ims.GlobalInvoke(a)
            Me.MenuCommandService.GlobalInvoke(a)
        End If

    End Sub

    Public Sub Copier()

        Dim ims As System.ComponentModel.Design.IMenuCommandService = TryCast(HostC.HostSurface.GetService(GetType(System.ComponentModel.Design.IMenuCommandService)), System.ComponentModel.Design.IMenuCommandService)
        Dim a As System.ComponentModel.Design.CommandID = System.ComponentModel.Design.StandardCommands.Copy
        ims.GlobalInvoke(a)

        Me.MenuCommandService.GlobalInvoke(a)

            'Clipboard.SetDataObject(Me.File, True)
        'If Clipboard.GetDataObject().GetDataPresent("VelerSoftware.SZVB.Projet.SZW_File", True) Then
        '    MsgBox(DirectCast(Clipboard.GetDataObject.GetData("VelerSoftware.SZVB.Projet.SZW_File", True), VelerSoftware.SZVB.Projet.SZW_File).Nom)
        'End If



    End Sub
    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles Aligner.Click
        FastColoredTextBox1.Text = CType(HostC.HostSurface.Loader, Loader.BasicHostLoader).GetCode()

    End Sub

    Private Sub ButtonItem11_Click(sender As Object, e As EventArgs) Handles ButtonItem11.Click

        Dim currentHostControl = HostC
        Dim stringXML As String = CType(currentHostControl.HostSurface.Loader, Loader.BasicHostLoader).GetCode()
        GenTextCpc(stringXML)

        Dim code = CType(currentHostControl.HostSurface.Loader, Loader.BasicHostLoader).GetCode()
        FastColoredTextBox1.Text = code
        Dim fileName As String = TextBoxX2.Text
        If TextBoxX2.Text = Nothing Then
            Dim dlgSaveFile As New SaveFileDialog
            dlgSaveFile.Filter = "Fichier XML (.*xml)|*.xml"


            If dlgSaveFile.ShowDialog = DialogResult.OK Then
                fileName = dlgSaveFile.FileName
                TextBoxX2.Text = fileName

                If fileName.Length <> 0 Then


                End If
            End If
        Else
            fileName = TextBoxX2.Text
        End If

        If TextBoxX2.Text = Nothing Then
            MessageBox.Show("Pas de chemin de fichier XML renseigné, enregistrement impossible !")
        Else
            File.WriteAllText(TextBoxX2.Text, code)

        End If

    End Sub



    Private doc As XmlDocument
    Private WinToCpcControls As Dictionary(Of String, String)
    Private CpcDebutToFins As Dictionary(Of String, String)
    Private sb As StringBuilder
    Public MenuCommandService As System.ComponentModel.Design.IMenuCommandService

    Public SelectionService As System.ComponentModel.Design.ISelectionService
    Private Sub PerformAction(ByVal text As String)


        If HostC Is Nothing Then Return

        Dim ims As System.ComponentModel.Design.IMenuCommandService = TryCast(HostC.HostSurface.GetService(GetType(System.ComponentModel.Design.IMenuCommandService)), System.ComponentModel.Design.IMenuCommandService)

        Try

            Select Case text
                Case "&Cut"
                    ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.Cut)
                Case "C&opy"
                    ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.Copy)
                Case "&Paste"
                    ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.Paste)
                Case "&Undo"
                    ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.Undo)
                Case "&Redo"
                    ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.Redo)
                Case "&Delete"
                    ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.Delete)
                Case "&Select All"
                    ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.SelectAll)
                Case "&Lefts"
                    ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.AlignLeft)
                Case "&Centers"
                    ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.AlignHorizontalCenters)
                Case "&Rights"
                    ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.AlignRight)
                Case "&Tops"
                    ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.AlignTop)
                Case "&Middles"
                    ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.AlignVerticalCenters)
                Case "&Bottoms"
                    ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.AlignBottom)
                Case Else
            End Select

        Catch
            MessageBox.Show("Error in performing the action: " & text.Replace("&", ""))
        End Try
    End Sub

    Private Sub ActionClick(ByVal sender As Object, ByVal e As EventArgs)
        PerformAction(TryCast(sender, DevComponents.DotNetBar.ButtonItem).Text)
    End Sub

    'Private inputFile As String = "C:\Users\OUNIS\Desktop\WinSerializePanel\WinTweakDedignerHost" + "\Exemple.xml"
    'Private outputFile As String = "C:\Users\OUNIS\Desktop\WinSerializePanel\WinTweakDedignerHost" + "\Exemple.txt"
    Public Sub GenTextCpc(stringXML As String)
        LoadWinToCpcControls()
        sb = New StringBuilder
        doc = New XmlDocument()

        'le code qui suit remets en place le noeud xml "RACINE" xml 
        ' comme  deja car la prop GetCode dans BasicHostLoader la supprime
        Dim cleandown As String = stringXML
        cleandown = "<DOCUMENT_ELEMENT>" + stringXML + "</DOCUMENT_ELEMENT>"

        doc.LoadXml(cleandown)

        Dim root As XmlNode = doc.DocumentElement
        For Each node As XmlNode In root.ChildNodes
            WriteNodeObject(node, sb)

        Next

        Dim cpcFileName As String = GetFileNameToSave() 'obtient le nom de fichier CPC à sauvegarder
        If cpcFileName IsNot Nothing Then
            File.WriteAllText(cpcFileName, sb.ToString)

        End If

    End Sub
    Private Moncurrentnode As XmlNode
    Private Monsbuilder As StringBuilder

    Private Sub WriteNodeObject(currentNode As XmlNode, sbuilder As StringBuilder)
        Dim nameTypes() As String = {}
        Dim names() As String = {}


        If currentNode.Name = "Object" Then ' c'est un node Object i.e. un Control
            nameTypes = currentNode.Attributes.GetNamedItem("type").Value.Split(New Char() {","})
            names = currentNode.Attributes.GetNamedItem("name").Value.Split(New Char() {","})

            Select Case nameTypes(0)

                Case WinToCpcControls.Keys(0)
                    sbuilder.Append(
                        ("
'REMARQUE : Cpcdosiennes, Cpcdosiens ce code est généré par
' _____   _____       ___  ___       ___   _   _    _____   _____   
'/  _  \ /  ___/     /   |/   |     /   | | | / /  | ____| |  _  \  
'| | | | | |___     / /|   /| |    / /| | | |/ /   | |__   | |_| |  
'| | | | \___  \   / / |__/ | |   / / | | | |\ \   |  __|  |  _  /  
'| |_| |  ___| |  / /       | |  / /  | | | | \ \  | |___  | | \ \  
'\_____/ /_____/ /_/        |_| /_/   |_| |_|  \_\ |_____| |_|  \_\ v 1.0
' La procédure suivante est requise par le Concepteur Windows Form
' Elle peut être modifiée à l'aide du Concepteur Windows Form  
' Ne la modifiez pas à l'aide de l'éditeur de code.                        ") & ChrW(10))
                    sbuilder.Append(WinToCpcControls.Values(0))
                    sbuilder.Append(" " + names(0))
                    sbuilder.AppendLine()
                    'XPATH  un autre operateut  XML fait des miracles 
                    'lit tou les nodes "Property" sous le currentNode
                    Dim childrops As XmlNodeList = currentNode.SelectNodes("Property")
                    For Each item As XmlNode In childrops
                        WriteNodeProperty(item, sbuilder)
                    Next
                    If parametrescheck.Checked Then
                        sbuilder.AppendLine(".Parameters" + "   " + " = """ + bordtext.Text & ctntext.Text & typetext.Text & "OMBRE:" & ombretext.Text + """")
                    End If
                    If Opacitetext.Text = Nothing Then
                    Else
                        sbuilder.AppendLine(".Opacite" + "      " + " = """ + Opacitetext.Text + """")
                    End If
                    If Couleurfenetretext.Text = Nothing Then
                    Else
                        sbuilder.AppendLine(".WindowColor" + "  " + " = """ + Couleurfenetretext.Text + """")
                    End If
                    If couleurtitretext.Text = Nothing Then
                    Else
                        sbuilder.AppendLine(".TitleColor" + "   " + " = """ + couleurtitretext.Text + """")
                    End If
                    If couleurfondtext.Text = Nothing Then
                    Else
                        sbuilder.AppendLine(".BackColor" + "    " + " = """ + couleurfondtext.Text + """")
                    End If
                    If iconetext.Text = Nothing Then
                    Else
                        sbuilder.AppendLine(".Icone" + "        " + " = """ + iconetext.Text + """")
                    End If
                    If imgtitretext.Text = Nothing Then
                    Else
                        sbuilder.AppendLine(".ImgTitre" + "     " + " = """ + imgtitretext.Text + """")
                    End If
                    sbuilder.AppendLine("Create/ @#" & Handletext.Text)
                    sbuilder.AppendLine(CpcDebutToFins.Values(0))
                Case WinToCpcControls.Keys(1)
                    sbuilder.Append(WinToCpcControls.Values(1))
                    sbuilder.AppendLine(" " + names(0))
                    sbuilder.AppendLine()
                    Dim childrops As XmlNodeList = currentNode.SelectNodes("Property")
                    For Each item As XmlNode In childrops
                        WriteNodeProperty(item, sbuilder)
                    Next
                    sbuilder.AppendLine("Create/")
                    sbuilder.AppendLine(CpcDebutToFins.Values(1))
                Case WinToCpcControls.Keys(2)
                    sbuilder.Append(WinToCpcControls.Values(2))
                    sbuilder.Append(" " + names(0))
                    sbuilder.AppendLine()
                    Dim childrops As XmlNodeList = currentNode.SelectNodes("Property")
                    For Each item As XmlNode In childrops
                        WriteNodeProperty(item, sbuilder)
                    Next
                    sbuilder.AppendLine("Create/")
                    sbuilder.AppendLine(CpcDebutToFins.Values(2))
                Case WinToCpcControls.Keys(3)
                    sbuilder.Append(WinToCpcControls.Values(3))
                    sbuilder.Append(" " + names(0))
                    sbuilder.AppendLine()
                    Dim childrops As XmlNodeList = currentNode.SelectNodes("Property")
                    For Each item As XmlNode In childrops
                        WriteNodeProperty(item, sbuilder)
                    Next
                    sbuilder.AppendLine("Create/")
                    sbuilder.AppendLine(CpcDebutToFins.Values(3))
                Case WinToCpcControls.Keys(4)
                    sbuilder.Append(WinToCpcControls.Values(4))
                    sbuilder.Append(" " + names(0))
                    sbuilder.AppendLine()
                    Dim childrops As XmlNodeList = currentNode.SelectNodes("Property")
                    For Each item As XmlNode In childrops
                        WriteNodeProperty(item, sbuilder)
                    Next
                    sbuilder.AppendLine("Create/")
                    sbuilder.AppendLine(CpcDebutToFins.Values(4))
                Case WinToCpcControls.Keys(5)
                    sbuilder.Append(WinToCpcControls.Values(5))
                    sbuilder.Append(" " + names(0))
                    sbuilder.AppendLine()
                    Dim childrops As XmlNodeList = currentNode.SelectNodes("Property")
                    For Each item As XmlNode In childrops
                        WriteNodeProperty(item, sbuilder)
                    Next
                    sbuilder.AppendLine("Create/")
                    sbuilder.AppendLine(CpcDebutToFins.Values(5))
                Case WinToCpcControls.Keys(6)
                    sbuilder.Append(WinToCpcControls.Values(6))
                    sbuilder.Append(" " + names(0))
                    sbuilder.AppendLine()
                    Dim childrops As XmlNodeList = currentNode.SelectNodes("Property")
                    For Each item As XmlNode In childrops
                        WriteNodeProperty(item, sbuilder)
                    Next
                    sbuilder.AppendLine("Create/")
                    sbuilder.AppendLine(CpcDebutToFins.Values(6))
            End Select
            sbuilder.AppendLine()
            For Each itemNode In currentNode.ChildNodes
                WriteNodeObject(itemNode, sbuilder) 'appel recurif car XML genere en fait un tree
            Next
        End If
        Dim code As String = sbuilder.ToString()
        tb.Text = code
    End Sub

    Private Sub WriteNodeProperty(currentNode As XmlNode, sbuilder As StringBuilder)
        Dim name As String
        Dim propertyValues() As String
        Dim propertyValues2 As String


        propertyValues = currentNode.InnerText.Split(New Char() {","})
        propertyValues2 = currentNode.InnerText
        name = currentNode.Attributes.GetNamedItem("name").Value


        If name = "Text" Then
            sbuilder.AppendLine(".text" + "         " + " = """ + propertyValues(0) + """")
        ElseIf name = "Handle" Then
            sbuilder.AppendLine(".Handle" + "       " + " = """ + "%" & Handletext.Text & "%" + """")
        ElseIf name = "Location" Then
            sbuilder.Append(".PX" + "           " + " = """ + propertyValues(0).Trim + """")
            sbuilder.AppendLine()
            sbuilder.AppendLine(".PY" + "           " + " = """ + propertyValues(1).Trim + """")
        ElseIf name = "ClientSize" Or name = "Size" Then
            sbuilder.Append(".SX" + "           " + " = """ + propertyValues(0).Trim + """")
            sbuilder.AppendLine()
            sbuilder.AppendLine(".SY" + "           " + " = """ + propertyValues(1).Trim + """")
        ElseIf name = "CouleurFond" Then
            If propertyValues2 = Nothing Then
            Else
                sbuilder.Append(".BackColor" + "    " + " = """ + propertyValues2.Trim + """")
                sbuilder.AppendLine()
            End If

        ElseIf name = "CouleurTexte" Then
            If propertyValues2 = Nothing Then
            Else
                sbuilder.Append(".TextColor" + "    " + " = """ + propertyValues2.Trim + """")
                sbuilder.AppendLine()
            End If
        ElseIf name = "Checked" Then
            Dim valeur As String = If(propertyValues(0) = "True", "1", "0")
            sbuilder.AppendLine(".Value" + "        " + " = """ + valeur + """")
        ElseIf name = "EVENT_PATH" Then
            If propertyValues2 = Nothing Then
            Else
                sbuilder.Append(".Event" + "        " + " = """ + propertyValues2.Trim + """")
                sbuilder.AppendLine()
            End If
        ElseIf name = "IMGAUTO" Then
            If propertyValues2 = Nothing Then
            Else
                IMGAUTO1 = "IMGAUTO:" & propertyValues2
            End If
        ElseIf name = "COL" Then
            If propertyValues2 = Nothing Then
            Else
                COL1 = "COL:" & propertyValues2
            End If
        ElseIf name = "UPD" Then
            If propertyValues2 = True Then

                UPD1 = "UPD:1"
            End If


        ElseIf name = "Image" Then
            If propertyValues2 = Nothing Then
            Else
                sbuilder.Append(".Image" + "        " + " = """ + propertyValues2 + """")
                sbuilder.AppendLine()
            End If
        ElseIf name = "Parameters" Then
            If propertyValues2 = Nothing Then
            Else
                sbuilder.Append(".Parameters" + "   " + " = """ + propertyValues2 + """")
                sbuilder.AppendLine()
            End If
        End If

    End Sub

    Private IMGAUTO1 As String
    Private MULTILINES1 As String
    Private COL1 As String
    Private UPD1 As String
    Private Sub LoadWinToCpcControls()

        WinToCpcControls = New Dictionary(Of String, String)
        WinToCpcControls.Add("System.Windows.Forms.Form", "Window/")
        WinToCpcControls.Add("ToolBox.PictureBox", "PictureBox/")
        WinToCpcControls.Add("ToolBox.CheckBox", "CheckBox/")
        WinToCpcControls.Add("ToolBox.Button", "Button/")
        WinToCpcControls.Add("ToolBox.TextBox", "TextBox/")
        WinToCpcControls.Add("ToolBox.TextBlock", "TextBlock/")
        WinToCpcControls.Add("ToolBox.ProgressBar", "ProgressBar/")

        CpcDebutToFins = New Dictionary(Of String, String)
        CpcDebutToFins.Add("Window/", "End/ Window")
        CpcDebutToFins.Add("PictureBox/", "End/ PictureBox")
        CpcDebutToFins.Add("CheckBox/", "End/ CheckBox")
        CpcDebutToFins.Add("Button/", "End/ Button")
        CpcDebutToFins.Add("TextBox/", "End/ TextBox")
        CpcDebutToFins.Add("TextBlock/", "End/ TextBlock")
        CpcDebutToFins.Add("ProgressBar/", "End/ ProgressBar")
    End Sub

    Private root As IComponent
    'AJOUT => UN SAVEDIALOG

    Private Function GetFileNameToSave() As String
        Dim fileName As String = Nothing
        If TextBoxX1.Text = Nothing Then
            Dim dlgSaveFile As New SaveFileDialog
            dlgSaveFile.Filter = "Files(.*cpc)|*.cpc"


            If dlgSaveFile.ShowDialog = DialogResult.OK Then
                fileName = dlgSaveFile.FileName
                TextBoxX1.Text = fileName

                If fileName.Length <> 0 Then
                    Return fileName

                End If
            End If
        Else
            fileName = TextBoxX1.Text
        End If
        Return fileName

    End Function

    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs)
        Dim currentHostControl = HostC
        CType(currentHostControl.HostSurface.Loader, Loader.BasicHostLoader).Save(True)


    End Sub






    Private Sub ButtonItem9_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Indisponible (version Beta)")
    End Sub

    Private Sub tb_TextChangedDelayed(sender As Object, e As TextChangedEventArgs) Handles tb.TextChangedDelayed
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

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonX1_Click_1(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim Nom_Ctrl_Actif As String
        If Form2.AdvPropertyGrid1.SelectedObject.ToString.Contains("[") Then
            Nom_Ctrl_Actif = Form2.AdvPropertyGrid1.SelectedObject.ToString.Split("[")(0).TrimEnd(" ")
        Else
            Nom_Ctrl_Actif = Form2.AdvPropertyGrid1.SelectedObject.GetType.GetProperty("Name").GetValue(Form2.AdvPropertyGrid1.SelectedObject, Nothing)
        End If
        'Else
        ' Nom_Ctrl_Actif = SelectionService.PrimarySelection.ToString.Split("[")(0).TrimEnd(" ")
        ' End If
        TextBoxX3.Text = Nom_Ctrl_Actif
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim dlgSaveFile As New SaveFileDialog
        dlgSaveFile.Filter = "Fichier CC+ (.*cpc)|*.cpc"
        Dim fileName As String = Nothing

        If dlgSaveFile.ShowDialog = DialogResult.OK Then
            fileName = dlgSaveFile.FileName
            TextBoxX4.Text = fileName
            Dim di As DirectoryInfo = New DirectoryInfo(fileName)
            Dim fs As FileStream = File.Create(fileName)
            ' add file to  di

            If fileName.Length <> 0 Then


            End If
        End If

        fileName = TextBoxX4.Text

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        If TextBoxX4.Text = Nothing Then
            MessageBox.Show("Veuillez sélectionner un fichier évènement CC+")
        Else
            My.Computer.FileSystem.WriteAllText(TextBoxX4.Text, "Function/ " & TextBoxX3.Text & ".MouseClick()" & vbCrLf & "" & vbCrLf & "End/ Function", True)
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ' Try

        '_formCount += 1
        'HostC = _hostSurfaceManager.GetNewHost(TextBoxX2.Text)
        'rm2.Toolbox.DesignerHost = HostC.DesignerHost
        '' Dim tabpage As TabPage = New TabPage(tabText)
        'TabPage.Tag = CurrentMenuSelectionLoaderType
        'HostC.Parent = Panel1
        'HostC.Dock = DockStyle.Fill


        'tabControl1.TabPages.Add(tabpage)
        ' tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1
        '_hostSurfaceManager.ActiveDesignSurface = HostC.HostSurface

        'Dim ims As System.ComponentModel.Design.IMenuCommandService = TryCast(HostC.HostSurface.GetService(GetType(System.ComponentModel.Design.IMenuCommandService)), System.ComponentModel.Design.IMenuCommandService)

        'Catch
        'MessageBox.Show("Error in creating new host", "Shell Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ' End Try
    End Sub

    Private Sub ButtonItem1_Click_1(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        Dim ims As System.ComponentModel.Design.IMenuCommandService = TryCast(HostC.HostSurface.GetService(GetType(System.ComponentModel.Design.IMenuCommandService)), System.ComponentModel.Design.IMenuCommandService)
        ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.Delete)
    End Sub

    ' Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    '  Try
    'Dim fileName As String = Nothing

    ' Open File Dialog
    'Dim dlg As OpenFileDialog = New OpenFileDialog()
    'dlg.DefaultExt = "xml"
    'dlg.Filter = "Xml Files|*.xml"
    'If dlg.ShowDialog() = DialogResult.OK Then fileName = dlg.FileName
    'Equals(fileName, Nothing) Then Return

    ' Create Form
    '_formCount += 1
    'ostC = _hostSurfaceManager.GetNewHost(fileName)
    'Toolbox.DesignerHost = hc.DesignerHost

    'xtBoxX2.Text = fileName

    'e.Tag = HostC.HostSurface.Loader


    'HostC.Parent = Panel1
    'HostC.Dock = DockStyle.Fill
    '_hostSurfaceManager.ActiveDesignSurface = HostC.HostSurface
    ' F 'orm2.Toolbox.DesignerHost = HostC.DesignerHost
    ' Catch
    'MessageBox.Show("Error in creating new host", "Shell Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    ' End Try
    'End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Copy_Click(sender As Object, e As EventArgs) Handles Copy.Click
        Dim ims As System.ComponentModel.Design.IMenuCommandService = TryCast(HostC.HostSurface.GetService(GetType(System.ComponentModel.Design.IMenuCommandService)), System.ComponentModel.Design.IMenuCommandService)
        ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.CenterHorizontally)
    End Sub

    Private Sub ButtonItem6_Click(sender As Object, e As EventArgs) Handles ButtonItem6.Click
        Dim ims As System.ComponentModel.Design.IMenuCommandService = TryCast(HostC.HostSurface.GetService(GetType(System.ComponentModel.Design.IMenuCommandService)), System.ComponentModel.Design.IMenuCommandService)
        ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.CenterVertically)
    End Sub
End Class


