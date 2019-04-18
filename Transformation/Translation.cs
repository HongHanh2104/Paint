using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class Translation : Transformation
    {
        public Translation(Point pointStart, Point pointEnd) : base(pointStart, pointEnd) { }

        public override void getTransformation(Matrix translation, Point pointAnchor)
        {
            translation.Translate(pointEnd.X - pointStart.X, pointEnd.Y - pointStart.Y);
        }
    }
}
