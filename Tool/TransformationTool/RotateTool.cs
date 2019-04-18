using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class RotateTool : TransformationTool
    {
        public RotateTool(): base() { }

        public override object CreateTransformation()
        {
            Rotation rotation = new Rotation(pointStart, pointEnd, direction);
            return rotation;
        }
    }
}
