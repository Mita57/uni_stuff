using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Color forecolor = button2.ForeColor;
            Color backcolor = button2.BackColor;
            button2.Enabled = !button2.Enabled;
            button2.ForeColor = forecolor;
            button2.BackColor = backcolor;
            //TODO: color changes when disabled
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (button1.Left >= 5)
            {
                button1.Left -= 5;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //TODO: everything
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MinimizeBox = !MinimizeBox;
        }
    }
}
