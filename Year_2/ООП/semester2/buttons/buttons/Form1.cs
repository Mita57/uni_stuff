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
            int leftButton = button1.Left;
            int leftLabel = label1.Left;
            button1.Left = button2.Left;
            button2.Left = button3.Left;
            button3.Left = button4.Left;
            button4.Left = button5.Left;
            button5.Left = leftButton;
            label1.Left = label2.Left;
            label2.Left = label3.Left;
            label3.Left = label4.Left;
            label4.Left = label5.Left;
            label5.Left = leftLabel;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MinimizeBox = !MinimizeBox;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if(Control.ModifierKeys == Keys.None)
            {
                label1.Font = new Font(label1.Font.Name, label1.Font.Size + 1);
                label2.Font = new Font(label2.Font.Name, label2.Font.Size + 1);
                label3.Font = new Font(label3.Font.Name, label3.Font.Size + 1);
                label4.Font = new Font(label4.Font.Name, label4.Font.Size + 1);
                label5.Font = new Font(label5.Font.Name, label5.Font.Size + 1);
            }

            if (Control.ModifierKeys == Keys.Shift && label1.Font.Size >= 1)
            {
                label1.Font = new Font(label1.Font.Name, label1.Font.Size - 1);
                label2.Font = new Font(label2.Font.Name, label2.Font.Size - 1);
                label3.Font = new Font(label3.Font.Name, label3.Font.Size - 1);
                label4.Font = new Font(label4.Font.Name, label4.Font.Size - 1);
                label5.Font = new Font(label5.Font.Name, label5.Font.Size - 1);
            }

            if (Control.ModifierKeys == Keys.Control)
            {
                label1.Font = new Font(label1.Font.Name, label1.Font.Size);
                label2.Font = new Font(label2.Font.Name, label2.Font.Size);
                label3.Font = new Font(label3.Font.Name, label3.Font.Size);
                label4.Font = new Font(label4.Font.Name, label4.Font.Size);
                label5.Font = new Font(label5.Font.Name, label5.Font.Size);
            }
        }
    }
}
