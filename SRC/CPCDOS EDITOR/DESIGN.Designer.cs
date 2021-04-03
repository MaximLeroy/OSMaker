using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace OSMaker
{
    [DesignerGenerated()]
    partial class DESIGN : Form
    {
        public DESIGN()
        {
            InitializeComponent();
        }

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
            components = new System.ComponentModel.Container();
            RibbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            StyleManager1 = new DevComponents.DotNetBar.StyleManager(components);
            SuspendLayout();
            // 
            // RibbonControl1
            // 
            RibbonControl1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(45)), Conversions.ToInteger(Conversions.ToByte(45)), Conversions.ToInteger(Conversions.ToByte(48)));
            // 
            // 
            // 
            RibbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            RibbonControl1.CaptionVisible = true;
            RibbonControl1.Dock = DockStyle.Top;
            RibbonControl1.ForeColor = Color.White;
            RibbonControl1.KeyTipsFont = new Font("Tahoma", 7.0f);
            RibbonControl1.Location = new Point(0, 0);
            RibbonControl1.Name = "RibbonControl1";
            RibbonControl1.Size = new Size(882, 29);
            RibbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            RibbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            RibbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            RibbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            RibbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            RibbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            RibbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            RibbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            RibbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            RibbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            RibbonControl1.SystemText.QatDialogOkButton = "OK";
            RibbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            RibbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            RibbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            RibbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            RibbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            RibbonControl1.TabGroupHeight = 14;
            RibbonControl1.TabIndex = 33;
            RibbonControl1.Text = "RibbonControl1";
            // 
            // StyleManager1
            // 
            StyleManager1.ManagerColorTint = Color.Black;
            StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark;
            StyleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Color.White, Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(43)), Conversions.ToInteger(Conversions.ToByte(87)), Conversions.ToInteger(Conversions.ToByte(154))));
            // 
            // DESIGN
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(45)), Conversions.ToInteger(Conversions.ToByte(45)), Conversions.ToInteger(Conversions.ToByte(48)));
            ClientSize = new Size(882, 647);
            Controls.Add(RibbonControl1);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "DESIGN";
            Opacity = 0.8d;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Concepteur";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        internal DevComponents.DotNetBar.RibbonControl RibbonControl1;
        internal DevComponents.DotNetBar.StyleManager StyleManager1;
    }
}