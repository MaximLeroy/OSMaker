using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

//using FarsiLibrary.Win;
using FastColoredTextBoxNS;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Windows.Media;

namespace OSMaker.Panneaux
{
    [System.ComponentModel.TypeConverter(typeof(System.Windows.Media.FontFamilyConverter))]
    [System.Windows.Localizability(System.Windows.LocalizationCategory.Font)]
    public partial class Doc : DocumentC
    {
        private View m_view;
        public Doc()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Dpi;
            DockAreas = DockAreas.Document | DockAreas.Float;
            BlueStyle = new TextStyle(SolidBlue, null, FontStyle.Regular);
            OrangeStyle = new TextStyle(SolidBlueLight, null, FontStyle.Regular);
            VertLightStyle = new TextStyle(SolidVert, null, FontStyle.Regular);
            MagentaStyle = new TextStyle(SolidNumber, null, FontStyle.Regular);
            YellowStyle = new TextStyle(SolidJaune, null, FontStyle.Regular);
            GreenStyle = new TextStyle(SolidGreen, null, FontStyle.Regular);
            RoseStyle = new TextStyle(SolidRose, null, FontStyle.Regular);
            EqualStyle = new TextStyle(SolidEqual, null, FontStyle.Regular);
           
        }

        public string filepath = "";
        private List<ExplorerItem> explorerList = new List<ExplorerItem>();

        // 'SolidBrush
        private SolidBrush SolidGreen = new SolidBrush(System.Drawing.Color.FromArgb(87, 166, 74));
        private SolidBrush SolidBlue = new SolidBrush(System.Drawing.Color.FromArgb(86, 156, 214));
        private SolidBrush SolidBlueLight = new SolidBrush(System.Drawing.Color.FromArgb(156, 220, 254));
        private SolidBrush SolidEqual = new SolidBrush(System.Drawing.Color.FromArgb(180, 180, 180));
        private SolidBrush SolidRose = new SolidBrush(System.Drawing.Color.FromArgb(216, 160, 223));
        private SolidBrush SolidVert = new SolidBrush(System.Drawing.Color.FromArgb(78, 201, 176));
        private SolidBrush SolidVertFonce = new SolidBrush(System.Drawing.Color.FromArgb(55, 146, 124));
        private SolidBrush SolidJaune = new SolidBrush(System.Drawing.Color.FromArgb(220, 220, 170));
        private SolidBrush SolidNumber = new SolidBrush(System.Drawing.Color.FromArgb(181, 206, 168));
        // 'Brushes
        private TextStyle SpringGreenStyle = new TextStyle(System.Drawing.Brushes.SpringGreen, null, FontStyle.Regular);
        private TextStyle BlueStyle;
        private TextStyle OrangeStyle;
        private TextStyle RedStyle = new TextStyle(System.Drawing.Brushes.LightCoral, null, FontStyle.Regular);
        private TextStyle VertLightStyle;
        private TextStyle BoldStyle = new TextStyle(null, null, FontStyle.Bold | FontStyle.Underline);
        private TextStyle Gras = new TextStyle(null, null, FontStyle.Bold);
        private TextStyle GrayStyle = new TextStyle(System.Drawing.Brushes.Gray, null, FontStyle.Regular);
        private TextStyle MagentaStyle;
        private TextStyle YellowStyle;
        private TextStyle GreenStyle;
        private TextStyle BrownStyle = new TextStyle(System.Drawing.Brushes.Brown, null, FontStyle.Italic);
        private TextStyle MaroonStyle = new TextStyle(System.Drawing.Brushes.Maroon, null, FontStyle.Regular);
        private TextStyle RoseStyle;
        private TextStyle EqualStyle;
        private MarkerStyle SameWordsStyle = new MarkerStyle(new SolidBrush(System.Drawing.Color.FromArgb(40, System.Drawing.Color.Gray)));

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
            e.ChangedRange.SetStyle(RoseStyle, @"(TYPE:|UPD:|COL:|CTN:|BORD:|OMBRE:|IMGAUTO:|EDIT:|MULTILINES:|SHADOW:|MOVE:|SIZ:|SIZEBTN:|REDUCT:|CLOSE:|TASKBAR:|\,|fonction\/|function\/|End\/ Function|Fin\/ Fonction|Si\/|If\/|Fin\/ si|End\/ If|alors\:|Txt\/|Fin\/ Fonction|then:|sinon:|else:)", RegexOptions.IgnoreCase);
            e.ChangedRange.SetStyle(EqualStyle, @"\=");
            e.ChangedRange.SetStyle(OrangeStyle, @"(\.Parametres|\.titlecolor|\.PX|\.PY|\.SX|\.SY|\.Value|\.BackColor|\.CouleurText|\.Icone|\.ImgTitre|\.Opacite|\.titre|\.CouleurFenetre|\.CouleurTitre|\.px|\.py|\.tx|\.ty|\.opacite|\.Image|\.evenement|\.texte|\.Handle|\.pid|\.nom|\.name|\.parameters|\.opacity|\.image|\.evenement|\.couleurfenetre|\.windowcolor|\.couleurtitre|\.couleurtexte|\.textcolor|\.handle|\.icone|\.icon|\.imgtitre|\.titleimg|\.TitleImg|fenetre\/|fin\/ fenetre|\.event|\.couleurfond|\.title|\.Text)", RegexOptions.IgnoreCase);
            e.ChangedRange.SetStyle(BlueStyle, @"(End\/ window|window\/|End\/ button|button\/|End\/ textbox|textbox\/|End\/ textblock|textblock\/|End\/ progressbar|progressbar\/|End\/ picturebox|picturebox\/|End\/ checkbox|checkbox\/|sys\/|\/processus|exe\/|\/pid\:|ccp\/|\/SET.LEVEL)", RegexOptions.IgnoreCase);
            e.ChangedRange.SetStyle(BlueStyle, @"(debut_section_critique|begin_critical_section|fin_section_critique|end_critical_section|\/INIT|\/menu|\/touche|\/key|\/INIT|\/atouche|\/wkey|\/pause|\/tcp|\/udp|\/attendre|\/wait|\/recevoir|\/receive|\/envoyer|\/send|\/mode|\/stop|\/temp|\/tempr|\/debug|\/cpinticore|\/thread|\/thread[MIN]|\/thread[STD]|\/thread[MAX]|\/optimisation|\/optimization|\/lang|\/change|\/pause|\/bin|\/app|\/mem|\/lang|\/ecran|\/screen|\/ccp)", RegexOptions.IgnoreCase);
            e.ChangedRange.SetStyle(YellowStyle, "@#.*$", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(RoseStyle, @"fix\/|declare\/|declarer\/|set\/|txt\/|goto\/|aller\/|Client\/|serveur\/|server\/|pos\/|stop\/|cls\/|aide\/|help\/|ouvrir\/|open\/|ecrire\/|write\/|return\/|ping\/|telecharger\/|download\/|iug\/|demarrer\/|start\/|close\/|fermer\/|creer\/|create\/|set\/", RegexOptions.IgnoreCase);
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
            e.ChangedRange.SetFoldingMarkers(@"ProgressBar\/", @"End\/ ProgressBar", RegexOptions.IgnoreCase);
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
            ProgressBar,
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

        private System.Drawing.Color currentLineColor = System.Drawing.Color.FromArgb(100, 210, 210, 255);
        private System.Drawing.Color changedLineColor = System.Drawing.Color.FromArgb(255, 230, 230, 255);

        // Private explorerList As List(Of PowerfulCSharpEditor.ExplorerItem) = New List(Of PowerfulCSharpEditor.ExplorerItem)()

        private bool tbFindChanged = false;
        private DateTime lastNavigatedDateTime = DateTime.Now;
        private string m_fileName = string.Empty;
        public string m_filetext = string.Empty;
        public string FileName
        {
            get { return m_fileName; }
            set
            {
                if (value != string.Empty)
                {
                    Stream s = new FileStream(value, FileMode.Open);

                    FileInfo efInfo = new FileInfo(value);

                    string fext = efInfo.Extension.ToUpper();
                   
                    if (fext.Equals(".cpc"))
                       richTextBox1.LoadFile(s, RichTextBoxStreamType.RichText);
                    
                    else
                        richTextBox1.LoadFile(s, RichTextBoxStreamType.PlainText);
                    s.Close();
                }
                string text = richTextBox1.Text;
                _tb.Text = text;
                m_fileName = value;
                this.ToolTipText = value;
            }
        }

        // workaround of RichTextbox control's bug:
        // If load file before the control showed, all the text format will be lost
        // re-load the file after it get showed.
        private bool m_resetText = true;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (m_resetText)
            {
                m_resetText = false;
                FileName = FileName;
            }
        }

        protected override string GetPersistString()
        {
            // Add extra information into the persist string for this document
            // so that it is available when deserialized.
            return GetType().ToString() + "," + FileName + "," + Text;
        }

     

      
        
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
           // if (FileName == string.Empty)
               // this.richTextBox1.Text = DocumentC.d;
        }
     
        private void Doc_Load(object sender, EventArgs e)
        {
         //  System.Windows.Media.TextFormatting.Pr pfc = new PrivateFontCollection();
         //   pfc.AddFontFile("C:\\Path To\\PALETX3.ttf");
         //   label1.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);


            metroTextBox1.Text = filepath ;
                    
                

                _tb.Focus();
            
                string text = _tb.Text;
                ThreadPool.QueueUserWorkItem((o) => ReBuildObjectExplorer(text));
            
           
        }

        private void menuItem2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This is to demostrate menu item has been successfully merged into the main form. Form Text=" + Text);
        }

        private void _tb_TextChanged(object sender, TextChangedEventArgs e)
        {
          
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
                var regex = new Regex(@"^(?<range>[\w\s]+\b(struct|enum|interface)\s+[\w<>,\s]+)|^\s*(public|private|internal|protected|window\/|Texteblock\/|Button\/|Fix/|Checkbox\/|picturebox\/|Imagebox\/|ProgressBar\/|Textbox\/|Checkbox\/|Textblock\/|rem\/|Rem\/|fonction\/|function\/|si\/|if\/|set/)[^\n]+(\n?\s*{|;)?", RegexOptions.Multiline | RegexOptions.IgnoreCase);
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
                        else if (item.title.ToLower().Contains("set")) // si contient
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

                        else if (item.title.ToLower().Contains("progressbar")) // SYNTAXE ANGLAISE
                                                                           // si contient
                        {
                            int ii = item.title.LastIndexOf(" ");
                            item.title = item.title.Substring(ii).Trim();
                            item.type = ExplorerItemType.ProgressBar; // TYPE
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
                   dataGridView1.RowCount = explorerList.Count;
                    dataGridView1.Invalidate();
                }));
            }
            catch (Exception ex_332)
            {
                Console.WriteLine(ex_332);
            }
        }

        private void _tb_TextChangedDelayed(object sender, TextChangedEventArgs e)
        {
            string text = (sender as FastColoredTextBox).Text;
            ThreadPool.QueueUserWorkItem((o) => ReBuildObjectExplorer(text));
            CPCDOSSyntaxHighlight(e);
         //   _tb.AutoScroll = true;
            _tb.ShowScrollBars = true;
            _tb.Font = new Font("Source Code Pro", 9.75f);
            _tb.Dock = DockStyle.Fill;
            _tb.LeftBracket = '(';
            _tb.RightBracket = ')';
            _tb.LeftBracket2 = Conversions.ToChar(@"\x0");
            _tb.RightBracket2 = Conversions.ToChar(@"\x0");
            _tb.DoCaretVisible();
            _tb.IsChanged = true;
           // _tb.ClearUndo();
            _tb.Focus();
            _tb.DelayedTextChangedInterval = 1000;
            _tb.DelayedEventsInterval = 1000;
        }

        private void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
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
                                e.Value = My.Resources.Resources.Class_16x;
                                break;
                            }

                        case ExplorerItemType.Method:
                            {
                                e.Value = My.Resources.Resources.Method_16x;
                                break;
                            }

                        case ExplorerItemType.Property:
                            {
                                e.Value = My.Resources.Resources.Property_16x;
                                break;
                            }

                        case ExplorerItemType.Event:
                            {
                                e.Value = My.Resources.Resources.Event_16x;
                                break;
                            }

                        case ExplorerItemType.Bouton:
                            {
                                e.Value = My.Resources.Resources.Button_16xBlack;
                                break;
                            }

                        case ExplorerItemType.Checkbox:
                            {
                                e.Value = My.Resources.Resources.CheckBoxChecked_16xBlack;
                                break;
                            }

                        case ExplorerItemType.Comment:
                            {
                                e.Value = My.Resources.Resources.CommentCode_16x;
                                break;
                            }

                        case ExplorerItemType.Creer:
                            {
                                e.Value = My.Resources.Resources.Create_16x;
                                break;
                            }

                        case ExplorerItemType.Fin:
                            {
                                e.Value = My.Resources.Resources.EndPoint_16x;
                                break;
                            }

                        case ExplorerItemType.Textbox:
                            {
                                e.Value = My.Resources.Resources.TextBox_16xBlack;
                                break;
                            }

                        case ExplorerItemType.Textbloc:
                            {
                                e.Value = My.Resources.Resources.TextBlock_16xBlack;
                                break;
                            }

                        case ExplorerItemType.Imagebox:
                            {
                                e.Value = My.Resources.Resources.Image_16xBlack;
                                break;
                            }

                        case ExplorerItemType.Fonction:
                            {
                                e.Value = My.Resources.Resources.fonction16;
                                break;
                            }
                        case ExplorerItemType.ProgressBar:
                            {
                                e.Value = My.Resources.Resources.ProgressBar_16xBlack;
                                break;
                            }
                    }
                }
            }
            catch (Exception ex_8D)
            {
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_tb is object)
            {
                var item = explorerList[e.RowIndex];
                _tb.GoEnd();
                _tb.SelectionStart = item.position;
                _tb.DoSelectionVisible();
                _tb.Focus();
            }
        }

        private void Undo()
        {
            if (_tb.UndoEnabled)
                _tb.Undo();
        }
        private void Redo()
        {
            if (_tb.RedoEnabled)
                _tb.Redo();
        }
        private void SelectAll()
        {
            _tb.Selection.SelectAll();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            _tb.Copy();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            _tb.Paste();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            _tb.Cut();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            
        }

        private void tmUpdateInterface2_Tick(object sender, EventArgs e)
        {
            try
            {
               
                    annulerToolStripMenuItem1.Enabled = undoButton.Enabled = _tb.UndoEnabled;
                    rétablirToolStripMenuItem1.Enabled = redoButton.Enabled = _tb.RedoEnabled;
                    saveButton.Enabled = _tb.IsChanged;
                  
                    pasteButton.Enabled = collerCtrlVToolStripMenuItem.Enabled = true;
                    cutButton.Enabled = couperToolStripMenuItem.Enabled =
                    copyButton.Enabled = copierCtrlCToolStripMenuItem.Enabled = !_tb.Selection.IsEmpty;

                if (_tb.UndoEnabled == true) 
                {
                    undoButton.BackgroundImage = My.Resources.Resources.Undo_16x;
                }
                else
                {
                    undoButton.BackgroundImage = My.Resources.Resources.Undo_grey_16x;
                }
                if (_tb.RedoEnabled == true)
                {
                    redoButton.BackgroundImage = My.Resources.Resources.Redo_16x;
                }
                else
                {
                    redoButton.BackgroundImage = My.Resources.Resources.Redo_grey_16x;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            _tb.ShowFindDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            _tb.ShowReplaceDialog();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            _tb.ShowFindDialog();
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            _tb.ShowReplaceDialog();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(metroTextBox1.Text, _tb.Text);
                _tb.IsChanged = false;
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    File.WriteAllText(metroTextBox1.Text, _tb.Text);
                  
                else
                {

                }
            }

        }

        private void sélectionnerToutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void commentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _tb.InsertLinePrefix("//");
        }

        private void rétablirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void annulerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _tb.Cut();
        }

        private void copierCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _tb.Copy();
        }

        private void collerCtrlVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _tb.Paste();
        }

        private void cloneButton_Click(object sender, EventArgs e)
        {
            //expand selection
            _tb.Selection.Expand();
            //get text of selected lines
            string text = Environment.NewLine + _tb.Selection.Text;
            //move caret to end of selected lines
            _tb.Selection.Start = _tb.Selection.End;
            //insert text
            _tb.InsertText(text);
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            _tb.InsertLinePrefix("//");
        }

        private void uncommentButton_Click(object sender, EventArgs e)
        {
            _tb.RemoveLinePrefix("//");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            _tb.RemoveLinePrefix("//");
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            //expand selection
            _tb.Selection.Expand();
            //get text of selected lines
            string text = Environment.NewLine + _tb.Selection.Text;
            //move caret to end of selected lines
            _tb.Selection.Start = _tb.Selection.End;
            //insert text
            _tb.InsertText(text);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            //start autoUndo block
            _tb.BeginAutoUndo();
            //expand selection
            _tb.Selection.Expand();
            //get text of selected lines
            string text = Environment.NewLine + _tb.Selection.Text;
            //comment lines
            _tb.InsertLinePrefix("//");
            //move caret to end of selected lines
            _tb.Selection.Start = _tb.Selection.End;
            //insert text
            _tb.InsertText(text);
            //end of autoUndo block
            _tb.EndAutoUndo();
        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            filepath = metroTextBox1.Text;
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == false)
            {
                panel4.Visible = true;
            }
            else
                panel4.Visible = false;
        }

        private void metroButton17_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == false)
            {
                panel3.Visible = true;
            }
            else
                panel3.Visible = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DocumentMap1.Visible = true;
            dataGridView1.Visible = false;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DocumentMap1.Visible = false;
            dataGridView1.Visible = true;
        }

        private void _tb_TextChanging(object sender, TextChangingEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
