using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace Host 
{
    /// <summary>
    /// Inherits from DesignSurface and hosts the RootComponent and 
    /// all other designers. It also uses loaders (BasicDesignerLoader
    /// or CodeDomDesignerLoader) when required. It also provides various
    /// services to the designers. Adds MenuCommandService which is used
    /// for Cut, Copy, Paste, etc.
    /// </summary>
	public class HostSurface : DesignSurface
	{
		#region  MenuCommandService
		private MenuCommandServiceExt _menuCommandService = null;
		#endregion
		private BasicDesignerLoader _loader;
		private ISelectionService _selectionService; 

		public HostSurface() : base()
		{
            this.AddService(typeof(IMenuCommandService), new MenuCommandService(this));
		}
		public HostSurface(IServiceProvider parentProvider) : base(parentProvider)
		{
            this.AddService(typeof(IMenuCommandService), new MenuCommandService(this));
        }

		internal void Initialize()
		{

			Control control = null;
			IDesignerHost host = (IDesignerHost)this.GetService(typeof(IDesignerHost));
			_menuCommandService = new MenuCommandServiceExt(this);
			if (_menuCommandService != null)
			{
				//- remove the old Service, i.e. the DesignsurfaceExt service
				this.ServiceContainer.RemoveService(typeof(IMenuCommandService), false);
				//- add the new IMenuCommandService
				this.ServiceContainer.AddService(typeof(IMenuCommandService), _menuCommandService);
			}
			if (host == null)
				return;

			try
			{
				// Set the backcolor
			
					control = this.View as Control;
				control.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)));


				// Set SelectionService - SelectionChanged event handler
				_selectionService = (ISelectionService)(this.ServiceContainer.GetService(typeof(ISelectionService)));
				_selectionService.SelectionChanged += new EventHandler(selectionService_SelectionChanged);
				this.ServiceContainer.AddService(typeof(IMenuCommandService), new MenuCommandService(this));
			}
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }
        }

		public BasicDesignerLoader Loader
		{
			get
			{
				return _loader;
			}
			set
			{
				_loader = value;
			}
		}

		/// <summary>
        /// When the selection changes this sets the PropertyGrid's selected component 
		/// </summary>
        private void selectionService_SelectionChanged(object sender, EventArgs e)
		{
			if (_selectionService != null)
			{
				ICollection selectedComponents = _selectionService.GetSelectedComponents();
				PropertyGrid propertyGrid = (PropertyGrid)this.GetService(typeof(PropertyGrid));


				object[] comps = new object[selectedComponents.Count];
				int i = 0;

				foreach (Object o in selectedComponents)
				{
					comps[i] = o;
					i++;
				}

				propertyGrid.SelectedObjects = comps;
			}
		}

		public void AddService(Type type, object serviceInstance)
		{
			this.ServiceContainer.AddService(type, serviceInstance);
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
		}

	}// class
}// namespace
