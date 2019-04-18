using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    abstract class Transformation : object
    {
        protected Point pointStart;
        protected Point pointEnd;

        public Transformation(Point pointStart, Point pointEnd)
        {
            this.pointStart = pointStart;
            this.pointEnd = pointEnd;
        }

        public virtual Matrix getTransformationMatrix(Point pointAnchor)
        {
            Matrix translation = new Matrix();
            translation.Translate(-pointAnchor.X, -pointAnchor.Y, MatrixOrder.Append);
            getTransformation(translation, pointAnchor);
            translation.Translate(pointAnchor.X, pointAnchor.Y, MatrixOrder.Append);
            return translation;
        }

        public abstract void getTransformation(Matrix translation, Point pointAnchor);
    }
}
