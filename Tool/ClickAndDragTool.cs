using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows;

namespace Paint
{
    abstract class ClickAndDragTool : Tool
    {
        public ClickAndDragTool() { }

        protected Point pointStart;
        protected Point pointEnd;
        protected Point pointPrev;

        protected int direction;

        public void Update(MouseEventArgs M)
        {
            pointEnd = M.Location;

            Point v1 = new Point(pointEnd.X - pointStart.X, pointEnd.Y - pointStart.Y);
            Point v2 = new Point(pointPrev.X - pointStart.X, pointPrev.Y - pointStart.Y);
            if (v1.X * v2.Y - v2.X * v1.Y > 0)
                direction = 1;
            else
                direction = -1;
        }

        public override object onMouseDown(MouseEventArgs e, PaintSpace p)
        {
            pointStart = e.Location;

            isRightBtn = (e.Button == MouseButtons.Right) ? true : false;
            isLeftBtn = (e.Button == MouseButtons.Left) ? true : false;
            isDragging = true;

            Update(e);

            return null;
        }
    }

    abstract class CDShapeTool : ClickAndDragTool
    {
        public override object onMouseMove(MouseEventArgs e, PaintSpace p)
        {
            if (isDragging)
            {
                Update(e);
                object shape = CreateShape(p);
                pointPrev = pointEnd;
                return shape;
            }
            return null;
        }

        public override object onMouseUp(MouseEventArgs e, PaintSpace p)
        {
            isDragging = false;
            return CreateShape(p);
        }

        public abstract object CreateShape(PaintSpace p);

        public override PaintTool Type()
        {
            return PaintTool.CDShapeTool;
        }
    }

    abstract class TransformationTool : ClickAndDragTool
    {
        public override object onMouseMove(MouseEventArgs e, PaintSpace p)
        {
            if (isDragging)
            {
                Update(e);
                //p.MainGraphics.Clear(Color.Transparent);
                return CreateTransformation();
            }
            return null;
        }

        public override object onMouseUp(MouseEventArgs e, PaintSpace p)
        {
            isDragging = false;
            return CreateTransformation();
        }

        public abstract object CreateTransformation();

        public override PaintTool Type()
        {
            return PaintTool.TransformationTool;
        }
    }
}
