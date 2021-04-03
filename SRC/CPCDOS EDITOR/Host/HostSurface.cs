using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;

namespace OSMaker.Host
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
        private BasicDesignerLoader _loader;
        private ISelectionService _selectionService;
        public System.Windows.Forms.Design.WindowsFormsDesignerOptionService designerOptionService = new System.Windows.Forms.Design.WindowsFormsDesignerOptionService();

        // Menu
        public MenuCommandServiceImpl Menu;

        public HostSurface() : base()
        {
            AddService(typeof(IMenuCommandService), new MenuCommandService(this));
            ServiceContainer.AddService(typeof(IMenuCommandService), Menu);
        }

        public HostSurface(IServiceProvider parentProvider) : base(parentProvider)
        {
            AddService(typeof(IMenuCommandService), new MenuCommandService(this));
        }

        internal void Initialize()
        {
            Control control = null;
            IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
            if (host is null)
                return;
            try
            {
                // Set the backcolor
                var hostType = host.RootComponent.GetType();
                if (ReferenceEquals(hostType, typeof(Form)))
                {
                    control = View as Control;
                    control.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)));
                    control.Dock = DockStyle.Fill;
                }
                else if (ReferenceEquals(hostType, typeof(UserControl)))
                {
                    control = View as Control;
                    control.BackColor = Color.White;
                }
                else if (ReferenceEquals(hostType, typeof(Component)))
                {
                    control = View as Control;
                    control.BackColor = Color.FloralWhite;
                }
                else
                {
                    throw new Exception("Undefined Host Type: " + hostType.ToString());
                }


                // Set SelectionService - SelectionChanged event handler
                _selectionService = (ISelectionService)ServiceContainer.GetService(typeof(ISelectionService));
                _selectionService.SelectionChanged += new EventHandler(selectionService_SelectionChanged);
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
            if (_selectionService is object)
            {
                var selectedComponents = _selectionService.GetSelectedComponents();
                AdvPropertyGrid propertyGrid = (AdvPropertyGrid)GetService(typeof(AdvPropertyGrid));
                var comps = new object[selectedComponents.Count];
                int i = 0;
                foreach (var o in selectedComponents)
                {
                    comps[i] = o;
                    i += 1;
                }

                propertyGrid.SelectedObjects = comps;
            }
        }

        public void AddService(Type type, object serviceInstance)
        {
            ServiceContainer.AddService(type, serviceInstance);
        }
    } // class
} // namespace
