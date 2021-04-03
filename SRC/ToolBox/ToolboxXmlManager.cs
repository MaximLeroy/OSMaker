using System;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;

namespace ToolBox.ToolboxLibrary
{
    /// <summary>
    /// ToolboxXmlManager - Reads an XML file and populates the toolbox.
    /// </summary>
    public class ToolboxXmlManager
    {
        private Toolbox m_toolbox = null;
        private Type[] cpcdosFormsToolTypes = new Type[] { typeof(TextBlock), typeof(Button), typeof(CheckBox), typeof(PictureBox), typeof(ProgressBar), typeof(TextBox) };
        private ToolBox toolBox;

        // Private componentsToolTypes As Type() = New Type() {GetType(System.IO.FileSystemWatcher), GetType(System.Diagnostics.Process), GetType(Timers.Timer)}
        // Private dataToolTypes As Type() = New Type() {GetType(Data.OleDb.OleDbCommandBuilder), GetType(Data.OleDb.OleDbConnection), GetType(Data.SqlClient.SqlCommandBuilder), GetType(Data.SqlClient.SqlConnection)}
        // Private userControlsToolTypes As Type() = New Type() {GetType(UserControl)}

        public ToolboxXmlManager(Toolbox toolbox)
        {
            m_toolbox = toolbox;
        }

        public ToolboxXmlManager(ToolBox toolBox)
        {
            this.toolBox = toolBox;
        }

        public ToolboxTabCollection PopulateToolboxInfo()
        {
            try
            {
                if (object.Equals(Toolbox.FilePath, null) || object.Equals(Toolbox.FilePath, "") || object.Equals(Toolbox.FilePath, string.Empty))
                    return PopulateToolboxTabs();
                var xmlDocument = new XmlDocument();
                xmlDocument.Load(Toolbox.FilePath);
                return PopulateToolboxTabs(xmlDocument);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured in reading Toolbox.xml file." + Constants.vbLf + ex.ToString());
                return null;
            }
        }

        private Toolbox Toolbox
        {
            get
            {
                return m_toolbox;
            }
        }

        private ToolboxTabCollection PopulateToolboxTabs()
        {
            var toolboxTabs = new ToolboxTabCollection();
            var tabNames = new[] { Strings.CpcdosForms }; // Strings.Components, Strings.Data, Strings.UserControls}
            for (int i = 0, loopTo = tabNames.Length - 1; i <= loopTo; i++)
            {
                var toolboxTab = new ToolboxTab();
                toolboxTab.Name = tabNames[i];
                PopulateToolboxItems(toolboxTab);
                toolboxTabs.Add(toolboxTab);
            }

            return toolboxTabs;
        }

        private void PopulateToolboxItems(ToolboxTab toolboxTab)
        {
            if (toolboxTab is null)
                return;
            Type[] typeArray = null;
            switch (toolboxTab.Name ?? "")
            {
                case Strings.CpcdosForms:
                    {
                        typeArray = cpcdosFormsToolTypes;
                        break;
                    }
                    // Case Strings.Components
                    // typeArray = componentsToolTypes
                    // Case Strings.Data
                    // typeArray = dataToolTypes
                    // Case Strings.UserControls
                    // typeArray = userControlsToolTypes
                    // Case Else
            }

            var toolboxItems = new ToolboxItemCollection();
            for (int i = 0, loopTo = typeArray.Length - 1; i <= loopTo; i++)
            {
                var toolboxItem = new ToolboxItem();
                toolboxItem.Type = typeArray[i];
                toolboxItem.Name = typeArray[i].Name;
                toolboxItems.Add(toolboxItem);
            }

            toolboxTab.ToolboxItems = toolboxItems;
        }

        private ToolboxTabCollection PopulateToolboxTabs(XmlDocument xmlDocument)
        {
            if (xmlDocument is null)
                return null;
            var toolboxNode = xmlDocument.FirstChild;
            if (toolboxNode is null)
                return null;
            var tabCollectionNode = toolboxNode.FirstChild;
            if (tabCollectionNode is null)
                return null;
            var tabsNodeList = tabCollectionNode.ChildNodes;
            if (tabsNodeList is null)
                return null;
            var toolboxTabs = new ToolboxTabCollection();
            foreach (XmlNode tabNode in tabsNodeList)
            {
                if (tabNode is null)
                    continue;
                var propertiesNode = tabNode.FirstChild;
                if (propertiesNode is null)
                    continue;
                XmlNode nameNode = propertiesNode[Strings.Name];
                if (nameNode is null)
                    continue;
                var toolboxTab = new ToolboxTab();
                toolboxTab.Name = nameNode.InnerXml.ToString();
                PopulateToolboxItems(tabNode, toolboxTab);
                toolboxTabs.Add(toolboxTab);
            }

            if (toolboxTabs.Count == 0)
                return null;
            return toolboxTabs;
        }

        private void PopulateToolboxItems(XmlNode tabNode, ToolboxTab toolboxTab)
        {
            if (tabNode is null)
                return;
            XmlNode toolboxItemCollectionNode = tabNode[Strings.ToolboxItemCollection];
            if (toolboxItemCollectionNode is null)
                return;
            var toolboxItemNodeList = toolboxItemCollectionNode.ChildNodes;
            if (toolboxItemNodeList is null)
                return;
            var toolboxItems = new ToolboxItemCollection();
            foreach (XmlNode toolboxItemNode in toolboxItemNodeList)
            {
                if (toolboxItemNode is null)
                    continue;
                XmlNode typeNode = toolboxItemNode[Strings.Type];
                if (typeNode is null)
                    continue;
                bool found = false;
                var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies();
                int i = 0;
                while (i < loadedAssemblies.Length && !found)
                {
                    var assembly = loadedAssemblies[i];
                    var types = assembly.GetTypes();
                    int j = 0;
                    while (j < types.Length && !found)
                    {
                        var type = types[j];
                        if (Equals(type.FullName, typeNode.InnerXml.ToString()))
                        {
                            var toolboxItem = new ToolboxItem();
                            toolboxItem.Type = type;
                            toolboxItems.Add(toolboxItem);
                            found = true;
                        }

                        j += 1;
                    }

                    i += 1;
                }
            }

            toolboxTab.ToolboxItems = toolboxItems;
            return;
        }

        private class Strings
        {
            public const string Toolbox = "Toolbox";
            public const string TabCollection = "TabCollection";
            public const string Tab = "Tab";
            public const string Properties = "Properties";
            public const string Name = "Name";
            public const string ToolboxItemCollection = "ToolboxItemCollection";
            public const string ToolboxItem = "ToolboxItem";
            public const string Type = "Type";
            public const string CpcdosForms = "Objets Cpcdos";
            public const string Components = "Components";
            // Public Const Data = "Data"
            public const string UserControls = "User Controls";
        }
    } // class
} // namespace
