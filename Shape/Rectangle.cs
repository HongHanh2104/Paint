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
    class MyRectangle : FilledShape
    {
        protected Point pointTopLeft;
        protected Point pointBottomRight;

        public MyRectangle(PaintSpace p, Point pointStart, Point pointEnd) : base(p)
        {
            this.pointTopLeft = pointStart;
            this.pointBottomRight = pointEnd;
        }

        public override GraphicsPath CreatePath()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(GetRectangle(pointTopLeft, pointBottomRight));
            return path;
        }

        public override Point GetAnchor()
        {
            Rectangle rect = GetRectangle(pointTopLeft, pointBottomRight);
            return new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("PointTopLeft", pointTopLeft, typeof(Point));
            info.AddValue("PointBottomRight", pointBottomRight, typeof(Point));
        }

        public MyRectangle(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            pointTopLeft = (Point)info.GetValue("PointTopLeft", typeof(Point));
            pointBottomRight = (Point)info.GetValue("PointBottomRight", typeof(Point));
        }

        public Rectangle ToRectangle()
        {
            return GetBoundingBox();
        }
    }
}
