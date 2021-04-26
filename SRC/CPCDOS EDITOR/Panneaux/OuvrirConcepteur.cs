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

namespace OSMaker.Panneaux
{
    public partial class OuvrirConcepteur : DocumentC
    {
        public OuvrirConcepteur()
        {
            InitializeComponent();
        }
        private Host.HostSurfaceManager _hostSurfaceManager;
        private Host.HostControl HostC;
        public System.ComponentModel.Design.IMenuCommandService MenuCommandService;
        public System.ComponentModel.Design.ISelectionService SelectionService;
        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                string fileName = null;

                // Open File Dialog
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.DefaultExt = "xml";
                dlg.Filter = "Xml Files|*.xml";
                if (dlg.ShowDialog() == DialogResult.OK)
                    fileName = dlg.FileName;

                if (fileName == null)
                    return;

                // Create Form
                _hostSurfaceManager = new Host.HostSurfaceManager();
                 HostC = _hostSurfaceManager.GetNewHost(fileName);
                //Toolbox.DesignerHost = hc.DesignerHost;
             

          

                HostC.Parent = _Panel1;
                HostC.Dock = DockStyle.Fill;
                _hostSurfaceManager.AddService(typeof(IToolboxService), Home.m_toolbox.toolbox1);
                _hostSurfaceManager.AddService(typeof(PropertyGrid), Home.m_propertyWindow.propertyGrid);

            }
            catch
            {
                MessageBox.Show("Error in creating new host", "Shell Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void OuvrirConcepteur_Load(object sender, EventArgs e)
        {
            try
            {

                if (Home.fileName == null)
                    return;

                // Create Form
                _hostSurfaceManager = new Host.HostSurfaceManager();
                HostC = _hostSurfaceManager.GetNewHost(Home.fileName);
                //Toolbox.DesignerHost = hc.DesignerHost;

                metroFichierXml.Text = Home.fileName;

                metroButton2.Visible = false;
                HostC.Parent = _Panel1;
                HostC.Dock = DockStyle.Fill;
                _hostSurfaceManager.AddService(typeof(IToolboxService), Home.m_toolbox.toolbox1);
                _hostSurfaceManager.AddService(typeof(PropertyGrid), Home.m_propertyWindow.propertyGrid);

            }
            catch
            {
                MessageBox.Show("Error in creating new host", "Shell Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
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
            FastColoredTextBox1.Text = code;
            _tb.Text = WinToCpcDosCplus.ModuleCpcDosCplus.tbS;
            string fileName = metroFichierXml.Text;
            string codeccplus = _tb.Text;
            string fileNameC = metroFichierCCPlus.Text;
            if (string.IsNullOrEmpty(metroFichierXml.Text))
            {
                var dlgSaveFile = new SaveFileDialog();
                dlgSaveFile.Filter = "Fichier OSM (.*osm)|*.osm";
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
                try
                {
                    File.WriteAllText(metroFichierXml.Text, code);
                }
                catch
                { }
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.Delete;
            ims.GlobalInvoke(a);
            MenuCommandService.GlobalInvoke(a);

        }

        private void horizontalementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.CenterHorizontally;
            ims.GlobalInvoke(a);
            MenuCommandService.GlobalInvoke(a);
        }

        private void verticalementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuCommandService = new Host.MenuCommandServiceImpl(_hostSurfaceManager);
            System.ComponentModel.Design.IMenuCommandService ims = HostC.HostSurface.GetService(typeof(System.ComponentModel.Design.IMenuCommandService)) as System.ComponentModel.Design.IMenuCommandService;
            var a = System.ComponentModel.Design.StandardCommands.CenterVertically;
            ims.GlobalInvoke(a);
            MenuCommandService.GlobalInvoke(a);
        }
    }
    }

