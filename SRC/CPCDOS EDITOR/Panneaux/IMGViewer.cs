using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace OSMaker.Panneaux
{
    public partial class IMGViewer : DocumentC
    {
        public IMGViewer()
        {
            InitializeComponent();
        }
        public static string filepath = "";
        // this tracks the transformation applied to the PictureBox's Graphics
        private Matrix transform = new Matrix();
        public static double s_dScrollValue = 1.01; // zoom factor

        private void IMGViewer_Load(object sender, EventArgs e)
        {

        }
        //FUNCTION FOR MOUSE SCROL ZOOM-IN
        private void ZoomScroll(Point location, bool zoomIn)
        {
            // make zoom-point (cursor location) our origin
            transform.Translate(-location.X, -location.Y);

            // perform zoom (at origin)
            if (zoomIn)
                transform.Scale((float)s_dScrollValue, (float)s_dScrollValue);
            else
                transform.Scale((float)(1 / s_dScrollValue), (float)(1 / s_dScrollValue));

            // translate origin back to cursor
            transform.Translate(location.X, location.Y);

            pictureBox1.Invalidate();
        }
        protected override void OnMouseWheel(MouseEventArgs mea)
        {
            pictureBox1.Focus();
            if (pictureBox1.Focused == true && mea.Delta != 0)
            {
                ZoomScroll(mea.Location, mea.Delta > 0);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Transform = transform;
        }
    }
}
