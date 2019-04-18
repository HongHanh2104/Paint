using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class Rotation : Transformation
    {
        int direction;

        public Rotation(Point pointStart, Point pointEnd, int direction) : base(pointStart, pointEnd)
        {
            this.direction = direction;
        }

        public float GetAngle(Point v1, Point v2)
        {
            double cos = (v1.X * v2.X + v1.Y * v2.Y) * 1.0 / (Math.Sqrt(v1.X * v1.X + v1.Y * v1.Y) * Math.Sqrt(v2.X * v2.X + v2.Y * v2.Y));
            Console.WriteLine(cos);
            float angle = (float)(Math.Acos(cos) * 180.0f / Math.PI);
            //if (direction * cos > 0) angle = -angle;
            return angle;
        }

        public override void getTransformation(Matrix translation, Point pointAnchor)
        {
            Point vStart = new Point(pointStart.X - pointAnchor.X, pointStart.Y - pointAnchor.Y);
            Point vEnd = new Point(pointEnd.X - pointAnchor.X, pointEnd.Y - pointAnchor.Y);
            float angle = GetAngle(vStart, vEnd);
            //Console.WriteLine(angle);
            translation.Rotate(angle, MatrixOrder.Append);
            
        }
    }
}
