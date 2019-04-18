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
    class LineTool : CDShapeTool
    {
        public LineTool(): base() { }

        public override object CreateShape(PaintSpace p)
        {
            Line line = new Line(p, pointStart, pointEnd);
            //line.Draw(p.MainGraphics);
            return line;
        }
    }
}
