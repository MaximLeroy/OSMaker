using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
//using FarsiLibrary.Win;
using FastColoredTextBoxNS;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace OSMaker
{
    internal partial class OSMCodeBox
    {
        public OSMCodeBox()
        {
            BlueStyle = new TextStyle(SolidBlue, null, FontStyle.Regular);
            OrangeStyle = new TextStyle(SolidBlueLight, null, FontStyle.Regular);
            VertLightStyle = new TextStyle(SolidVert, null, FontStyle.Regular);
            MagentaStyle = new TextStyle(SolidNumber, null, FontStyle.Regular);
            YellowStyle = new TextStyle(SolidJaune, null, FontStyle.Regular);
            GreenStyle = new TextStyle(SolidGreen, null, FontStyle.Regular);
            RoseStyle = new TextStyle(SolidRose, null, FontStyle.Regular);
            EqualStyle = new TextStyle(SolidEqual, null, FontStyle.Regular);
            InitializeComponent();
            _tb.Name = "tb";
            _dgvObjectExplorer2.Name = "dgvObjectExplorer2";
            _ButtonItem9.Name = "ButtonItem9";
        }

        private Host.HostSurfaceManager _hostSurfaceManager = null;
        private int _formCount = 0;
        private List<ExplorerItem> explorerList = new List<ExplorerItem>();

        // 'SolidBrush
        private SolidBrush SolidGreen = new SolidBrush(Color.FromArgb(87, 166, 74));
        private SolidBrush SolidBlue = new SolidBrush(Color.FromArgb(86, 156, 214));
        private SolidBrush SolidBlueLight = new SolidBrush(Color.FromArgb(156, 220, 254));
        private SolidBrush SolidEqual = new SolidBrush(Color.FromArgb(180, 180, 180));
        private SolidBrush SolidRose = new SolidBrush(Color.FromArgb(216, 160, 223));
        private SolidBrush SolidVert = new SolidBrush(Color.FromArgb(78, 201, 176));
        private SolidBrush SolidVertFonce = new SolidBrush(Color.FromArgb(55, 146, 124));
        private SolidBrush SolidJaune = new SolidBrush(Color.FromArgb(220, 220, 170));
        private SolidBrush SolidNumber = new SolidBrush(Color.FromArgb(181, 206, 168));
        // 'Brushes
        private TextStyle SpringGreenStyle = new TextStyle(Brushes.SpringGreen, null, FontStyle.Regular);
        private TextStyle BlueStyle;
        private TextStyle OrangeStyle;
        private TextStyle RedStyle = new TextStyle(Brushes.LightCoral, null, FontStyle.Regular);
        private TextStyle VertLightStyle;
        private TextStyle BoldStyle = new TextStyle(null, null, FontStyle.Bold | FontStyle.Underline);
        private TextStyle Gras = new TextStyle(null, null, FontStyle.Bold);
        private TextStyle GrayStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
        private TextStyle MagentaStyle;
        private TextStyle YellowStyle;
        private TextStyle GreenStyle;
        private TextStyle BrownStyle = new TextStyle(Brushes.Brown, null, FontStyle.Italic);
        private TextStyle MaroonStyle = new TextStyle(Brushes.Maroon, null, FontStyle.Regular);
        private TextStyle RoseStyle;
        private TextStyle EqualStyle;
        private MarkerStyle SameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(40, Color.Gray)));

        private void CPCDOSSyntaxHighlight(TextChangedEventArgs e)
        {

            // clear style of changed range
            e.ChangedRange.ClearStyle(BlueStyle, BoldStyle, GrayStyle, MagentaStyle, GreenStyle, BrownStyle, RedStyle);
            // string highlighting


            // comment highlighting
            e.ChangedRange.SetStyle(GreenStyle, "//.*$", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(GreenStyle, "rem/.*$", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(GreenStyle, "'.*$", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline);
            e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft);
            e.ChangedRange.SetStyle(VertLightStyle, "%.+?%");
            // number highlighting
            e.ChangedRange.SetStyle(MagentaStyle, @"\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b");
            e.ChangedRange.SetStyle(RoseStyle, @"(TYPE:|CTN:|BORD:|OMBRE:|IMGAUTO:|EDIT:|MULTILINE:|\,|fonction\/|function\/|End\/ Function|Fin\/ Fonction|Si\/|If\/|Fin\/ si|End\/ If|alors\:|Txt\/|Fin\/ Fonction|then:|sinon:|else:)", RegexOptions.IgnoreCase);
            e.ChangedRange.SetStyle(EqualStyle, @"\=");
            e.ChangedRange.SetStyle(OrangeStyle, @"(\.Parametres|\.titlecolor|\.PX|\.PY|\.SX|\.SY|\.Valeur|\.BackColor|\.CouleurText|\.Icone|\.ImgTitre|\.Opacite|\.titre|\.CouleurFenetre|\.CouleurTitre|\.px|\.py|\.tx|\.ty|\.opacite|\.Text|\.Image|\.evenement|\.texte|\.Handle|\.pid|\.nom|\.name|\.title|\.parameters|\.opacity|\.image|\.evenement|\.couleurfenetre|\.windowcolor|\.couleurtitre|\.couleurtexte|\.textcolor|\.handle|\.icone|\.icon|\.imgtitre|\.titleimg|fenetre\/|fin\/ fenetre|\.event|\.couleurfond)", RegexOptions.IgnoreCase);
            e.ChangedRange.SetStyle(BlueStyle, @"(End\/ window|window\/|End\/ button|button\/|End\/ textbox|textbox\/|End\/ textblock|textblock\/|End\/ progressbar|progressbar\/|End\/ picturebox|picturebox\/|End\/ checkbox|checkbox\/|sys\/|\/processus|exe\/|\/pid\:|ccp\/|\/SET.LEVEL)", RegexOptions.IgnoreCase);
            e.ChangedRange.SetStyle(BlueStyle, @"(debut_section_critique|begin_critical_section|fin_section_critique|end_critical_section|\/INIT|\/menu|\/touche|\/key|\/INIT|\/atouche|\/wkey|\/pause|\/tcp|\/udp|\/attendre|\/wait|\/recevoir|\/receive|\/envoyer|\/send|\/mode|\/stop|\/temp|\/tempr|\/debug|\/cpinticore|\/thread|\/thread[MIN]|\/thread[STD]|\/thread[MAX]|\/optimisation|\/optimization|\/lang|\/change|\/pause|\/bin|\/app|\/mem|\/lang|\/ecran|\/screen|\/ccp)", RegexOptions.IgnoreCase);
            e.ChangedRange.SetStyle(YellowStyle, "@#.*$", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(RoseStyle, @"fix\/|declare\/|declarer\/|set\/|txt\/|goto\/|aller\/|Client\/|serveur\/|server\/|pos\/|stop\/|cls\/|aide\/|help\/|ouvrir\/|open\/|ecrire\/|write\/|return\/|ping\/|telecharger\/|download\/|iug\/|demarrer\/|start\/|close\/|fermer\/|creer\/|create\/", RegexOptions.IgnoreCase);
            e.ChangedRange.SetStyle(YellowStyle, "/.*$", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(RedStyle, "\".*?\"|'.+?'");


            // attribute highlighting
            e.ChangedRange.SetStyle(GrayStyle, @"^\s*(?<range>\[.+?\])\s*$", RegexOptions.Multiline);
            // class name highlighting
            e.ChangedRange.SetStyle(BoldStyle, @"\b(class|struct|enum)\s+(?<range>\w+?)\b");
            // keyword highlighting
            e.ChangedRange.SetStyle(BlueStyle, @"\b(abstract|as|base|bool|break|byte|case|catch|char|class|const|continue|decimal|default|delegate|do|double|else|enum|explicit|extern|false|finally|fixed|float|for|foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|void|volatile|while|add|alias|ascending|descending|dynamic|from|get|global|group|into|join|let|orderby|partial|remove|select|set|value|var|where|yield)\b|#region\b|#endregion\b|");






            // CE QUE JE TEST @# DEVELOPPEZ.NET


            // clear folding markers
            e.ChangedRange.ClearFoldingMarkers();
            // set folding markers

            e.ToString().ToUpper();
            // allow to collapse region blocks
            e.ChangedRange.SetFoldingMarkers(@"Window\/", @"End\/ Window", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers(@"picturebox\/", @"End\/ picturebox", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers(@"Texteblock\/", @"End\/ Texteblock", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers(@"Button\/", @"End\/ Button", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers(@"Imagebox\/", @"End\/ Imagebox", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers(@"Textbox\/", @"End\/ Textbox", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers(@"Checkbox\/", @"End\/ Checkbox", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers(@"Progressbar\/", @"End\/ Progressbar", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers(@"Function\/", @"End\/ Function", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers(@"Fonction\/", @"Fin\/ Fonction", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers(@"fenetre\/", @"fin\/ fenetre", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers(@"imagebox\/", @"fin\/ imagebox", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers(@"Textebloc\/", @"Fin\/ Textebloc", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers(@"Bouton\/", @"Fin\/ Bouton", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers(@"Textebox\/", @"fin\/ Textebox", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers(@"Checkbox\/", @"fin\/ Checkbox", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers(@"BarreProgression\/", @"fin\/ Barreprogression", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers(@"si\/", @"fin\/ si", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers(@"if\/", @"end\/ if", RegexOptions.IgnoreCase);
        }

        private enum ExplorerItemType
        {
            Class,
            Method,
            Property,
            Event,
            Bouton,
            Imagebox,
            Comment,
            Textbox,
            Textbloc,
            Checkbox,
            Fin,
            Creer,
            Fonction
        }

        // Private Class ExplorerItem
        // Public type As PowerfulCSharpEditor.ExplorerItemType

        // Public title As String

        // Public position As Integer
        // End Class

        // Private Class ExplorerItemComparer
        // Implements IComparer(Of PowerfulCSharpEditor.ExplorerItem)

        // Public Function Compare(x As PowerfulCSharpEditor.ExplorerItem, y As PowerfulCSharpEditor.ExplorerItem) As Integer Implements IComparer(Of PowerfulCSharpEditor.ExplorerItem).Compare
        // Return x.title.CompareTo(y.title)
        // End Function
        // End Class

        private class DeclarationSnippet : SnippetAutocompleteItem
        {
            public DeclarationSnippet(string snippet) : base(snippet)
            {
            }

            public override CompareResult Compare(string fragmentText)
            {
                string pattern = Regex.Escape(fragmentText);
                CompareResult result;
                if (Regex.IsMatch(Text, @"\b" + pattern, RegexOptions.IgnoreCase))
                {
                    result = CompareResult.Visible;
                }
                else
                {
                    result = CompareResult.Hidden;
                }

                return result;
            }
        }

        private class InsertSpaceSnippet : AutocompleteItem
        {
            private string pattern;

            public override string ToolTipTitle
            {
                get
                {
                    return Text;
                }

                set
                {
                }
            }

            public InsertSpaceSnippet(string pattern) : base("")
            {
                this.pattern = pattern;
            }

            public InsertSpaceSnippet() : this(@"^(\d+)([a-zA-Z_]+)(\d*)$")
            {
            }

            public override CompareResult Compare(string fragmentText)
            {
                CompareResult result;
                if (Regex.IsMatch(fragmentText, pattern))
                {
                    Text = InsertSpaces(fragmentText);
                    if ((Text ?? "") != (fragmentText ?? ""))
                    {
                        result = CompareResult.Visible;
                        return result;
                    }
                }

                result = CompareResult.Hidden;
                return result;
            }

            public string InsertSpaces(string fragment)
            {
                var i = Regex.Match(fragment, pattern);
                string result;
                if (i is null)
                {
                    result = fragment;
                }
                else if (string.IsNullOrEmpty(i.Groups[1].Value) && string.IsNullOrEmpty(i.Groups[3].Value))
                {
                    result = fragment;
                }
                else
                {
                    result = string.Concat(new string[] { i.Groups[1].Value, " ", i.Groups[2].Value, " ", i.Groups[3].Value }).Trim();
                }

                return result;
            }
        }

        private class InsertEnterSnippet : AutocompleteItem
        {
            private Place enterPlace = Place.Empty;

            public override string ToolTipTitle
            {
                get
                {
                    return "Insert line break after '}'";
                }

                set
                {
                }
            }

            public InsertEnterSnippet() : base("[Line break]")
            {
            }

            public override CompareResult Compare(string fragmentText)
            {
                var r = Parent.Fragment.Clone();
                CompareResult result;
                while (r.Start.iChar > 0)
                {
                    if (Conversions.ToString(r.CharBeforeStart) == "}")
                    {
                        enterPlace = r.Start;
                        result = CompareResult.Visible;
                        return result;
                    }

                    r.GoLeftThroughFolded();
                }

                result = CompareResult.Hidden;
                return result;
            }

            public override string GetTextForReplace()
            {
                var r = Parent.Fragment;
                var end = r.End;
                r.Start = enterPlace;
                r.End = r.End;
                return Environment.NewLine + r.Text;
            }

            public override void OnSelected(AutocompleteMenu popupMenu, SelectedEventArgs e)
            {
                base.OnSelected(popupMenu, e);
                if (Parent.Fragment.tb.AutoIndent)
                {
                    Parent.Fragment.tb.DoAutoIndent();
                }
            }
        }

        public class BookmarkInfo
        {
            public int iBookmark;
            public FastColoredTextBox tb;
        }

        // Private components As IContainer = Nothing

        private StatusStrip ssMain;

        // Private WithEvents tsFiles3 As FATabStrip


        private SaveFileDialog sfdMain;
        private OpenFileDialog ofdMain;
        private ContextMenuStrip cmMain;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.Timer tmUpdateInterface;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem replaceToolStripMenuItem;
        private DataGridView dgvObjectExplorer;
        private DataGridViewImageColumn clImage;
        private DataGridViewTextBoxColumn clName;
        private ToolStripStatusLabel lbWordUnderMouse;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem autoIndentSelectedTextToolStripMenuItem;
        private ToolStripMenuItem commentSelectedToolStripMenuItem;
        private ToolStripMenuItem uncommentSelectedToolStripMenuItem;
        private ToolStripMenuItem cloneLinesToolStripMenuItem;
        private ToolStripMenuItem cloneLinesAndCommentToolStripMenuItem;
        private string[] keywords = new string[] { "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock", "long", "namespace", "new", "null", "object", "operator", "out", "override", "params", "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual", "void", "volatile", "while", "add", "alias", "ascending", "descending", "dynamic", "from", "get", "global", "group", "into", "join", "let", "orderby", "partial", "remove", "select", "set", "value", "var", "where", "yield", "cpcdoscesttropbien" };
        private string[] methods = new string[] { "Equals()", "GetHashCode()", "GetType()", "ToString()", "Maxime", "GetMaxou()" };
        private string[] snippets = new string[] { "if(^)" + Constants.vbLf + "{" + Constants.vbLf + ";" + Constants.vbLf + "}", "if(^)" + Constants.vbLf + "{" + Constants.vbLf + ";" + Constants.vbLf + "}" + Constants.vbLf + "else" + Constants.vbLf + "{" + Constants.vbLf + ";" + Constants.vbLf + "}", "for(^;;)" + Constants.vbLf + "{" + Constants.vbLf + ";" + Constants.vbLf + "}", "while(^)" + Constants.vbLf + "{" + Constants.vbLf + ";" + Constants.vbLf + "}", "do" + Constants.vbLf + "{" + Constants.vbLf + "^;" + Constants.vbLf + "}while();", "switch(^)" + Constants.vbLf + "{" + Constants.vbLf + "case : break;" + Constants.vbLf + "}" };
        private string[] declarationSnippets = new string[] { "public class ^" + Constants.vbLf + "{" + Constants.vbLf + "}", "private class ^" + Constants.vbLf + "{" + Constants.vbLf + "}", "internal class ^" + Constants.vbLf + "{" + Constants.vbLf + "}", "public struct ^" + Constants.vbLf + "{" + Constants.vbLf + ";" + Constants.vbLf + "}", "private struct ^" + Constants.vbLf + "{" + Constants.vbLf + ";" + Constants.vbLf + "}", "internal struct ^" + Constants.vbLf + "{" + Constants.vbLf + ";" + Constants.vbLf + "}", "public void ^()" + Constants.vbLf + "{" + Constants.vbLf + ";" + Constants.vbLf + "}", "" + Constants.vbLf + "fenetre/^" + Constants.vbLf + "creer/" + Constants.vbLf + "Fin/ fenetre", "internal void ^()" + Constants.vbLf + "{" + Constants.vbLf + ";" + Constants.vbLf + "}", "protected void ^()" + Constants.vbLf + "{" + Constants.vbLf + ";" + Constants.vbLf + "}", "public ^{ get; set; }", "private ^{ get; set; }", "internal ^{ get; set; }", "protected ^{ get; set; }" };

        // Private invisibleCharsStyle As Style = New InvisibleCharsRenderer(Pens.Gray)

        private Color currentLineColor = Color.FromArgb(100, 210, 210, 255);
        private Color changedLineColor = Color.FromArgb(255, 230, 230, 255);

        // Private explorerList As List(Of PowerfulCSharpEditor.ExplorerItem) = New List(Of PowerfulCSharpEditor.ExplorerItem)()

        private bool tbFindChanged = false;
        private DateTime lastNavigatedDateTime = DateTime.Now;

        private void tb_TextChangedDelayed(object sender, TextChangedEventArgs e)
        {
            string text = (sender as FastColoredTextBox).Text;
            ThreadPool.QueueUserWorkItem((o) => ReBuildObjectExplorer(text));
            CPCDOSSyntaxHighlight(e);
            tb.AutoScroll = false;
            tb.Font = new Font("Consolas", 9.75f);
            tb.Dock = DockStyle.Fill;
            tb.LeftBracket = '(';
            tb.RightBracket = ')';
            tb.LeftBracket2 = Conversions.ToChar(@"\x0");
            tb.RightBracket2 = Conversions.ToChar(@"\x0");
            tb.DoCaretVisible();
            tb.IsChanged = false;
            tb.ClearUndo();
            tb.Focus();
            tb.DelayedTextChangedInterval = 1000;
            tb.DelayedEventsInterval = 1000;
        }

        private class ExplorerItem
        {
            public ExplorerItemType type;
            public string title;
            public int position;
        }

        private class ExplorerItemComparer : IComparer<ExplorerItem>
        {
            public int Compare(ExplorerItem x, ExplorerItem y)
            {
                return x.title.CompareTo(y.title);
            }
        }

        private void ReBuildObjectExplorer(string text)
        {
            try
            {
                // LISTE GENERALE//////////////////////////////////////////////////////////////////////////////////////////////////////
                var list = new List<ExplorerItem>();
                int lastClassIndex = -1;
                var regex = new Regex(@"^(?<range>[\w\s]+\b(struct|enum|interface)\s+[\w<>,\s]+)|^\s*(public|private|internal|protected|window\/|Texteblock\/|Button\/|Fix/|Checkbox\/|picturebox\/|Imagebox\/|Textbox\/|Checkbox\/|Textblock\/|rem\/|Rem\/|fonction\/|function\/|si\/|if\/)[^\n]+(\n?\s*{|;)?", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                foreach (Match r in regex.Matches(text))
                {
                    try
                    {
                        string s = r.Value;
                        int i = s.IndexOfAny(new char[] { '=', '{', ';' });
                        if (i >= 0)
                        {
                            s = s.Substring(0, i);
                        }
                        // FENETRE/////////////////////////////////////////////////////////////////
                        s = s.Trim();
                        var item = new ExplorerItem() { title = s, position = r.Index };
                        if (Regex.IsMatch(item.title, @"\b(class|fenetre|enum|interface)\b"))
                        {
                            item.title = item.title.Substring(item.title.LastIndexOf(" ")).Trim();
                            item.type = ExplorerItemType.Class;
                            list.Sort(lastClassIndex + 1, list.Count - (lastClassIndex + 1), new ExplorerItemComparer());
                            lastClassIndex = list.Count;
                        }
                        // VARIABLE////////////////////////////////////////////////////////////
                        // SYNTAXE FRANCAISE
                        else if (item.title.ToLower().Contains("fix")) // si contient
                        {
                            int ii = item.title.LastIndexOf(" ");
                            item.title = item.title.Substring(ii).Trim();
                            item.type = ExplorerItemType.Event; // image
                        }
                        // CHECKBOX/////////////////////////////////////////////////////
                        // SYNTAXE FRANCAISE
                        else if (item.title.ToLower().Contains("checkbox")) // si contient
                        {
                            int ii = item.title.LastIndexOf(" ");
                            item.title = item.title.Substring(ii).Trim();
                            item.type = ExplorerItemType.Checkbox; // image
                        }
                        // BOUTON///////////////////////////////////////////////////
                        // SYNTAXE FRANCAISE
                        else if (item.title.ToLower().Contains("bouton")) // si contient
                        {
                            int ii = item.title.LastIndexOf(" ");
                            item.title = item.title.Substring(ii).Trim();
                            item.type = ExplorerItemType.Bouton; // TYPE
                        }
                        else if (item.title.ToLower().Contains("button")) // si contient
                        {
                            int ii = item.title.LastIndexOf(" ");
                            item.title = item.title.Substring(ii).Trim();
                            item.type = ExplorerItemType.Bouton; // TYPE
                        }
                        // TEXTEBOX/////////////////////////////////////////////
                        // SYNTAXE FRANCAISE

                        else if (item.title.ToLower().Contains("textebox")) // si contient
                        {
                            int ii = item.title.LastIndexOf(" ");
                            item.title = item.title.Substring(ii).Trim();
                            item.type = ExplorerItemType.Textbox; // TYPE
                        }
                        else if (item.title.ToLower().Contains("textbox")) // SYNTAXE ANGLAISE
                                                                           // si contient
                        {
                            int ii = item.title.LastIndexOf(" ");
                            item.title = item.title.Substring(ii).Trim();
                            item.type = ExplorerItemType.Textbox; // TYPE
                        }

                        // TEXTEBLOC//////////////////////////////////////////
                        // SYNTAXE FRANCAISE
                        else if (item.title.ToLower().Contains("textebloc")) // si contient
                        {
                            int ii = item.title.LastIndexOf(" ");
                            item.title = item.title.Substring(ii).Trim();
                            item.type = ExplorerItemType.Textbloc; // TYPE
                        }
                        else if (item.title.ToLower().Contains("textblock")) // si contient
                        {
                            int ii = item.title.LastIndexOf(" ");
                            item.title = item.title.Substring(ii).Trim();
                            item.type = ExplorerItemType.Textbloc; // TYPE
                        }

                        // IMAGEBOX//////////////////////////////////
                        // SYNTAXE FRANCAISE

                        else if (item.title.ToLower().Contains("imagebox")) // si contient
                        {
                            int ii = item.title.LastIndexOf(" ");
                            item.title = item.title.Substring(ii).Trim();
                            item.type = ExplorerItemType.Imagebox; // TYPE
                        }
                        else if (item.title.ToLower().Contains("picturebox")) // SYNTAXE ANGLAISE
                                                                              // si contient
                        {
                            int ii = item.title.LastIndexOf(" ");
                            item.title = item.title.Substring(ii).Trim();
                            item.type = ExplorerItemType.Imagebox; // TYPE
                        }


                        // COMMENTAIRE///////////////////////////////////////////////////
                        else if (item.title.ToLower().Contains("rem")) // si contient
                        {
                            int ii = item.title.LastIndexOf(" ");
                            item.title = item.title.Substring(ii).Trim();
                            item.type = ExplorerItemType.Comment; // TYPE
                        }
                        // Fonction///////////////////////////////////////////////////
                        else if (item.title.ToLower().Contains("fonction")) // si contient
                        {
                            int ii = item.title.LastIndexOf(" ");
                            item.title = item.title.Substring(ii).Trim();
                            item.type = ExplorerItemType.Fonction; // TYPE
                        }
                        // COMMENTAIRE///////////////////////////////////////////////////
                        else if (item.title.ToLower().Contains("function")) // si contient
                        {
                            int ii = item.title.LastIndexOf(" ");
                            item.title = item.title.Substring(ii).Trim();
                            item.type = ExplorerItemType.Fonction; // TYPE
                        }
                        else
                        {
                        }

                        list.Add(item);
                    }
                    catch (Exception ex_2BF)
                    {
                        Console.WriteLine(ex_2BF);
                    }
                }

                list.Sort(lastClassIndex + 1, list.Count - (lastClassIndex + 1), new ExplorerItemComparer());
                BeginInvoke(new Action(() =>
                {
                    explorerList = list;
                    dgvObjectExplorer2.RowCount = explorerList.Count;
                    dgvObjectExplorer2.Invalidate();
                }));
            }
            catch (Exception ex_332)
            {
                Console.WriteLine(ex_332);
            }
        }

        private void ButtonItem9_Click(object sender, EventArgs e)
        {
        }

        private void dgvObjectExplorer2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (tb is object)
            {
                var item = explorerList[e.RowIndex];
                tb.GoEnd();
                tb.SelectionStart = item.position;
                tb.DoSelectionVisible();
                tb.Focus();
            }
        }

        private void dgvObjectExplorer2_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            try
            {
                var item = explorerList[e.RowIndex];
                if (e.ColumnIndex == 1)
                {
                    e.Value = item.title;
                }
                else
                {
                    switch (item.type)
                    {
                        case ExplorerItemType.Class:
                            {
                                e.Value = My.Resources.Resources.class_libraries;
                                break;
                            }

                        case ExplorerItemType.Method:
                            {
                                e.Value = My.Resources.Resources.box;
                                break;
                            }

                        case ExplorerItemType.Property:
                            {
                                e.Value = My.Resources.Resources.Bouton;
                                break;
                            }

                        case ExplorerItemType.Event:
                            {
                                e.Value = My.Resources.Resources.light16;
                                break;
                            }

                        case ExplorerItemType.Bouton:
                            {
                                e.Value = My.Resources.Resources.Bouton;
                                break;
                            }

                        case ExplorerItemType.Checkbox:
                            {
                                e.Value = My.Resources.Resources.checkbox;
                                break;
                            }

                        case ExplorerItemType.Comment:
                            {
                                e.Value = My.Resources.Resources.Comment;
                                break;
                            }

                        case ExplorerItemType.Creer:
                            {
                                e.Value = My.Resources.Resources.creer;
                                break;
                            }

                        case ExplorerItemType.Fin:
                            {
                                e.Value = My.Resources.Resources.fin;
                                break;
                            }

                        case ExplorerItemType.Textbox:
                            {
                                e.Value = My.Resources.Resources.textebox;
                                break;
                            }

                        case ExplorerItemType.Textbloc:
                            {
                                e.Value = My.Resources.Resources.textebloc;
                                break;
                            }

                        case ExplorerItemType.Imagebox:
                            {
                                e.Value = My.Resources.Resources.imagebox;
                                break;
                            }

                        case ExplorerItemType.Fonction:
                            {
                                e.Value = My.Resources.Resources.diamond16;
                                break;
                            }
                    }
                }
            }
            catch (Exception ex_8D)
            {
            }
        }

        private void OSMCodeBox_Load(object sender, EventArgs e)
        {
            string text = tb.Text;
            ThreadPool.QueueUserWorkItem((o) => ReBuildObjectExplorer(text));
        }

        private void tb_Load(object sender, EventArgs e)
        {
        }
    }
}