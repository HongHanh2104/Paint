using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    [Serializable]
    class Layer
    {
        bool isSelected = false;
        bool isHidden = false;
        string name;

        Bitmap bitmap;

        public Layer(Bitmap bitmap)
        {
            this.bitmap = bitmap;
        }

        public Bitmap getBitmap()
        {
            return bitmap;
        }

        public virtual void Render(Graphics g)
        {
            g.DrawImage(bitmap, 0, 0);
        }

        public virtual void DrawBounds(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 0.1f);
            float[] dashStyle = new float[] { 2, 5, 10, 4 };
            pen.DashPattern = dashStyle;

            //g.DrawRectangle(pen, shape.GetBoundingBox());
        }

        public virtual void UpdateParams(PaintSpace p)
        {

        }

        public virtual PaintSpace GetParams()
        {
            return null;
        }

        public virtual void Transform(Transformation transformation, bool done = false) { }
        public virtual void ResetMatrix() { }

        public virtual bool IsSelected()
        {
            return isSelected;
        }

        public virtual void ChangeSelection(bool isSelected)
        {
            this.isSelected = isSelected;
        }

        public virtual void ToggleState()
        {
            isHidden = isHidden ? false : true;
        }

        public virtual bool IsHidden() { return isHidden; }

        public virtual void SetName(string name)
        {
            this.name = name;
        }

        public virtual string GetName()
        {
            return this.name;
        }

        public virtual Layer Rasterize()
        {
            return this;
        }

        public void DeleteSelection(Rectangle currentScreenSelection)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.SetClip(currentScreenSelection);
                g.Clear(Color.Transparent);
                g.ResetClip();
            }
        }

        internal void CopySelection(Rectangle currentScreenSelection)
        {
            Bitmap crop = new Bitmap(currentScreenSelection.Width, currentScreenSelection.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            using (Graphics g = Graphics.FromImage(crop))
            {
                g.DrawImage(bitmap, new Rectangle(0, 0, crop.Width, crop.Height), currentScreenSelection, GraphicsUnit.Pixel);
            }
            Clipboard.SetImage(crop);
        }
    }

    [Serializable]
    class ShapeLayer : Layer
    {
        Shape shape;
        
        public ShapeLayer(Bitmap bitmap) : base(bitmap) { }

        public ShapeLayer(Bitmap bitmap, Shape shape) : base(bitmap)
        {
            this.shape = shape;
        }

        public void setShape(Shape shape)
        {
            this.shape = shape;
        }

        public override void Render(Graphics g)
        {
            if (shape != null)
            {
                shape.Draw(g);
            }
        }

        public override void DrawBounds(Graphics g)
        {
            if (shape != null)
            {
                Pen pen = new Pen(Color.Black, 0.1f);
                float[] dashStyle = new float[] { 2, 5, 10, 4 };
                pen.DashPattern = dashStyle;

                g.DrawRectangle(pen, shape.GetBoundingBox());
            }
        }

        public override void UpdateParams(PaintSpace p)
        {
            if (shape != null)
            {
                base.UpdateParams(p);
                shape.UpdateParams(p);
            }
        }

        public override PaintSpace GetParams()
        {
            if (shape != null)
                return shape.GetParams();
            return null;
        }

        public override void Transform(Transformation transformation, bool done = false)
        {
            if (shape != null)
            {
                shape.Transform(transformation, done);
            }
        }

        public override void ResetMatrix()
        {
            if (shape != null)
            {
                shape.ResetMatrix();
            }
        }

        public override Layer Rasterize()
        {
            Bitmap mainBitmap = getBitmap();
            Graphics g = Graphics.FromImage(mainBitmap);
            Render(g);
            Layer layer = new Layer(mainBitmap);
            return layer;
        }
    }
}
