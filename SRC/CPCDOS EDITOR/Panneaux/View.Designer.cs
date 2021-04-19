namespace OSMaker.Panneaux
{
    partial class View
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
            this.DocumentMap1 = new FastColoredTextBoxNS.DocumentMap();
            this.SuspendLayout();
            // 
            // DocumentMap1
            // 
            this.DocumentMap1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DocumentMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentMap1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentMap1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.DocumentMap1.Location = new System.Drawing.Point(0, 0);
            this.DocumentMap1.Margin = new System.Windows.Forms.Padding(4);
            this.DocumentMap1.Name = "DocumentMap1";
            this.DocumentMap1.Size = new System.Drawing.Size(272, 450);
            this.DocumentMap1.TabIndex = 6;
            this.DocumentMap1.Target = null;
            this.DocumentMap1.Text = "DocumentMap1";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 450);
            this.Controls.Add(this.DocumentMap1);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public FastColoredTextBoxNS.DocumentMap DocumentMap1;
    }
}