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
using static OSMaker.Classes.standbox;

namespace OSMaker.Formulaires
{
    public partial class New_OS : MetroFramework.Forms.MetroForm
    {
        public static string new_os_path = "";

        Color Background_color = Color.FromArgb(50, 150, 250);

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

                string OSCPC_content = "";
                {
                    oscpc OSCPC = new oscpc();

                    // OS informations
                    OSCPC.os_name = txtb_osName.Text;
                    OSCPC.os_SystemName = txtb_osSystemName.Text;
                    OSCPC.MediaPath = txtb_mediaFolder.Text;
                    OSCPC.AutorsNames = txtb_authors.Text;
                    OSCPC.CompagnyName = txtb_compagny.Text;
                    OSCPC.CreationDate = DateTime_creation.Text;

                    // Screen desktop
                    OSCPC.Resolution_auto = chk_SCREEN_autosize.Checked;
                    OSCPC.Resolution = txtb_SCREEN_manualresolution.Text;
                    if (rad_screen_16bits.Checked == true)
                        OSCPC.Resolution_bit = "16";
                    else if (rad_screen_24bits.Checked == true)
                        OSCPC.Resolution_bit = "24";
                    else if (rad_screen_32bits.Checked == true)
                        OSCPC.Resolution_bit = "32";

                    OSCPC.Background_image = txtb_background_image.Text;
                    OSCPC.Background_Color_R = Background_color.R;
                    OSCPC.Background_Color_G = Background_color.G;
                    OSCPC.Background_Color_B = Background_color.B;

                    OSCPC.DesktopIcons = chk_desktop.Checked;

                    // Create OS.CPC content
                    OSCPC_content = standbox.Generate_OS_CPC_contentfile(OSCPC);
                }

                // Create OS.CPC file
                using (StreamWriter sw = File.CreateText(txtb_osPath.Text + "\\" + txtb_osSystemName.Text + "\\OS.CPC"))
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



        private void New_OS_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(0);

            toolTip1.SetToolTip(chk_SCREEN_autosize, "Using runtime for select automatically best screen + bit resolution (eg:1920x1080 32bits)");
            toolTip1.SetToolTip(txtb_SCREEN_manualresolution, "WARNING: Use compatible resolution for your graphic hardware");
            toolTip1.SetToolTip(chk_SCREEN_autosize, "Using runtime for select best bit color resolution (eg:32 bits)");
            toolTip1.SetToolTip(txtb_SCREEN_manualresolution, "WARNING: Use compatible bit resolution for your graphic hardware");

            picture_background.BackColor = Background_color;
            colorDialog.Color = Background_color;
        }

        private void tab_BootScreen_Click(object sender, EventArgs e)
        {

        }

        private void btn_background_color_Click(object sender, EventArgs e)
        {
            // Afficher le dialogue de couleur
            colorDialog.ShowDialog();

            // Recuperer la couleur
            Background_color = colorDialog.Color;
            picture_background.BackColor = Background_color;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtb_background_image.Text = dlg.FileName;
                    picture_background.Load(txtb_background_image.Text);

                }
            }
            catch
            {

            }
        }

        private void btn_background_delete_Click(object sender, EventArgs e)
        {
            txtb_background_image.Text = "";
            picture_background.Image = null;
        }

        private void txtb_osName_TextChanged(object sender, EventArgs e)
        {
            txtb_osSystemName.Text = txtb_osName.Text;
        }
    }
}
