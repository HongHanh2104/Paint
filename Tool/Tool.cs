using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    abstract class Tool
    {
        protected bool isLeftBtn;
        protected bool isRightBtn;
        protected bool isDragging;

        public abstract object onMouseMove(MouseEventArgs e, PaintSpace p);
        public abstract object onMouseDown(MouseEventArgs e, PaintSpace p);
        public abstract object onMouseUp(MouseEventArgs e, PaintSpace p);

        public virtual void Reset()
        {
            
        }

        public abstract PaintTool Type();
    }

    abstract class MultiPointsTool : Tool
    {
        public override PaintTool Type()
        {
            return PaintTool.MultiPointsTool;
        }
    }
}
