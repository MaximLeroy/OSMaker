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
using WinToCpcDosCplus;
using OSMaker.Panneaux;
namespace OSMaker.Panneaux
{
    public partial class Concepteur : DocumentC
    {
        public Concepteur()
        {
            InitializeComponent();

        }
        private Host.HostSurfaceManager _hostSurfaceManager;
        private int _formCount = 0;
        private Host.HostControl HostC;
        private bool tbFindChanged = false;
        private DateTime lastNavigatedDateTime = DateTime.Now;
        [CLSCompliant(false)]
        public Host.Designer Designer = new Host.Designer(My.MySettingsProperty.Settings.Afficher_La_Griller, true, My.MySettingsProperty.Settings.Aimentation_Intelligente, true, My.MySettingsProperty.Settings.Smart_Tags, true, My.MySettingsProperty.Settings.Afficher_La_Griller);
        public System.ComponentModel.Design.IComponentChangeService componentChangeService;
        private XmlDocument doc;
        private Dictionary<string, string> WinToCpcControls;
        private Dictionary<string, string> CpcDebutToFins;
        private StringBuilder sb;
        public System.ComponentModel.Design.IMenuCommandService MenuCommandService;
        public System.ComponentModel.Design.ISelectionService SelectionService;
       private Panneaux.Toolbox toolboxx;
      //  private Panneaux.Toolbox = new Panneaux.Toolbox
         private  Panneaux.PropertyWindow propertyx;
       // propertyx = new Panneaux.PropertyWindow();
        private void EditeurCode_Load(object sender, EventArgs e)

        {
            try
            {
                _formCount += 1;
                HostC = _hostSurfaceManager.GetNewHost(typeof(Form), Host.LoaderType.BasicDesignerLoader);
                // AddTabForNewHost("Form" & _formCount.ToString() & " - " & Strings.Design)
                HostC.Parent = panel1;
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
            _hostSurfaceManager.AddService(typeof(IToolboxService), toolboxx.toolbox1);
            _hostSurfaceManager.AddService(typeof(PropertyGrid), propertyx.propertyGrid);
        }

        private void AddTabForNewHost(string tabText)
        {
            System.ComponentModel.Design.IServiceContainer serviceContainer;
            toolboxx.toolbox1.DesignerHost = HostC.DesignerHost;
            // Dim tabpage As TabPage = New TabPage(tabText)
            // TabPage.Tag = CurrentMenuSelectionLoaderType
            HostC.Parent = panel1;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)

        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
