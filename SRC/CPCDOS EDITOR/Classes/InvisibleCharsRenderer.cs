using System;
using System.Drawing;
using FastColoredTextBoxNS;
using Microsoft.VisualBasic.CompilerServices;

namespace OSMaker.OSMaker
{
    public class InvisibleCharsRenderer : Style
    {
        private Pen pen;

        public InvisibleCharsRenderer(Pen pen)
        {
            this.pen = pen;
        }

        public override void Draw(Graphics gr, Point position, Range range)
        {
            var tb = range.tb;
            using (Brush brush = new SolidBrush(pen.Color))
            {
                foreach (Place place in range)
                {
                    char c = tb[place].c;
                    if (Conversions.ToString(c) != " ")
                    {
                        goto IL_BC;
                    }

                    var point = tb.PlaceToPoint(place);
                    point.Offset((int)Math.Round(tb.CharWidth / 2d), (int)Math.Round(tb.CharHeight / 2d));
                    gr.DrawLine(pen, point.X, point.Y, point.X + 1, point.Y);
                    if (tb[place.iLine].Count - 1 == place.iChar)
                    {
                        goto IL_BC;
                    }

                    continue;
                IL_BC:
                    ;
                    if (tb[place.iLine].Count - 1 == place.iChar)
                    {
                        point = tb.PlaceToPoint(place);
                        point.Offset(tb.CharWidth, 0);
                        gr.DrawString("¶", tb.Font, brush, point);
                    }
                }
            }
        }
    }
}