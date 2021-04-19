using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI;

namespace OSMaker.Panneaux
{
    public partial class PropertyWindow : ToolWindow
    {
        public PropertyWindow()
        {
            InitializeComponent();
        }

        private void PropertyWindow_Load(object sender, EventArgs e)
        {
          
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            propertyGrid.PropertySort = PropertySort.Alphabetical;
            metroButton1.Highlight = true;
            metroButton2.Highlight = false;
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            propertyGrid.PropertySort = PropertySort.Categorized;
            metroButton1.Highlight = false;
            metroButton2.Highlight = true;
        }
    }
}
