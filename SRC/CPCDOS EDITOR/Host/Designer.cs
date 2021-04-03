using System;
using System.Windows.Forms;
using ToolBox;

using ToolBox.ToolboxLibrary;

namespace OSMaker.Host
{
    public class Designer : System.ComponentModel.Design.DesignSurface
    {

        // Gestion des options de design
        public System.Windows.Forms.Design.WindowsFormsDesignerOptionService designerOptionService = new System.Windows.Forms.Design.WindowsFormsDesignerOptionService();

        // Menu
        public MenuCommandServiceImpl Menu;

        public System.ComponentModel.Design.ServiceContainer _ServiceContainer
        {
            get
            {
                return ServiceContainer;
            }
        }

        public Designer() : this(false, true, true, true, true, true, true)
        {
        }

        public Designer(bool ShowGrid, bool EnableInSituEditing, bool UseSnapLines, bool UseOptimizedCodeGeneration, bool UseSmartTags, bool ObjectBoundSmartTagAutoShow, bool SnapToGrid) : base()
        {
            // Service de gestion du toolbox
            ServiceContainer.AddService(typeof(System.Drawing.Design.IToolboxService), new Toolbox());
            // ServiceContainer.AddService(typeof(System.ComponentModel.Design.IResourceService), new DesignerResourceService(this.resourceStore));
            ServiceContainer.AddService(typeof(AmbientProperties), new AmbientProperties());
            // Service de vue du concepteur
            // ServiceContainer.AddService(typeof(ViewService), new ViewService());
            // Service de gestion des menus
            Menu = new MenuCommandServiceImpl(ServiceContainer);
            // AddHandler Me.Menu.OnExecuteViewCode, AddressOf Me.Menu_OnExecuteViewCode
            // AddHandler Me.Menu.OnExecuteViewProperty, AddressOf Me.Menu_OnExecuteViewProperty
            // AddHandler Me.Menu.OnExecuteCreateEvent, AddressOf Me.Menu_OnExecuteCreateEvent
            // AddHandler Me.Menu.OnSelectComponentEvent, AddressOf Me.Menu_OnSelectComponentEvent
            // Me.Menu.Designer = Me
            ServiceContainer.AddService(typeof(System.ComponentModel.Design.IMenuCommandService), Menu);
            // On sp�cifie qu'on va utilser la grille pour placer les composants
            designerOptionService.CompatibilityOptions.ShowGrid = ShowGrid;
            designerOptionService.CompatibilityOptions.EnableInSituEditing = EnableInSituEditing;
            designerOptionService.CompatibilityOptions.UseSnapLines = UseSnapLines;
            designerOptionService.CompatibilityOptions.UseOptimizedCodeGeneration = UseOptimizedCodeGeneration;
            designerOptionService.CompatibilityOptions.UseSmartTags = UseSmartTags;
            designerOptionService.CompatibilityOptions.ObjectBoundSmartTagAutoShow = ObjectBoundSmartTagAutoShow;
            designerOptionService.CompatibilityOptions.SnapToGrid = SnapToGrid;
            ServiceContainer.AddService(typeof(System.ComponentModel.Design.DesignerOptionService), designerOptionService);
        }

        public void Menu_OnExecuteViewCode(object sender, EventArgs e)
        {
            OnExecuteViewCode?.Invoke(sender, e);
        }

        public delegate void OnExecuteViewCodeEventHandler(object sender, EventArgs e);

        public event OnExecuteViewCodeEventHandler OnExecuteViewCode;

        public void Menu_OnExecuteViewProperty(object sender, EventArgs e)
        {
            OnExecuteViewProperty?.Invoke(sender, e);
        }

        public delegate void OnExecuteViewPropertyEventHandler(object sender, EventArgs e);

        public event OnExecuteViewPropertyEventHandler OnExecuteViewProperty;

        public void Menu_OnExecuteCreateEvent(object sender, EventArgs e)
        {
            OnExecuteCreateEvent?.Invoke(sender, e);
        }

        public delegate void OnExecuteCreateEventEventHandler(object sender, EventArgs e);

        public event OnExecuteCreateEventEventHandler OnExecuteCreateEvent;

        public void Menu_OnSelectComponentEvent(object sender, EventArgs e)
        {
            OnSelectComponentEvent?.Invoke(sender, e);
        }

        public delegate void OnSelectComponentEventEventHandler(object sender, EventArgs e);

        public event OnSelectComponentEventEventHandler OnSelectComponentEvent;
    }
}