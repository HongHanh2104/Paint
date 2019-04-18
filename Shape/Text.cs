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
    class Text : FilledShape
    {
        string text;
        Point pointOrigin;
        Font font;

        public Text(PaintSpace p, Point origin, string text, Font font) : base(p)
        {
            this.text = text;
            this.font = font;
            this.pointOrigin = origin;
        }

        public override GraphicsPath CreatePath()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddString(text, font.FontFamily, (int)font.Style, font.Size, pointOrigin, StringFormat.GenericTypographic);
            return path;
        }

        public override Point GetAnchor()
        {
            return new Point();
        }

        public override void UpdateParams(PaintSpace p)
        {
            base.UpdateParams(p);
            this.font = p.TextFont;
        }

        public override PaintSpace GetParams()
        {
            PaintSpace ps = base.GetParams();
            ps.TextFont = this.font;
            return ps;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue("PointOrigin", pointOrigin, typeof(Point));
            info.AddValue("Text", text);
            info.AddValue("Font", font, typeof(Font));
        }

        public Text(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            pointOrigin = (Point)info.GetValue("PointOrigin", typeof(Point));
            text = info.GetString("Text");
            font = (Font)info.GetValue("Font", typeof(Font));
        }
    }
}
