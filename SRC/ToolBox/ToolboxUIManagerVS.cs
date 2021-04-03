using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ToolBox.ToolboxLibrary
{
    /// <summary>
    /// ToolboxUIManagerVS
    /// </summary>
    public class ToolboxUIManagerVS
    {
        private Toolbox m_toolbox;
        private System.Drawing.Design.ToolboxItem pointer; // a "null" tool

        public ToolboxUIManagerVS(Toolbox toolbox)
        {
            m_toolbox = toolbox;
            pointer = new System.Drawing.Design.ToolboxItem();
            pointer.DisplayName = "<Pointer>";
            pointer.Bitmap = new Bitmap(16, 16);
        }

        public ToolboxUIManagerVS(ToolBox toolBox)
        {
            ToolBox = toolBox;
        }

        private Toolbox Toolbox
        {
            get
            {
                return m_toolbox;
            }
        }

        public ToolBox ToolBox { get; }

        public void FillToolbox()
        {
            CreateControls();
            ConfigureControls();
            this.UpdateToolboxItems(Toolbox.Tabs.Count - 1);
        }

        private void CreateControls()
        {
            Toolbox.Controls.Clear();
            Toolbox.ToolsListBox = new ListBox();
            Toolbox.TabPageArray = new Button[Toolbox.Tabs.Count];
        }

        private void ConfigureControls()
        {
            Toolbox.SuspendLayout();
            for (int i = Toolbox.Tabs.Count - 1; i >= 0; i -= 1)
            {
                // 
                // Tab Button
                // 
                var button = new Button();
                button.ForeColor = SystemColors.ButtonHighlight;
                button.Dock = DockStyle.Top;
                button.FlatStyle = FlatStyle.Popup;
                button.Location = new Point(0, (i + 1) * 20);
                button.Name = Toolbox.Tabs[i].Name;
                button.Size = new Size(Toolbox.Width, 20);
                button.TabIndex = i + 1;
                button.Text = Toolbox.Tabs[i].Name;
                button.TextAlign = ContentAlignment.MiddleLeft;
                button.Tag = i;
                button.Click += new EventHandler(button_Click);
                Toolbox.Controls.Add(button);
                Toolbox.TabPageArray[i] = button;
            }


            // 
            // toolboxTitleButton
            // 
            // Dim toolboxTitleButton As Button = New Button()
            // toolboxTitleButton.BackColor = SystemColors.ActiveCaption
            // toolboxTitleButton.Dock = DockStyle.Top
            // toolboxTitleButton.FlatStyle = FlatStyle.Popup
            // toolboxTitleButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            // toolboxTitleButton.Location = New Point(0, 0)
            // toolboxTitleButton.Name = "toolboxTitleButton"
            // toolboxTitleButton.Size = New Size(Toolbox.Width, 20)
            // toolboxTitleButton.TabIndex = 0
            // toolboxTitleButton.Text = "Toolbox"
            // toolboxTitleButton.TextAlign = ContentAlignment.MiddleLeft
            // Toolbox.Controls.Add(toolboxTitleButton)

            // 
            // listBox
            // 
            var listBox = new ListBox();
            listBox.BorderStyle = BorderStyle.None;
            listBox.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)));
            listBox.DrawMode = DrawMode.OwnerDrawFixed;
            listBox.ItemHeight = 18;
            listBox.ResetForeColor();
            listBox.Location = new Point(0, (Toolbox.Tabs.Count + 1) * 20);
            listBox.Name = "ToolsListBox";
            listBox.ForeColor = Color.White;
            listBox.Size = new Size(Toolbox.Width, Toolbox.Height - (Toolbox.Tabs.Count + 1) * 20);
            listBox.TabIndex = Toolbox.Tabs.Count + 1;
            listBox.ForeColor = Color.White;
            Toolbox.Controls.Add(listBox);
            this.UpdateToolboxItems(Toolbox.Tabs.Count - 1);
            Toolbox.ResumeLayout();
            Toolbox.ForeColor = Color.White;
            Toolbox.ToolsListBox.ForeColor = Color.White;
            Toolbox.ToolsListBox = listBox;
            Toolbox.SizeChanged += new EventHandler(Toolbox_SizeChanged);
        }

        private void UpdateToolboxItems(int tabIndex)
        {
            Toolbox.ToolsListBox.Items.Clear();
            Toolbox.ToolsListBox.Items.Add(pointer);
            if (Toolbox.Tabs.Count <= 0)
                return;
            var toolboxTab = Toolbox.Tabs[tabIndex];
            var toolboxItems = toolboxTab.ToolboxItems;
            System.Collections.IList list = toolboxItems;
            for (int i = 0; i < list.Count; i++)
            {
                ToolboxItem toolboxItem = (ToolboxItem)list[i];
                var type = toolboxItem.Type;
                var tbi = new System.Drawing.Design.ToolboxItem(type);
                ToolboxBitmapAttribute tba = TypeDescriptor.GetAttributes(type)[typeof(ToolboxBitmapAttribute)] as ToolboxBitmapAttribute;
                if (tba is object)
                {
                    tbi.Bitmap = (Bitmap)tba.GetImage(type);
                }

                Toolbox.ToolsListBox.Items.Add(tbi);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button is null)
                return;
            int index = Conversions.ToInteger(button.Tag);
            if (button.Dock == DockStyle.Top)
            {
                for (int i = index + 1, loopTo = Toolbox.TabPageArray.Length - 1; i <= loopTo; i++)
                    Toolbox.TabPageArray[i].Dock = DockStyle.Bottom;
            }
            else
            {
                for (int i = 0, loopTo1 = index; i <= loopTo1; i++)
                    Toolbox.TabPageArray[i].Dock = DockStyle.Top;
            }

            Toolbox.ToolsListBox.Location = new Point(0, (index + 2) * 20);
            UpdateToolboxItems(index);
        }

        private void Toolbox_SizeChanged(object sender, EventArgs e)
        {
            Toolbox.ToolsListBox.Size = new Size(Toolbox.Width, Toolbox.Height - (Toolbox.Tabs.Count + 1) * 20);
        }
    } // class
} // namespace
