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
    class RectangleTool : CDShapeTool
    {
        public RectangleTool() : base() { }

        public override object CreateShape(PaintSpace p)
        {
            MyRectangle rect = new MyRectangle(p, pointStart, pointEnd);
            //rect.Draw(p.MainGraphics);
            return rect;
        }
    }
}
