using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel.Design;

namespace Host
{
    class MenuCommandServiceExt : IMenuCommandService
    {

        //- this ServiceProvider is the DesignsurfaceExt2 instance 
        //- passed as paramter inside the ctor
        IServiceProvider _serviceProvider = null;

        MenuCommandService _menuCommandService = null;

        public MenuCommandServiceExt(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
            _menuCommandService = new MenuCommandService(serviceProvider);
        }

        public void ShowContextMenu(CommandID menuID, int x, int y)
        {
            ContextMenu contextMenu = new ContextMenu();

            // Add the standard commands CUT/COPY/PASTE/DELETE
            MenuCommand command = FindCommand(StandardCommands.Cut);
            if (command != null)
            {
                MenuItem menuItem = new MenuItem("Cut", new EventHandler(OnMenuClicked));
                menuItem.Tag = command;
                contextMenu.MenuItems.Add(menuItem);
            }
            command = FindCommand(StandardCommands.Copy);
            if (command != null)
            {
                MenuItem menuItem = new MenuItem("Copy", new EventHandler(OnMenuClicked));
                menuItem.Tag = command;
                contextMenu.MenuItems.Add(menuItem);
            }
            command = FindCommand(StandardCommands.Paste);
            if (command != null)
            {
                MenuItem menuItem = new MenuItem("Paste", new EventHandler(OnMenuClicked));
                menuItem.Tag = command;
                contextMenu.MenuItems.Add(menuItem);
            }
            command = FindCommand(StandardCommands.Delete);
            if (command != null)
            {
                MenuItem menuItem = new MenuItem("Delete", new EventHandler(OnMenuClicked));
                menuItem.Tag = command;
                contextMenu.MenuItems.Add(menuItem);
            }

            //- Show the contexteMenu
            DesignSurface surface = (DesignSurface)_serviceProvider;
            Control viewService = (Control)surface.View;

            if (viewService != null)
            {
                contextMenu.Show(viewService, viewService.PointToClient(new Point(x, y)));
            }
        }

        //- Management of the selections of the contexteMenu
        private void OnMenuClicked(object sender, EventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;
            if (menuItem != null && menuItem.Tag is MenuCommand)
            {
                MenuCommand command = menuItem.Tag as MenuCommand;
                command.Invoke();
            }
        }


        public void AddCommand(MenuCommand command)
        {
            _menuCommandService.AddCommand(command);
        }


        public void AddVerb(DesignerVerb verb)
        {
            _menuCommandService.AddVerb(verb);
        }


        public MenuCommand FindCommand(CommandID commandID)
        {
            return _menuCommandService.FindCommand(commandID);
        }


        public bool GlobalInvoke(CommandID commandID)
        {
            return _menuCommandService.GlobalInvoke(commandID);
        }


        public void RemoveCommand(MenuCommand command)
        {
            _menuCommandService.RemoveCommand(command);
        }


        public void RemoveVerb(DesignerVerb verb)
        {
            _menuCommandService.RemoveVerb(verb);
        }


        public DesignerVerbCollection Verbs
        {
            get
            {
                return _menuCommandService.Verbs;
            }
        }
    }
}
