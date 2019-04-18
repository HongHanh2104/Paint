using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    partial class NewForm : Form
    {
        private MainForm paint;
        public NewForm(MainForm paint)
        {
            InitializeComponent();
            this.paint = paint;
        }

        private void btn_Set_Click(object sender, EventArgs e)
        {
            paint.CreateMainPaint((int)numericUpDown_width.Value, (int)numericUpDown_height.Value);
            Close();
        }
    }
}
