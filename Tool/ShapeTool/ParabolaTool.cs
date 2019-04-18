using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    class ParabolaTool: CDShapeTool
    {
        public ParabolaTool(): base() { }

        public override object CreateShape(PaintSpace p)
        {
            Parabola parabola = new Parabola(p, pointStart, pointEnd);
            //parabola.Draw(p.MainGraphics);
            return parabola;
        }

        /*public ParabolaTool(): base() { }

        private List<Point> pointList = new List<Point>();

        public override Shape Draw(PaintSpace p)
        {
            Pen pen = new Pen(p.ForeColor, p.BorderWidth);
            pen.DashStyle = (System.Drawing.Drawing2D.DashStyle)p.DashStyle;
            p.MainGraphics.DrawCurve(pen, pointList.ToArray());
            pointList.Clear();
            return null;
        }

        public override void onMouseDown(MouseEventArgs e, PaintSpace p)
        {
            base.onMouseDown(e, p);
            if (isLeftBtn && pointList.Count < 3)
            {
                pointList.Add(pointStart);
                Pen pen = new Pen(p.ForeColor, p.BorderWidth);
                pen.DashStyle = (System.Drawing.Drawing2D.DashStyle)p.DashStyle;
                p.MainGraphics.DrawEllipse(pen, pointStart.X, pointStart.Y, 2, 2);
            }

            if (isRightBtn && pointList.Count > 1)
            {
                Draw(p);
            }
        }*/
    }
}
