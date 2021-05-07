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

namespace OSMaker
{
    public partial class Nouveau : MetroFramework.Forms.MetroForm
    {
        public Nouveau()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void Nouveau_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public string pathdirectory = "";
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroRadioButton2.Checked == true)
            {
                Home.m_solutionExplorer.New_IUG(pathosmtextBox.Text, pathcpctextBox.Text, nameccplustextBox.Text);
                IUGConceptor conceptordesk = new IUGConceptor();
                conceptordesk.New_Desktop(pathosmtextBox.Text, pathcpctextBox.Text);
                conceptordesk.Show(Home.dockPanel);
                conceptordesk.Text = nameccplustextBox.Text + ".osm [Design]";
                Close();
            }
            else
            {
                // Home.m_solutionExplorer.New_IUG(pathtextBox.Text,nametextBox.Text);
                Home.m_solutionExplorer.New_IUG(pathosmtextBox.Text, pathcpctextBox.Text, nameccplustextBox.Text);
                IUGConceptor conceptor = new IUGConceptor();
                conceptor.New_Host(pathosmtextBox.Text, pathcpctextBox.Text);
                conceptor.Show(Home.dockPanel);
                conceptor.Text = nameccplustextBox.Text + ".osm [Design]";
                Close();
            }
        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {
            
            pathcpctextBox.Text = pathcpc + "\\" + nameccplustextBox.Text + ".cpc";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            try
            {
                var dlg = new FileFolderDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    
                    pathosmtextBox.Text = dlg.SelectedPath + "\\" + nameosmtextbox.Text + ".osm";
                    pathosm = dlg.SelectedPath + "\\";
                    //_tv.Nodes.Clear();
                    //LoadDirectory(txtDirectory.Text);
                    //txtDirectory.Style = MetroFramework.MetroColorStyle.Green;
                    //metroButton1.Visible = false;
                }
            }
            catch
            {

            }
        }
        public string pathcpc = "";
        public string pathosm = "";
        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                var dlg = new FileFolderDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pathcpctextBox.Text = dlg.SelectedPath + "\\" + nameccplustextBox.Text + ".cpc";
                    pathcpc = dlg.SelectedPath + "\\";
                    //_tv.Nodes.Clear();
                    //LoadDirectory(txtDirectory.Text);
                    //txtDirectory.Style = MetroFramework.MetroColorStyle.Green;
                    //metroButton1.Visible = false;
                }
            }
            catch
            {

            }
        }

        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton3.Checked == true) 
            {
                metroLabel2.Visible = pathosmtextBox.Visible = metroButton3.Visible = false;
            }
            else
            {
                metroLabel2.Visible = pathosmtextBox.Visible = metroButton3.Visible = true;
                
            }
        }

        private void metroRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
       
            if (metroRadioButton5.Checked == true)
            {
                metroLabel2.Visible = pathosmtextBox.Visible = metroButton3.Visible = false;
                nameccplustextBox.Text = "OS";
            }
            else
            {
                metroLabel2.Visible = pathosmtextBox.Visible = metroButton3.Visible = true;
                
            }
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DirectoryInfo diosm = new DirectoryInfo(pathosm);
            DirectoryInfo dicpc = new DirectoryInfo(pathcpc);
            if (metroRadioButton1.Checked == true)
            {

                nameosmtextbox.Text = Home.m_solutionExplorer.GetNewFileNameXML(diosm).Replace(".osm","");
                nameccplustextBox.Text = Home.m_solutionExplorer.GetNewFileNameCPC(dicpc).Replace(".cpc", "");
            }
            else
            {
               

            }
        }

        private void nameosmtextbox_TextChanged(object sender, EventArgs e)
        {
            pathosmtextBox.Text = pathosm + "\\"+ nameosmtextbox.Text + ".osm";
        }
    }
}
