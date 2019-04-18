using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    class BezierTool : MultiPointsTool
    {
        public BezierTool() : base() { }

        private List<Point> pointList = new List<Point>();

        public object CreateShape(PaintSpace p)
        {
            Bezier bezier = new Bezier(p, pointList);
            pointList.Clear();
            return bezier;
        }

        public object CreatePartShape(PaintSpace p)
        {
            Bezier bezier = new Bezier(p, pointList);
            return bezier;
        }

        public override object onMouseDown(MouseEventArgs e, PaintSpace p)
        {
            if (e.Button == MouseButtons.Left)
            {
                pointList.Add(e.Location);
                Console.WriteLine(pointList.Count);
                foreach (Point po in pointList)
                {
                    Console.WriteLine("{0},{1}", po.X, po.Y);
                }
                Console.WriteLine();
            }
            if (pointList.Count == 4)
            {
                return CreateShape(p);
            }

            if (pointList.Count > 1)
                return CreatePartShape(p);

            return null;
        }

        public override object onMouseMove(MouseEventArgs e, PaintSpace p)
        {
            return null;
        }

        public override object onMouseUp(MouseEventArgs e, PaintSpace p)
        {
            return null;
        }

        public override void Reset()
        {
            pointList.Clear();
        }
    }
}
