using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace OSMaker
{
    public partial class Form2
    {
        public Form2()
        {
            InitializeComponent();
            _Bar2.Name = "Bar2";
            _ButtonItem18.Name = "ButtonItem18";
            _ButtonItem19.Name = "ButtonItem19";
            _ButtonItem21.Name = "ButtonItem21";
            _ButtonItem22.Name = "ButtonItem22";
            _ButtonItem23.Name = "ButtonItem23";
            _ButtonItem24.Name = "ButtonItem24";
            _tv.Name = "tv";
            _PictureBox1.Name = "PictureBox1";
        }

        private object path = "E:/";

        private void LoadDirectory(string dir)
        {
            ProgressBarX1.Value = 25;
            ButtonItem16.Text = "Load Directory étape 1/4";
            var di = new DirectoryInfo(dir);
            var newNode = tv.Nodes.Add(di.Name);
            newNode.Tag = di.FullName;
            newNode.StateImageIndex = 0;
            ProgressBarX1.Value = 50;
            ButtonItem16.Text = "Load Directory étape 2/4";
            LoadFiles(dir, newNode);
            ButtonItem16.Text = "Load Directory étape 3/4";
            ProgressBarX1.Value = 75;
            LoadSubDirectories(dir, newNode);
            ButtonItem16.Text = "Load Directory étape 4/4";
            ProgressBarX1.Value = 100;
            ButtonItem16.Text = "Prêt";
        }

        private void LoadSubDirectories(string dir, TreeNode node)
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

        private void LoadFiles(string dir, TreeNode td)
        {
            var CPCfiles = Directory.GetFiles(dir, "*.cpc");
            var TXTfiles = Directory.GetFiles(dir, "*.xml");

            // Loop through them to see files  
            foreach (var CPCfile in CPCfiles)
            {
                var fi = new FileInfo(CPCfile);
                var tnode = td.Nodes.Add(fi.Name);
                tnode.Tag = fi.FullName;
                tnode.StateImageIndex = 1;
            }

            foreach (var TXTfile in TXTfiles)
            {
                var fi = new FileInfo(TXTfile);
                var tnode = td.Nodes.Add(fi.Name);
                tnode.Tag = fi.FullName;
                tnode.StateImageIndex = 4;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tv.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)));

            // If Not Equals(path, "") AndAlso Directory.Exists(path.ToString) Then LoadDirectory(path.ToString)



        }

        private TreeNode mySelectedNode = null;

        private void tv_MouseDown(object sender, MouseEventArgs e)
        {
            mySelectedNode = tv.GetNodeAt(e.X, e.Y);
        }

        private void tv_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.StateImageIndex = 3;
        }

        private void tv_AfterExpand(object sender, TreeViewEventArgs e)
        {
        }

        private void tv_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.StateImageIndex = 0;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtDirectory.Text = dlg.SelectedPath;
                tv.Nodes.Clear();
                LoadDirectory(txtDirectory.Text);
            }
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
                    tv.Nodes.Clear();
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
                    tv.Nodes.Clear();
                    LoadDirectory(txtDirectory.Text);

                    // CODE A VIRER

                    // srcDir.MoveTo(dstDirName);

                    // srcDir.Delete(true);
                }
            }
        }

        private void tv_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
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

                tv.LabelEdit = false;
            }
        }

        private void ButtonItem19_Click(object sender, EventArgs e)
        {
            if (mySelectedNode is object && mySelectedNode.Parent is object)
            {
                tv.SelectedNode = mySelectedNode;
                tv.LabelEdit = true;
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

        private void ButtonItem23_Click(object sender, EventArgs e)
        {
            var node = tv.SelectedNode;
            string oldPathDir = node.Text;
            if (oldPathDir.ToLower().Contains(".txt") || oldPathDir.ToLower().Contains(".xml") || oldPathDir.ToLower().Contains(".cpc"))
            {
                MessageBox.Show("Veuillez sélectionner un dossier et non un fichier");
            }
            else
            {
                if (tv.SelectedNode is null)
                    return;
                var selNode = tv.SelectedNode;
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

        private void tv_MouseDown_1(object sender, MouseEventArgs e)
        {
            mySelectedNode = tv.GetNodeAt(e.X, e.Y);
        }

        private void ButtonItem21_Click(object sender, EventArgs e)
        {
            var node = tv.SelectedNode;
            string oldPathDir = node.Text;
            if (oldPathDir.ToLower().Contains(".txt") || oldPathDir.ToLower().Contains(".xml") || oldPathDir.ToLower().Contains(".cpc"))
            {
                MessageBox.Show("Veuillez sélectionner un dossier et non un fichier");
            }
            else
            {
                if (tv.SelectedNode is null)
                    return;
                string pathDir = Conversions.ToString(tv.SelectedNode.Tag);
                var di = new DirectoryInfo(pathDir);

                // add file to  di
                string newFileName = GetNewFileNameCPC(di);

                // Adds new node as a child node of the currently selected node.
                var newNode = new TreeNode(newFileName);
                newNode.Tag = di.FullName + @"\\" + newFileName;
                newNode.ImageKey = "NewFile";
                tv.SelectedNode.Nodes.Add(newNode);
                tv.SelectedNode = newNode;
                var nouveaunoeud = tv.SelectedNode;
                // Create new document and add it to existing bar
                var dockItem = new DockContainerItem();
                dockItem.Text = nouveaunoeud.Text;

                // Add control to it
                var t = new OSMCodeBox();


                // PanelDockContainer will be used to host any controls. It provides automatic focus management so focused
                // document tab appears bold
                var panel = new PanelDockContainer();
                panel.Controls.Add(t);
                t.Dock = DockStyle.Fill;
                dockItem.Control = panel;
                t.LabelItem1.Text = pathDir + @"\" + newFileName;
                Bar6.Items.Add(dockItem);
                Bar6.SelectedDockContainerItem = dockItem;
            }
        }

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

        private void ButtonItem24_Click(object sender, EventArgs e)
        {
            if (tv.SelectedNode is null)
                return;
            var selNode = tv.SelectedNode;
            string pathDir = Conversions.ToString(selNode.Tag);
            if (pathDir.ToLower().Contains("cpc") || pathDir.ToLower().Contains("xml"))
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
            tv.Nodes.Remove(selNode);
        }

        private void ButtonItem18_Click(object sender, EventArgs e)
        {
            if (tv.SelectedNode is null)
                return;
            var selNode = tv.SelectedNode;
            if (selNode.Text.EndsWith("cpc") || selNode.Text.EndsWith("CPC"))
            {
                string pathDir = Conversions.ToString(selNode.Tag);
                var fi = new FileInfo(pathDir);

                // edit file
                using (var sr = new StreamReader(fi.FullName))
                {
                    var dockItem = new DockContainerItem();
                    dockItem.Text = selNode.Text;

                    // Add control to it
                    var t = new OSMCodeBox();


                    // PanelDockContainer will be used to host any controls. It provides automatic focus management so focused
                    // document tab appears bold
                    var panel = new PanelDockContainer();
                    panel.Controls.Add(t);
                    t.Dock = DockStyle.Fill;
                    dockItem.Control = panel;
                    Bar6.Items.Add(dockItem);
                    t.tb.Text = sr.ReadToEnd();
                    t.LabelItem1.Text = fi.FullName;
                    Bar6.SelectedDockContainerItem = dockItem;
                }
            }

            if (selNode.Text.EndsWith("xml") || selNode.Text.EndsWith("XML"))
            {
                string pathDir = Conversions.ToString(selNode.Tag);
                var fi = new FileInfo(pathDir);

                // edit file
                using (var sr = new StreamReader(fi.FullName))
                {
                    var dockItem = new DockContainerItem();
                    dockItem.Text = selNode.Text;

                    // Add control to it
                    var t = new EditeurCCplus();


                    // PanelDockContainer will be used to host any controls. It provides automatic focus management so focused
                    // document tab appears bold
                    var panel = new PanelDockContainer();
                    panel.Controls.Add(t);
                    t.Dock = DockStyle.Fill;
                    dockItem.Control = panel;
                    Bar6.Items.Add(dockItem);
                    t.tb.Text = sr.ReadToEnd();
                    t.TextBoxX2.Text = fi.FullName;
                    Bar6.SelectedDockContainerItem = dockItem;
                }
            }
        }

        private void Bar2_ItemClick(object sender, EventArgs e)
        {
        }

        private void ButtonItem22_Click(object sender, EventArgs e)
        {
            var node = tv.SelectedNode;
            string oldPathDir = node.Text;
            if (oldPathDir.ToLower().Contains(".txt") || oldPathDir.ToLower().Contains(".xml") || oldPathDir.ToLower().Contains(".cpc"))
            {
                MessageBox.Show("Veuillez sélectionner un dossier et non un fichier");
            }
            else
            {
                if (tv.SelectedNode is null)
                    return;
                string pathDir = Conversions.ToString(tv.SelectedNode.Tag);
                var di = new DirectoryInfo(pathDir);

                // add file to  di
                string newFileName = GetNewFileNameXML(di);

                // Adds new node as a child node of the currently selected node.
                var newNode = new TreeNode(newFileName);
                newNode.Tag = di.FullName + @"\\" + newFileName;
                newNode.ImageKey = "NewFile";
                tv.SelectedNode.Nodes.Add(newNode);
                tv.SelectedNode = newNode;
                var nouveaunoeud = tv.SelectedNode;
                // Create new document and add it to existing bar
                var dockItem = new DockContainerItem();
                dockItem.Text = nouveaunoeud.Text;

                // Add control to it
                var t = new EditeurCCplus();


                // PanelDockContainer will be used to host any controls. It provides automatic focus management so focused
                // document tab appears bold
                var panel = new PanelDockContainer();
                panel.Controls.Add(t);
                t.Dock = DockStyle.Fill;
                dockItem.Control = panel;
                t.TextBoxX2.Text = pathDir + @"\" + newFileName;
                Bar6.Items.Add(dockItem);
                Bar6.SelectedDockContainerItem = dockItem;
            }
        }
    }
}