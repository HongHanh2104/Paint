using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    class PaintSpace
    {
        private Color foreColor;
        private Color backColor;
        private Bitmap pattern;
        private Font textFont;
        private float dashWidth;
        private int dashStyle;

        private Graphics mainGraphics;

        public Color ForeColor
        {
            get
            {
                return foreColor;
            }

            set
            {
                foreColor = value;
            }
        }

        public Graphics MainGraphics
        {
            get
            {
                return mainGraphics;
            }

            set
            {
                mainGraphics = value;
            }
        }

        public float BorderWidth
        {
            get
            {
                return dashWidth;
            }

            set
            {
                dashWidth = value;
            }
        }

        public int DashStyle
        {
            get
            {
                return dashStyle;
            }

            set
            {
                dashStyle = value;
            }
        }

        public Color BackColor
        {
            get
            {
                return backColor;
            }

            set
            {
                backColor = value;
            }
        }

        public Font TextFont
        {
            get
            {
                return textFont;
            }

            set
            {
                textFont = value;
            }
        }

        public Bitmap Pattern
        {
            get
            {
                return pattern;
            }

            set
            {
                pattern = value;
            }
        }
    }
}
