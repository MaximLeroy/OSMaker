using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
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
        public event EventHandler DoubleClick;
        // Menu
        public MenuCommandServiceImpl Menu;
        [CLSCompliant(false)]
        public OSMaker.UndoEngineImpl undoEngine;

        private void doublbcli(object sender, EventArgs e)
        {
            MessageBox.Show("double click");
        }
        public HostSurface() : base()
        {
            this.AddService(typeof(IMenuCommandService), new MenuCommandService(this.ServiceContainer));
            //You only need to do your own implementation if you want to do something special. 
            this.AddService(typeof(IDesignerSerializationService),
                new DesignerSerializationService(this.ServiceContainer));
            this.AddService(typeof(ComponentSerializationService),
                new CodeDomComponentSerializationService(this.ServiceContainer));
            // AJOUT : UndoEngine
            UndoEngine undoEngine = new UndoEngineImpl(this.ServiceContainer);

            //- enable the UndoEngine
            undoEngine.Enabled = true;
            if (undoEngine != null)
            {
                //- the UndoEngine is ready to be replaced
                this.ServiceContainer.RemoveService(typeof(UndoEngine), false);
                this.ServiceContainer.AddService(typeof(UndoEngine), undoEngine);
                Menu = new MenuCommandServiceImpl(this.ServiceContainer);
                Menu.Designer = this;
                ServiceContainer.AddService(typeof(System.ComponentModel.Design.IMenuCommandService), Menu);
                Menu.AddCommand(new MenuCommand(new EventHandler(this.ExecuteUndo), StandardCommands.Undo));
                Menu.AddCommand(new MenuCommand(new EventHandler(this.ExecuteRedo), StandardCommands.Redo));

            }
        }

        public HostSurface(IServiceProvider parentProvider) : base(parentProvider)
        {
            Menu = new MenuCommandServiceImpl(this.ServiceContainer);
            Menu.Designer = this;
            ServiceContainer.AddService(typeof(System.ComponentModel.Design.IMenuCommandService), Menu);
            Menu.AddCommand(new MenuCommand(new EventHandler(this.ExecuteUndo), StandardCommands.Undo));
            Menu.AddCommand(new MenuCommand(new EventHandler(this.ExecuteRedo), StandardCommands.Redo));
            // idem  correction
            //  this.AddService(typeof(IMenuCommandService), new MenuCommandService(this.ServiceContainer));
            // Ajout : les 2 lignes de code suivantes. 
            this.AddService(typeof(IDesignerSerializationService),
                new DesignerSerializationService(this.ServiceContainer));
            this.AddService(typeof(ComponentSerializationService),
                new CodeDomComponentSerializationService(this.ServiceContainer));
            this.AddService(typeof(UndoEngine), new UndoEngineImpl(this.ServiceContainer));
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
                  control.Font = new Font("Consolas", 7.8f);
                   
                    
                    
                }
                else if (ReferenceEquals(hostType, typeof(UserControl)))
                {
                    control = View as Control;
                    control.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)));
                    control.Dock = DockStyle.Fill;
                    control.Font = new Font("Consolas", 7.8f);
                   
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
        /// 
        // ICI les EVENT HANDLERS
        private void ExecuteUndo(object sender, EventArgs e)
        {

            UndoEngineImpl undoEngine = this.GetService(typeof(UndoEngine)) as UndoEngineImpl;

            if (undoEngine != null)

                undoEngine.DoUndo();

        }

        private void ExecuteRedo(object sender, EventArgs e)
        {

            UndoEngineImpl undoEngine = this.GetService(typeof(UndoEngine)) as UndoEngineImpl;

            if (undoEngine != null)

                undoEngine.DoRedo();

        }
        private void selectionService_SelectionChanged(object sender, EventArgs e)
        {
            if (_selectionService is object)
            {
                var selectedComponents = _selectionService.GetSelectedComponents();
               
               PropertyGrid propertyGrid = (PropertyGrid)GetService(typeof(PropertyGrid));
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
