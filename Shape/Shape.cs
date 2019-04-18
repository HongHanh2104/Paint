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
    abstract class Shape : ISerializable
    {
        protected Color ForeColor;
        protected int dashStyle;
        protected float width;

        protected Matrix transformationMatrix;
        protected Matrix previousMatrix;

        public Shape(PaintSpace p)
        {
            transformationMatrix = new Matrix();
            previousMatrix = transformationMatrix.Clone();

            this.ForeColor = p.ForeColor;
            this.dashStyle = (int)p.DashStyle;
            this.width = p.BorderWidth;
        }

        public virtual void UpdateParams(PaintSpace p)
        {
            this.ForeColor = p.ForeColor;
            this.dashStyle = (int)p.DashStyle;
            this.width = p.BorderWidth;
        }

        public virtual PaintSpace GetParams()
        {
            PaintSpace ps = new PaintSpace();
            ps.ForeColor = ForeColor;
            ps.DashStyle = dashStyle;
            ps.BorderWidth = width;
            return ps;
        }

        public abstract GraphicsPath CreatePath();

        public virtual void DrawBorder(GraphicsPath path, Graphics drawingSpace)
        {
            Pen p = new Pen(ForeColor, width);
            p.DashStyle = (DashStyle)dashStyle;
            p.DashCap = DashCap.Round;
            drawingSpace.DrawPath(p, path);
        }

        public virtual void Draw(Graphics drawingSpace)
        {
            drawingSpace.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath path = CreatePath();
            path.Transform(transformationMatrix);
            DrawBorder(path, drawingSpace);
        }

        public virtual GraphicsPath GetPath()
        {
            return CreatePath();
        }

        public virtual Rectangle GetBoundingBox()
        {
            return Rectangle.Round(CreatePath().GetBounds(transformationMatrix));
        }

        public abstract Point GetAnchor();

        public Point GetDefaultAnchor()
        {
            Rectangle bounds = GetBoundingBox();
            return new Point(bounds.X + bounds.Width / 2, bounds.Y + bounds.Height / 2);
        }

        public virtual Point GetTransformedAnchor()
        {
            Point[] newPoints = new Point[] { GetDefaultAnchor() };
            //transformationMatrix.TransformPoints(newPoints);
            return newPoints[0];
        }

        internal void Transform(Transformation transformation, bool done = false)
        {
            transformationMatrix.Multiply(transformation.getTransformationMatrix(GetTransformedAnchor()), MatrixOrder.Append);

            if (done)
            {
                previousMatrix = transformationMatrix.Clone();
            }
        }

        internal void ResetMatrix()
        {
            transformationMatrix = previousMatrix.Clone();
        }

        protected Rectangle GetRectangle(Point p1, Point p2)
        {
            Rectangle rect = new Rectangle();
            if (p1.X < p2.X)
            {
                rect.X = p1.X;
                rect.Width = p2.X - p1.X;
            }
            else
            {
                rect.X = p2.X;
                rect.Width = p1.X - p2.X;
            }

            if (p1.Y < p2.Y)
            {
                rect.Y = p1.Y;
                rect.Height = p2.Y - p1.Y;
            }
            else
            {
                rect.Y = p2.Y;
                rect.Height = p1.Y - p2.Y;
            }

            return rect;
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ForeColor", ForeColor, ForeColor.GetType());
            info.AddValue("DashStyle", dashStyle);
            info.AddValue("Width", width);
            
            float[] matrix = transformationMatrix.Elements;
            info.AddValue("TransformationMatrix", matrix, typeof(float[]));

            matrix = previousMatrix.Elements;
            info.AddValue("PreviousMatrix", matrix, typeof(float[]));
        }

        public Shape(SerializationInfo info, StreamingContext context)
        {
            ForeColor = (Color)info.GetValue("ForeColor", Color.Red.GetType());
            dashStyle = info.GetInt32("DashStyle");
            width = (float)info.GetDouble("Width");

            float[] matrix = (float[])info.GetValue("TransformationMatrix", typeof(float[]));
            transformationMatrix = new Matrix(matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5]);
            matrix = (float[])info.GetValue("PreviousMatrix", typeof(float[]));
            previousMatrix = new Matrix(matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5]);
        }
    }

    [Serializable]
    abstract class FilledShape : Shape
    {
        protected Color BackColor;
        protected Bitmap pattern;

        public FilledShape(PaintSpace p) : base(p) {
            BackColor = p.BackColor;
            pattern = p.Pattern;
        }

        public override PaintSpace GetParams()
        {
            PaintSpace ps = base.GetParams();
            ps.BackColor = BackColor;
            ps.Pattern = pattern;
            return ps;
        }

        public virtual void FillShape(GraphicsPath path, Graphics drawingSpace)
        {
            if (pattern != null)
            {
                TextureBrush b = new TextureBrush(pattern);
                b.MultiplyTransform(transformationMatrix);
                drawingSpace.FillPath(b, path);
            }
            else
            {
                SolidBrush b = new SolidBrush(BackColor);
                drawingSpace.FillPath(b, path);
            }
        }

        public override void Draw(Graphics drawingSpace)
        {
            drawingSpace.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath path = CreatePath();
            path.Transform(transformationMatrix);
            FillShape(path, drawingSpace);
            DrawBorder(path, drawingSpace);
        }

        public override void UpdateParams(PaintSpace p)
        {
            base.UpdateParams(p);
            BackColor = p.BackColor;
            pattern = p.Pattern;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("BackColor", BackColor, BackColor.GetType());
            info.AddValue("Pattern", pattern, typeof(Bitmap));
        }

        public FilledShape(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            BackColor = (Color)info.GetValue("BackColor", typeof(Color));
            pattern = (Bitmap)info.GetValue("Pattern", typeof(Bitmap));
        }
    }
}