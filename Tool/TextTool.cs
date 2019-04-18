using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    class TextTool : Tool
    {
        public override object onMouseDown(MouseEventArgs e, PaintSpace p)
        {
            TextForm textGetter = new TextForm(p);
            textGetter.ShowDialog();
            return new Text(p, e.Location, textGetter.getText(), textGetter.getFont());
        }

        public override object onMouseMove(MouseEventArgs e, PaintSpace p)
        {
            return null;
        }

        public override object onMouseUp(MouseEventArgs e, PaintSpace p)
        {
            return null;
        }

        public override PaintTool Type()
        {
            return PaintTool.TextTool;
        }
    }
}
