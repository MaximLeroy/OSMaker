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
using System.Drawing.Design;
using WindowConceptor;

namespace FolderExplorer
{
    public partial class Explorer : ToolWindow
    {
        public Explorer()
        {
            InitializeComponent();
        }
        public static string filename = "";
        private void Explorer_Load(object sender, EventArgs e)
        {

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
        
        private string GetNewFileNameCPC(DirectoryInfo di)
        {
            string newItem = "Class";
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
                sw.WriteLine(newItem);
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }

            newItem += countFile.ToString() + ".cpc";
            return newItem;
        }

        private string GetNewFileNameXML(DirectoryInfo di)
        {
            string newItem = "IUG";
            // Dim files = Directory.GetFiles(di.FullName, "*.xml")
            // Dim fileName = di.FullName & "\" & newItem
            // Dim countFile = 0

            // If files.Length = 0 Then
            // 'countFile = 1
            // Else
            // countFile = files.Length + 1
            // End If

            // fileName += countFile.ToString() & ".xml"
            // Dim fi As FileInfo = New FileInfo(fileName)

            // Create a file .
            // Using sw As StreamWriter = fi.CreateText()
            // sw.WriteLine(newItem)
            // sw.WriteLine("Save please")

            // End Using

            // newItem += countFile.ToString() & ".xml"
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
            }

            catch
            {
            }
        }

        private void _tv_AfterSelect(object sender, TreeViewEventArgs e)
        {

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



                Conceptor concepteur = new Conceptor();
                concepteur.Text = filename;

               filename = fi.FullName;
                string nomfichier = fi.Name;
                string text = fi.Name;

                concepteur.Text = nomfichier + " [Design]";
                concepteur.Font = new Font("Microsoft Sans Serif", 7);
                if (Home.dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
                {
                    concepteur.MdiParent = this;
                    concepteur.Show();
                }
                else
                {
                    concepteur.Show(Home.dockPanel);
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
                        dummyDoc.Show();
                    }
                    else
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



                
                

                Home.fileName = fi.FullName;
                EditeurCCplus concepteur = new EditeurCCplus();
                concepteur.Text = Home.fileName;
                string nomfichier = fi.Name;
                string text = fi.Name;

                concepteur.Text = nomfichier + " [Design]";
                concepteur.Font = new Font("Microsoft Sans Serif", 7);

                if (Home.dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
                {
                    concepteur.MdiParent = this;
                    concepteur.Show();
                }
                else
                {
                    concepteur.Show(Home.dockPanel);
                }

            }
        }
        private Conceptor CreateNewConcepteur(string text)
        {
            Conceptor concepteurr = new Conceptor();
            concepteurr.Text = text;
            return concepteurr;
        }
        private Conceptor CreateNewConcepteur()
        {
            Conceptor Concepteurr = new Conceptor();

            int count = 1;
            string text = $"IUG{count}";


            Concepteurr.Text = text;
            Concepteurr.Font = new Font("Microsoft Sans Serif", 7);
            // Concepteurr. = new Font("Microsoft Sans Serif", 7);
            return Concepteurr;
        }
        public static string pathXml;
        private void iUGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home.fileName = null;
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
                string pathDir = Conversions.ToString(_tv.SelectedNode.Tag);
                var di = new DirectoryInfo(pathDir);

                // add file to  di
                string newFileName = GetNewFileNameXML(di) + ".osm";

                // Adds new node as a child node of the currently selected node.
                var newNode = new TreeNode(newFileName);
                newNode.Tag = di.FullName + @"\\" + newFileName;
                newNode.ImageKey = "NewFile";
                newNode.StateImageIndex = 4;
                _tv.SelectedNode.Nodes.Add(newNode);
                _tv.SelectedNode = newNode;
             
                // Create new document and add it to existing bar
              

                // Add control to it
                


                // PanelDockContainer will be used to host any controls. It provides automatic focus management so focused
                // document tab appears bold

                EditeurCCplus concepteur = CreateNewConcepteur();
                if (Home.dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
                {
                    concepteur.MdiParent = this;
                    concepteur.Show();

                }
                else
                    concepteur.metroFichierXml.Text = di.FullName + @"\" + newFileName;
                    concepteur.Show(Home.dockPanel);
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

        private void _PictureBox1_Click(object sender, EventArgs e)
        {
            OuvrirFolderBrowser();
        }
    }
}
