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
    public partial class EditOS : MetroFramework.Forms.MetroForm
    {

        Color Background_color = Color.FromArgb(50, 150, 250);

        public EditOS(int tab, string current_os_path)
        {
            InitializeComponent();


            string current_os_path_BOOTCONFIG = current_os_path + "\\BOOT\\CONFIG.CPC";
            string current_os_path_FILE = current_os_path + "\\OS.CPC";

            metroTabControl1.SelectTab(tab);


            if (System.IO.File.Exists(current_os_path_FILE) == true)
            {
                // Display OS information from CPC files

                txtb_osPath.Text = current_os_path;
                txtb_osName.Text = standbox.getVariableFromCPCFile(current_os_path_FILE, "OS_NAME");
                txtb_osSystemName.Text = current_os_path.Substring(current_os_path.LastIndexOf(@"\") + 1);
                txtb_mediaFolder.Text = standbox.getVariableFromCPCFile(current_os_path_FILE, "GUI_OS");
                txtb_authors.Text = standbox.getVariableFromCPCFile(current_os_path_FILE, "OS_Author");
                txtb_compagny.Text = standbox.getVariableFromCPCFile(current_os_path_FILE, "OS_Compagny");

                string dateupdate = standbox.getVariableFromCPCFile(current_os_path_FILE, "OS_Updated");
                DateTime dt;
                DateTime.TryParse(dateupdate, out dt);
                DateTime_creation.Value = dt;

                // Screen desktop auto
                if (standbox.getVariableFromCPCFile(current_os_path_FILE, "SCR_AUTO").ToUpper() == "TRUE")
                    chk_SCREEN_autosize.Checked = true;

                // Screen resolution
                txtb_SCREEN_manualresolution.Text = standbox.getVariableFromCPCFile(current_os_path_FILE, "SCR_RES");

                // Screen bit color
                string bit_res = standbox.getVariableFromCPCFile(current_os_path_FILE, "SCR_BIT");
                if (bit_res == "16")
                    rad_screen_16bits.Checked = true;
                else if (bit_res == "24")
                    rad_screen_24bits.Checked = true;
                else if (bit_res == "32")
                    rad_screen_32bits.Checked = true;

                // Background screen
                txtb_background_image.Text = standbox.getVariableFromCPCFile(current_os_path_FILE, "SCR_IMG");

                // Load image to picturebox
                picture_background.Load(txtb_background_image.Text);

                // Background coloration
                int Red, Green, Blue;
                string scr_color = standbox.getVariableFromCPCFile(current_os_path_FILE, "SCR_COLOR");

                int.TryParse(scr_color.Substring(0, 3), out Red);
                int.TryParse(scr_color.Substring(4, 3), out Green);
                int.TryParse(scr_color.Substring(8, 3), out Blue);

                Color coloration = Color.FromArgb(Red, Green, Blue);

                Background_color = coloration;

                // Icons on desktop
                if (standbox.getVariableFromCPCFile(current_os_path_FILE, "DESKTOP_ICONS").ToUpper() == "TRUE")
                    chk_desktop.Checked = true;
                else
                    chk_desktop.Checked = false;
            }
            else
            {
                MessageBox.Show(this, "OS.CPC is not avaiable, please check OS folder", "Error during reading", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //***********************************************************************************//

            
            if (System.IO.File.Exists(current_os_path_BOOTCONFIG) == true)
            {
                btn_BOOT_save.Text = "Save";

                // Bootscreen config file
                if (standbox.getVariableFromCPCFile(current_os_path_BOOTCONFIG, "OS_NAME") == "1")
                    chk_BootScreen_Enable.Checked = true;
                else
                    chk_BootScreen_Enable.Checked = false;


                txtb_BootScreenResolution.Text = standbox.getVariableFromCPCFile(current_os_path_BOOTCONFIG, "cpc_sys.boot.bootscreen.scr_res");

                // Images parameters
                txtb_Bootscreen_FPS.Text = standbox.getVariableFromCPCFile(current_os_path_BOOTCONFIG, "cpc_sys.boot.bootscreen.fps");
                txtb_Bootscreen_NumberImages.Text = standbox.getVariableFromCPCFile(current_os_path_BOOTCONFIG, "cpc_sys.boot.bootscreen.size");
                txtb_Bootscreen_NumberImages.Text = standbox.getVariableFromCPCFile(current_os_path_BOOTCONFIG, "cpc_sys.boot.bootscreen.begin");
                txtb_Bootscreen_LoopImage.Text = standbox.getVariableFromCPCFile(current_os_path_BOOTCONFIG, "cpc_sys.boot.bootscreen.loop");
                txtb_Bootscreen_OpacityImage.Text = standbox.getVariableFromCPCFile(current_os_path_BOOTCONFIG, "cpc_sys.boot.bootscreen.frames_opacity");


                // Darkening
                string dakrning_ = standbox.getVariableFromCPCFile(current_os_path_BOOTCONFIG, "cpc_sys.boot.bootscreen.darkening");

                if (dakrning_ == "1")
                    rad_Bootscreen_DARKENING_Begin.Checked = true;
                else if (dakrning_ == "2")
                    rad_Bootscreen_DARKENING_End.Checked = true;
                else if (dakrning_ == "3")
                    rad_Bootscreen_DARKENING_Both.Checked = true;
                else
                    rad_Bootscreen_DARKENING_disable.Checked = true;
            }
            else
            {
                btn_BOOT_save.Text = "Generate";
            }

        }




        public string path = "";



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

        

        private void EditOS_Load(object sender, EventArgs e)
        {
            

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

        private void btn_BOOT_next_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_SCREEN_previous_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(1);
        }

        private void btn_SCREEN_next_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(3);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(4);
        }

        private void btn_Finish_Previous_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(3);
        }


        private void btn_Save_OSCFG_Click(object sender, EventArgs e)
        {

        }

        private void chk_SCREEN_autosize_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_BOOT_save_Click(object sender, EventArgs e)
        {

        }
    }
}
