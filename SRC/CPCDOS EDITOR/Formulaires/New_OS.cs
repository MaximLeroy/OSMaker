using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using OSMaker.Classes;

namespace OSMaker.Formulaires
{
    public partial class New_OS : MetroFramework.Forms.MetroForm
    {
        public static string new_os_path = "";
        public New_OS()
        {
            InitializeComponent();
        }

    

        public string path = "";



        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtb_pathVM.Text = "";
            txtb_osPath.Text = "";

            txtb_osName.Text = "";
            txtb_osSystemName.Text = "";
            
            txtb_mediaFolder.Text = "";

            txtb_compagny.Text = "";
            txtb_authors.Text = "";
            DateTime_creation.ResetText();
            
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if ((txtb_osPath.Text.Length > 1) && (txtb_osSystemName.Text.Length > 1) && (txtb_mediaFolder.Text.Length > 1))
            {
                // Create OS folder
                Directory.CreateDirectory(txtb_osPath.Text + "\\" + txtb_osSystemName.Text);

                // Create Media folder
                Directory.CreateDirectory(txtb_osPath.Text + "\\" + txtb_mediaFolder.Text);

                // Create boot folder
                Directory.CreateDirectory(txtb_osPath.Text + "\\" + txtb_osSystemName.Text + "\\BOOT");

                // Create OS.CPC content
                string OSCPC_content = standbox.Generate_OS_CPC_contentfile(txtb_osName.Text, txtb_osSystemName.Text, txtb_mediaFolder.Text, txtb_authors.Text, txtb_compagny.Text, DateTime_creation.Text);

                // Create OS.CPC file
                using (StreamWriter sw = File.AppendText(txtb_osPath.Text + "\\" + txtb_osSystemName.Text + "\\OS.CPC"))
                {
                    sw.WriteLine(OSCPC_content);
                }

                // Open folder project into OSmaker window
                new_os_path = txtb_osPath.Text + "\\" + txtb_osSystemName.Text;

                // Close this form
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Please enter the information correctly.", "Unable to create OS folders", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_vmFolder_Click(object sender, EventArgs e)
        {
            try
            {
                var dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtb_pathVM.Text = dlg.FileName;

                }
            }
            catch
            {

            }
        }

        private void btn_osFolder_Click(object sender, EventArgs e)
        {
            try
            {
                var dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    path = dlg.SelectedPath;
                    txtb_osPath.Text = dlg.SelectedPath + "\\" + txtb_osName.Text;

                }
            }
            catch
            {

            }
        }

        private void txtb_osSystemName_TextChanged(object sender, EventArgs e)
        {
            txtb_mediaFolder.Text = txtb_osSystemName.Text + "\\media";
        }
    }
}
