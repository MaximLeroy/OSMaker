//using System;
//using System.Collections.Generic;
//using System.ComponentModel.Design;
//using System.Diagnostics;
//using System.Drawing;
//using System.Windows.Forms;

//namespace OSMaker.Host
//{
//    public class MenuCommandServiceImpl : MenuCommandService
//    {
//        private DesignerVerbCollection m_globalVerbs = new DesignerVerbCollection();
//        public interface IDesignerSerializationService
//        {

//        }
//        public MenuCommandServiceImpl(IServiceProvider serviceProvider) : base(serviceProvider)
//        {
//            m_globalVerbs.Add(StandartVerb("Cut", StandardCommands.Cut));
//            m_globalVerbs.Add(StandartVerb("Copy", StandardCommands.Copy));
//            m_globalVerbs.Add(StandartVerb("Paste", StandardCommands.Paste));
//            m_globalVerbs.Add(StandartVerb("Delete", StandardCommands.Delete));
//            m_globalVerbs.Add(StandartVerb("Select All", StandardCommands.SelectAll));

//        }

//        private DesignerVerb StandartVerb(string text, CommandID commandID)
//        {
//            return new DesignerVerb(text, (o, e) =>
//            {
//                IMenuCommandService ms = GetService(typeof(IMenuCommandService)) as IMenuCommandService;
//                Debug.Assert(ms is object);
//                ms.GlobalInvoke(commandID);
//            });
//        }

//        public class MenuItem : ToolStripMenuItem
//        {
//            private DesignerVerb verb;

//            public MenuItem(DesignerVerb verb) : base(verb.Text)
//            {
//                Enabled = verb.Enabled;
//                this.verb = verb;
//                Click += InvokeCommand;
//            }

//            private void InvokeCommand(object sender, EventArgs e)
//            {
//                try
//                {
//                    verb.Invoke();
//                }
//                catch (Exception ex)
//                {
//                    Trace.Write("MenuCommandServiceImpl: " + ex.ToString());
//                }
//            }
//        }

//        private ToolStripItem[] BuildMenuItems()
//        {
//            var items = new List<ToolStripItem>();
//            foreach (DesignerVerb verb in m_globalVerbs)
//                items.Add(new MenuItem(verb));
//            return items.ToArray();
//        }

//        public override void ShowContextMenu(CommandID menuID, int x, int y)
//        {
//            var cm = new ContextMenuStrip();
//            cm.Items.AddRange(BuildMenuItems());
//            ISelectionService ss = GetService(typeof(ISelectionService)) as ISelectionService;
//            Debug.Assert(ss is object);
//            Control ps = ss.PrimarySelection as Control;
//            Debug.Assert(ps is object);
//            var s = ps.PointToScreen(new Point(0, 0));
//            cm.Show(ps, new Point(x - s.X, y - s.Y));
//        }

//    }
//}