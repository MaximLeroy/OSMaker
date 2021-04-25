using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace Host
{
	/// <summary>
	/// Hosts the HostSurface which inherits from DesignSurface.
	/// </summary>
	public class HostControl : System.Windows.Forms.UserControl
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem test2ToolStripMenuItem;
        private HostSurface _hostSurface;

		public HostControl(HostSurface hostSurface)
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			InitializeHost(hostSurface);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.test2ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 52);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.test2ToolStripMenuItem.Text = "Test2";
            // 
            // HostControl
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Name = "HostControl";
            this.Size = new System.Drawing.Size(268, 224);
            this.Load += new System.EventHandler(this.HostControl_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion
		#region  MenuCommandService
		private MenuCommandServiceExt _menuCommandService = null;
		#endregion
		internal void InitializeHost(HostSurface hostSurface)
		{
			try
			{
				if (hostSurface == null)
					return;

				_hostSurface = hostSurface;

				Control control = _hostSurface.View as Control;

				control.Parent = this;
				control.Dock = DockStyle.Fill;
				control.Visible = true;

				 
	}
			catch(Exception ex)
			{
                Trace.WriteLine(ex.ToString());
			}
		}
		public HostSurface HostSurface
		{
			get
			{
				return _hostSurface;
			}
		}
		public IDesignerHost DesignerHost
		{
			get
			{
				return (IDesignerHost)_hostSurface.GetService(typeof(IDesignerHost));
			}
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
        private void HostControl_Load(object sender, EventArgs e)
        {

        }
    } // class
}// namespace
