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
    partial class TextForm : Form
    {
        string text;
        FontDialog fontDlg = new FontDialog();

        public TextForm(PaintSpace p)
        {
            InitializeComponent();
            fontDlg.Font = p.TextFont;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            text = txtBox_Text.Text;
            Close();
        }

        private void btn_Font_Click(object sender, EventArgs e)
        {
            fontDlg.Font = txtBox_Text.Font;
            if (fontDlg.ShowDialog() == DialogResult.OK)
                txtBox_Text.Font = fontDlg.Font;
        }


        public Font getFont()
        {
            return txtBox_Text.Font;
        }
        public string getText()
        {
            return text;
        }

        
    }
}
