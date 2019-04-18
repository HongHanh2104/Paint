using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    class HyperbolaTool: CDShapeTool
    {
        public HyperbolaTool(): base() { }

        public override object CreateShape(PaintSpace p)
        {
            Hyperbola hyperbola = new Hyperbola(p, pointStart, pointEnd);
            //hyperbola.Draw(p.MainGraphics);
            return hyperbola;
        }
    }
}
