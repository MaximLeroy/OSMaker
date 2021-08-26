namespace OSMaker.Formulaires
{
    partial class OS_param
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chk_SCREEN_autosize = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtb_SCREEN_manualresolution = new System.Windows.Forms.TextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // chk_SCREEN_autosize
            // 
            this.chk_SCREEN_autosize.AutoSize = true;
            this.chk_SCREEN_autosize.Checked = true;
            this.chk_SCREEN_autosize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_SCREEN_autosize.Location = new System.Drawing.Point(64, 102);
            this.chk_SCREEN_autosize.Margin = new System.Windows.Forms.Padding(2);
            this.chk_SCREEN_autosize.Name = "chk_SCREEN_autosize";
            this.chk_SCREEN_autosize.Size = new System.Drawing.Size(73, 15);
            this.chk_SCREEN_autosize.TabIndex = 84;
            this.chk_SCREEN_autosize.Text = "Auto-size";
            this.chk_SCREEN_autosize.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chk_SCREEN_autosize.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(33, 75);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 25);
            this.metroLabel3.TabIndex = 109;
            this.metroLabel3.Text = "Screen";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // txtb_SCREEN_manualresolution
            // 
            this.txtb_SCREEN_manualresolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtb_SCREEN_manualresolution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_SCREEN_manualresolution.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_SCREEN_manualresolution.ForeColor = System.Drawing.SystemColors.Control;
            this.txtb_SCREEN_manualresolution.Location = new System.Drawing.Point(64, 121);
            this.txtb_SCREEN_manualresolution.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_SCREEN_manualresolution.Name = "txtb_SCREEN_manualresolution";
            this.txtb_SCREEN_manualresolution.Size = new System.Drawing.Size(104, 21);
            this.txtb_SCREEN_manualresolution.TabIndex = 108;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel14.ForeColor = System.Drawing.Color.Black;
            this.metroLabel14.Location = new System.Drawing.Point(64, 144);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(135, 30);
            this.metroLabel14.TabIndex = 110;
            this.metroLabel14.Text = "Set here your compatible \r\nscreen resolution";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel14.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(33, 186);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 25);
            this.metroLabel1.TabIndex = 111;
            this.metroLabel1.Text = "Boot screen";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(34, 279);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 25);
            this.metroLabel2.TabIndex = 112;
            this.metroLabel2.Text = "Cursor";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // OS_param
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 476);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.txtb_SCREEN_manualresolution);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.chk_SCREEN_autosize);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OS_param";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.Text = "OS configuration";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OS_param_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private MetroFramework.Controls.MetroCheckBox chk_SCREEN_autosize;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox txtb_SCREEN_manualresolution;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}