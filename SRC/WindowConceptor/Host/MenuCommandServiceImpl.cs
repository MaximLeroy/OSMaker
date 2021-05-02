using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel.Design;


namespace WindowConceptor.Host
{
    public class MenuCommandServiceImpl : MenuCommandService
    {
        // Liste des services du DesignSurface
        IServiceProvider serviceProvider;


        public HostSurface Designer;
        // MenuCommmand de base
        System.ComponentModel.Design.MenuCommandService menuCommandService = null;

        public MenuCommandServiceImpl(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            menuCommandService = new System.ComponentModel.Design.MenuCommandService(serviceProvider);

            MenuCommand undoCommand = new MenuCommand(new EventHandler(ExecuteUndo), StandardCommands.Undo);
            menuCommandService.AddCommand(undoCommand);

            MenuCommand redoCommand = new MenuCommand(new EventHandler(ExecuteRedo), StandardCommands.Redo);
            menuCommandService.AddCommand(redoCommand);

            MenuCommand ViewCodeCommand = new MenuCommand(new EventHandler(OnExecuteViewCode2), StandardCommands.ViewCode);
            menuCommandService.AddCommand(ViewCodeCommand);

            MenuCommand PropertyCommand = new MenuCommand(new EventHandler(OnExecuteViewProperty2), StandardCommands.Properties);
            menuCommandService.AddCommand(PropertyCommand);

            MenuCommand CreateEventCommand = new MenuCommand(new EventHandler(OnExecuteCreateEvent2), StandardCommands.DocumentOutline);
            menuCommandService.AddCommand(CreateEventCommand);
        }

        // Affichage du contexteMenu
        // Affiche la commande supprimer
        public override void ShowContextMenu(System.ComponentModel.Design.CommandID menuID, int x, int y)
        {


            // Création du contextMenu
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem contextMenuitems = new ToolStripMenuItem();
            contextMenu.Items.AddRange(new ToolStripMenuItem[] { contextMenuitems });

            System.ComponentModel.Design.MenuCommand command;

            // Ajout de la commande
            command = menuCommandService.FindCommand(System.ComponentModel.Design.StandardCommands.Undo);
            

            // Ajout de la commande
            command = menuCommandService.FindCommand(System.ComponentModel.Design.StandardCommands.Redo);
           

            contextMenu.Items.Add(new ToolStripSeparator());

            // Ajout de la commande
            command = menuCommandService.FindCommand(System.ComponentModel.Design.StandardCommands.Cut);
            

            // Ajout de la commande
            command = menuCommandService.FindCommand(System.ComponentModel.Design.StandardCommands.Copy);
          

            // Ajout de la command
            command = menuCommandService.FindCommand(System.ComponentModel.Design.StandardCommands.Paste);
           

            // Ajout de la commande
            command = menuCommandService.FindCommand(System.ComponentModel.Design.StandardCommands.Delete);
           
            contextMenuitems.DropDownItems.Add(new ToolStripSeparator());

            //// Ajout de la commande
            //if (Designer != null)
            //{
            //    VelerSoftware.Design.Toolkit.KryptonContextMenuItem Select_menuItem;
            //    VelerSoftware.Design.Toolkit.KryptonContextMenuItems Selects_menuItem = new VelerSoftware.Design.Toolkit.KryptonContextMenuItems();
            //    if (Variables.Langue == "fr") { Select_menuItem = new VelerSoftware.Design.Toolkit.KryptonContextMenuItem(Resources.SelectionnerTexte, null, null); } else { Select_menuItem = new VelerSoftware.Design.Toolkit.KryptonContextMenuItem(Resources.SelectionnerTexte_EN, null, null); }
            //    foreach (System.ComponentModel.Component item in Designer.ComponentContainer.Components)
            //    {
            //        VelerSoftware.Design.Toolkit.KryptonContextMenuItem Component_menuItem;
            //        Component_menuItem = new VelerSoftware.Design.Toolkit.KryptonContextMenuItem(item.Site.Name, new EventHandler(OnSelectComponentEvent2));
            //        Component_menuItem.Tag = item;
            //        Selects_menuItem.Items.Add(Component_menuItem);
            //    }
            //    Select_menuItem.Items.Add(Selects_menuItem);
            //    contextMenuitems.Items.Add(Select_menuItem);
            //}

            // Ajout de la command
            command = menuCommandService.FindCommand(System.ComponentModel.Design.StandardCommands.SelectAll);
         

            contextMenuitems.DropDownItems.Add(new ToolStripSeparator());

            // Ajout de la commande
            command = menuCommandService.FindCommand(System.ComponentModel.Design.StandardCommands.BringToFront);
        
            // Ajout de la commande
            command = menuCommandService.FindCommand(System.ComponentModel.Design.StandardCommands.SendToBack);
           

            contextMenuitems.DropDownItems.Add(new ToolStripSeparator());

            // Ajout de la commande
            command = menuCommandService.FindCommand(System.ComponentModel.Design.StandardCommands.LockControls);
            if (command != null)
           

            contextMenuitems.DropDownItems.Add(new ToolStripSeparator());

            // Ajout de la commande
            command = menuCommandService.FindCommand(System.ComponentModel.Design.StandardCommands.ViewCode);
            if (command != null)
       

            // Ajout de la commande
            command = menuCommandService.FindCommand(System.ComponentModel.Design.StandardCommands.DocumentOutline);
          

            // Ajout de la commande
            command = menuCommandService.FindCommand(System.ComponentModel.Design.StandardCommands.Properties);
        

            // Affichage du contextMenu


            // erreur sur Designer.View : conversion impossible de 'object' en system.windows.form.control
            Conceptor _editeur = new Conceptor();
            _editeur.metroContextMenu1.Show(Conceptor.HostC, new Point(System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y));

        }

        // Gestion des selections du contexteMenu
        private void OnMenuClicked(object sender, EventArgs e)
        {
            ToolStripDropDownButton menuItem = sender as ToolStripDropDownButton;
            if (menuItem != null && menuItem.Tag is System.ComponentModel.Design.MenuCommand)
            {
                System.ComponentModel.Design.MenuCommand command = menuItem.Tag as System.ComponentModel.Design.MenuCommand;
                command.Invoke();
            }
        }

        // Ajout de command satndard au service
        public override void AddCommand(System.ComponentModel.Design.MenuCommand command)
        {
            try
            {
                menuCommandService.AddCommand(command);
            }
            catch
            {
            }
        }

        // Ajout de verb au service
        public override void AddVerb(System.ComponentModel.Design.DesignerVerb verb)
        {
            menuCommandService.AddVerb(verb);
        }

        // Recherche une commande standard à partir de son id
        public new System.ComponentModel.Design.MenuCommand FindCommand(System.ComponentModel.Design.CommandID commandID)
        {
            return menuCommandService.FindCommand(commandID);
        }

        // Exécute une command standard
        public override bool GlobalInvoke(System.ComponentModel.Design.CommandID commandID)
        {
            return menuCommandService.GlobalInvoke(commandID);
        }

        // Retire une command satndard du service
        public override void RemoveCommand(System.ComponentModel.Design.MenuCommand command)
        {
            menuCommandService.RemoveCommand(command);
        }

        // Retire un verb du service
        public override void RemoveVerb(System.ComponentModel.Design.DesignerVerb verb)
        {
            menuCommandService.RemoveVerb(verb);
        }

        // Retourne la liste de verbs du service
        public override System.ComponentModel.Design.DesignerVerbCollection Verbs
        {
            get
            {
                return menuCommandService.Verbs;
            }
        }

        public void ExecuteUndo(object sender, EventArgs e)
        {
            UndoEngineImpl undoEngine = GetService(typeof(UndoEngine)) as UndoEngineImpl;
            if (undoEngine != null)
                undoEngine.DoUndo();
        }

        public void ExecuteRedo(object sender, EventArgs e)
        {
            UndoEngineImpl undoEngine = GetService(typeof(UndoEngine)) as UndoEngineImpl;
            if (undoEngine != null)
                undoEngine.DoRedo();
        }




        public void OnExecuteViewCode2(object sender, EventArgs e)
        {
            if (this.OnExecuteViewCode != null)
            {
                this.OnExecuteViewCode(sender, e);
            }
        }

        /// <summary>
        /// Declare un delegate
        /// </summary>
        public delegate void OnExecuteViewCodeEventHandler(object sender, EventArgs e);
        /// <summary>
        /// Declare un evenement qui va contenir les informations que nous souhaitons envoyer
        /// </summary>
        public event OnExecuteViewCodeEventHandler OnExecuteViewCode;




        public void OnExecuteViewProperty2(object sender, EventArgs e)
        {
            if (this.OnExecuteViewProperty != null)
            {
                this.OnExecuteViewProperty(sender, e);
            }
        }

        /// <summary>
        /// Declare un delegate
        /// </summary>
        public delegate void OnExecuteViewPropertyEventHandler(object sender, EventArgs e);
        /// <summary>
        /// Declare un evenement qui va contenir les informations que nous souhaitons envoyer
        /// </summary>
        public event OnExecuteViewPropertyEventHandler OnExecuteViewProperty;





        public void OnExecuteCreateEvent2(object sender, EventArgs e)
        {
            if (this.OnExecuteCreateEvent != null)
            {
                this.OnExecuteCreateEvent(sender, e);
            }
        }

        /// <summary>
        /// Declare un delegate
        /// </summary>
        public delegate void OnExecuteCreateEventEventHandler(object sender, EventArgs e);
        /// <summary>
        /// Declare un evenement qui va contenir les informations que nous souhaitons envoyer
        /// </summary>
        public event OnExecuteCreateEventEventHandler OnExecuteCreateEvent;





        public void OnSelectComponentEvent2(object sender, EventArgs e)
        {
            if (this.OnSelectComponentEvent != null)
            {
                this.OnSelectComponentEvent(sender, e);
            }
        }

        /// <summary>
        /// Declare un delegate
        /// </summary>
        public delegate void OnSelectComponentEventEventHandler(object sender, EventArgs e);
        /// <summary>
        /// Declare un evenement qui va contenir les informations que nous souhaitons envoyer
        /// </summary>
        public event OnSelectComponentEventEventHandler OnSelectComponentEvent;

    }
}