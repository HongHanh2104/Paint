using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    class ParabolaTool: Tool
    {
        public ParabolaTool(): base() { }

        private List<Point> pointList = new List<Point>();

        private void Draw(PaintSpace p)
        {
            p.MainGraphics.DrawCurve(p.MainPen, pointList.ToArray());
            pointList.Clear();
        }

        public override void onMouseDown(MouseEventArgs e, PaintSpace p)
        {
            base.onMouseDown(e, p);
            if (IsLeftBtn && pointList.Count < 3)
            {
                pointList.Add(StartPoint);
                p.MainGraphics.DrawEllipse(p.MainPen, StartPoint.X, StartPoint.Y, 2, 2);
            }

            if (IsRightBtn && pointList.Count > 1)
            {
                Draw(p);
            }
        }
    }
}
