using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
//using FarsiLibrary.Win;
using FastColoredTextBoxNS;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace OSMaker
{
    public partial class EditeurCCplus
    {
        public EditeurCCplus()
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
            CustomInitialize();
            _tb.Name = "tb";
            _PictureBox4.Name = "PictureBox4";
            _PictureBox2.Name = "PictureBox2";
            _ButtonX2.Name = "ButtonX2";
            _ButtonX1.Name = "ButtonX1";
            _ButtonItem11.Name = "ButtonItem11";
            _ButtonItem1.Name = "ButtonItem1";
            _Aligner.Name = "Aligner";
            _Copy.Name = "Copy";
            _ButtonItem6.Name = "ButtonItem6";
            _Panel1.Name = "Panel1";
        }

        private Host.HostSurfaceManager _hostSurfaceManager;
        private int _formCount = 0;
        private Host.HostControl HostC;
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
            e.ChangedRange.SetStyle(RoseStyle, @"(TYPE:|CTN:|BORD:|OMBRE:|IMGAUTO:|EDIT:|MULTILINE:|\,)");
            e.ChangedRange.SetStyle(EqualStyle, @"\=");
            e.ChangedRange.SetStyle(BlueStyle, @"(Create\/|create\/|End\/ window|window\/|End\/ button|button\/|End\/ textbox|textbox\/|End\/ textblock|textblock\/|End\/ progressbar|progressbar\/|End\/ picturebox|picturebox\/|End\/ checkbox|checkbox\/)", RegexOptions.IgnoreCase);
            e.ChangedRange.SetStyle(YellowStyle, "@#.*$", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(YellowStyle, "/.*$", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(RedStyle, "\".*?\"|'.+?'");


            // attribute highlighting
            e.ChangedRange.SetStyle(GrayStyle, @"^\s*(?<range>\[.+?\])\s*$", RegexOptions.Multiline);
            // class name highlighting
            e.ChangedRange.SetStyle(BoldStyle, @"\b(class|struct|enum)\s+(?<range>\w+?)\b");
            // keyword highlighting
            e.ChangedRange.SetStyle(BlueStyle, @"\b(abstract|as|base|bool|break|byte|case|catch|char|class|const|continue|decimal|default|delegate|do|double|else|enum|explicit|extern|false|finally|fixed|float|for|foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|void|volatile|while|add|alias|ascending|descending|dynamic|from|get|global|group|into|join|let|orderby|partial|remove|select|set|value|var|where|yield)\b|#region\b|#endregion\b|");
            e.ChangedRange.SetStyle(OrangeStyle, @"(\.Parametres|\.PX|\.PY|\.SX|\.SY|\.Valeur|\.BackColor|\.CouleurText|\.Event|\.event|\.Icone|\.ImgTitre|\.Opacite|\.titre|\.CouleurFenetre|\.CouleurTitre|\.px|\.py|\.tx|\.ty|\.opacite|\.Text|\.Image|\.evenement|\.texte|\.Handle|\.handle)", RegexOptions.IgnoreCase);
            e.ChangedRange.SetStyle(Gras, @"fenetre\/", RegexOptions.IgnoreCase);
            e.ChangedRange.SetStyle(Gras, @"Fin\/ fenetre", RegexOptions.IgnoreCase);



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
        }

        private class Strings
        {
            public const string Design = "Design";
            public const string Code = "Code";
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
            Creer
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
        [CLSCompliant(false)]
        public Host.Designer Designer = new Host.Designer(My.MySettingsProperty.Settings.Afficher_La_Griller, true, My.MySettingsProperty.Settings.Aimentation_Intelligente, true, My.MySettingsProperty.Settings.Smart_Tags, true, My.MySettingsProperty.Settings.Afficher_La_Griller);
        public System.ComponentModel.Design.IComponentChangeService componentChangeService;

        private void EditeurCCplus_Load(object sender, EventArgs e)
        {
            try
            {
                _formCount += 1;
                HostC = _hostSurfaceManager.GetNewHost(typeof(Form), Host.LoaderType.BasicDesignerLoader);
                // AddTabForNewHost("Form" & _formCount.ToString() & " - " & Strings.Design)
                HostC.Parent = Panel1;
                HostC.Dock = DockStyle.Fill;
            }
            catch
            {
                MessageBox.Show("Error in creating new host", "Shell Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [CLSCompliant(false)]
        public OSMaker.UndoEngineImpl undoEngine;

        private void CustomInitialize()
        {
            _hostSurfaceManager = new Host.HostSurfaceManager();
            _hostSurfaceManager.AddService(typeof(IToolboxService), My.MyProject.Forms.Form2.Toolbox);
            _hostSurfaceManager.AddService(typeof(DevComponents.DotNetBar.AdvPropertyGrid), My.MyProject.Forms.Form2.AdvPropertyGrid1);
        }

        private void AddTabForNewHost(string tabText)
        {
            System.ComponentModel.Design.IServiceContainer serviceContainer;
            My.MyProject.Forms.Form2.Toolbox.DesignerHost = HostC.DesignerHost;
            // Dim tabpage As TabPage = New TabPage(tabText)
            // TabPage.Tag = CurrentMenuSelectionLoaderType
            HostC.Parent = Panel1;
            HostC.Dock = DockStyle.Fill;


            // tabControl1.TabPages.Add(tabpage)
            // tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1
            _hostSurfaceManager.ActiveDesignSurface = HostC.HostSurface;
            serviceContainer = (System.ComponentModel.Design.IServiceContainer)_hostSurfaceManager.GetService(typeof(System.ComponentModel.Design.ServiceContainer));
            MenuCommandService = new Host.MenuCommandServiceImpl(serviceContainer);
            HostC.DesignerHost.AddService(typeof(System.ComponentModel.Design.MenuCommandService), MenuCommandService);

            // Ajout du service Annuler/Retablir
            undoEngine = new OSMaker.UndoEngineImpl(serviceContainer);
            undoEngine.Enabled = false;
            _hostSurfaceManager.AddService(typeof(System.ComponentModel.Design.UndoEngine), undoEngine);
        }

        public void Coller()
        {
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            if (My.MyProject.Computer.Clipboard.GetDataObject().GetDataPresent("CF_DESIGNERCOMPONENTS_V2", true)) // On vérifie que des contrôles soient dans le Presse-papiers
            {
                var a = System.ComponentModel.Design.StandardCommands.Paste;
                ims.GlobalInvoke(a);
                MenuCommandService.GlobalInvoke(a);
            }
        }

        public void Copier()
        {
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.Copy;
            ims.GlobalInvoke(a);
            MenuCommandService.GlobalInvoke(a);

            // Clipboard.SetDataObject(Me.File, True)
            // If Clipboard.GetDataObject().GetDataPresent("VelerSoftware.SZVB.Projet.SZW_File", True) Then
            // MsgBox(DirectCast(Clipboard.GetDataObject.GetData("VelerSoftware.SZVB.Projet.SZW_File", True), VelerSoftware.SZVB.Projet.SZW_File).Nom)
            // End If



        }

        private void ButtonItem1_Click(object sender, EventArgs e)
        {
            FastColoredTextBox1.Text = ((Loader.BasicHostLoader)HostC.HostSurface.Loader).GetCode();
        }

        private void ButtonItem11_Click(object sender, EventArgs e)
        {
            var currentHostControl = HostC;
            string stringXML = ((Loader.BasicHostLoader)currentHostControl.HostSurface.Loader).GetCode();
            WinToCpc.ModuleCpc.GenTextCpc(stringXML);
            //GenTextCpc(stringXML);
            string code = ((Loader.BasicHostLoader)currentHostControl.HostSurface.Loader).GetCode();
            FastColoredTextBox1.Text = code;
            string fileName = TextBoxX2.Text;
            if (string.IsNullOrEmpty(TextBoxX2.Text))
            {
                var dlgSaveFile = new SaveFileDialog();
                dlgSaveFile.Filter = "Fichier XML (.*xml)|*.xml";
                if (dlgSaveFile.ShowDialog() == DialogResult.OK)
                {
                    fileName = dlgSaveFile.FileName;
                    TextBoxX2.Text = fileName;
                    if (fileName.Length != 0)
                    {
                    }
                }
            }
            else
            {
                fileName = TextBoxX2.Text;
            }

            if (string.IsNullOrEmpty(TextBoxX2.Text))
            {
                MessageBox.Show("Pas de chemin de fichier XML renseigné, enregistrement impossible !");
            }
            else
            {
                File.WriteAllText(TextBoxX2.Text, code);
            }
        }

        private XmlDocument doc;
        private Dictionary<string, string> WinToCpcControls;
        private Dictionary<string, string> CpcDebutToFins;
        private StringBuilder sb;
        public System.ComponentModel.Design.IMenuCommandService MenuCommandService;
        public System.ComponentModel.Design.ISelectionService SelectionService;

        private void PerformAction(string text)
        {
            if (HostC is null)
                return;
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            try
            {
                switch (text ?? "")
                {
                    case "&Cut":
                        {
                            ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.Cut);
                            break;
                        }

                    case "C&opy":
                        {
                            ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.Copy);
                            break;
                        }

                    case "&Paste":
                        {
                            ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.Paste);
                            break;
                        }

                    case "&Undo":
                        {
                            ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.Undo);
                            break;
                        }

                    case "&Redo":
                        {
                            ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.Redo);
                            break;
                        }

                    case "&Delete":
                        {
                            ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.Delete);
                            break;
                        }

                    case "&Select All":
                        {
                            ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.SelectAll);
                            break;
                        }

                    case "&Lefts":
                        {
                            ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.AlignLeft);
                            break;
                        }

                    case "&Centers":
                        {
                            ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.AlignHorizontalCenters);
                            break;
                        }

                    case "&Rights":
                        {
                            ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.AlignRight);
                            break;
                        }

                    case "&Tops":
                        {
                            ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.AlignTop);
                            break;
                        }

                    case "&Middles":
                        {
                            ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.AlignVerticalCenters);
                            break;
                        }

                    case "&Bottoms":
                        {
                            ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.AlignBottom);
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }
            }
            catch
            {
                MessageBox.Show("Error in performing the action: " + text.Replace("&", ""));
            }
        }

        private void ActionClick(object sender, EventArgs e)
        {
            PerformAction((sender as DevComponents.DotNetBar.ButtonItem).Text);
        }

        // Private inputFile As String = "C:\Users\OUNIS\Desktop\WinSerializePanel\WinTweakDedignerHost" + "\Exemple.xml"
        // Private outputFile As String = "C:\Users\OUNIS\Desktop\WinSerializePanel\WinTweakDedignerHost" + "\Exemple.txt"
        
        public void GenTextCpc(string stringXML)
        {
            LoadWinToCpcControls();
            sb = new StringBuilder();
            doc = new XmlDocument();

            // le code qui suit remets en place le noeud xml "RACINE" xml 
            // comme  deja car la prop GetCode dans BasicHostLoader la supprime
            string cleandown = stringXML;
            cleandown = "<DOCUMENT_ELEMENT>" + stringXML + "</DOCUMENT_ELEMENT>";
            doc.LoadXml(cleandown);
            XmlNode root = doc.DocumentElement;
            foreach (XmlNode node in root.ChildNodes)
                WriteNodeObject(node, sb);
            string cpcFileName = GetFileNameToSave(); // obtient le nom de fichier CPC à sauvegarder
            if (cpcFileName is object)
            {
                File.WriteAllText(cpcFileName, sb.ToString());
            }
        }

        private XmlNode Moncurrentnode;
        private StringBuilder Monsbuilder;

        private void WriteNodeObject(XmlNode currentNode, StringBuilder sbuilder)
        {
            object[] nameTypes = new object[] { };
            object[] names = new object[] { };
           
            if (currentNode.Name == "Object") // c'est un node Object i.e. un Control
            {
                nameTypes = currentNode.Attributes.GetNamedItem("type").Value.Split(new char[] { ',' });
                names = currentNode.Attributes.GetNamedItem("name").Value.Split(new char[] { ',' });
                switch (nameTypes[0] ?? "")
                {
                    case var @case when @case == (WinToCpcControls.Keys.ElementAtOrDefault(0) ?? ""):
                        {
                            sbuilder.Append(@"
'REMARQUE : Cpcdosiennes, Cpcdosiens ce code est généré par
' _____   _____       ___  ___       ___   _   _    _____   _____   
'/  _  \ /  ___/     /   |/   |     /   | | | / /  | ____| |  _  \  
'| | | | | |___     / /|   /| |    / /| | | |/ /   | |__   | |_| |  
'| | | | \___  \   / / |__/ | |   / / | | | |\ \   |  __|  |  _  /  
'| |_| |  ___| |  / /       | |  / /  | | | | \ \  | |___  | | \ \  
'\_____/ /_____/ /_/        |_| /_/   |_| |_|  \_\ |_____| |_|  \_\ v 1.0
' La procédure suivante est requise par le Concepteur Windows Form
' Elle peut être modifiée à l'aide du Concepteur Windows Form  
' Ne la modifiez pas à l'aide de l'éditeur de code.                        " + '\n');
                            sbuilder.Append(WinToCpcControls.Values.ElementAtOrDefault(0));
                            sbuilder.Append(" " + names[0]);
                            sbuilder.AppendLine();
                            // XPATH  un autre operateut  XML fait des miracles 
                            // lit tou les nodes "Property" sous le currentNode
                            var childrops = currentNode.SelectNodes("Property");
                            foreach (XmlNode item in childrops)
                                WriteNodeProperty(item, sbuilder);
                            if (parametrescheck.Checked)
                            {
                                sbuilder.AppendLine(".Parameters" + "   " + " = \"" + bordtext.Text + ctntext.Text + typetext.Text + "OMBRE:" + ombretext.Text + "\"");
                            }

                            if (string.IsNullOrEmpty(Opacitetext.Text))
                            {
                            }
                            else
                            {
                                sbuilder.AppendLine(".Opacite" + "      " + " = \"" + Opacitetext.Text + "\"");
                            }

                            if (string.IsNullOrEmpty(Couleurfenetretext.Text))
                            {
                            }
                            else
                            {
                                sbuilder.AppendLine(".WindowColor" + "  " + " = \"" + Couleurfenetretext.Text + "\"");
                            }

                            if (string.IsNullOrEmpty(couleurtitretext.Text))
                            {
                            }
                            else
                            {
                                sbuilder.AppendLine(".TitleColor" + "   " + " = \"" + couleurtitretext.Text + "\"");
                            }

                            if (string.IsNullOrEmpty(couleurfondtext.Text))
                            {
                            }
                            else
                            {
                                sbuilder.AppendLine(".BackColor" + "    " + " = \"" + couleurfondtext.Text + "\"");
                            }

                            if (string.IsNullOrEmpty(iconetext.Text))
                            {
                            }
                            else
                            {
                                sbuilder.AppendLine(".Icone" + "        " + " = \"" + iconetext.Text + "\"");
                            }

                            if (string.IsNullOrEmpty(imgtitretext.Text))
                            {
                            }
                            else
                            {
                                sbuilder.AppendLine(".ImgTitre" + "     " + " = \"" + imgtitretext.Text + "\"");
                            }

                            sbuilder.AppendLine("Create/ @#" + Handletext.Text);
                            sbuilder.AppendLine(CpcDebutToFins.Values.ElementAtOrDefault(0));
                            break;
                        }

                    case var case1 when case1 == (WinToCpcControls.Keys.ElementAtOrDefault(1) ?? ""):
                        {
                            sbuilder.Append(WinToCpcControls.Values.ElementAtOrDefault(1));
                            sbuilder.AppendLine(" " + names[0]);
                            sbuilder.AppendLine();
                            var childrops = currentNode.SelectNodes("Property");
                            foreach (XmlNode item in childrops)
                                WriteNodeProperty(item, sbuilder);
                            sbuilder.AppendLine("Create/");
                            sbuilder.AppendLine(CpcDebutToFins.Values.ElementAtOrDefault(1));
                            break;
                        }

                    case var case2 when case2 == (WinToCpcControls.Keys.ElementAtOrDefault(2) ?? ""):
                        {
                            sbuilder.Append(WinToCpcControls.Values.ElementAtOrDefault(2));
                            sbuilder.Append(" " + names[0]);
                            sbuilder.AppendLine();
                            var childrops = currentNode.SelectNodes("Property");
                            foreach (XmlNode item in childrops)
                                WriteNodeProperty(item, sbuilder);
                            sbuilder.AppendLine("Create/");
                            sbuilder.AppendLine(CpcDebutToFins.Values.ElementAtOrDefault(2));
                            break;
                        }

                    case var case3 when case3 == (WinToCpcControls.Keys.ElementAtOrDefault(3) ?? ""):
                        {
                            sbuilder.Append(WinToCpcControls.Values.ElementAtOrDefault(3));
                            sbuilder.Append(" " + names[0]);
                            sbuilder.AppendLine();
                            var childrops = currentNode.SelectNodes("Property");
                            foreach (XmlNode item in childrops)
                                WriteNodeProperty(item, sbuilder);
                            sbuilder.AppendLine("Create/");
                            sbuilder.AppendLine(CpcDebutToFins.Values.ElementAtOrDefault(3));
                            break;
                        }

                    case var case4 when case4 == (WinToCpcControls.Keys.ElementAtOrDefault(4) ?? ""):
                        {
                            sbuilder.Append(WinToCpcControls.Values.ElementAtOrDefault(4));
                            sbuilder.Append(" " + names[0]);
                            sbuilder.AppendLine();
                            var childrops = currentNode.SelectNodes("Property");
                            foreach (XmlNode item in childrops)
                                WriteNodeProperty(item, sbuilder);
                            sbuilder.AppendLine("Create/");
                            sbuilder.AppendLine(CpcDebutToFins.Values.ElementAtOrDefault(4));
                            break;
                        }

                    case var case5 when case5 == (WinToCpcControls.Keys.ElementAtOrDefault(5) ?? ""):
                        {
                            sbuilder.Append(WinToCpcControls.Values.ElementAtOrDefault(5));
                            sbuilder.Append(" " + names[0]);
                            sbuilder.AppendLine();
                            var childrops = currentNode.SelectNodes("Property");
                            foreach (XmlNode item in childrops)
                                WriteNodeProperty(item, sbuilder);
                            sbuilder.AppendLine("Create/");
                            sbuilder.AppendLine(CpcDebutToFins.Values.ElementAtOrDefault(5));
                            break;
                        }

                    case var case6 when case6 == (WinToCpcControls.Keys.ElementAtOrDefault(6) ?? ""):
                        {
                            sbuilder.Append(WinToCpcControls.Values.ElementAtOrDefault(6));
                            sbuilder.Append(" " + names[0]);
                            sbuilder.AppendLine();
                            var childrops = currentNode.SelectNodes("Property");
                            foreach (XmlNode item in childrops)
                                WriteNodeProperty(item, sbuilder);
                            sbuilder.AppendLine("Create/");
                            sbuilder.AppendLine(CpcDebutToFins.Values.ElementAtOrDefault(6));
                            break;
                        }
                }

                sbuilder.AppendLine();
                foreach (var itemNode in currentNode.ChildNodes)
                    WriteNodeObject((XmlNode)itemNode, sbuilder); // appel recurif car XML genere en fait un tree
            }

            string code = sbuilder.ToString();
            tb.Text = code;
        }

        private void WriteNodeProperty(XmlNode currentNode, StringBuilder sbuilder)
        {
            string name;
            string[] propertyValues;
            string propertyValues2;
            propertyValues = currentNode.InnerText.Split(new char[] { ',' });
            propertyValues2 = currentNode.InnerText;
            name = currentNode.Attributes.GetNamedItem("name").Value;
            if (name == "Text")
            {
                sbuilder.AppendLine(".text" + "         " + " = \"" + propertyValues[0] + "\"");
            }
            else if (name == "Handle")
            {
                sbuilder.AppendLine(".Handle" + "       " + " = \"" + "%" + Handletext.Text + "%" + "\"");
            }
            else if (name == "Location")
            {
                sbuilder.Append(".PX" + "           " + " = \"" + propertyValues[0].Trim() + "\"");
                sbuilder.AppendLine();
                sbuilder.AppendLine(".PY" + "           " + " = \"" + propertyValues[1].Trim() + "\"");
            }
            else if (name == "ClientSize" | name == "Size")
            {
                sbuilder.Append(".SX" + "           " + " = \"" + propertyValues[0].Trim() + "\"");
                sbuilder.AppendLine();
                sbuilder.AppendLine(".SY" + "           " + " = \"" + propertyValues[1].Trim() + "\"");
            }
            else if (name == "CouleurFond")
            {
                if (string.IsNullOrEmpty(propertyValues2))
                {
                }
                else
                {
                    sbuilder.Append(".BackColor" + "    " + " = \"" + propertyValues2.Trim() + "\"");
                    sbuilder.AppendLine();
                }
            }
            else if (name == "CouleurTexte")
            {
                if (string.IsNullOrEmpty(propertyValues2))
                {
                }
                else
                {
                    sbuilder.Append(".TextColor" + "    " + " = \"" + propertyValues2.Trim() + "\"");
                    sbuilder.AppendLine();
                }
            }
            else if (name == "Checked")
            {
                string valeur = propertyValues[0] == "True" ? "1" : "0";
                sbuilder.AppendLine(".Value" + "        " + " = \"" + valeur + "\"");
            }
            else if (name == "EVENT_PATH")
            {
                if (string.IsNullOrEmpty(propertyValues2))
                {
                }
                else
                {
                    sbuilder.Append(".Event" + "        " + " = \"" + propertyValues2.Trim() + "\"");
                    sbuilder.AppendLine();
                }
            }
            else if (name == "IMGAUTO")
            {
                if (string.IsNullOrEmpty(propertyValues2))
                {
                }
                else
                {
                    IMGAUTO1 = "IMGAUTO:" + propertyValues2;
                }
            }
            else if (name == "COL")
            {
                if (string.IsNullOrEmpty(propertyValues2))
                {
                }
                else
                {
                    COL1 = "COL:" + propertyValues2;
                }
            }
            else if (name == "UPD")
            {
                if (Conversions.ToBoolean(propertyValues2) == true)
                {
                    UPD1 = "UPD:1";
                }
            }
            else if (name == "Image")
            {
                if (string.IsNullOrEmpty(propertyValues2))
                {
                }
                else
                {
                    sbuilder.Append(".Image" + "        " + " = \"" + propertyValues2 + "\"");
                    sbuilder.AppendLine();
                }
            }
            else if (name == "Parameters")
            {
                if (string.IsNullOrEmpty(propertyValues2))
                {
                }
                else
                {
                    sbuilder.Append(".Parameters" + "   " + " = \"" + propertyValues2 + "\"");
                    sbuilder.AppendLine();
                }
            }
        }

        private string IMGAUTO1;
        private string MULTILINES1;
        private string COL1;
        private string UPD1;

        private void LoadWinToCpcControls()
        {
            WinToCpcControls = new Dictionary<string, string>();
            WinToCpcControls.Add("System.Windows.Forms.Form", "Window/");
            WinToCpcControls.Add("ToolBox.PictureBox", "PictureBox/");
            WinToCpcControls.Add("ToolBox.CheckBox", "CheckBox/");
            WinToCpcControls.Add("ToolBox.Button", "Button/");
            WinToCpcControls.Add("ToolBox.TextBox", "TextBox/");
            WinToCpcControls.Add("ToolBox.TextBlock", "TextBlock/");
            WinToCpcControls.Add("ToolBox.ProgressBar", "ProgressBar/");

            CpcDebutToFins = new Dictionary<string, string>();
            CpcDebutToFins.Add("Window/", "End/ Window");
            CpcDebutToFins.Add("PictureBox/", "End/ PictureBox");
            CpcDebutToFins.Add("CheckBox/", "End/ CheckBox");
            CpcDebutToFins.Add("Button/", "End/ Button");
            CpcDebutToFins.Add("TextBox/", "End/ TextBox");
            CpcDebutToFins.Add("TextBlock/", "End/ TextBlock");
            CpcDebutToFins.Add("ProgressBar/", "End/ ProgressBar");
        }

        private IComponent root;
        // AJOUT => UN SAVEDIALOG

        private string GetFileNameToSave()
        {
            string fileName = null;
            if (string.IsNullOrEmpty(TextBoxX1.Text))
            {
                var dlgSaveFile = new SaveFileDialog();
                dlgSaveFile.Filter = "Files(.*cpc)|*.cpc";
                if (dlgSaveFile.ShowDialog() == DialogResult.OK)
                {
                    fileName = dlgSaveFile.FileName;
                    TextBoxX1.Text = fileName;
                    if (fileName.Length != 0)
                    {
                        return fileName;
                    }
                }
            }
            else
            {
                fileName = TextBoxX1.Text;
            }

            return fileName;
        }

        private void ButtonItem2_Click(object sender, EventArgs e)
        {
            var currentHostControl = HostC;
            ((Loader.BasicHostLoader)currentHostControl.HostSurface.Loader).Save(true);
        }

        private void ButtonItem9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Indisponible (version Beta)");
        }

        private void tb_TextChangedDelayed(object sender, TextChangedEventArgs e)
        {
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

        private void ButtonX1_Click(object sender, EventArgs e)
        {
        }

        private void ButtonX1_Click_1(object sender, EventArgs e)
        {
            string Nom_Ctrl_Actif;
            if (My.MyProject.Forms.Form2.AdvPropertyGrid1.SelectedObject.ToString().Contains("["))
            {
                Nom_Ctrl_Actif = My.MyProject.Forms.Form2.AdvPropertyGrid1.SelectedObject.ToString().Split('[')[0].TrimEnd(' ');
            }
            else
            {
                Nom_Ctrl_Actif = Conversions.ToString(My.MyProject.Forms.Form2.AdvPropertyGrid1.SelectedObject.GetType().GetProperty("Name").GetValue(My.MyProject.Forms.Form2.AdvPropertyGrid1.SelectedObject, null));
            }
            // Else
            // Nom_Ctrl_Actif = SelectionService.PrimarySelection.ToString.Split("[")(0).TrimEnd(" ")
            // End If
            TextBoxX3.Text = Nom_Ctrl_Actif;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            var dlgSaveFile = new SaveFileDialog();
            dlgSaveFile.Filter = "Fichier CC+ (.*cpc)|*.cpc";
            string fileName = null;
            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                fileName = dlgSaveFile.FileName;
                TextBoxX4.Text = fileName;
                var di = new DirectoryInfo(fileName);
                var fs = File.Create(fileName);
                // add file to  di

                if (fileName.Length != 0)
                   
                {
                    
                }
            }

            fileName = TextBoxX4.Text;
        }

        private void ButtonX2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxX4.Text))
            {
                MessageBox.Show("Veuillez sélectionner un fichier évènement CC+");
            }
            else
            {
                My.MyProject.Computer.FileSystem.WriteAllText(TextBoxX4.Text, "Function/ " + TextBoxX3.Text + ".MouseClick()" + Constants.vbCrLf + "" + Constants.vbCrLf + "End/ Function", true);
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            // Try

            // _formCount += 1
            // HostC = _hostSurfaceManager.GetNewHost(TextBoxX2.Text)
            // rm2.Toolbox.DesignerHost = HostC.DesignerHost
            // ' Dim tabpage As TabPage = New TabPage(tabText)
            // TabPage.Tag = CurrentMenuSelectionLoaderType
            // HostC.Parent = Panel1
            // HostC.Dock = DockStyle.Fill


            // tabControl1.TabPages.Add(tabpage)
            // tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1
            // _hostSurfaceManager.ActiveDesignSurface = HostC.HostSurface

            // Dim ims As System.ComponentModel.Design.IMenuCommandService = TryCast(HostC.HostSurface.GetService(GetType(System.ComponentModel.Design.IMenuCommandService)), System.ComponentModel.Design.IMenuCommandService)

            // Catch
            // MessageBox.Show("Error in creating new host", "Shell Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            // End Try
        }

        private void ButtonItem1_Click_1(object sender, EventArgs e)
        {
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.Delete);
        }

        // Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        // Try
        // Dim fileName As String = Nothing

        // Open File Dialog
        // Dim dlg As OpenFileDialog = New OpenFileDialog()
        // dlg.DefaultExt = "xml"
        // dlg.Filter = "Xml Files|*.xml"
        // If dlg.ShowDialog() = DialogResult.OK Then fileName = dlg.FileName
        // Equals(fileName, Nothing) Then Return

        // Create Form
        // _formCount += 1
        // ostC = _hostSurfaceManager.GetNewHost(fileName)
        // Toolbox.DesignerHost = hc.DesignerHost

        // xtBoxX2.Text = fileName

        // e.Tag = HostC.HostSurface.Loader


        // HostC.Parent = Panel1
        // HostC.Dock = DockStyle.Fill
        // _hostSurfaceManager.ActiveDesignSurface = HostC.HostSurface
        // F 'orm2.Toolbox.DesignerHost = HostC.DesignerHost
        // Catch
        // MessageBox.Show("Error in creating new host", "Shell Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        // End Try
        // End Sub

        private void PictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.CenterHorizontally);
        }

        private void ButtonItem6_Click(object sender, EventArgs e)
        {
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.CenterVertically);
        }
    }
}