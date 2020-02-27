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

        int chosen = 1;

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

            FontStyle[] array = new FontStyle[]{FontStyle.Regular, FontStyle.Bold, FontStyle.Italic, FontStyle.Underline};
            if (Control.ModifierKeys == Keys.Control)
            {
                label1.Font = new Font(label1.Font.Name, label1.Font.Size, array[chosen]);
                label2.Font = new Font(label2.Font.Name, label2.Font.Size, array[chosen]);
                label3.Font = new Font(label3.Font.Name, label3.Font.Size, array[chosen]);
                label4.Font = new Font(label4.Font.Name, label4.Font.Size, array[chosen]);
                label5.Font = new Font(label5.Font.Name, label5.Font.Size, array[chosen]);
                chosen++;
                if(chosen == 4)
                {
                    chosen = 0;
                }
            }
        }



        private void Form1_Click(object sender, EventArgs e)
        {
            restore();
        }

        private void restore()
        {
            this.MinimizeBox = true;
            label1.Left = 12;
            label2.Left = 134;
            label3.Left = 293;
            label4.Left = 404;
            label5.Left = 530;
            button1.Left = 25;
            button2.Left = 152;
            button3.Left = 280;
            button4.Left = 404;
            button5.Left = 530;
            this.Width = 677;
            this.Height = 161;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(Control.ModifierKeys == Keys.Alt && e.KeyCode == Keys.I)
            {
                restore();
            }

            if (Control.ModifierKeys == Keys.Alt && e.KeyCode == Keys.X)
            {
                this.Close();
            }
        }

        private void MouseOver(object sender, EventArgs e)
        {
            infoLabel.Text += (Convert.ToString(((Button)sender).Tag));
        }

        private void MouseLeeft(object sender, EventArgs e)
        {
            infoLabel.Text = "Инфа: ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.PaleGreen;
            button2.BackColor = Color.MediumSpringGreen;
            button3.BackColor = Color.SpringGreen;
            button4.BackColor = Color.Lime;
            button5.BackColor = Color.Green;
        }

        private void RBMClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ColorDialog MyDialog = new ColorDialog();
                if (MyDialog.ShowDialog() == DialogResult.OK)
                    ((Button)sender).BackColor = MyDialog.Color;
            }
        }
    }
}
