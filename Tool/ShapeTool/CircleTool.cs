using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    class CircleTool : CDShapeTool
    {
        public CircleTool() : base() { }

        public override object CreateShape(PaintSpace p)
        {
            Ellipse ellipse = new Ellipse(p, pointStart, pointEnd);
            //ellipse.Draw(p.MainGraphics);
            return ellipse;
        }
    }
}