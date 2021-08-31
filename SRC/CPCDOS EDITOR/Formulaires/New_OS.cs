using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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



        private void btn_create_Click(object sender, EventArgs e)
        {
            if ((txtb_osPath.Text.Length > 1) && (txtb_osSystemName.Text.Length > 1) && (txtb_mediaFolder.Text.Length > 1))
            {

                /****************************************************************************************/



                // Create OS folder
                Directory.CreateDirectory(txtb_osPath.Text + "\\" + txtb_osSystemName.Text);

                // Create Media folder
                Directory.CreateDirectory(txtb_osPath.Text + "\\" + txtb_mediaFolder.Text);

                // Create boot folder
                Directory.CreateDirectory(txtb_osPath.Text + "\\" + txtb_osSystemName.Text + "\\boot");



                /****************************************************************************************/



                { /**** Generate os.cpc file for operating system ****/
                    oscpc OSCPC = new oscpc();

                    // OS informations
                    OSCPC.os_name = txtb_osName.Text;
                    OSCPC.os_SystemName = txtb_osSystemName.Text;
                    OSCPC.MediaPath = txtb_mediaFolder.Text;
                    OSCPC.AutorsNames = txtb_authors.Text;
                    OSCPC.CompagnyName = txtb_compagny.Text;
                    OSCPC.CreationDate = DateTime_creation.Value.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);

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

                    // Generate code
                    string OSCPC_content = standbox.Generate_OS_CPC_contentfile(OSCPC);

                    // Create OS.CPC file
                    using (StreamWriter sw = File.CreateText(txtb_osPath.Text + "\\" + txtb_osSystemName.Text + "\\os.cpc"))
                    {
                        sw.WriteLine(OSCPC_content);
                    }
                }


                /****************************************************************************************/



                { /**** Open folder project into OSmaker window ****/

                    new_os_path = txtb_osPath.Text + "\\" + txtb_osSystemName.Text;

                    // Copy media dir to your OS
                    try
                    {
                        standbox.DirectoryCopy(txtb_osPath.Text + "\\media", new_os_path + "\\media", true);
                    }
                    catch
                    {
                        MessageBox.Show(this, "Unable to copy original media dir to your OS. Please check if your OS dir is in CPCDOS dir", "Error during OS generation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                /****************************************************************************************/


                // Close this form
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Please enter the information correctly.", "Unable to create OS folders", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_vmFolder_Click(object sender, EventArgs e)
        {
            try
            {
                warn_VM.Visible = false;
                var dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtb_pathVM.Text = dlg.FileName;
                    if (!txtb_pathVM.Text.ToUpper().Contains(".OVA"))
                    {
                        warn_VM.Visible = true;
                        MessageBox.Show(this, "WARNING : This file may not work.", "OVA virtual file format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                warn_VM.Visible = true;
            }
        }

        private void btn_osFolder_Click(object sender, EventArgs e)
        {
            try
            {
                warn_OSPath.Visible = false;
                var dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    path = dlg.SelectedPath;
                    if (System.IO.Directory.Exists(path + "\\MEDIA") && ((System.IO.Directory.Exists(path + "\\..\\..\\CPCDOS") || (System.IO.Directory.Exists(path + "\\..\\..\\BIN")))))
                        txtb_osPath.Text = dlg.SelectedPath + "\\" + txtb_osName.Text;
                    else
                    {
                        warn_OSPath.Visible = true;
                        MessageBox.Show(this, "Please select OS dir locate on CPCDOS folder system", "Wrong OS directory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            catch
            {
                warn_OSPath.Visible = true;
            }
        }

        private void txtb_osSystemName_TextChanged(object sender, EventArgs e)
        {
            warn_OSNameSystem.Visible = false;

            txtb_mediaFolder.Text = txtb_osSystemName.Text + "\\media";
            
            if (txtb_osSystemName.Text == "")
                warn_OSNameSystem.Visible = true;
            else
                warn_OSNameSystem.Visible = false;
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
            warn_OSName.Visible = false;
            txtb_osSystemName.Text = txtb_osName.Text;
            if(txtb_osName.Text == "")
            {
                warn_OSName.Visible = true;
            }

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(1);
        }

        private void btn_Next_MouseEnter(object sender, EventArgs e)
        {

            if (txtb_osName.Text.Length < 2)
                warn_OSName.Visible = true;
            if (txtb_osSystemName.Text.Length < 2)
                warn_OSNameSystem.Visible = true;
            if (txtb_mediaFolder.Text.Length < 2)
                warn_MediaPath.Visible = true;
            if (txtb_authors.Text.Length < 2)
                warn_Author.Visible = true;
            if (txtb_compagny.Text.Length < 2)
                warn_Compagny.Visible = true;
            if (DateTime_creation.Text.Length < 2)
                warn_Date.Visible = true;
        }

        private void txtb_mediaFolder_TextChanged(object sender, EventArgs e)
        {
            warn_MediaPath.Visible = false;
            if (txtb_mediaFolder.Text == "")
            {
                warn_MediaPath.Visible = true;
            }
            else
            {
                if (!standbox.IsValidPath(txtb_mediaFolder.Text))
                {
                    warn_OSNameSystem.Visible = true;
                }
            }
        }


        private void btn_SCREEN_previous_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(0);
        }

        private void btn_SCREEN_next_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(2);
        }


        private void btn_Finish_Previous_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(1);
        }
    }
}
