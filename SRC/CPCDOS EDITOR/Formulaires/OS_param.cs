using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using OSMaker.Classes;

namespace OSMaker.Formulaires
{
    public partial class OS_param : MetroFramework.Forms.MetroForm
    {

        public OS_param()
        {
            InitializeComponent();
        }

        private void OS_param_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(chk_SCREEN_autosize, "Use runtime for select best screen resolution (eg:1920x1080)");
            toolTip1.SetToolTip(txtb_SCREEN_manualresolution, "WARNING: Use compatible resolution for your graphic hardware !");
        }
    }
}
