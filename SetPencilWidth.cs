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
    partial class SetPencilWidth : Form
    {
        private MainForm paint;
        public SetPencilWidth(MainForm paint)
        {
            InitializeComponent();
            this.paint = paint;

        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            paint.setPencilWidthValue((float)numericUpDown1.Value);
            Close();
        }
    }
}
