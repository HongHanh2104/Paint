using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    class SelectionTool : CDShapeTool
    {
        public SelectionTool() : base() { }

        public override object CreateShape(PaintSpace p)
        {
            PaintSpace np = new PaintSpace
            {
                BackColor = Color.Transparent,
                ForeColor = Color.Transparent,
                MainGraphics = p.MainGraphics,
                DashStyle = (int)DashStyle.Solid,
                BorderWidth = 0.5f
            };

            MyRectangle rect = new MyRectangle(np, pointStart, pointEnd);
            return rect;
        }

        public override PaintTool Type()
        {
            return PaintTool.SelectionTool;
        }
    }
}
