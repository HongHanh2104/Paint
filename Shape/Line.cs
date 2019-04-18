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
    class Line : Shape
    {
        private Point pointStart;
        private Point pointEnd;

        public Line(PaintSpace p, Point pointStart, Point pointEnd) : base(p)
        {
            this.pointStart = pointStart;
            this.pointEnd = pointEnd;
        }

        public override GraphicsPath CreatePath()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddLine(pointStart, pointEnd);
            //path.Transform(transformationMatrix);
            return path;
        }

        public override Point GetAnchor()
        {
            Rectangle rect = GetRectangle(pointStart, pointEnd);
            return new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue("PointStart", pointStart, typeof(Point));
            info.AddValue("PointEnd", pointEnd, typeof(Point));
        }

        public Line(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            pointStart = (Point)info.GetValue("PointStart", typeof(Point));
            pointEnd = (Point)info.GetValue("PointEnd", typeof(Point));
        }
    }
}
