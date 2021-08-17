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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using WeifenLuo.WinFormsUI.Docking;
using System.Reflection;
using OSMaker.Panneaux;
using Exporter.Controls;
using Exporter;
using System.Drawing.Design;


namespace OSMaker.Panneaux
{
    public partial class SolutionExplorer : ToolWindow
    {
        public Home monhome { get; set; }

        public SolutionExplorer()
        {
            InitializeComponent();
        }
        public void Recharger()
        {
            try
            {


                _tv.Nodes.Clear();
                LoadDirectory(txtDirectory.Text);
                txtDirectory.Style = MetroFramework.MetroColorStyle.Green;

            }
            catch
            {
                MessageBox.Show("Veuillez renseigner un chemin de dossier valide");
            }
        }
        public void Renommer()
        {
            {
                if (mySelectedNode is object && mySelectedNode.Parent is object)
                {
                    _tv.SelectedNode = mySelectedNode;
                    _tv.LabelEdit = true;
                    if (!mySelectedNode.IsEditing)
                    {
                        mySelectedNode.BeginEdit();
                    }
                }
                else
                {
                    MessageBox.Show("No tree node selected or selected node is a root node." + Constants.vbLf + "Editing of root nodes is not allowed.", "Invalid selection");
                }
            }
        }
        public void NouveauDossier()
        {
            try
            {
                var node = _tv.SelectedNode;
                string oldPathDir = node.Text;
                if (oldPathDir.ToLower().Contains(".txt") || oldPathDir.ToLower().Contains(".osm") || oldPathDir.ToLower().Contains(".cpc"))
                {
                    MessageBox.Show("Veuillez sélectionner un dossier et non un fichier");
                }
                else
                {
                    if (_tv.SelectedNode is null)
                        return;
                    var selNode = _tv.SelectedNode;
                    string pathDir = Conversions.ToString(selNode.Tag);
                    var di = new DirectoryInfo(pathDir);

                    // add subdirectory to  di
                    string newDirectoryName = GetNewFolderName(di);

                    // Adds new node as a child node of the currently selected node.
                    var newNode = new TreeNode(newDirectoryName);
                    newNode.Tag = di.FullName + @"\\" + newDirectoryName;
                    newNode.ImageKey = "NewFolder";
                    newNode.StateImageIndex = 0;
                    selNode.Nodes.Add(newNode);
                }
            }
            catch
            {


            }
        }
        public void OuvrirFolderBrowser()
        {
            try
            {
                var dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtDirectory.Text = dlg.SelectedPath;
                    _tv.Nodes.Clear();
                    LoadDirectory(txtDirectory.Text);
                    txtDirectory.Style = MetroFramework.MetroColorStyle.Green;
                }
            }
            catch
            {

            }
        }

        public void Supprimer()
        {
            if (_tv.SelectedNode is null)
                return;
            var selNode = _tv.SelectedNode;
            string pathDir = Conversions.ToString(selNode.Tag);
            if (pathDir.ToLower().Contains("cpc") || pathDir.ToLower().Contains("osm"))
            {
                var fi = new FileInfo(pathDir);
                fi.Delete();
            }
            else
            {
                var di = new DirectoryInfo(pathDir);
                di.Delete(true);
            }

            // Removes currently selected node
            _tv.Nodes.Remove(selNode);
        }
        protected override void OnRightToLeftLayoutChanged(EventArgs e)
        {
            _tv.RightToLeftLayout = RightToLeftLayout;
        }
        private void SolutionExplorer_Load(object sender, EventArgs e)
        {
            this.Size = new Size(316, 579);
        }
        private object path = "E:/";
        private DocumentC FindDocument(string text)
        {
            if (Home.dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                    if (form.Text == text)
                        return form as DocumentC;

                return null;
            }
            else
            {
                foreach (DocumentC content in Home.dockPanel.Documents)
                    if (content.DockHandler.TabText == text)
                    {
                        content.DockHandler.Show(Home.dockPanel);
                        return content;
                    }

                return null;
            }
        }
        private IDockContent FindMetroDocument(string text)
        {
            if (Home.dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (MetroFramework.Forms.MetroForm form in MdiChildren)
                    if (form.Text == text)
                        return form as IDockContent;

                return null;
            }
            else
            {
                foreach (IDockContent content in Home.dockPanel.Documents)
                    if (content.DockHandler.TabText == text)
                    {
                        content.DockHandler.Show(Home.dockPanel);
                        return content;
                    }

                return null;
            }
        }
      
        public string GetNewFileNameCPC(DirectoryInfo di)
        {
            string newItem = "IUG";
            var files = Directory.GetFiles(di.FullName, "*.cpc");
            string fileName = di.FullName + @"\" + newItem;
            int countFile = 0;
            if (files.Length == 0)
            {
                countFile = 1;
            }
            else
            {
                countFile = files.Length + 1;
            }

            fileName += countFile.ToString() + ".cpc";
            var fi = new FileInfo(fileName);

            // Create a file .
            using (var sw = fi.CreateText())
            {
                
                sw.WriteLine("Window/ IUG");
                sw.WriteLine("Create/");
                sw.WriteLine("End/ Window");
            }

            newItem += countFile.ToString() + ".cpc";
            return newItem;
        }

        public string GetNewFileNameXML(DirectoryInfo di)
        {
          

            string newItem = "IUG";
            var files = Directory.GetFiles(di.FullName, "*.osm");
            string fileName = di.FullName + @"\" + newItem;
            int countFile = 0;
            if (files.Length == 0)
            {
                countFile = 1;
            }
            else
            {
                countFile = files.Length + 1;
            }

            fileName += countFile.ToString() + ".osm";
            var fi = new FileInfo(fileName);

          

            newItem += countFile.ToString() + ".osm";
            return newItem;
        }
        private string GetNewFolderName(DirectoryInfo di)
        {



            // it is a fileInfo
            string newFolder = "Nouveau Dossier";
            var subdirs = Directory.GetDirectories(di.FullName, newFolder + "*");
            string dirName = di.FullName + @"\\" + newFolder;
            int countDir = 0;
            if (subdirs.Length == 0)
            {
                countDir = 1;
            }
            else
            {
                countDir = subdirs.Length + 1;
            }

            dirName += countDir.ToString();
            var newDir = new DirectoryInfo(dirName);

            // Create a  directory
            newDir.Create();
            newFolder += countDir.ToString();
            return newFolder;
        }
        private void RenameItem(TreeNode node, string newLabel)
        {
            string oldPathDir = Conversions.ToString(node.Tag);
            if (oldPathDir.Contains("txt") || oldPathDir.Contains("xml") || oldPathDir.Contains("cpc")) // it is a fileInfo
            {
                var srcFi = new FileInfo(oldPathDir);
                string srcDircName = srcFi.FullName;
                int index = srcDircName.LastIndexOf('\\');
                string partDirName = srcDircName.Remove(index);
                string dstDirName = partDirName + @"\\" + newLabel;
                if (!srcDircName.Equals(dstDirName))
                {
                    Directory.Move(srcDircName, dstDirName); // move source to destination 
                    _tv.Nodes.Clear();
                    LoadDirectory(txtDirectory.Text);

                    // CODE A VIRER
                    // srcFi.MoveTo(dstFileName);

                    // srcFi.Delete();

                } // it is a directorinfo
            }
            else
            {
                var srcDir = new DirectoryInfo(oldPathDir);
                string srcDirName = srcDir.FullName;
                int index = srcDirName.LastIndexOf('\\');
                string partDirName = srcDirName.Remove(index);
                string dstDirName = partDirName + @"\\" + newLabel;
                if (!srcDirName.Equals(dstDirName))
                {
                    Directory.Move(srcDirName, dstDirName); // move source to destination 
                    _tv.Nodes.Clear();
                    LoadDirectory(txtDirectory.Text);

                    // CODE A VIRER

                    // srcDir.MoveTo(dstDirName);

                    // srcDir.Delete(true);
                }
            }
        }
        public void LoadDirectory(string dir)
        {

            progressBar1.Value = 25;
            progressBar1.Text = "Load Directory étape 1/4";
            var di = new DirectoryInfo(dir);
            var newNode = _tv.Nodes.Add(di.Name);
            newNode.Tag = di.FullName;
            newNode.StateImageIndex = 0;
            progressBar1.Value = 50;
            progressBar1.Text = "Load Directory étape 2/4";
            LoadFiles(dir, newNode);
            progressBar1.Text = "Load Directory étape 3/4";
            progressBar1.Value = 75;
            LoadSubDirectories(dir, newNode);
            progressBar1.Text = "Load Directory étape 4/4";
            progressBar1.Value = 100;
            progressBar1.Text = "Prêt";
        }

        private void LoadSubDirectories(string dir, TreeNode node)
        {
            try
            {
                var subdirectoryEntries = Directory.GetDirectories(dir);
                // Loop through them to see if they have any other subdirectories  
                foreach (var subdirectory in subdirectoryEntries)
                {
                    var di = new DirectoryInfo(subdirectory);
                    var newNnode = node.Nodes.Add(di.Name);
                    newNnode.StateImageIndex = 0;
                    newNnode.Tag = di.FullName;
                    LoadFiles(subdirectory, newNnode);
                    LoadSubDirectories(subdirectory, newNnode);
                }
            }

            catch
            {

            }

        }

        private void LoadFiles(string dir, TreeNode td)
        {
            try
            {
                var CPCfiles = Directory.GetFiles(dir, "*.cpc");
                var OSMfiles = Directory.GetFiles(dir, "*.osm");
                var OVAfiles = Directory.GetFiles(dir, "*.ova");
                var LOGfiles = Directory.GetFiles(dir, "*.log");
                var LSTfiles = Directory.GetFiles(dir, "*.lst");
                var TXTfiles = Directory.GetFiles(dir, "*.txt");
                // Image files
                var PNGfiles = Directory.GetFiles(dir, "*.png");
                var JPGfiles = Directory.GetFiles(dir, "*.jpg");
                var JPEGfiles = Directory.GetFiles(dir, "*.jpeg");
                var BMPfiles = Directory.GetFiles(dir, "*.bmp");
                // Loop through them to see files  
                foreach (var CPCfile in CPCfiles)
                {
                    var fi = new FileInfo(CPCfile);
                    var tnode = td.Nodes.Add(fi.Name);
                    tnode.Tag = fi.FullName;
                    tnode.StateImageIndex = 1;
                }

                foreach (var OSMfile in OSMfiles)
                {
                    var fi = new FileInfo(OSMfile);
                    var tnode = td.Nodes.Add(fi.Name);
                    tnode.Tag = fi.FullName;
                    tnode.StateImageIndex = 4;

                }
                foreach (var OVAfile in OVAfiles)
                {
                    var fi = new FileInfo(OVAfile);
                    var tnode = td.Nodes.Add(fi.Name);
                    tnode.Tag = fi.FullName;
                    tnode.StateImageIndex = 5;

                }
                foreach (var LOGfile in LOGfiles)
                {
                    var fi = new FileInfo(LOGfile);
                    var tnode = td.Nodes.Add(fi.Name);
                    tnode.Tag = fi.FullName;
                    tnode.StateImageIndex = 6;

                }
                foreach (var LSTfile in LSTfiles)
                {
                    var fi = new FileInfo(LSTfile);
                    var tnode = td.Nodes.Add(fi.Name);
                    tnode.Tag = fi.FullName;
                    tnode.StateImageIndex = 7;

                }
                foreach (var TXTfile in TXTfiles)
                {
                    var fi = new FileInfo(TXTfile);
                    var tnode = td.Nodes.Add(fi.Name);
                    tnode.Tag = fi.FullName;
                    tnode.StateImageIndex = 8;

                }
                //Images files
                foreach (var PNGfile in PNGfiles)
                {
                    var fi = new FileInfo(PNGfile);
                    var tnode = td.Nodes.Add(fi.Name);
                    tnode.Tag = fi.FullName;
                    tnode.StateImageIndex = 9;

                }
                foreach (var JPGfile in JPGfiles)
                {
                    var fi = new FileInfo(JPGfile);
                    var tnode = td.Nodes.Add(fi.Name);
                    tnode.Tag = fi.FullName;
                    tnode.StateImageIndex = 9;

                }
                foreach (var JPEGfile in JPEGfiles)
                {
                    var fi = new FileInfo(JPEGfile);
                    var tnode = td.Nodes.Add(fi.Name);
                    tnode.Tag = fi.FullName;
                    tnode.StateImageIndex = 9;

                }
                foreach (var BMPfile in BMPfiles)
                {
                    var fi = new FileInfo(BMPfile);
                    var tnode = td.Nodes.Add(fi.Name);
                    tnode.Tag = fi.FullName;
                    tnode.StateImageIndex = 9;

                }
            }

            catch
            {
            }
        }

        private void _tv_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void _PictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                var dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtDirectory.Text = dlg.SelectedPath;
                    _tv.Nodes.Clear();
                    LoadDirectory(txtDirectory.Text);
                    txtDirectory.Style = MetroFramework.MetroColorStyle.Green;
                }
            }
            catch
            {

            }
        }

        private void _tv_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.StateImageIndex = 3;
        }

        private void _tv_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.StateImageIndex = 0;
        }

        private void _tv_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            try
            {
                if (!Equals(e.Label, null))
                {
                    if (e.Label.Length > 0)
                    {
                        if (e.Label.IndexOfAny(new char[] { '@', '\\', ',', '!' }) == -1)
                        {
                            // Stop editing without canceling the label change.
                            RenameItem(e.Node, e.Label);
                            e.Node.EndEdit(false);
                        }
                        else
                        {
                            // Cancel the label edit action, inform the user, and 
                            // place the node in edit mode again. 
                            e.CancelEdit = true;
                            MessageBox.Show("Invalid tree node label." + Constants.vbLf + "The invalid characters are: '@','.', ',', '!'", "Node Label Edit");
                            e.Node.BeginEdit();
                        }
                    }
                    else
                    {
                        // Cancel the label edit action, inform the user, and 
                        // place the node in edit mode again. 
                        e.CancelEdit = true;
                        MessageBox.Show("Invalid tree node label." + Constants.vbLf + "The label cannot be blank", "Node Label Edit");
                        e.Node.BeginEdit();
                    }

                    _tv.LabelEdit = false;
                }
            }
            catch { }
        }
        private TreeNode mySelectedNode = null;
        private void _tv_MouseDown(object sender, MouseEventArgs e)
        {
            mySelectedNode = _tv.GetNodeAt(e.X, e.Y);
        }
     
        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_tv.SelectedNode is null)
                return;
            var selNode = _tv.SelectedNode;
            if (selNode.Text.EndsWith("cpc") || selNode.Text.EndsWith("CPC"))
            {
                string pathDir = Conversions.ToString(selNode.Tag);
                var fi = new FileInfo(pathDir);

                // edit file

                {

                    string fullName = fi.FullName;
                    string fileName = Path.GetFileName(fullName);



                    Doc dummyDoc = new Doc();
                    dummyDoc.Text = fileName;
                   
                        dummyDoc.MdiParent = this;
                        dummyDoc.Show();
                    
                        dummyDoc.Show(Home.dockPanel);
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

            if (selNode.Text.EndsWith("osm") || selNode.Text.EndsWith("OSM"))
            {
                string pathDir = Conversions.ToString(selNode.Tag);
                var fi = new FileInfo(pathDir);



                //OuvrirConcepteur concepteur = new OuvrirConcepteur();
                //concepteur.Text = Home.fileName;

                Home.fileName = fi.FullName;
                string nomfichier = fi.Name;
                string text = fi.Name;

                //concepteur.Text = nomfichier + " [Design]";
                //concepteur.Font = new Font("Microsoft Sans Serif", 7);
                if (Home.dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
                {
                   // concepteur.MdiParent = this;
                   // concepteur.Show();
                }
                else
                {
                    //concepteur.Show(Home.dockPanel);
                }

            }
        }


        private void _tv_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (_tv.SelectedNode is null)
                return;
            var selNode = _tv.SelectedNode;
            if (selNode.Text.EndsWith("cpc") || selNode.Text.EndsWith("CPC"))
            {
                if (FindDocument(_tv.SelectedNode.Text) == null)
                {


                    string pathDir = Conversions.ToString(selNode.Tag);
                    var fi = new FileInfo(pathDir);

                    // edit file

                    {

                        string fullName = fi.FullName;
                        string fileName = Path.GetFileName(fullName);



                        Doc dummyDoc = new Doc();
                        dummyDoc.Text = fileName;
                        if (Home.dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
                        {
                            dummyDoc.MdiParent = this;
                            dummyDoc.filepath = fullName;
                            dummyDoc.Show();
                        }
                        else
                            dummyDoc.filepath = fullName;
                        dummyDoc.Show(Home.dockPanel);
                        try
                        {
                            dummyDoc.FileName = fullName;
                            dummyDoc.filepath = fullName;
                        }
                        catch (Exception exception)
                        {
                            dummyDoc.Close();
                            MessageBox.Show(exception.Message);
                        }


                    }
               }
               
            }

            if (selNode.Text.EndsWith("osm") || selNode.Text.EndsWith("OSM"))
            {
                if (FindDocument(_tv.SelectedNode.Text + " [Design]") == null)
                {
                    string pathDir = Conversions.ToString(selNode.Tag);
                    var fi = new FileInfo(pathDir);






                    //   Home.fileName = fi.FullName;
                    IUGConceptor concepteur = new IUGConceptor();

                    string nomfichier = fi.Name;
                    string text = fi.Name;

                    concepteur.Text = nomfichier + " [Design]";
                    concepteur.Font = new Font("Microsoft Sans Serif", 7);

                    if (Home.dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
                    {
                        concepteur.MdiParent = this;
                        concepteur.Show();
                        concepteur.Open_Host(fi.FullName);
                    }
                    else
                    {
                        concepteur.Show(Home.dockPanel);
                        concepteur.Open_Host(fi.FullName);
                        concepteur.metroFichierXml.Text = fi.FullName;
                    }
                }
            }

            if (selNode.Text.EndsWith("png") || selNode.Text.EndsWith("PNG") || selNode.Text.EndsWith("jpg") || selNode.Text.EndsWith("JPG") || selNode.Text.EndsWith("JPEG") || selNode.Text.EndsWith("BMP") || selNode.Text.EndsWith("bmp"))
            {
                string pathDir = Conversions.ToString(selNode.Tag);
                var fi = new FileInfo(pathDir);

                // edit file

                {

                    string fullName = fi.FullName;
                    string fileName = Path.GetFileName(fullName);



                    IMGViewer IMGDoc = new IMGViewer();
                    IMGDoc.Text = fileName;
                    if (Home.dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
                    {
                        IMGDoc.MdiParent = this;

                        //IMGDoc.file = fullName;
                        //Load the image
                        IMGDoc.pictureBox1.Load(fullName);
                        Image img = IMGDoc.pictureBox1.Image;
                        //Adjust the image size after loading it to Picture box
                        if (IMGDoc.pictureBox1.Width < img.Width && IMGDoc.pictureBox1.Height < img.Height)
                        {
                            IMGDoc.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        else
                        {

                            IMGDoc.pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                        }
                        
                        IMGDoc.Show();
                    }
                    else
                        //dummyDoc.filepath = fullName;
                        IMGDoc.pictureBox1.Load(fullName);
                    Image img2 = IMGDoc.pictureBox1.Image;
                    //Adjust the image size after loading it to Picture box
                    if (IMGDoc.pictureBox1.Width < img2.Width && IMGDoc.pictureBox1.Height < img2.Height)
                    {
                        IMGDoc.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {

                        IMGDoc.pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                    }
                    IMGDoc.Show(Home.dockPanel);
                    try
                    {
                        //IMGDoc.FileName = fullName;
                       // Doc.filepath = fullName;
                    }
                    catch (Exception exception)
                    {
                        IMGDoc.Close();
                        MessageBox.Show(exception.Message);
                    }


                }
            }

        }
        private IUGConceptor CreateNewConcepteur(string text)
        {
            IUGConceptor concepteurr = new IUGConceptor();
            concepteurr.Text = text;
            return concepteurr;
        }
        private IUGConceptor CreateNewConcepteur()
        {
            IUGConceptor Concepteurr = new IUGConceptor();

            int count = 1;
            string text = $"IUG{count}";


            Concepteurr.Text = text;
            Concepteurr.Font = new Font("Microsoft Sans Serif", 7);
            // Concepteurr. = new Font("Microsoft Sans Serif", 7);
            return Concepteurr;
        }
        public static string pathXml;
        public static string pathCPC = "";
        public static string pathOSM = "";

        public void New_CPC(string osmpath, string cpcpath, string name)
        {

            var node = _tv.SelectedNode;
            string oldPathDir = node.Text;


            if (_tv.SelectedNode is null)
                return;
            // string pathDir = Conversions.ToString(_tv.SelectedNode.Tag);
            //var di = new DirectoryInfo(pathDir);

            // add file to  di
        

            string newCpcFileName = name + ".cpc";
            // Adds new node as a child node of the currently selected node.
           
            var newCpcNode = new TreeNode(newCpcFileName);
            
            ///
            newCpcNode.Tag = cpcpath;
            //  Home.CPCPATH = newNode.Tag.ToString().Replace(".osm",".cpc");

            newCpcNode.ImageKey = "NewFile";
            newCpcNode.StateImageIndex = 1;
            _tv.SelectedNode.Nodes.Add(newCpcNode);

            _tv.SelectedNode = newCpcNode;

            // Create new document and add it to existing bar


            // Add control to it



            // PanelDockContainer will be used to host any controls. It provides automatic focus management so focused
            // document tab appears bold



        }
        public void New_IUG(string osmpath,string cpcpath, string name)
        {

            var node = _tv.SelectedNode;
            string oldPathDir = node.Text;

           
                if (_tv.SelectedNode is null)
                    return;
            // string pathDir = Conversions.ToString(_tv.SelectedNode.Tag);
            //var di = new DirectoryInfo(pathDir);

            // add file to  di
            string newFileName = name + ".osm";

                string newCpcFileName = name + ".cpc";
                // Adds new node as a child node of the currently selected node.
                var newNode = new TreeNode(newFileName);
                 var newCpcNode = new TreeNode(newCpcFileName);
                newNode.Tag = osmpath;
               // Home.OSMPATH = newNode.Tag.ToString();
                newNode.ImageKey = "NewFile";
                newNode.StateImageIndex = 4;
                _tv.SelectedNode.Nodes.Add(newNode);
                ///
                  newCpcNode.Tag = cpcpath;
                //  Home.CPCPATH = newNode.Tag.ToString().Replace(".osm",".cpc");

                 newCpcNode.ImageKey = "NewFile";
                 newCpcNode.StateImageIndex = 1;
                _tv.SelectedNode.Nodes.Add(newCpcNode);

                _tv.SelectedNode = newNode;

                // Create new document and add it to existing bar


                // Add control to it



                // PanelDockContainer will be used to host any controls. It provides automatic focus management so focused
                // document tab appears bold

               
            
        }
        private void iUGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_tv.SelectedNode.Text.ToLower().Contains(".txt") || _tv.SelectedNode.Text.ToLower().Contains(".osm") || _tv.SelectedNode.Text.ToLower().Contains(".cpc"))
            {
                MessageBox.Show("Veuillez sélectionner un dossier et non un fichier");
            }
            else
            {
                Nouveau nouveau = new Nouveau();
                nouveau.Show();

                Home.fileName = null;
                string pathDir = Conversions.ToString(_tv.SelectedNode.Tag);
                var di = new DirectoryInfo(pathDir);
                nouveau.pathdirectory = di.ToString();
                // add file to  di
                string newFileName = GetNewFileNameXML(di);
                nouveau.pathcpc = di.ToString();
                nouveau.pathosm = di.ToString();
                nouveau.nameccplustextBox.Text = newFileName.Replace(".osm", "");
                nouveau.pathosmtextBox.Text = di.ToString() + newFileName;
                nouveau.pathcpctextBox.Text = di.ToString() + "\\" + newFileName.Replace(".osm", ".cpc");
                nouveau.nameosmtextbox.Text = nouveau.nameccplustextBox.Text;
             

            }
        }
        public void Actualiser()
        {
            try
            {

                _tv.Nodes.Clear();
                LoadDirectory(txtDirectory.Text);
                txtDirectory.Style = MetroFramework.MetroColorStyle.Green;

            }
            catch
            {
                MessageBox.Show("Veuillez renseigner un chemin de dossier valide");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Actualiser();
        }

        private void renommerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            {
                if (mySelectedNode is object && mySelectedNode.Parent is object)
                {
                    _tv.SelectedNode = mySelectedNode;
                    _tv.LabelEdit = true;
                    if (!mySelectedNode.IsEditing)
                    {
                        mySelectedNode.BeginEdit();
                    }
                }
                else
                {
                    MessageBox.Show("No tree node selected or selected node is a root node." + Constants.vbLf + "Editing of root nodes is not allowed.", "Invalid selection");
                }
            }
            
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_tv.SelectedNode is null)
                return;
            var selNode = _tv.SelectedNode;
            string pathDir = Conversions.ToString(selNode.Tag);
            if (pathDir.ToLower().Contains("cpc") || pathDir.ToLower().Contains("osm"))
            {
                var fi = new FileInfo(pathDir);
                fi.Delete();
            }
            else
            {
                var di = new DirectoryInfo(pathDir);
                di.Delete(true);
            }

            // Removes currently selected node
            _tv.Nodes.Remove(selNode);
        }

        private void dossierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var node = _tv.SelectedNode;
                string oldPathDir = node.Text;
                if (oldPathDir.ToLower().Contains(".txt") || oldPathDir.ToLower().Contains(".osm") || oldPathDir.ToLower().Contains(".cpc"))
                {
                    MessageBox.Show("Veuillez sélectionner un dossier et non un fichier");
                }
                else
                {
                    if (_tv.SelectedNode is null)
                        return;
                    var selNode = _tv.SelectedNode;
                    string pathDir = Conversions.ToString(selNode.Tag);
                    var di = new DirectoryInfo(pathDir);

                    // add subdirectory to  di
                    string newDirectoryName = GetNewFolderName(di);

                    // Adds new node as a child node of the currently selected node.
                    var newNode = new TreeNode(newDirectoryName);
                    newNode.Tag = di.FullName + @"" + newDirectoryName;
                    newNode.ImageKey = "NewFolder";
                    newNode.StateImageIndex = 0;
                    selNode.Nodes.Add(newNode);
                }
            }
            catch
            {


            }
            }

        private void fichierCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var node = tv.SelectedNode;
            //string oldPathDir = node.Text;
            //if (oldPathDir.ToLower().Contains(".txt") || oldPathDir.ToLower().Contains(".xml") || oldPathDir.ToLower().Contains(".cpc"))
            //{
            //    MessageBox.Show("Veuillez sélectionner un dossier et non un fichier");
            //}
            //else
            //{
            //    if (tv.SelectedNode is null)
            //        return;
            //    string pathDir = Conversions.ToString(tv.SelectedNode.Tag);
            //    var di = new DirectoryInfo(pathDir);

            //    // add file to  di
            //    string newFileName = GetNewFileNameCPC(di);

            //    // Adds new node as a child node of the currently selected node.
            //    var newNode = new TreeNode(newFileName);
            //    newNode.Tag = di.FullName + @"\\" + newFileName;
            //    newNode.ImageKey = "NewFile";
            //    tv.SelectedNode.Nodes.Add(newNode);
            //    tv.SelectedNode = newNode;
            //    var nouveaunoeud = tv.SelectedNode;
            //    // Create new document and add it to existing bar
            //    var dockItem = new DockContainerItem();
            //    dockItem.Text = nouveaunoeud.Text;

            //    // Add control to it
            //    // var t = new OSMCodeBox();


            //    // PanelDockContainer will be used to host any controls. It provides automatic focus management so focused
            //    // document tab appears bold
            //    var panel = new PanelDockContainer();
            //    // panel.Controls.Add(t);
            //    // t.Dock = DockStyle.Fill;
            //    dockItem.Control = panel;
            //    //  t.LabelItem1.Text = pathDir + @"\" + newFileName;
            //    Bar6.Items.Add(dockItem);
            //    Bar6.SelectedDockContainerItem = dockItem;
            }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_tv.SelectedNode.Text.ToLower().Contains(".txt") || _tv.SelectedNode.Text.ToLower().Contains(".osm") || _tv.SelectedNode.Text.ToLower().Contains(".cpc"))
            {
                MessageBox.Show("Veuillez sélectionner un dossier et non un fichier");
            }
            else
            {
                Nouveau nouveau = new Nouveau();
                nouveau.Show();

                Home.fileName = null;
                string pathDir = Conversions.ToString(_tv.SelectedNode.Tag);
                var di = new DirectoryInfo(pathDir);
                nouveau.pathdirectory = di.ToString();
                // add file to  di
                string newFileName = GetNewFileNameXML(di);
                nouveau.pathcpc = di.ToString();
                nouveau.pathosm = di.ToString();
                nouveau.nameccplustextBox.Text = newFileName.Replace(".osm", "");
                nouveau.pathosmtextBox.Text = di.ToString() + newFileName;
                nouveau.pathcpctextBox.Text = di.ToString() + "\\" + newFileName.Replace(".osm", ".cpc");
                nouveau.nameosmtextbox.Text = nouveau.nameccplustextBox.Text;


            }
        }

        private void SolutionExplorer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
         
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            try
            {
                var dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                   txtDirectory.Text = dlg.SelectedPath;
                   _tv.Nodes.Clear();
                   LoadDirectory(txtDirectory.Text);
                   txtDirectory.Style = MetroFramework.MetroColorStyle.Green;
                    metroButton1.Visible = false;
                    _tv.Visible = true;
                }
            }
            catch
            {

            }
        }

        private void txtDirectory_TextChanged(object sender, EventArgs e)
        {
            if (txtDirectory.Text == "")
                metroButton1.Visible = true;
        }

        private void metroContextMenu1_Opening(object sender, CancelEventArgs e)
        {
            if (_tv.SelectedNode.Text.ToLower().Contains(".txt") || _tv.SelectedNode.Text.ToLower().Contains(".osm") || _tv.SelectedNode.Text.ToLower().Contains(".cpc"))
            {
                nouveauToolStripMenuItem.Visible = false;
            }
            else
            {
                nouveauToolStripMenuItem.Visible = true;
            }
        }

        private void nouveauDossierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var node = _tv.SelectedNode;
                string oldPathDir = node.Text;
                if (oldPathDir.ToLower().Contains(".txt") || oldPathDir.ToLower().Contains(".osm") || oldPathDir.ToLower().Contains(".cpc"))
                {
                    MessageBox.Show("Veuillez sélectionner un dossier et non un fichier");
                }
                else
                {
                    if (_tv.SelectedNode is null)
                        return;
                    var selNode = _tv.SelectedNode;
                    string pathDir = Conversions.ToString(selNode.Tag);
                    var di = new DirectoryInfo(pathDir);

                    // add subdirectory to  di
                    string newDirectoryName = GetNewFolderName(di);
                   
                    // Adds new node as a child node of the currently selected node.
                    var newNode = new TreeNode(newDirectoryName);
                    newNode.Tag = di.FullName + @"" + newDirectoryName;
                    newNode.ImageKey = "NewFolder";
                    newNode.StateImageIndex = 0;
                    selNode.Nodes.Add(newNode);
                    Actualiser();
                    _tv.ExpandAll();
                }
            }
            catch
            {


            }
        }
    }
    }


