using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    public class ColorManager
    {
        public Color getValueColor(Color c)
        {
            return Color.FromArgb((byte)~c.R, (byte)~c.G, (byte)~c.B);
        }
    }
}
