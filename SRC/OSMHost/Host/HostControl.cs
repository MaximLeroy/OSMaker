using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace OSMLoader.Host
{
    /// <summary>
    /// Hosts the HostSurface which inherits from DesignSurface.
    /// </summary>
    public class HostControl : UserControl
    {
        internal HostControl(HostSurface hostSurface)
        {
            base.Load += HostControl_Load;
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();
            InitializeHost(hostSurface);
        }

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;
        private HostSurface _hostSurface;
        private HostSurfaceManager _hostSurfaceManager;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components is object)
                    components.Dispose();
            }

            base.Dispose(disposing);
        }


        /* TODO ERROR: Skipped RegionDirectiveTrivia */        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ContextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenuBar1)).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenuBar1
            // 
            this.ContextMenuBar1.AntiAlias = true;
            this.ContextMenuBar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ContextMenuBar1.IsMaximized = false;
            this.ContextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem1});
            this.ContextMenuBar1.Location = new System.Drawing.Point(331, 211);
            this.ContextMenuBar1.Name = "ContextMenuBar1";
            this.ContextMenuBar1.Size = new System.Drawing.Size(75, 29);
            this.ContextMenuBar1.Stretch = true;
            this.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ContextMenuBar1.TabIndex = 0;
            this.ContextMenuBar1.TabStop = false;
            this.ContextMenuBar1.Text = "ContextMenuBar1";
            // 
            // ButtonItem1
            // 
            this.ButtonItem1.AutoExpandOnClick = true;
            this.ButtonItem1.Name = "ButtonItem1";
            this.ButtonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem2,
            this.ButtonItem3});
            this.ButtonItem1.Text = "ButtonItem1";
            this.ButtonItem1.Click += new System.EventHandler(this.ButtonItem1_Click);
            // 
            // ButtonItem2
            // 
            this.ButtonItem2.Name = "ButtonItem2";
            this.ButtonItem2.Text = "ButtonItem2";
            // 
            // ButtonItem3
            // 
            this.ButtonItem3.Name = "ButtonItem3";
            this.ButtonItem3.Text = "ButtonItem3";
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TestToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(105, 28);
            // 
            // TestToolStripMenuItem
            // 
            this.TestToolStripMenuItem.Name = "TestToolStripMenuItem";
            this.TestToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.TestToolStripMenuItem.Text = "Test";
            // 
            // HostControl
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ContextMenuBar1.SetContextMenuEx(this, this.ButtonItem1);
            this.Controls.Add(this.ContextMenuBar1);
            this.Name = "HostControl";
            this.Size = new System.Drawing.Size(484, 346);
            this.Load += new System.EventHandler(this.HostControl_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenuBar1)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        internal void InitializeHost(HostSurface hostSurface)
        {
            try
            {
                if (hostSurface is null)
                    return;
                _hostSurface = hostSurface;
                Control Control = _hostSurface.View as Control;
                Control.Parent = this;
                Control.Dock = DockStyle.Fill;
                Control.Visible = true;
                Control.ContextMenuStrip = ContextMenuStrip1;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }
        }

        internal HostSurface HostSurface
        {
            get
            {
                return _hostSurface;
            }
        }

        public class codee
        {
        }

        internal IDesignerHost DesignerHost
        {
            get
            {
                return (IDesignerHost)_hostSurface.GetService(typeof(IDesignerHost));
            }
        }

        private void HostControl_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
        }

        internal DevComponents.DotNetBar.ContextMenuBar ContextMenuBar1;
        internal DevComponents.DotNetBar.ButtonItem ButtonItem1;
        internal DevComponents.DotNetBar.ButtonItem ButtonItem2;
        internal DevComponents.DotNetBar.ButtonItem ButtonItem3;
        internal ContextMenuStrip ContextMenuStrip1;
        internal ToolStripMenuItem TestToolStripMenuItem;

        private void HostControl_Load_1(object sender, EventArgs e)
        {

        }
        public IDesignerHost GetIDesignerHost()
        {
            return (IDesignerHost)(this.GetService(typeof(IDesignerHost)));
        }
        public Control CreateControl(Type controlType, Size controlSize, Point controlLocation)
        {
            try
            {
                //- step.1
                //- get the IDesignerHost
                //- if we are not able to get it 
                //- then rollback (return without do nothing)
                IDesignerHost host = DesignerHost;
                if (null == host) return null;
                //- check if the root component has already been set
                //- if not so then rollback (return without do nothing)
                if (null == host.RootComponent) return null;
                //-
                //-
                //- step.2
                //- create a new component and initialize it via its designer
                //- if the component has not a designer
                //- then rollback (return without do nothing)
                //- else do the initialization
                IComponent newComp = host.CreateComponent(controlType);
                if (null == newComp) return null;
                IDesigner designer = host.GetDesigner(newComp);
                if (null == designer) return null;
                if (designer is IComponentInitializer)
                    ((IComponentInitializer)designer).InitializeNewComponent(null);
                //-
                //-
                //- step.3
                //- try to modify the Size/Location of the object just created
                PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(newComp);
                //- Sets a PropertyDescriptor to the specific property.
                PropertyDescriptor pdS = pdc.Find("Size", false);
                if (null != pdS)
                    pdS.SetValue(newComp, controlSize);
                PropertyDescriptor pdL = pdc.Find("Location", false);
                if (null != pdL)
                    pdL.SetValue(newComp, controlLocation);
                //-
                //-
                //- step.4
                //- commit the Creation Operation
                //- adding the control to the DesignSurface's root component
                //- and return the control just created to let further initializations
                ((Control)newComp).Parent = host.RootComponent as Control;
                return newComp as Control;
            }//end_try
            catch (Exception exx)
            {
                Debug.WriteLine(exx.Message);
                if (null != exx.InnerException)
                    Debug.WriteLine(exx.InnerException.Message);

                throw;
            }//end_catch
        }
        private void ButtonItem1_Click(object sender, EventArgs e)
        {

        }
        public void DoAction(string command)
        {
            if (string.IsNullOrEmpty(command)) return;

            IMenuCommandService ims = this.GetService(typeof(IMenuCommandService)) as IMenuCommandService;
            if (null == ims) return;


            try
            {
                switch (command.ToUpper())
                {
                    case "CUT":
                        ims.GlobalInvoke(StandardCommands.Cut);
                        break;
                    case "COPY":
                        ims.GlobalInvoke(StandardCommands.Copy);
                        break;
                    case "PASTE":
                        ims.GlobalInvoke(StandardCommands.Paste);
                        break;
                    case "DELETE":
                        ims.GlobalInvoke(StandardCommands.Delete);
                        break;
                    default:
                        // do nothing;
                        break;
                }//end_switch
            }//end_try
            catch (Exception exx)
            {
                Debug.WriteLine(exx.Message);
                if (null != exx.InnerException)
                    Debug.WriteLine(exx.InnerException.Message);

                throw;
            }//end_catch
        } // class
    } // namespace
}