using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace OSMaker
{
    [DesignerGenerated()]
    public partial class Objets : Form
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Objets));
            ButtonX15 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX14 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX14.Click += new EventHandler(ButtonX14_Click);
            ButtonX11 = new DevComponents.DotNetBar.ButtonX();
            ButtonX12 = new DevComponents.DotNetBar.ButtonX();
            ButtonX13 = new DevComponents.DotNetBar.ButtonX();
            ButtonX16 = new DevComponents.DotNetBar.ButtonX();
            _RibbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            _RibbonControl1.Click += new EventHandler(RibbonControl1_Click);
            StyleManager1 = new DevComponents.DotNetBar.StyleManager(components);
            SuspendLayout();
            // 
            // ButtonX15
            // 
            ButtonX15.AccessibleRole = AccessibleRole.PushButton;
            ButtonX15.BackColor = Color.DimGray;
            ButtonX15.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            ButtonX15.Font = new Font("Segoe UI", 10.2f);
            ButtonX15.Image = (Image)resources.GetObject("ButtonX15.Image");
            ButtonX15.Location = new Point(277, 33);
            ButtonX15.Name = "ButtonX15";
            ButtonX15.Size = new Size(47, 47);
            ButtonX15.Symbol = "";
            ButtonX15.SymbolColor = Color.White;
            ButtonX15.TabIndex = 45;
            ButtonX15.TextColor = Color.White;
            // 
            // ButtonX14
            // 
            _ButtonX14.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX14.BackColor = Color.DimGray;
            _ButtonX14.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            _ButtonX14.Font = new Font("Segoe UI", 10.2f);
            _ButtonX14.Image = (Image)resources.GetObject("ButtonX14.Image");
            _ButtonX14.Location = new Point(118, 33);
            _ButtonX14.Name = "_ButtonX14";
            _ButtonX14.Size = new Size(47, 47);
            _ButtonX14.Symbol = "";
            _ButtonX14.SymbolColor = Color.White;
            _ButtonX14.TabIndex = 40;
            _ButtonX14.TextColor = Color.White;
            // 
            // ButtonX11
            // 
            ButtonX11.AccessibleRole = AccessibleRole.PushButton;
            ButtonX11.BackColor = Color.DimGray;
            ButtonX11.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            ButtonX11.Font = new Font("Segoe UI", 10.2f);
            ButtonX11.Image = (Image)resources.GetObject("ButtonX11.Image");
            ButtonX11.Location = new Point(12, 33);
            ButtonX11.Name = "ButtonX11";
            ButtonX11.Size = new Size(47, 47);
            ButtonX11.Symbol = "";
            ButtonX11.SymbolColor = Color.White;
            ButtonX11.TabIndex = 43;
            ButtonX11.TextColor = Color.White;
            // 
            // ButtonX12
            // 
            ButtonX12.AccessibleRole = AccessibleRole.PushButton;
            ButtonX12.BackColor = Color.DimGray;
            ButtonX12.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            ButtonX12.Font = new Font("Segoe UI", 10.2f);
            ButtonX12.Image = (Image)resources.GetObject("ButtonX12.Image");
            ButtonX12.Location = new Point(224, 33);
            ButtonX12.Name = "ButtonX12";
            ButtonX12.Size = new Size(47, 47);
            ButtonX12.Symbol = "";
            ButtonX12.SymbolColor = Color.White;
            ButtonX12.TabIndex = 44;
            ButtonX12.TextColor = Color.White;
            // 
            // ButtonX13
            // 
            ButtonX13.AccessibleRole = AccessibleRole.PushButton;
            ButtonX13.BackColor = Color.DimGray;
            ButtonX13.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            ButtonX13.Font = new Font("Segoe UI", 10.2f);
            ButtonX13.Image = (Image)resources.GetObject("ButtonX13.Image");
            ButtonX13.Location = new Point(171, 33);
            ButtonX13.Name = "ButtonX13";
            ButtonX13.Size = new Size(47, 47);
            ButtonX13.Symbol = "";
            ButtonX13.SymbolColor = Color.White;
            ButtonX13.TabIndex = 42;
            ButtonX13.TextColor = Color.White;
            // 
            // ButtonX16
            // 
            ButtonX16.AccessibleRole = AccessibleRole.PushButton;
            ButtonX16.BackColor = Color.DimGray;
            ButtonX16.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            ButtonX16.Font = new Font("Segoe UI", 10.2f);
            ButtonX16.Image = (Image)resources.GetObject("ButtonX16.Image");
            ButtonX16.Location = new Point(65, 33);
            ButtonX16.Name = "ButtonX16";
            ButtonX16.Size = new Size(47, 47);
            ButtonX16.Symbol = "";
            ButtonX16.SymbolColor = Color.White;
            ButtonX16.TabIndex = 41;
            ButtonX16.TextColor = Color.White;
            // 
            // RibbonControl1
            // 
            _RibbonControl1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(45)), Conversions.ToInteger(Conversions.ToByte(45)), Conversions.ToInteger(Conversions.ToByte(48)));
            // 
            // 
            // 
            _RibbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _RibbonControl1.CaptionVisible = true;
            _RibbonControl1.Dock = DockStyle.Top;
            _RibbonControl1.ForeColor = Color.White;
            _RibbonControl1.KeyTipsFont = new Font("Tahoma", 7.0f);
            _RibbonControl1.Location = new Point(0, 0);
            _RibbonControl1.Name = "_RibbonControl1";
            _RibbonControl1.Size = new Size(340, 27);
            _RibbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _RibbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            _RibbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            _RibbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            _RibbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            _RibbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            _RibbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            _RibbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            _RibbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            _RibbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            _RibbonControl1.SystemText.QatDialogOkButton = "OK";
            _RibbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            _RibbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            _RibbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            _RibbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            _RibbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            _RibbonControl1.TabGroupHeight = 14;
            _RibbonControl1.TabIndex = 46;
            _RibbonControl1.Text = "RibbonControl1";
            // 
            // StyleManager1
            // 
            StyleManager1.ManagerColorTint = Color.Black;
            StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark;
            StyleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Color.White, Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(43)), Conversions.ToInteger(Conversions.ToByte(87)), Conversions.ToInteger(Conversions.ToByte(154))));
            // 
            // Objets
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            ClientSize = new Size(340, 87);
            Controls.Add(_RibbonControl1);
            Controls.Add(ButtonX15);
            Controls.Add(_ButtonX14);
            Controls.Add(ButtonX11);
            Controls.Add(ButtonX12);
            Controls.Add(ButtonX13);
            Controls.Add(ButtonX16);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Objets";
            StartPosition = FormStartPosition.Manual;
            Text = "Objets";
            TopMost = true;
            Load += new EventHandler(Objets_Load);
            MouseMove += new MouseEventHandler(Objets_MouseMove);
            ResumeLayout(false);
        }

        internal DevComponents.DotNetBar.ButtonX ButtonX15;
        private DevComponents.DotNetBar.ButtonX _ButtonX14;

        internal DevComponents.DotNetBar.ButtonX ButtonX14
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX14;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX14 != null)
                {
                    _ButtonX14.Click -= ButtonX14_Click;
                }

                _ButtonX14 = value;
                if (_ButtonX14 != null)
                {
                    _ButtonX14.Click += ButtonX14_Click;
                }
            }
        }

        internal DevComponents.DotNetBar.ButtonX ButtonX11;
        internal DevComponents.DotNetBar.ButtonX ButtonX12;
        internal DevComponents.DotNetBar.ButtonX ButtonX13;
        internal DevComponents.DotNetBar.ButtonX ButtonX16;
        private DevComponents.DotNetBar.RibbonControl _RibbonControl1;

        internal DevComponents.DotNetBar.RibbonControl RibbonControl1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RibbonControl1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RibbonControl1 != null)
                {
                    _RibbonControl1.Click -= RibbonControl1_Click;
                }

                _RibbonControl1 = value;
                if (_RibbonControl1 != null)
                {
                    _RibbonControl1.Click += RibbonControl1_Click;
                }
            }
        }

        internal DevComponents.DotNetBar.StyleManager StyleManager1;
    }
}