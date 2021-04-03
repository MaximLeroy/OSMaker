using System;
using System.Drawing;
using System.Windows.Forms;

namespace OSMaker.MyDesignerSurface
{
    public class DESIGN
    {
        private void DESIGN_Load(object sender, EventArgs e)
        {
        }

        private void ButtonX14_Click(object sender, EventArgs e)
        {
        }

        private void DESIGN_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void DESIGN_Closed(object sender, EventArgs e)
        {
        }

        private TableLayoutPanel TableLayoutPanel1;
        private MenuStrip MenuStrip1;
        private ToolStripMenuItem FichierToolStripMenuItem;
        private ToolStripMenuItem ChargerToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private PropertyGrid PropEditor;

        private void InitializeComponent()
        {
            TableLayoutPanel1 = new TableLayoutPanel();
            MenuStrip1 = new MenuStrip();
            FichierToolStripMenuItem = new ToolStripMenuItem();
            ChargerToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            PropEditor = new PropertyGrid();
            TableLayoutPanel1.SuspendLayout();
            MenuStrip1.SuspendLayout();

            // 
            // tableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 3;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel1.Controls.Add(MenuStrip1, 0, 0);
            TableLayoutPanel1.Controls.Add(PropEditor, 2, 1);
            TableLayoutPanel1.Dock = DockStyle.Fill;
            TableLayoutPanel1.Location = new Point(0, 0);
            TableLayoutPanel1.Name = "tableLayoutPanel1";
            TableLayoutPanel1.RowCount = 2;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel1.Size = new Size(792, 517);
            TableLayoutPanel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            TableLayoutPanel1.SetColumnSpan(MenuStrip1, 3);
            MenuStrip1.Location = new Point(0, 0);
            MenuStrip1.Name = "menuStrip1";
            MenuStrip1.Size = new Size(792, 20);
            MenuStrip1.TabIndex = 2;
            MenuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            FichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ChargerToolStripMenuItem, SaveToolStripMenuItem });
            FichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            FichierToolStripMenuItem.Size = new Size(54, 16);
            FichierToolStripMenuItem.Text = "Fichier";
            // 
            // chargerToolStripMenuItem
            // 
            ChargerToolStripMenuItem.Name = "chargerToolStripMenuItem";
            ChargerToolStripMenuItem.Size = new Size(116, 22);
            ChargerToolStripMenuItem.Text = "Charger";
            // 
            // saveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "saveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(116, 22);
            SaveToolStripMenuItem.Text = "Save";
            // 
            // propEditor
            // 
            PropEditor.CategoryForeColor = SystemColors.InactiveCaptionText;
            PropEditor.Dock = DockStyle.Fill;
            PropEditor.Location = new Point(597, 23);
            PropEditor.Name = "propEditor";
            PropEditor.Size = new Size(192, 491);
            PropEditor.TabIndex = 0;
            // 
            // DESIGN
            // 

            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
        }
    }
}