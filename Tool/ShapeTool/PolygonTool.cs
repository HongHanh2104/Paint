using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    class PolygonTool : MultiPointsTool
    {
        public PolygonTool(): base() { }

        private List<Point> pointList = new List<Point>();

        public object CreateShape(PaintSpace p)
        {
            Polygon polygon = new Polygon(p, pointList);
            pointList.Clear();
            return polygon;
        }

        public object CreatePartShape(PaintSpace p)
        {
            if (pointList.Count > 2)
            {
                Polygon polygon = new Polygon(p, pointList);
                return polygon;
            }
            return new Line(p, pointList[0], pointList[1]);
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
            else if (e.Button == MouseButtons.Right && pointList.Count > 1)
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
