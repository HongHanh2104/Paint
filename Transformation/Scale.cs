using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class Scale : Transformation
    {
        public Scale(Point pointStart, Point pointEnd) : base(pointStart, pointEnd) { }

        public override void getTransformation(Matrix translation, Point pointAnchor)
        {
            Point vStart = new Point(pointStart.X - pointAnchor.X, pointStart.Y - pointAnchor.Y);
            Point vEnd = new Point(pointEnd.X - pointAnchor.X, pointEnd.Y - pointAnchor.Y);

            if (vStart.X == 0) vStart.X = 1;
            if (vStart.Y == 0) vStart.Y = 1;

            translation.Scale(1 + (vEnd.X - vStart.X) * 1.0f / vStart.X, 1 + (vEnd.Y - vStart.Y) * 1.0f / vStart.Y, MatrixOrder.Append);
        }
    }
}
