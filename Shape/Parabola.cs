using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    [Serializable]
    class Parabola : Shape
    {
        private Point pointStart;
        private Point pointEnd;

        public Parabola(PaintSpace p, Point pointStart, Point pointEnd) : base(p)
        {
            this.pointStart = pointStart;
            this.pointEnd = pointEnd;
        }

        public void addSymmetricPoints(List<Point> pointLists, int x, int y)
        {
            pointLists.Add(new Point(pointStart.X + x, pointStart.Y + y));
            pointLists.Insert(0, new Point(pointStart.X - x, pointStart.Y + y));
        }

        public override GraphicsPath CreatePath()
        {
            List<Point> pointLists = GeneratePointLists();
            GraphicsPath path = new GraphicsPath();
            path.AddLines(pointLists.ToArray());
            return path;
            /*
            int x0 = pointStart.X, y0 = pointStart.Y;
            int x1 = this.pointEnd.X - pointStart.X, y1 = this.pointEnd.Y - pointStart.Y;
            int k = x1 * x1;
            int a = y1;

            Point C = new Point(pointStart.X, pointStart.Y);
            Point C1 = new Point(pointStart.X - x1, pointStart.Y + y1);
            Point C4 = new Point(pointStart.X + x1, pointStart.Y + y1);
            Point C2 = new Point(C1.X / 3 + 2 * C.X / 3, C1.Y / 3 + 2 * C.Y / 3);
            Point C3 = new Point(C4.X / 3 + 2 * C.X / 3, C4.Y / 3 + 2 * C.Y / 3);
            

            GraphicsPath path = new GraphicsPath();
            path.AddBezier(C1, C2, C3, C4);
            return path;
            */
        }

        private List<Point> GeneratePointLists()
        {
            List<Point> pointLists = new List<Point>();

            int x0 = pointStart.X, y0 = pointStart.Y;
            int x1 = this.pointEnd.X - pointStart.X, y1 = this.pointEnd.Y - pointStart.Y;
            int k = x1 * x1;
            int a = y1;

            if (x1 < 0)
            {
                x1 = -x1;
            }

            int yi = 1;
            if (a < 0)
            {
                yi = -1;
                a = -a;
            }

            int x = 0, y = 0;
            int p = k / 2 - a;

            while (2 * a * x <= k && x <= x1)
            {
                addSymmetricPoints(pointLists, x, y);
                if (p >= 0)
                {
                    p = p - 2 * a * x - 3 * a;
                }
                else
                {
                    p = p - 2 * a * x + k - 3 * a;
                    y += yi;
                }
                x++;
            }

            p = a / 2 - k;

            while (yi * y <= yi * y1)
            {
                addSymmetricPoints(pointLists, x, y);
                if (p >= 0)
                {
                    p = p - k;
                }
                else
                {
                    p = p + 2 * a * (x + 1) - k;
                    x++;
                }
                y += yi;
            }

            return pointLists;
        }

        public override Point GetAnchor()
        {
            return pointStart;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue("PointStart", pointStart, typeof(Point));
            info.AddValue("PointEnd", pointEnd, typeof(Point));
        }

        public Parabola(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            pointStart = (Point)info.GetValue("PointStart", typeof(Point));
            pointEnd = (Point)info.GetValue("PointEnd", typeof(Point));
        }
    }
}
