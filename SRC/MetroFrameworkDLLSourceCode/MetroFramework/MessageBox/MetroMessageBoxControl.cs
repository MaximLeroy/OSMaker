using MetroFramework.Controls;
using MetroFramework.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MetroFramework
{
    public partial class MetroMessageBoxControl : Form
    {
        public MetroMessageBoxControl()
        {
            InitializeComponent();

            _properties = new MetroMessageBoxProperties(this);

            StylizeButton(metroButton1);
            StylizeButton(metroButton2);
            StylizeButton(metroButton3);

            metroButton1.Click += new EventHandler(button_Click);
            metroButton2.Click += new EventHandler(button_Click);
            metroButton3.Click += new EventHandler(button_Click);

        }

        /// <summary>
        /// Gets the top body section of the control. 
        /// </summary>
        public Panel Body
        {
            get { return panelbody; }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MetroMessageBoxProperties _properties = null;

        /// <summary>
        /// Gets the message box display properties.
        /// </summary>
        public MetroMessageBoxProperties Properties
        { get { return _properties; } }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DialogResult _result = DialogResult.None;


        /// <summary>
        /// Gets the dialog result that the user have chosen.
        /// </summary>
        public DialogResult Result
        {
            get { return _result; }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _inputBoxText = "";

        /// <summary>
        /// Gets the dialog result that the user have chosen.
        /// </summary>
        public string InputBoxText
        {
            get { return _inputBoxText; }
        }

        /// <summary>
        /// Arranges the apperance of the message box overlay.
        /// </summary>
        public void ArrangeApperance()
        {
            titleLabel.Text = _properties.Title;
            messageLabel.Text = _properties.Message;

            if (_properties.InputBox)
            {
                metroTextBox1.Enabled = true;
                metroTextBox1.Visible = true;
            }
            else
            {
                metroTextBox1.Enabled = false;
                metroTextBox1.Visible = false;
            }

            switch (_properties.Buttons)
            {
                case MessageBoxButtons.OK:
                    EnableButton(metroButton1);

                    metroButton1.Text = "&OK";
                    metroButton1.Location = metroButton3.Location;
                    metroButton1.Tag = DialogResult.OK;
                    this.AcceptButton = metroButton1;
                    this.CancelButton = metroButton1;

                    EnableButton(metroButton2, false);
                    EnableButton(metroButton3, false);
                    break;
                case MessageBoxButtons.OKCancel:
                    EnableButton(metroButton1);

                    metroButton1.Text = "&OK";
                    metroButton1.Location = metroButton2.Location;
                    metroButton1.Tag = DialogResult.OK;
                    this.AcceptButton = metroButton1;

                    EnableButton(metroButton2);

                    metroButton2.Text = "&Cancel";
                    metroButton2.Location = metroButton3.Location;
                    metroButton2.Tag = DialogResult.Cancel;
                    this.CancelButton = metroButton2;

                    EnableButton(metroButton3, false);
                    break;
                case MessageBoxButtons.RetryCancel:
                    EnableButton(metroButton1);

                    metroButton1.Text = "&Retry";
                    metroButton1.Location = metroButton2.Location;
                    metroButton1.Tag = DialogResult.Retry;
                    this.AcceptButton = metroButton1;

                    EnableButton(metroButton2);

                    metroButton2.Text = "&Cancel";
                    metroButton2.Location = metroButton3.Location;
                    metroButton2.Tag = DialogResult.Cancel;
                    this.CancelButton = metroButton2;

                    EnableButton(metroButton3, false);
                    break;
                case MessageBoxButtons.YesNo:
                    EnableButton(metroButton1);

                    metroButton1.Text = "&Yes";
                    metroButton1.Location = metroButton2.Location;
                    metroButton1.Tag = DialogResult.Yes;
                    this.AcceptButton = metroButton1;

                    EnableButton(metroButton2);

                    metroButton2.Text = "&No";
                    metroButton2.Location = metroButton3.Location;
                    metroButton2.Tag = DialogResult.No;
                    this.CancelButton = metroButton2;

                    EnableButton(metroButton3, false);
                    break;
                case MessageBoxButtons.YesNoCancel:
                    EnableButton(metroButton1);

                    metroButton1.Text = "&Yes";
                    metroButton1.Tag = DialogResult.Yes;

                    EnableButton(metroButton2);

                    metroButton2.Text = "&No";
                    metroButton2.Tag = DialogResult.No;

                    EnableButton(metroButton3);

                    metroButton3.Text = "&Cancel";
                    metroButton3.Tag = DialogResult.Cancel;
                    this.CancelButton = metroButton2;

                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    EnableButton(metroButton1);

                    metroButton1.Text = "&Abort";
                    metroButton1.Tag = DialogResult.Abort;

                    EnableButton(metroButton2);

                    metroButton2.Text = "&Retry";
                    metroButton2.Tag = DialogResult.Retry;

                    EnableButton(metroButton3);

                    metroButton3.Text = "&Ignore";
                    metroButton3.Tag = DialogResult.Ignore;

                    break;
                default : break;
            }



            switch (_properties.Icon)
            {
                case  MessageBoxIcon.Error:
                    panelbody.BackColor = MetroColors.ErrorColor;
                    break;
                case MessageBoxIcon.Warning:
                    panelbody.BackColor = MetroColors.WarningColor;
                    break;
                case MessageBoxIcon.Information:
                    panelbody.BackColor = MetroColors.Blue;
                    break;
                case MessageBoxIcon.Question:
                    panelbody.BackColor = MetroColors.QuestionColor;
                    break;
                default:
                    panelbody.BackColor = Color.DarkGray; 
                    break;
            }

        }

        private void EnableButton(MetroButton button)
        { 
            EnableButton(button, true); 
        }

        private void EnableButton(MetroButton button, bool enabled)
        {
            button.Enabled = enabled; button.Visible = enabled;
        }

        /// <summary>
        /// Sets the default focused button.
        /// </summary>
        public void SetFocus()
        {
            if (_properties.InputBox)
            {
                if (metroTextBox1 != null)
                {
                    metroTextBox1.Focus();
                    metroTextBox1.Select();
                }
            }
            else
            {
                switch (_properties.DefaultButton)
                {
                    case MessageBoxDefaultButton.Button1:
                        if (metroButton1 != null)
                        {
                            if (metroButton1.Enabled) metroButton1.Focus();
                        }
                        break;
                    case MessageBoxDefaultButton.Button2:
                        if (metroButton2 != null)
                        {
                            if (metroButton2.Enabled) metroButton2.Focus();
                        }
                        break;
                    case MessageBoxDefaultButton.Button3:
                        if (metroButton3 != null)
                        {
                            if (metroButton3.Enabled) metroButton3.Focus();
                        }
                        break;
                    default: break;
                }
            }
        }

        //private void button_MouseClick(object sender, MouseEventArgs e)
        //{
        //    //MetroButton button = (MetroButton)sender;
        //    //button.BackColor = MetroPaint.BackColor.Button.Press(MetroFramework.MetroThemeStyle.Light);
        //    //button.FlatAppearance.BorderColor = MetroPaint.BorderColor.Button.Press(MetroFramework.MetroThemeStyle.Light);
        //    //button.ForeColor = MetroPaint.ForeColor.Button.Press(MetroFramework.MetroThemeStyle.Light);
        //}

        private void button_MouseEnter(object sender, EventArgs e)
        { StylizeButton((MetroButton)sender, true); }

        private void button_MouseLeave(object sender, EventArgs e)
        { StylizeButton((MetroButton)sender); }

        private void StylizeButton(MetroButton button)
        { StylizeButton(button, false); }

        private void StylizeButton(MetroButton button, bool hovered)
        {
            button.Cursor = Cursors.Hand;

            //button.MouseClick -= button_MouseClick;
            //button.MouseClick += button_MouseClick;
            
            button.MouseEnter -= button_MouseEnter;
            button.MouseEnter += button_MouseEnter;

            button.MouseLeave -= button_MouseLeave;
            button.MouseLeave += button_MouseLeave;

            //if (hovered)
            //{
            //    button.FlatAppearance.BorderColor = MetroPaint.BorderColor.Button.Hover(MetroFramework.MetroThemeStyle.Light);
            //    button.ForeColor = MetroPaint.ForeColor.Button.Hover(MetroFramework.MetroThemeStyle.Light);
            //}
            //else
            //{
            //    button.BackColor = MetroPaint.BackColor.Button.Normal(MetroFramework.MetroThemeStyle.Light);
            //    button.FlatAppearance.BorderColor = Color.SlateGray;
            //    button.FlatAppearance.MouseOverBackColor = MetroPaint.BorderColor.Button.Hover(MetroFramework.MetroThemeStyle.Light);
            //    button.ForeColor = MetroPaint.ForeColor.Button.Normal(MetroFramework.MetroThemeStyle.Light);
            //    button.FlatAppearance.BorderSize = 1;
            //}
        }

        private void button_Click(object sender, EventArgs e)
        {
            MetroButton button = (MetroButton)sender;
            if (!button.Enabled) return;
            _result = (DialogResult)button.Tag;
            _inputBoxText = metroTextBox1.Text;
            Hide();
        }

        private void tlpBody_Shown(object sender, EventArgs e)
        {
            SetFocus();
        }

    }
}
