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
    class PencilTool:Tool
    {
        public PencilTool() : base() { } 
        GraphicsPath graphicsPath = new GraphicsPath();
        private Point lastPoint;

        public void Draw(Pen pen, Graphics g)
        {
            graphicsPath.Widen(pen);
            graphicsPath.Flatten(); 
            g.DrawPath(pen, graphicsPath);
            graphicsPath.Reset();
            //Console.WriteLine("Start Point: {0} ", StartPoint);
            //Console.WriteLine("End Point: {0}", EndPoint);
        }

        public override void onMouseDown(MouseEventArgs e, PaintSpace p)
        {
            base.onMouseDown(e, p);
            lastPoint = EndPoint;
        }

        public override void onMouseMove(MouseEventArgs e, PaintSpace p)
        {
            base.onMouseMove(e, p);
            if (IsDragging)
            {
                if (lastPoint != EndPoint)
                {
                    graphicsPath.AddLine(EndPoint, lastPoint);
                    lastPoint = EndPoint;
                    Draw(p.MainPen, p.MainGraphics);
                    //Console.WriteLine("Draw Draw Draw !!!!");
                }
            }
        }
    }
}
