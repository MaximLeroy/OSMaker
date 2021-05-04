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
    public partial class IUGConceptor : DocumentC
    {
        public IUGConceptor()
        {

           
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


        public System.ComponentModel.Design.IComponentChangeService componentChangeService;

        private void EditeurCCplus_Load(object sender, EventArgs e)
        {
            try
            {

                if (Home.fileName == null)
                {
                    _formCount += 1;
                    HostC = _hostSurfaceManager.GetNewHost(typeof(Form), Host.LoaderType.BasicDesignerLoader);
                  
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
        #region commandes
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
        #endregion commandes

        private void ButtonItem1_Click(object sender, EventArgs e)
        {
            //FastColoredTextBox1.Text = ((Loader.BasicHostLoader)HostC.HostSurface.Loader).GetCode();
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


        private void metroButton2_Click(object sender, EventArgs e)
        {
         ToolBox.TextBlock b1 = (ToolBox.TextBlock)HostC.CreateControl(typeof(ToolBox.TextBlock), new Size(200, 40), new Point(10, 10));
            
        }

      
        private void metroButton1_Click(object sender, EventArgs e)
        {

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

        private void metroButton17_Click(object sender, EventArgs e)
        {

        }

        private void metroButton18_Click(object sender, EventArgs e)
        {

        }
    }
}