using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class Form2 : Form
    {
        private Form1 mainf;

        public Form2(Form f)
        {
            InitializeComponent();
            mainf = (Form1) f;
        }

        public void action1()
        {
            Color c = BackColor;
            BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);
            BackColor = c;
            Refresh();
            Thread.Sleep(500);
        }

        public void action2()
        {
            this.Left -= 20;
        }

        public void action3()
        {
            string t = this.Text;
            this.Text = "";
            Refresh();
            Thread.Sleep(5000);
            this.Text = t;
            Refresh();
            Thread.Sleep(500);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name = "A";
            if (radioButton2.Checked) name = "B";
            if (radioButton3.Checked) name = "C";
            Action act = null;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                {
                    act = action1;
                    break;
                }
                case 1:
                {
                    act = action2;
                    break;
                }
                case 2:
                {
                    act = action3;
                    break;
                }
            }

            mainf.register(name, this, act);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = "A";
            if (radioButton2.Checked) name = "B";
            if (radioButton3.Checked) name = "C";
            Action act = null;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                {
                    act = action1;
                    break;
                }
                case 1:
                {
                    act = action2;
                    break;
                }
                case 2:
                {
                    act = action3;
                    break;
                }
            }

            mainf.unRegister(name, this, act);
        }
    }
}