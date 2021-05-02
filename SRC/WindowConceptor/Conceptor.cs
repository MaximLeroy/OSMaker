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
using OSMaker;

namespace WindowConceptor
{
    public partial class Conceptor : DocumentC
    {
        public Conceptor()
        {
            InitializeComponent();
            CustomInitialize();



          
        }
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
        public static Host.HostControl3 HostC;
        private XmlDocument doc;
        private Dictionary<string, string> WinToCpcControls;
        private Dictionary<string, string> CpcDebutToFins;
        private StringBuilder sb;
        public System.ComponentModel.Design.IMenuCommandService MenuCommandService;
        public System.ComponentModel.Design.ISelectionService SelectionService;
        public static string metroFichierEvent = "";
        public static string _selection = "";

        private void CustomInitialize()
        {

            _hostSurfaceManager = new Host.HostSurfaceManager();
            _hostSurfaceManager.AddService(typeof(IToolboxService), Home.m_toolbox.toolbox1);
            _hostSurfaceManager.AddService(typeof(PropertyGrid), Home.m_propertyWindow.propertyGrid);

            //MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            //HostC.DesignerHost.AddService(typeof(System.ComponentModel.Design.MenuCommandService), MenuCommandService);
            //   _hostSurfaceManager.AddService(typeof(System.ComponentModel.Design.UndoEngine), undoEngine);

        }
        private void Conceptor_Load(object sender, EventArgs e)
        {
            try
            {

                if (Home.fileName == null)
                {
                    _formCount += 1;
                    HostC = _hostSurfaceManager.GetNewHost(typeof(Form), Host.LoaderType.BasicDesignerLoader);
                    // AddTabForNewHost("Form" & _formCount.ToString() & " - " & Strings.Design)
                    HostC.Parent = _Panel1;
                    HostC.Dock = DockStyle.Fill;


                    ToolBox.Window b1 = (ToolBox.Window)HostC.CreateControl(typeof(ToolBox.Window), new Size(50, 50), new Point(10, 10));
                    b1.Dock = DockStyle.Fill;
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

        #region Commandes
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
        #endregion Commandes

        private void testToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void horizontalementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void verticalementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void mouseClickToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sélectionnerToutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void metroButton18_Click(object sender, EventArgs e)
        {

        }

        private void metroButton11_Click(object sender, EventArgs e)
        {

        }

        private void metroButton12_Click(object sender, EventArgs e)
        {

        }

        private void metroButton13_Click(object sender, EventArgs e)
        {

        }

        private void metroButton14_Click(object sender, EventArgs e)
        {

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {

        }

        private void metroButton8_Click(object sender, EventArgs e)
        {

        }

        private void metroButton9_Click(object sender, EventArgs e)
        {

        }

        private void metroButton10_Click(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void sélectionnerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void annulerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
