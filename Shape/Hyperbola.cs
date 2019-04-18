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
    class Hyperbola : Shape
    {
        private Point pointStart;
        private Point pointEnd;

        public Hyperbola(PaintSpace p, Point pointStart, Point pointEnd) : base(p)
        {
            this.pointStart = pointStart;
            this.pointEnd = pointEnd;
        }

        public override GraphicsPath CreatePath()
        {
            List<Point> firstQuarterPointLists = GeneratePointLists();

            List<Point> pointLists = new List<Point>();
            List<Point> symmetricPointLists = new List<Point>();
            foreach(Point p in firstQuarterPointLists)
            {
                pointLists.Add(p);
                pointLists.Insert(0, new Point(p.X, pointStart.Y - (p.Y - pointStart.Y)));

                symmetricPointLists.Add(new Point(pointStart.X - (p.X - pointStart.X), p.Y));
                symmetricPointLists.Insert(0, new Point(pointStart.X - (p.X - pointStart.X), pointStart.Y - (p.Y - pointStart.Y)));

            }

            GraphicsPath path1 = new GraphicsPath();
            path1.AddLines(pointLists.ToArray());
            GraphicsPath path2 = new GraphicsPath();
            path2.AddLines(symmetricPointLists.ToArray());

            GraphicsPath path = new GraphicsPath();
            try
            {
                path.AddPath(path1, false);
                path.AddPath(path2, false);
            }
            catch { }

            return path;
        }

        private List<Point> GeneratePointLists()
        {
            List<Point> pointLists = new List<Point>();

            int x0 = pointStart.X, y0 = pointStart.Y;
            int x1 = Math.Abs(pointEnd.X - pointStart.X), y1 = Math.Abs(pointEnd.Y - pointStart.Y);

            int k = 50;
            int a = y1 * y1;
            int b = x1 * x1 - k * k;
            int c = k * k * y1 * y1;

            int x = k, y = 0;
            int p;

            p = a * x * x + a * x + a - (b + c);

            while (a * x >= b * y && y <= y1)
            {
                pointLists.Add(new Point(x0 + x, y0 + y));
                if (p < 0)
                {
                    p = p + 2 * a * (x + 3) - b * (2 * y + 1);
                    x++;

                }
                else
                {
                    p = p - b * (2 * y + 1);
                }
                y++;
            }

            while (x <= x1)
            {
                pointLists.Add(new Point(x0 + x, y0 + y));
                if (p < 0)
                {
                    p = p + a * (2 * x + 3);
                }
                else
                {
                    p = p - 2 * b * (y + 1) + a * (2 * x + 3);
                    y++;
                }
                x++;
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

        public Hyperbola(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            pointStart = (Point)info.GetValue("PointStart", typeof(Point));
            pointEnd = (Point)info.GetValue("PointEnd", typeof(Point));
        }
    }
}
