﻿using System;
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
    class Bezier : Shape
    {
        protected List<Point> pointLists;

        public Bezier(PaintSpace p, List<Point> pointLists) : base(p)
        {
            this.pointLists = new List<Point>();
            foreach (Point point in pointLists)
            {
                this.pointLists.Add(new Point(point.X, point.Y));
            }
        }

        public override GraphicsPath CreatePath()
        {
            GraphicsPath path = new GraphicsPath();
            if (pointLists.Count == 4)
                path.AddBezier(pointLists[0], pointLists[1], pointLists[2], pointLists[3]);
            return path;
        }

        public override Point GetAnchor()
        {
            int x = 0;
            int y = 0;
            foreach (Point p in pointLists)
            {
                x += p.X;
                y += p.Y;
            }
            return new Point(x / pointLists.Count, y / pointLists.Count);
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("ListPoints", pointLists, typeof(List<Point>));
        }

        public Bezier(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            pointLists = (List<Point>)info.GetValue("ListPoints", typeof(List<Point>));
        }
    }
}
