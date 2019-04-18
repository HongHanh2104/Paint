using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class ScaleTool : TransformationTool
    {
        public ScaleTool(): base() { }

        public override object CreateTransformation()
        {
            Scale scale = new Scale(pointStart, pointEnd);
            return scale;
        }
    }
}
