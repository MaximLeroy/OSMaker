using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WeifenLuo.WinFormsUI.Docking;
using System.Reflection;
using OSMaker.Panneaux;
using Exporter.Controls;
using Exporter;
using System.Drawing.Design;
using MetroFramework;
//using VM_Viewer;
using OutputW;
using OSMaker.VM_Viewer;
using static cwc.LauchTool;

namespace OSMaker
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        bool moving;
        Point offset;
        Point original;

        private bool m_bSaveLayout = true;
        private DeserializeDockContent m_deserializeDockContent;
        public static SolutionExplorer m_solutionExplorer;
        public static PropertyWindow m_propertyWindow;
        public static DockPanel m_dockPanel;
        public static Toolbox m_toolbox;
        public static OutputW.Form1 m_sortie;
     
        
       // private DummyTaskList m_taskList;
        private bool _showSplash;
       // private SplashScreen _splashScreen;
        public Home()
        {
            InitializeComponent();
            mainMenu.Renderer = new ToolStripProfessionalRenderer(new LeftMenuColorTable());
            AutoScaleMode = AutoScaleMode.Dpi;

            //SetSplashScreen();
            CreateStandardControls();

          
  
            m_solutionExplorer.RightToLeftLayout = RightToLeftLayout;
            //m_deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);

            vsToolStripExtender1.DefaultRenderer = _toolStripProfessionalRenderer;
          
        }
        public static WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private void CreateStandardControls()

        {
            
            m_solutionExplorer = new SolutionExplorer();
            m_propertyWindow = new PropertyWindow();
            m_toolbox = new Toolbox();
          m_sortie = new OutputW.Form1();

            //   m_outputWindow = new OutputWindow();

        }
        public class submenuColorTable : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(30,30,30); }
            }

            public override Color MenuItemBorder
            {
                get { return Color.FromArgb(30, 30, 30); }
            }

            public override Color ToolStripDropDownBackground
            {
                get { return Color.FromArgb(30, 30, 30); }
            }

            public override Color ToolStripContentPanelGradientBegin
            {
                get { return Color.FromArgb(30, 30, 30); }
            }
        }

        public class LeftMenuColorTable : ProfessionalColorTable
        {
            public override Color MenuItemBorder
            {
                get { return Color.FromArgb(30, 30, 30); }
            }

            public override Color MenuBorder  //added for changing the menu border
            {
                get { return Color.FromArgb(30, 30, 30); }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(30, 30, 30); }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(30, 30, 30); }
            }

            public override Color ToolStripBorder
            {
                get { return Color.FromArgb(30, 30, 30); }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(30, 30, 30); }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(30, 30, 30); }
            }

            public override Color ToolStripDropDownBackground
            {
                get { return Color.FromArgb(30, 30, 30); }
            }

            public override Color ToolStripGradientBegin
            {
                get { return Color.FromArgb(30, 30, 30); }
            }

            public override Color ToolStripGradientEnd
            {
                get { return Color.FromArgb(30, 30, 30); }
            }

            public override Color ToolStripGradientMiddle
            {
                get { return Color.FromArgb(30, 30, 30); }
            }
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(62,62,66); }
            }
         
        }
        public static string OSMPATH = "";
        public static string CPCPATH = "";
        private void Home_Load(object sender, EventArgs e)

        {
            dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();

            dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            dockPanel.DockBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dockPanel.DockBottomPortion = 150D;
            dockPanel.DockLeftPortion = 200D;
            dockPanel.DockRightPortion = 200D;
            dockPanel.DockTopPortion = 150D;
            dockPanel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            dockPanel.Location = new System.Drawing.Point(0, 61);
            dockPanel.Name = "dockPanel";
            dockPanel.Padding = new System.Windows.Forms.Padding(6);
            dockPanel.RightToLeftLayout = true;
            dockPanel.ShowAutoHideContentOnHover = false;
            dockPanel.Size = new System.Drawing.Size(810, 455);
            dockPanel.TabIndex = 12;
            dockPanel.Theme = this.vS2015DarkTheme1;
            this.panel1.Controls.Add(dockPanel);
            SetSchema(this.vS2015DarkTheme1, null);
           
          string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "OSMaker.config");

        

            CloseAllContents();

            CreateStandardControls();
            m_propertyWindow.Show(dockPanel, DockState.DockRight);

            m_solutionExplorer.Show(m_propertyWindow.Pane, DockAlignment.Top, 0.5) ;


            m_toolbox.Show(dockPanel, DockState.DockLeftAutoHide);
            m_sortie.Show(dockPanel, DockState.DockBottomAutoHide);
            m_sortie.Text = "Sortie";


           

            dockPanel.ResumeLayout(true, true);

            Accueil MonAccueil = CreateNewAccueil();
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                MonAccueil.MdiParent = this;
                MonAccueil.Show();
            }
            else
                MonAccueil.Show(dockPanel);
        }
        private IDockContent FindDocument(string text)
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                    if (form.Text == text)
                        return form as IDockContent;

                return null;
            }
            else
            {
                foreach (IDockContent content in dockPanel.Documents)
                    if (content.DockHandler.TabText == text)
                        return content;

                return null;
            }
        }

        public  Doc CreateNewDocument()
        {
            Doc dummyDoc = new Doc();

            int count = 1;
            string text = $"Document{count}";
            while (FindDocument(text) != null)
            {
                count++;
                text = $"Document{count}";
            }

            dummyDoc.Text = text;
            return dummyDoc;
        }
        private Exporter.formulaire.Form1 NewExporterEnOSM()
        {
            Exporter.formulaire.Form1 exporter = new Exporter.formulaire.Form1();

            int count = 1;
            string text = "Exporter en OSM";
           

            exporter.Text = text;
            return exporter;
        }
        private EditeurCCplus CreateNewConcepteur()
        {
           EditeurCCplus Concepteurr = new EditeurCCplus();

            int count = 1;
            string text = $"Document{count}";
            while (FindDocument(text) != null)
            {
                count++;
                text = $"Document{count}";
            }

            Concepteurr.Text = text;
            Concepteurr.Font = new Font("Microsoft Sans Serif", 7);
           // Concepteurr. = new Font("Microsoft Sans Serif", 7);
            return Concepteurr;
        }
        private Accueil CreateNewAccueil()
        {
            Accueil MonAccueil = new Accueil();
          

            MonAccueil.Text = "Accueil";
            MonAccueil.Font = new Font("Microsoft Sans Serif", 7);
           
            return MonAccueil;
        }
        public static string fileName = null;
        private OuvrirConcepteur OuvrirConcepteur()
        {
            OuvrirConcepteur Concepteurr = new OuvrirConcepteur();


          
            // Concepteurr. = new Font("Microsoft Sans Serif", 7);
            return Concepteurr;
        }
        // NOUVEAU DOCUMENT
        private Doc CreateNewDocument(string text)
        {
            Doc dummyDoc = new Doc();
            dummyDoc.Text = text;
            return dummyDoc;
        }
        // EXPORTER
        private Exporter.formulaire.Form1 NewExporterEnOSM(string text)
        {
           Exporter.formulaire.Form1 exporter = new Exporter.formulaire.Form1();
            exporter.Text = text;
            return exporter;
        }
        // NOUVELLE FENETRE
        private EditeurCCplus CreateNewConcepteur(string text)
        {
            EditeurCCplus concepteurr = new EditeurCCplus();
            concepteurr.Text = text;
            return concepteurr;
        }
        // OUVRIR FENETRE
        private OuvrirConcepteur OuvrirConcepteur(string text)
        {
            OuvrirConcepteur concepteurr = new OuvrirConcepteur();
            concepteurr.Text = text;
            return concepteurr;
        }
        // TOUT FERMER
        private void CloseAllDocuments()
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                    form.Close();
            }
            else
            {
                foreach (IDockContent document in dockPanel.DocumentsToArray())
                {
                    // IMPORANT: dispose all panes.
                    document.DockHandler.DockPanel = null;
                    document.DockHandler.Close();
                }
            }
        }

        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(SolutionExplorer).ToString())
                return m_solutionExplorer;
            else if (persistString == typeof(PropertyWindow).ToString())
                return m_propertyWindow;
            else if (persistString == typeof(Toolbox).ToString())
                return m_toolbox;
            else if (persistString == typeof(Sortie).ToString())
                return m_sortie;
            
            else
            {
                // DummyDoc overrides GetPersistString to add extra information into persistString.
                // Any DockContent may override this value to add any needed information for deserialization.

                string[] parsedStrings = persistString.Split(new char[] { ',' });
                if (parsedStrings.Length != 3)
                    return null;

                if (parsedStrings[0] != typeof(Doc).ToString())
                    return null;

                Doc dummyDoc = new Doc();
                if (parsedStrings[1] != string.Empty)
                    dummyDoc.FileName = parsedStrings[1];
                if (parsedStrings[2] != string.Empty)
                    dummyDoc.Text = parsedStrings[2];

                return dummyDoc;
            }
        }

        private void CloseAllContents()
        {
            // we don't want to create another instance of tool window, set DockPanel to null
            m_solutionExplorer.DockPanel = null;
            m_propertyWindow.DockPanel = null;
            m_toolbox.DockPanel = null;
            //m_outputWindow.DockPanel = null;
           // m_taskList.DockPanel = null;

            // Close all other document windows
            CloseAllDocuments();

            // IMPORTANT: dispose all float windows.
            foreach (var window in dockPanel.FloatWindows.ToList())
                window.Dispose();

            System.Diagnostics.Debug.Assert(dockPanel.Panes.Count == 0);
            System.Diagnostics.Debug.Assert(dockPanel.Contents.Count == 0);
            System.Diagnostics.Debug.Assert(dockPanel.FloatWindows.Count == 0);
        }

        private readonly ToolStripRenderer _toolStripProfessionalRenderer = new ToolStripProfessionalRenderer();
        private void SetSchema(object sender, System.EventArgs e)
        {
           // Persist settings when rebuilding UI
           //string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "OSMaker.temp.config");

           //dockPanel.SaveAsXml(configFile);
            CloseAllContents();

            //if (sender == this.menuItemSchemaVS2005)
            //{
            //   dockPanel.Theme = this.vS2005Theme1;
            //    this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2005, vS2005Theme1);
            //}
            //else if (sender == this.menuItemSchemaVS2003)
            //{
            //    dockPanel.Theme = this.vS2003Theme1;
            //    this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2003, vS2003Theme1);
            //}
            //else if (sender == this.menuItemSchemaVS2012Light)
            //{
            //    dockPanel.Theme = this.vS2012LightTheme1;
            //    this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2012, vS2012LightTheme1);
            //}
            //else if (sender == this.menuItemSchemaVS2012Blue)
            //{
            //    dockPanel.Theme = this.vS2012BlueTheme1;
            //    this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2012, vS2012BlueTheme1);
            //}
            //else if (sender == this.menuItemSchemaVS2012Dark)
            //{
            //    dockPanel.Theme = this.vS2012DarkTheme1;
            //    this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2012, vS2012DarkTheme1);
            //}
            //else if (sender == this.menuItemSchemaVS2013Blue)
            //{
            //    dockPanel.Theme = this.vS2013BlueTheme1;
            //    this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2013, vS2013BlueTheme1);
            //}
            //else if (sender == this.menuItemSchemaVS2013Light)
            //{
            //    dockPanel.Theme = this.vS2013LightTheme1;
            //    this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2013, vS2013LightTheme1);
            //}
            //else if (sender == this.menuItemSchemaVS2013Dark)
            //{
            //    dockPanel.Theme = this.vS2013DarkTheme1;
            //    this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2013, vS2013DarkTheme1);
            //}
            //else if (sender == this.menuItemSchemaVS2015Blue)
            //{
            //    dockPanel.Theme = this.vS2015BlueTheme1;
            //    this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, vS2015BlueTheme1);
            //}
            //else if (sender == this.menuItemSchemaVS2015Light)
            //{
            //    dockPanel.Theme = this.vS2015LightTheme1;
            //    this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, vS2015LightTheme1);
            //}
            //else if (sender == this.menuItemSchemaVS2015Dark)
            //{
            //    dockPanel.Theme = this.vS2015DarkTheme1;
            //    this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, vS2015DarkTheme1);
            //}

            //menuItemSchemaVS2005.Checked = (sender == menuItemSchemaVS2005);
            //menuItemSchemaVS2003.Checked = (sender == menuItemSchemaVS2003);
            //menuItemSchemaVS2012Light.Checked = (sender == menuItemSchemaVS2012Light);
            //menuItemSchemaVS2012Blue.Checked = (sender == menuItemSchemaVS2012Blue);
            //menuItemSchemaVS2012Dark.Checked = (sender == menuItemSchemaVS2012Dark);
            //menuItemSchemaVS2013Light.Checked = (sender == menuItemSchemaVS2013Light);
            //menuItemSchemaVS2013Blue.Checked = (sender == menuItemSchemaVS2013Blue);
            //menuItemSchemaVS2013Dark.Checked = (sender == menuItemSchemaVS2013Dark);
            //menuItemSchemaVS2015Light.Checked = (sender == menuItemSchemaVS2015Light);
            //menuItemSchemaVS2015Blue.Checked = (sender == menuItemSchemaVS2015Blue);
            //menuItemSchemaVS2015Dark.Checked = (sender == menuItemSchemaVS2015Dark);
            if (dockPanel.Theme.ColorPalette != null)
            {
                
            }

            //if (File.Exists(configFile))
            //    dockPanel.LoadFromXml(configFile, m_deserializeDockContent);
        }

        private void EnableVSRenderer(VisualStudioToolStripExtender.VsVersion version, ThemeBase theme)
        {
            vsToolStripExtender1.SetStyle(mainMenu, version, theme);
           
            
        }

        private void SetDocumentStyle(object sender, System.EventArgs e)
        {
            DocumentStyle oldStyle = dockPanel.DocumentStyle;
            DocumentStyle newStyle;
          
                newStyle = DocumentStyle.SystemMdi;

            if (oldStyle == newStyle)
                return;

            if (oldStyle == DocumentStyle.SystemMdi || newStyle == DocumentStyle.SystemMdi)
                CloseAllDocuments();

            dockPanel.DocumentStyle = newStyle;
            
            menuItemLayoutByCode.Enabled = (newStyle != DocumentStyle.SystemMdi);
            menuItemLayoutByXml.Enabled = (newStyle != DocumentStyle.SystemMdi);
        
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            Doc Doc = CreateNewDocument();
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                Doc.MdiParent = this;
                Doc.Show();
            }
            else
                Doc.Show(dockPanel);
        }

        private void menuItemSolutionExplorer_Click(object sender, EventArgs e)
        {
            m_solutionExplorer.Show(dockPanel);
        }

        private void menuItemPropertyWindow_Click(object sender, EventArgs e)
        {
            m_propertyWindow.Show(dockPanel);
        }

        private void menuItemToolbox_Click(object sender, EventArgs e)
        {
            m_toolbox.Show(dockPanel);
        }

        private void menuItemOutputWindow_Click(object sender, EventArgs e)
        {
            //m_outputWindow.Show(dockPanel);
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.InitialDirectory = Application.ExecutablePath;
            openFile.Filter = "cpc files (*.cpc)|*.cpc";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string fullName = openFile.FileName;
                string fileName = Path.GetFileName(fullName);

                if (FindDocument(fileName) != null)
                {
                    MessageBox.Show("Le document: " + fileName + " est déjà ouvert !");
                    return;
                }

                Doc dummyDoc = new Doc();
                dummyDoc.Text = fileName;
                if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
                {
                    dummyDoc.MdiParent = this;
                    dummyDoc.Show();
                }
                else
                    dummyDoc.Show(dockPanel);
                try
                {
                    dummyDoc.FileName = fullName;
                }
                catch (Exception exception)
                {
                    dummyDoc.Close();
                    MessageBox.Show(exception.Message);
                }

            }
        }

        private void menuItemLayoutByCode_Click(object sender, EventArgs e)
        {
            dockPanel.SuspendLayout(true);

            CloseAllContents();

            CreateStandardControls();

            m_solutionExplorer.Show(dockPanel, DockState.DockRight);
            m_propertyWindow.Show(m_solutionExplorer.Pane, m_solutionExplorer);
            m_toolbox.Show(dockPanel, DockState.DockLeft);
            m_sortie.Show(dockPanel, DockState.DockBottom);
            

            Doc doc1 = CreateNewDocument("Document1");
            Doc doc2 = CreateNewDocument("Document2");
            Doc doc3 = CreateNewDocument("Document3");
            Doc doc4 = CreateNewDocument("Document4");
            doc1.Show(dockPanel, DockState.Document);
            doc2.Show(doc1.Pane, null);
            doc3.Show(doc1.Pane, DockAlignment.Bottom, 0.5);
            doc4.Show(doc3.Pane, DockAlignment.Right, 0.5);

            dockPanel.ResumeLayout(true, true);
        }

        private void menuItemTaskList_Click(object sender, EventArgs e)
        {
           EditeurCCplus concepteur = CreateNewConcepteur();
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                concepteur.MdiParent = this;
                concepteur.Show();
            }
            else
                concepteur.Show(dockPanel);
        }

        private void ouvrirUnDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirConcepteur concepteur = new OuvrirConcepteur();
            concepteur.Text = fileName;
            // Open File Dialog
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = "osm";
            dlg.Filter = "OSM Files|*.osm";
            if (dlg.ShowDialog() == DialogResult.OK)
                fileName = dlg.FileName;
            string nomfichier = dlg.SafeFileName;
            string text = fileName;
            if (FindDocument(nomfichier) != null)
            {
                MessageBox.Show("Le document: " + fileName + " est déjà ouvert, il sera ouvert une seconde fois !");


            }
            else
            {
                concepteur.Text = nomfichier;
                concepteur.Font = new Font("Microsoft Sans Serif", 7);
                if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
                {
                    concepteur.MdiParent = this;
                    concepteur.Show();
                }
                else
                {
                    concepteur.Show(dockPanel);
                }
            }
        }

        private void exporterCCAuFormatOSMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
      

        }

        private void menuItemSchemaVS2012Dark_Click(object sender, EventArgs e)
        {

        }

        private void menuItemLayoutByXml_Click(object sender, EventArgs e)
        {

        }

        private void exporterCCAuFormatOSMToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void ouvrirUnDocumentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "OSMaker.config");
            
            if (m_bSaveLayout)
                dockPanel.SaveAsXml(configFile);
            else if (File.Exists(configFile))
                File.Delete(configFile);

            Application.Exit();

        }

        private void menuItemLayoutByXml_Click_1(object sender, EventArgs e)
        {
            dockPanel.SuspendLayout(true);

            // In order to load layout from XML, we need to close all the DockContents
            CloseAllContents();

            CreateStandardControls();
          
            Assembly assembly = Assembly.GetAssembly(typeof(Home));
            Stream xmlStream = assembly.GetManifestResourceStream("OSMaker.Resources.DockPanel.xml");
            dockPanel.LoadFromXml(xmlStream, m_deserializeDockContent);
            xmlStream.Close();

            dockPanel.ResumeLayout(true, true);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuItemClose_Click(object sender, EventArgs e)
        {
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "OSMaker.config");

            dockPanel.SaveAsXml(configFile);
        }

        private void fichierCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exporter.formulaire.Form1 exporter = NewExporterEnOSM();
            Exporter.formulaire.Form1._hostSurfaceManager.AddService(typeof(IToolboxService), Home.m_toolbox.toolbox1);
            Exporter.formulaire.Form1._hostSurfaceManager.AddService(typeof(PropertyGrid), Home.m_propertyWindow.propertyGrid);
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                exporter.MdiParent = this;
                exporter.Show();
            }
            else
                exporter.Show(dockPanel);
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirConcepteur concepteur = new OuvrirConcepteur();
            concepteur.Text = fileName;
            // Open File Dialog
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = "osm";
            dlg.Filter = "OSM Files|*.osm";
            if (dlg.ShowDialog() == DialogResult.OK)
                fileName = dlg.FileName;
            string nomfichier = dlg.SafeFileName;
            string text = fileName;
            if (FindDocument(nomfichier) != null)
            {
                MessageBox.Show("Le document: " + fileName + " est déjà ouvert, il sera ouvert une seconde fois !");


            }
            else
            {
                concepteur.Text = nomfichier;
                concepteur.Font = new Font("Microsoft Sans Serif", 7);
                if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
                {
                    concepteur.MdiParent = this;
                    concepteur.Show();
                }
                else
                {
                    concepteur.Show(dockPanel);
                }
            }
        }

        private void menuItemSolutionExplorer_Click_1(object sender, EventArgs e)
         
        {
            SolutionExplorer solutionexplo = new SolutionExplorer();
            solutionexplo.Show(dockPanel, DockState.DockRight);
        }

        private void mainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            mainMenu.Capture = true;
            offset = MousePosition;
            original = this.Location;
        }

        private void mainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (!moving)
                return;

            int x = original.X + MousePosition.X - offset.X;
            int y = original.Y + MousePosition.Y - offset.Y;

            this.Location = new Point(x, y);
        }

        private void mainMenu_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            mainMenu.Capture = false;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (!moving)
                return;

            int x = original.X + MousePosition.X - offset.X;
            int y = original.Y + MousePosition.Y - offset.Y;

            this.Location = new Point(x, y);
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            panel3.Capture = false;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            panel3.Capture = true;
            offset = MousePosition;
            original = this.Location;
        }

        private void menuItemPropertyWindow_Click_1(object sender, EventArgs e)
        {
            PropertyWindow propertyWindow = new PropertyWindow();
            propertyWindow.Show(dockPanel, DockState.DockRight);
        }

        private void menuItemToolbox_Click_1(object sender, EventArgs e)
        {
            Toolbox toolbox = new Toolbox();
            toolbox.Show(dockPanel, DockState.DockLeft);
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           

        }
       
        private void metroButton2_Click(object sender, EventArgs e)
        {
            VM_GUI mv = new VM_GUI();
            mv.Show(dockPanel);
            m_sortie.DockState = DockState.DockBottom;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (panel5.Visible == false)
            {
                panel5.Visible = true;
            }
            else
                panel5.Visible = false;
        }
        VM_GUI mv = new VM_GUI();
        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (mv.Visible == false)
                { mv.Show(dockPanel); }
                else
                { mv.Hide(); }
                //mv.Show(dockPanel);
              //  mv.CloseBu;
                m_sortie.DockState = DockState.DockBottom;
                mv.fLauchBtn(metroFichierMV.Text); ;
                panel6.Visible = true;
            }
            catch
            {

            }

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
           // mv.Stop();
            panel6.Visible = false;
           
            mv.Hide();
           
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
          //  mv.Show();
          //  mv.EditDrive(metroFichierDisk.Text);
        }
    }



        #region Event Handlers
    }

#endregion