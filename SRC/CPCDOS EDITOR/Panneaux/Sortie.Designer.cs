namespace OSMaker.Panneaux
{
    partial class Sortie
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
            this.Outputrich = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Outputrich
            // 
            this.Outputrich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Outputrich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Outputrich.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outputrich.ForeColor = System.Drawing.SystemColors.Control;
            this.Outputrich.Location = new System.Drawing.Point(0, 0);
            this.Outputrich.Name = "Outputrich";
            this.Outputrich.Size = new System.Drawing.Size(800, 450);
            this.Outputrich.TabIndex = 0;
            this.Outputrich.Text = "----------------Output-----------------------------------------------------------" +
    "--------------------";
            // 
            // Sortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Outputrich);
            this.Name = "Sortie";
            this.Text = "Output";
            this.Load += new System.EventHandler(this.Sortie_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Outputrich;
    }
}