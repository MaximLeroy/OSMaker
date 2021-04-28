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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sortie));
            this.rtOutput = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rtOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // rtOutput
            // 
            this.rtOutput.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.rtOutput.AutoScrollMinSize = new System.Drawing.Size(52, 17);
            this.rtOutput.BackBrush = null;
            this.rtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rtOutput.CharHeight = 17;
            this.rtOutput.CharWidth = 8;
            this.rtOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtOutput.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.rtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtOutput.Font = new System.Drawing.Font("Consolas", 9F);
            this.rtOutput.ForeColor = System.Drawing.Color.Gainsboro;
            this.rtOutput.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rtOutput.IsReplaceMode = false;
            this.rtOutput.LeftPadding = 25;
            this.rtOutput.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.rtOutput.Location = new System.Drawing.Point(0, 0);
            this.rtOutput.Margin = new System.Windows.Forms.Padding(4);
            this.rtOutput.Name = "rtOutput";
            this.rtOutput.Paddings = new System.Windows.Forms.Padding(0);
            this.rtOutput.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.rtOutput.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("rtOutput.ServiceColors")));
            this.rtOutput.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.rtOutput.ShowScrollBars = false;
            this.rtOutput.Size = new System.Drawing.Size(800, 450);
            this.rtOutput.TabIndex = 8;
            this.rtOutput.Zoom = 100;
            // 
            // Sortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtOutput);
            this.Name = "Sortie";
            this.Text = "Sortie";
            this.Load += new System.EventHandler(this.Sortie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rtOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox rtOutput;
    }
}