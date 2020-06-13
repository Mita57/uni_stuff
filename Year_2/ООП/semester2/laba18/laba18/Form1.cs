using System;
using System.Threading;
using System.Windows.Forms;

namespace laba18
{
    public partial class Form1 : Form
    {
        MyThread th1 = new MyThread();
        MyThread th2 = new MyThread();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            th1.go();
            if (!checkBox1.Checked)
            {
                th1.suspend();
            }

            th2.go();
            if (!checkBox1.Checked)
            {
                th2.suspend();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = th1.Count.ToString();
            textBox2.Text = th2.Count.ToString();
            th1.Count = 0;
            th2.Count = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                th1.resume();
            }
            else
            {
                th1.suspend();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                th2.resume();
            }
            else
            {
                th2.suspend();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            th1.stop();
            checkBox1.Enabled = false;
            trackBar1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            th2.stop();
            checkBox2.Enabled = false;
            trackBar2.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            th1.Priority = (ThreadPriority) (trackBar1.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            th2.Priority = (ThreadPriority) (trackBar2.Value);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            th1.stop();
            th2.stop();
        }
    }
}