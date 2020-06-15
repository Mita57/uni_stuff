using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba18
{
    public partial class Form1 : Form
    {
        MyThread RedThread;

        MyThread GreenThread;

        MyThread BlueThread;

        MyThread Timer;

        int Red;

        int Green;

        int Blue;

        private int RedSpeed = 150000;
        
        private int GreenSpeed = 150000;
        
        private int BlueSpeed = 150000;

        public static PictureBox pBox1;

        public static PictureBox pBox2;

        public static PictureBox pBox3;

        public static PictureBox pBox4;

        public delegate void TimeDelegate(Label label);

        TimeDelegate Clock;

        public Form1()
        {
            InitializeComponent();

            Clock = new TimeDelegate(StartTime);

            pBox1 = pictureBox1;
            pBox2 = pictureBox2;
            pBox3 = pictureBox3;
            pBox4 = pictureBox4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RedThread = new MyThread();
            GreenThread = new MyThread();
            BlueThread = new MyThread();
            Timer = new MyThread();

            RedThread.Go(ChangeRedColor);
            RedThread.Break();
            GreenThread.Go(ChangeGreenColor);
            GreenThread.Break();
            BlueThread.Go(ChangeBlueColor);
            BlueThread.Break();
            Timer.Go(SetTimer);
        }

        private void StartTime(Label label)
        {
            label1.Text = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond}";
        }

        private void ChangeRedColor()
        {
            bool flag = false;
            int red = 0;
            
            while (true)
            {
                if (!flag)
                {
                    while (RedThread.ThStop)
                    {
                        RedThread.Sleep(10);
                    }
                    
                    for (int i = 0; i < RedSpeed; i++)
                    {
                        Math.Sin(2);
                    }

                    lock (RedThread)
                    {
                        Red = red;
                        pBox2.BackColor = Color.FromArgb(red, 0, 0);
                    }

                    RedThread.Count++;
                    red = RedThread.Count;
                    
                    if (red > 255)
                    {
                        red = 255;
                        flag = true;
                    }
                }
                else
                {
                    while (RedThread.ThStop)
                    {
                        RedThread.Sleep(10);
                    }

                    for (int i = 0; i < RedSpeed; i++)
                    {
                        Math.Sin(2);
                    }

                    lock (RedThread)
                    {
                        Red = red;
                        pBox2.BackColor = Color.FromArgb(red, 0, 0);
                    }

                    RedThread.Count--;
                    red = RedThread.Count;
                    if (red < 0)
                    {
                        red = 0;
                        flag = false;
                    }
                }
            }
        }

        void ChangeGreenColor()
        {
            bool flag = false;
            int green = 0;
            while (true)
            {
                if (!flag)
                {
                    while (GreenThread.ThStop)
                    {
                        GreenThread.Sleep(10);
                    }

                    for (int i = 0; i < GreenSpeed; i++)
                    {
                        Math.Sin(2);
                    }

                    lock (GreenThread)
                    {
                        Green = green;
                        pBox3.BackColor = Color.FromArgb(0, green, 0);
                    }

                    GreenThread.Count++;
                    green = GreenThread.Count;
                    if (green > 255)
                    {
                        green = 255;
                        flag = true;
                    }
                }
                else
                {
                    while (GreenThread.ThStop)
                    {
                        GreenThread.Sleep(10);
                    }

                    for (int i = 0; i < GreenSpeed; i++)
                    {
                        Math.Sin(2);
                    }

                    lock (GreenThread)
                    {
                        Green = green;
                        pBox3.BackColor = Color.FromArgb(0, green, 0);
                    }

                    GreenThread.Count--;
                    green = GreenThread.Count;
                    if (green < 0)
                    {
                        green = 0;
                        flag = false;
                    }
                }
            }
        }

        void ChangeBlueColor()
        {
            bool flag = false;
            int blue = 0;
            while (true)
            {
                if (!flag)
                {
                    while (BlueThread.ThStop)
                    {
                        BlueThread.Sleep(10);
                    }

                    for (int i = 0; i < BlueSpeed; i++)
                    {
                        Math.Sin(2);
                    }

                    lock (BlueThread)
                    {
                        Blue = blue;
                        pBox4.BackColor = Color.FromArgb(0, 0, blue);
                    }

                    BlueThread.Count++;
                    blue = BlueThread.Count;
                    if (blue > 255)
                    {
                        blue = 255;
                        flag = true;
                    }
                }
                else
                {
                    while (BlueThread.ThStop)
                    {
                        BlueThread.Sleep(10);
                    }

                    for (int i = 0; i < BlueSpeed; i++)
                    {
                        Math.Sin(2);
                    }

                    lock (BlueThread)
                    {
                        Blue = blue;
                        pBox4.BackColor = Color.FromArgb(0, 0, blue);
                    }

                    BlueThread.Count--;
                    blue = BlueThread.Count;
                    if (blue < 0)
                    {
                        blue = 0;
                        flag = false;
                    }
                }
            }
        }

        void SetTimer()
        {
            Thread.Sleep(50);
            lock (RedThread)
            {
                lock (GreenThread)
                {
                    lock (BlueThread)
                    {
                        pBox1.BackColor = Color.FromArgb(Red, Green, Blue);
                        label1.ForeColor = Color.FromArgb(Red, Green, Blue);
                    }
                }
            }

            Invoke(Clock, label1);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                RedThread.Continue();
            }
            else
            {
                RedThread.Break();
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                GreenThread.Continue();
            }
            else
            {
                GreenThread.Break();
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox3.Checked)
            {
                BlueThread.Continue();
            }
            else
            {
                BlueThread.Break();
            }
        }

        private void TrackBar3_Scroll(object sender, EventArgs e)
        {
            BlueSpeed = trackBar3.Value * 500000;
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            GreenSpeed = trackBar2.Value * 50000;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            RedSpeed = trackBar1.Value * 50000;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            RedThread.Stop();
            GreenThread.Stop();
            BlueThread.Stop();
            Timer.Stop();
        }
    }
}