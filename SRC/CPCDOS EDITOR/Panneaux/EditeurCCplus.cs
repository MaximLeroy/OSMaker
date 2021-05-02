using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
using WinToCpcDosCplus;
using WeifenLuo.WinFormsUI.Docking;
using OSMaker.Panneaux;

namespace OSMaker
{
    public partial class EditeurCCplus : DocumentC
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

            
          
            _Panel1.Name = "Panel1";
        }
        //private ServiceContainer serviceContainer = null;
     
        private void OnSelectionChanged(object sender, System.EventArgs e)
        {
           System.ComponentModel.Design.ISelectionService s = (ISelectionService)_hostSurfaceManager.GetService(typeof(ISelectionService));

            object[] selection;
            if (s.SelectionCount == 0)
                Home.m_propertyWindow.propertyGrid.SelectedObject = null;
            else
            {
                selection = new object[s.SelectionCount];
                s.GetSelectedComponents().CopyTo(selection, 0);
                Home.m_propertyWindow.propertyGrid.SelectedObjects = selection;
            }

            if (s.PrimarySelection == null)
              _selection = "";
            else
            {
                IComponent component = (IComponent)s.PrimarySelection;
    _selection = component.Site.Name + " (" + component.GetType().Name + ")";
            }
        }
        public static Host.HostSurfaceManager _hostSurfaceManager;
        private int _formCount = 0;
        public static Host.HostControl HostC;
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
      
        public System.ComponentModel.Design.IComponentChangeService componentChangeService;
     
        private void HostControl_MouseDoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("double click");
        }
        private void EditeurCCplus_Load(object sender, EventArgs e)
        {
            try
            {

                if (Home.fileName == null)
                {
                    _formCount += 1;
                    HostC = _hostSurfaceManager.GetNewHost(typeof(Form), Host.LoaderType.BasicDesignerLoader);
                    // AddTabForNewHost("Form" & _formCount.ToString() & " - " & Strings.Design)
                    HostC.Parent = Panel1;
                    HostC.Dock = DockStyle.Fill;

                    metroFichierXml.Text = Home.OSMPATH;
                    metroFichierCCPlus.Text = Home.CPCPATH;
                    ToolBox.Window b1 = (ToolBox.Window)HostC.CreateControl(typeof(ToolBox.Window), new Size(50, 50), new Point(10, 10));
                    b1.Dock = DockStyle.Fill;
                    var currentHostControl = HostC;
                    string stringXML = ((Loader.BasicHostLoader)currentHostControl.HostSurface.Loader).GetCode();
                    ModuleCpcDosCplus.GenTextCpc(stringXML);
                    //GenTextCpc(stringXML);
                    string code = ((Loader.BasicHostLoader)currentHostControl.HostSurface.Loader).GetCode();
                    //FastColoredTextBox1.Text = code;
                    //tb.Text = WinToCpcDosCplus.ModuleCpcDosCplus.tbS;
                    string fileName = metroFichierXml.Text;
                    string codeccplus = WinToCpcDosCplus.ModuleCpcDosCplus.tbS;
                    string fileNameC = metroFichierCCPlus.Text;
                    if (string.IsNullOrEmpty(metroFichierXml.Text))
                    {
                        var dlgSaveFile = new SaveFileDialog();
                        dlgSaveFile.Filter = "Fichier OSMaker (.*osm)|*.osm";
                        if (dlgSaveFile.ShowDialog() == DialogResult.OK)
                        {
                            fileName = dlgSaveFile.FileName;
                            metroFichierXml.Text = fileName;
                            if (fileName.Length != 0)
                            {
                            }
                        }
                    }
                    else
                    {
                        fileName = metroFichierXml.Text;
                    }

                    if (string.IsNullOrEmpty(metroFichierXml.Text))
                    {
                        MessageBox.Show("Pas de chemin de fichier OSMaker renseigné, enregistrement impossible !");
                    }
                    else
                    {
                        File.WriteAllText(metroFichierXml.Text, code);
                    }
                    if (string.IsNullOrEmpty(metroFichierCCPlus.Text))
                    {
                        var dlgSaveFile = new SaveFileDialog();
                        dlgSaveFile.Filter = "Fichier CPC (.*cpc)|*.cpc";
                        if (dlgSaveFile.ShowDialog() == DialogResult.OK)
                        {
                            fileNameC = dlgSaveFile.FileName;
                            metroFichierCCPlus.Text = fileNameC;
                            if (fileNameC.Length != 0)
                            {
                            }
                        }
                    }
                    else
                    {
                        fileNameC = metroFichierCCPlus.Text;
                    }

                    if (string.IsNullOrEmpty(metroFichierCCPlus.Text))
                    {
                        MessageBox.Show("Pas de chemin de fichier CpcdosC+ renseigné, enregistrement impossible !");
                    }
                    else
                    {
                        File.WriteAllText(metroFichierCCPlus.Text, codeccplus);
                    }
                }
                else
                {

                    // Create Form
                    _hostSurfaceManager = new Host.HostSurfaceManager();
                    HostC = _hostSurfaceManager.GetNewHost(Home.fileName);
                   
                    //Toolbox.DesignerHost = hc.DesignerHost;

                    metroFichierXml.Text = Home.fileName;

                    //  metroButton2.Visible = false;
                    HostC.Parent = _Panel1;
                    HostC.Dock = DockStyle.Fill;
                    _hostSurfaceManager.AddService(typeof(IToolboxService), Home.m_toolbox.toolbox1);
                    _hostSurfaceManager.AddService(typeof(PropertyGrid), Home.m_propertyWindow.propertyGrid);
                }

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
            
           

            //on pourra choisir sur quelle forme ajouter en modifiant avec un textbox
          
            _hostSurfaceManager = new Host.HostSurfaceManager();
            _hostSurfaceManager.AddService(typeof(IToolboxService), Home.m_toolbox.toolbox1);
           
            _hostSurfaceManager.AddService(typeof(PropertyGrid), Home.m_propertyWindow.propertyGrid);
            //MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            //HostC.DesignerHost.AddService(typeof(System.ComponentModel.Design.MenuCommandService), MenuCommandService);
            //   _hostSurfaceManager.AddService(typeof(System.ComponentModel.Design.UndoEngine), undoEngine);

        }

        private void AddTabForNewHost(string tabText)
        {
            System.ComponentModel.Design.IServiceContainer serviceContainer;
        Home.m_toolbox.toolbox1.DesignerHost = HostC.DesignerHost;
            // Dim tabpage As TabPage = New TabPage(tabText)
            // TabPage.Tag = CurrentMenuSelectionLoaderType
            HostC.Parent = Panel1;
            HostC.Dock = DockStyle.Fill;


            // tabControl1.TabPages.Add(tabpage)
            // tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1
            _hostSurfaceManager.ActiveDesignSurface = HostC.HostSurface;
           // serviceContainer = (System.ComponentModel.Design.IServiceContainer)_hostSurfaceManager.GetService(typeof(System.ComponentModel.Design.ServiceContainer));
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            HostC.DesignerHost.AddService(typeof(System.ComponentModel.Design.MenuCommandService), MenuCommandService);

            // Ajout du service Annuler/Retablir
            undoEngine = new OSMaker.UndoEngineImpl(_hostSurfaceManager);
            undoEngine.Enabled = true;
            _hostSurfaceManager.AddService(typeof(System.ComponentModel.Design.UndoEngine), undoEngine);

            ISelectionService s = (ISelectionService)_hostSurfaceManager.GetService(typeof(ISelectionService));
            s.SelectionChanged += new EventHandler(OnSelectionChanged);
        }

        public void Coller()
        {
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.Paste;
            ims.GlobalInvoke(a);
            MenuCommandService.GlobalInvoke(a);
        }

        public void Copier()
        {
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.Copy;
            ims.GlobalInvoke(a);
            MenuCommandService.GlobalInvoke(a);


        }
        public void Couper()
        {
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.Cut;
            ims.GlobalInvoke(a);
            MenuCommandService.GlobalInvoke(a);


        }

        public void Annuler()
        {
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.Undo;
            ims.GlobalInvoke(a);
        }
        public void Retablir()
        {
          
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
           
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.Redo;
            ims.GlobalInvoke(a);
        }
        public void Avant()
        {
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.BringToFront;
            ims.GlobalInvoke(a);
            MenuCommandService.GlobalInvoke(a);
        }
        public void Arriere()
        {
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.BringForward;
            ims.GlobalInvoke(a);
            MenuCommandService.GlobalInvoke(a);
        }
        public void Supprimer()
        {
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.Delete;
            ims.GlobalInvoke(a);
            MenuCommandService.GlobalInvoke(a);
        }
        public void Verouiller()
        {
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.LockControls;
            ims.GlobalInvoke(a);
            MenuCommandService.GlobalInvoke(a);
        }
        public void CentrerHorizontallement()
        {
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.CenterHorizontally;
            ims.GlobalInvoke(a);
            MenuCommandService.GlobalInvoke(a);
        }
        public void CentrerVerticalement()
        {
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.CenterVertically;
            ims.GlobalInvoke(a);
            MenuCommandService.GlobalInvoke(a);
        }
        public void SelectionnerTout()
        {
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.SelectAll;
            ims.GlobalInvoke(a);
            MenuCommandService.GlobalInvoke(a);
        }










        private void ButtonItem1_Click(object sender, EventArgs e)
        {
            //FastColoredTextBox1.Text = ((Loader.BasicHostLoader)HostC.HostSurface.Loader).GetCode();
        }

        private void ButtonItem11_Click(object sender, EventArgs e)
        {
           

        }

        private XmlDocument doc;
        private Dictionary<string, string> WinToCpcControls;
        private Dictionary<string, string> CpcDebutToFins;
        private StringBuilder sb;
        public System.ComponentModel.Design.IMenuCommandService MenuCommandService;
        public System.ComponentModel.Design.ISelectionService SelectionService;

        
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
           
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
        }

        private void ButtonX1_Click_1(object sender, EventArgs e)
        {
            string Nom_Ctrl_Actif;
            if (Home.m_propertyWindow.propertyGrid.SelectedObject.ToString().Contains("["))
            {
                _selection = Home.m_propertyWindow.propertyGrid.SelectedObject.ToString().Split('[')[0].TrimEnd(' ');
            }
            else
            {
                _selection = Conversions.ToString(Home.m_propertyWindow.propertyGrid.SelectedObject.GetType().GetProperty("Name").GetValue(Home.m_propertyWindow.propertyGrid.SelectedObject, null));
            }
            // Else
            // Nom_Ctrl_Actif = SelectionService.PrimarySelection.ToString.Split("[")(0).TrimEnd(" ")
            // End If
         
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            var dlgSaveFile = new SaveFileDialog();
            dlgSaveFile.Filter = "Fichier CC+ (.*cpc)|*.cpc";
            string fileName = null;
            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                fileName = dlgSaveFile.FileName;
                metroFichierCCPlus.Text = fileName;
                var di = new DirectoryInfo(fileName);
                var fs = File.Create(fileName);
                // add file to  di

                if (fileName.Length != 0)
                   
                {
                    
                }
            }

            fileName = metroFichierCCPlus.Text;
        }

        private void ButtonX2_Click(object sender, EventArgs e)
        {
           
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

        private void buttonItem1_Click_2(object sender, EventArgs e)
        {
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.Copy);
        }

        private void buttonItem2_Click_1(object sender, EventArgs e)
        {
           
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            ims.GlobalInvoke(System.ComponentModel.Design.StandardCommands.Paste);
            
        }

        private void Bar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            FormCollection nbforms = Application.OpenForms;


            //on pourra choisir sur quelle forme ajouter en modifiant avec un textbox

           //PropertyWindow monbouton;
           
             
            //on pourra choisir sur quelle forme ajouter en modifiant avec un textbox
           // nbforms["preview"].Controls.Add(monbouton);

            //on pourra choisir sur quelle forme ajouter en modifiant avec un textbox
          //  nbforms["PropertyWindow"].pro;
           // PropertyWindow property;
       
        }
        public static string metroFichierEvent = "";
        public static string _selection = "";
        private void metroLier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(metroFichierEvent))
            {
                MessageBox.Show("Veuillez sélectionner un fichier évènement CC+");
            }
            else
            {
                My.MyProject.Computer.FileSystem.WriteAllText(metroFichierEvent, "Function/ " + _selection + ".MouseClick()" + Constants.vbCrLf + "" + Constants.vbCrLf + "End/ Function", true);
            }
           
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            // Assigner une valeur aux variables
            //WinToCpcDosCplus.ModuleCpcDosCplus.OpacitetextS = metroOpacite.Text;
            //WinToCpcDosCplus.ModuleCpcDosCplus.couleurfondtextS = metroCFR.Text;
            //WinToCpcDosCplus.ModuleCpcDosCplus.couleurtitretextS = metroCTR.Text;
            //WinToCpcDosCplus.ModuleCpcDosCplus.ombretextS = metroOmbre.Text;
            //WinToCpcDosCplus.ModuleCpcDosCplus.imgtitretextS = metroImgTitre.Text;
            //WinToCpcDosCplus.ModuleCpcDosCplus.iconetextS = metroIcone.Text;
            //WinToCpcDosCplus.ModuleCpcDosCplus.HandletextS = metroHandle.Text;
            //WinToCpcDosCplus.ModuleCpcDosCplus.typetextS = metroType.Text;
            //WinToCpcDosCplus.ModuleCpcDosCplus.ctntextS = metroCTN.Text;
            //if (metroParametres.Checked == true)
            //{
            //    WinToCpcDosCplus.ModuleCpcDosCplus.parametrescheckB = true;
            //}
            //else
            //{
            //    WinToCpcDosCplus.ModuleCpcDosCplus.parametrescheckB = false;
            //}

            var currentHostControl = HostC;
            string stringXML = ((Loader.BasicHostLoader)currentHostControl.HostSurface.Loader).GetCode();
            ModuleCpcDosCplus.GenTextCpc(stringXML);
            //GenTextCpc(stringXML);
            string code = ((Loader.BasicHostLoader)currentHostControl.HostSurface.Loader).GetCode();
            //FastColoredTextBox1.Text = code;
          //  tb.Text = WinToCpcDosCplus.ModuleCpcDosCplus.tbS;
            string fileName = metroFichierXml.Text;
            string codeccplus = WinToCpcDosCplus.ModuleCpcDosCplus.tbS;
            string fileNameC = metroFichierCCPlus.Text;
            if (string.IsNullOrEmpty(metroFichierXml.Text))
            {
                var dlgSaveFile = new SaveFileDialog();
                dlgSaveFile.Filter = "Fichier OSMaker (.*osm)|*.osm";
                if (dlgSaveFile.ShowDialog() == DialogResult.OK)
                {
                    fileName = dlgSaveFile.FileName;
                    metroFichierXml.Text = fileName;
                    if (fileName.Length != 0)
                    {
                    }
                }
            }
            else
            {
                fileName = metroFichierXml.Text;
            }

            if (string.IsNullOrEmpty(metroFichierXml.Text))
            {
                MessageBox.Show("Pas de chemin de fichier OSMaker renseigné, enregistrement impossible !");
            }
            else
            {
                File.WriteAllText(metroFichierXml.Text, code);
            }
            if (string.IsNullOrEmpty(metroFichierCCPlus.Text))
            {
                var dlgSaveFile = new SaveFileDialog();
                dlgSaveFile.Filter = "Fichier CPC (.*cpc)|*.cpc";
                if (dlgSaveFile.ShowDialog() == DialogResult.OK)
                {
                    fileNameC = dlgSaveFile.FileName;
                    metroFichierCCPlus.Text = fileNameC;
                    if (fileNameC.Length != 0)
                    {
                    }
                }
            }
            else
            {
                fileNameC = metroFichierCCPlus.Text;
            }

            if (string.IsNullOrEmpty(metroFichierCCPlus.Text))
            {
                MessageBox.Show("Pas de chemin de fichier CpcdosC+ renseigné, enregistrement impossible !");
            }
            else
            {
                File.WriteAllText(metroFichierCCPlus.Text, codeccplus);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
         ToolBox.TextBlock b1 = (ToolBox.TextBlock)HostC.CreateControl(typeof(ToolBox.TextBlock), new Size(200, 40), new Point(10, 10));
            
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
           
        }

      

        private void _Panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("double click");
        }

        private void _Panel1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("double click");
        }
        
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

          
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void horizontalementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void verticalementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.CenterVertically;
            ims.GlobalInvoke(a);
            MenuCommandService.GlobalInvoke(a);
        }

        private void sélectionnerToutToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void toolStripMenuItem9_Click_1(object sender, EventArgs e)
        {
            OSMaker.UndoEngineImpl undoEngine = GetService(typeof(UndoEngine)) as OSMaker.UndoEngineImpl;
            if (undoEngine != null)
                undoEngine.DoUndo();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            OSMaker.UndoEngineImpl undoEngine = GetService(typeof(UndoEngine)) as OSMaker.UndoEngineImpl;
            if (undoEngine != null)
                undoEngine.DoRedo();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.Cut;
            ims.GlobalInvoke(a);
            MenuCommandService.GlobalInvoke(a);
        }

        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.Copy;
            ims.GlobalInvoke(a);
            MenuCommandService.GlobalInvoke(a);
        }

        private void testToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.Paste;
            ims.GlobalInvoke(a);
            MenuCommandService.GlobalInvoke(a);
        }

        private void annulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.Undo;
            ims.GlobalInvoke(a);
           
        }

        private void rétablirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.Redo;
            ims.GlobalInvoke(a);

        }

        private void sélectionnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.SelectAll;
            ims.GlobalInvoke(a);
            MenuCommandService.GlobalInvoke(a);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            // Assigner une valeur aux variables
            //WinToCpcDosCplus.ModuleCpcDosCplus.OpacitetextS = metroOpacite.Text;
            //WinToCpcDosCplus.ModuleCpcDosCplus.couleurfondtextS = metroCFR.Text;
            //WinToCpcDosCplus.ModuleCpcDosCplus.couleurtitretextS = metroCTR.Text;
            //WinToCpcDosCplus.ModuleCpcDosCplus.ombretextS = metroOmbre.Text;
            //WinToCpcDosCplus.ModuleCpcDosCplus.imgtitretextS = metroImgTitre.Text;
            //WinToCpcDosCplus.ModuleCpcDosCplus.iconetextS = metroIcone.Text;
            //WinToCpcDosCplus.ModuleCpcDosCplus.HandletextS = metroHandle.Text;
            //WinToCpcDosCplus.ModuleCpcDosCplus.typetextS = metroType.Text;
            //WinToCpcDosCplus.ModuleCpcDosCplus.ctntextS = metroCTN.Text;
            //if (metroParametres.Checked == true)
            //{
            //    WinToCpcDosCplus.ModuleCpcDosCplus.parametrescheckB = true;
            //}
            //else
            //{
            //    WinToCpcDosCplus.ModuleCpcDosCplus.parametrescheckB = false;
            //}

            var currentHostControl = HostC;
            string stringXML = ((Loader.BasicHostLoader)currentHostControl.HostSurface.Loader).GetCode();
            ModuleCpcDosCplus.GenTextCpc(stringXML);
            //GenTextCpc(stringXML);
            string code = ((Loader.BasicHostLoader)currentHostControl.HostSurface.Loader).GetCode();
            //FastColoredTextBox1.Text = code;
            //tb.Text = WinToCpcDosCplus.ModuleCpcDosCplus.tbS;
            string fileName = metroFichierXml.Text;
            string codeccplus = WinToCpcDosCplus.ModuleCpcDosCplus.tbS;
            string fileNameC = metroFichierCCPlus.Text;
            if (string.IsNullOrEmpty(metroFichierXml.Text))
            {
                var dlgSaveFile = new SaveFileDialog();
                dlgSaveFile.Filter = "Fichier OSMaker (.*osm)|*.osm";
                if (dlgSaveFile.ShowDialog() == DialogResult.OK)
                {
                    fileName = dlgSaveFile.FileName;
                    metroFichierXml.Text = fileName;
                    if (fileName.Length != 0)
                    {
                    }
                }
            }
            else
            {
                fileName = metroFichierXml.Text;
            }

            if (string.IsNullOrEmpty(metroFichierXml.Text))
            {
                MessageBox.Show("Pas de chemin de fichier OSMaker renseigné, enregistrement impossible !");
            }
            else
            {
                File.WriteAllText(metroFichierXml.Text, code);
            }
            if (string.IsNullOrEmpty(metroFichierCCPlus.Text))
            {
                var dlgSaveFile = new SaveFileDialog();
                dlgSaveFile.Filter = "Fichier CPC (.*cpc)|*.cpc";
                if (dlgSaveFile.ShowDialog() == DialogResult.OK)
                {
                    fileNameC = dlgSaveFile.FileName;
                    metroFichierCCPlus.Text = fileNameC;
                    if (fileNameC.Length != 0)
                    {
                    }
                }
            }
            else
            {
                fileNameC = metroFichierCCPlus.Text;
            }

            if (string.IsNullOrEmpty(metroFichierCCPlus.Text))
            {
                MessageBox.Show("Pas de chemin de fichier CpcdosC+ renseigné, enregistrement impossible !");
            }
            else
            {
                File.WriteAllText(metroFichierCCPlus.Text, codeccplus);
            }
        }

        private void mouseClickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            if (Home.m_propertyWindow.propertyGrid.SelectedObject.ToString().Contains("["))
            {
                _selection = Home.m_propertyWindow.propertyGrid.SelectedObject.ToString().Split('[')[0].TrimEnd(' ');
            }
            else
            {

                _selection = Conversions.ToString(Home.m_propertyWindow.propertyGrid.SelectedObject.GetType().GetProperty("Name").GetValue(Home.m_propertyWindow.propertyGrid.SelectedObject, null));
            }
          Doc doc = CreateNewDocument();
            doc.Show(Home.dockPanel);

            // Else
            // Nom_Ctrl_Actif = SelectionService.PrimarySelection.ToString.Split("[")(0).TrimEnd(" ")
            // End If

        }
        public Doc CreateNewDocument()
        {
            Doc dummyDoc = new Doc();

            int count = 1;
            string text = $"Document{count}";
            //while (FindDocument(text) != null)
            //{
            //    count++;
            //    text = $"Document{count}";
            //}

            dummyDoc.Text = text;
            return dummyDoc;
        }
        private Doc CreateNewDocument(string text)
        {
            Doc dummyDoc = new Doc();
            dummyDoc.Text = text;
            return dummyDoc;
        }

   

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
            }
            else
                panel2.Visible = false;
        }

        private void horizontalementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CentrerHorizontallement();
        }

        private void verticalementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CentrerVerticalement();
        }

        private void rétablirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Retablir();
        }

        private void annulerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Annuler();
        }

        private void copierCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copier();
        }

        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Couper();
        }

        private void collerCtrlVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Coller();
        }

        private void sélectionnerToutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {


           SelectionnerTout();

        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supprimer();
        }

        private void mettreEnAvantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Avant();
        }

        private void mettreEnArrièrePlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arriere();
        }

        private void vérouillerLesContrôlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Verouiller();
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            Annuler();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Retablir();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            Couper();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            
            Copier();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent("CF_DESIGNERCOMPONENTS_V2") == true)
                Coller();
            
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            Supprimer();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            Avant();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            Arriere();
        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            Verouiller();
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            CentrerHorizontallement();
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            CentrerVerticalement();
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            SelectionnerTout();
        }

        private void metroButton18_Click(object sender, EventArgs e)
        {

        }

        private void metroContextMenu1_Opening(object sender, CancelEventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent("CF_DESIGNERCOMPONENTS_V2") == true )
            {
                collerCtrlVToolStripMenuItem.Enabled = true;
            }
            else
            {
                collerCtrlVToolStripMenuItem.Enabled = false;
            }
        }
    }
}