using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ToolBox.ToolboxLibrary;
namespace OSMLoader
{
    [DesignerGenerated()]
    public partial class TestDesignervb : Form
    {

        // Form remplace la méthode Dispose pour nettoyer la liste des composants.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requise par le Concepteur Windows Form
        private System.ComponentModel.IContainer components;

        // REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
        // Elle peut être modifiée à l'aide du Concepteur Windows Form.  
        // Ne la modifiez pas à l'aide de l'éditeur de code.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Toolbox1 = new ToolBox.ToolboxLibrary.Toolbox();
            this.Panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.Toolbox1);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.Panel1);
            this.SplitContainer1.Size = new System.Drawing.Size(1557, 700);
            this.SplitContainer1.SplitterDistance = 277;
            this.SplitContainer1.SplitterWidth = 5;
            this.SplitContainer1.TabIndex = 0;
            // 
            // Toolbox1
            // 
            this.Toolbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Toolbox1.DesignerHost = null;
            this.Toolbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Toolbox1.FilePath = null;
            this.Toolbox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Toolbox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Toolbox1.Location = new System.Drawing.Point(0, 0);
            this.Toolbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Toolbox1.Name = "Toolbox1";
            this.Toolbox1.SelectedCategory = null;
            this.Toolbox1.Size = new System.Drawing.Size(277, 700);
            this.Toolbox1.TabIndex = 0;
            // 
            // Panel1
            // 
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1275, 700);
            this.Panel1.TabIndex = 0;
            // 
            // TestDesignervb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 700);
            this.Controls.Add(this.SplitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TestDesignervb";
            this.Text = "TestDesignervb";
            this.Load += new System.EventHandler(this.TestDesignervb_Load);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        internal SplitContainer SplitContainer1;
        internal Toolbox Toolbox1;
        internal Panel Panel1;
    }
}