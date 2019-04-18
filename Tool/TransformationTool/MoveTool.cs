using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class MoveTool : TransformationTool
    {
        public MoveTool(): base() { }

        public override object CreateTransformation()
        { 
            Translation translation = new Translation(pointStart, pointEnd);
            return translation;
        }
    }
}
