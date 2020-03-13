using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int parts = 0;
        static int high = 0;

        static double segmentation = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            int iterations = (int)iterationsAmount.Value;
            int threads = (int)threadsAmount.Value;
            double result = 0;
            double[] args = new double[iterations];
            double[] vals = new double[iterations];
            segmentation = 1/(double)iterations;
            parts = iterations / threads;
            args[0] = 1;
            high = 0;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 1; i < args.Length; i++)
            {
                args[i] = args[i - 1] + segmentation;
            }
            for(int i = 0; i < vals.Length; i++)
            {
                vals[i] = fun(args[i]);
            }


            if(rectangleRB.Checked)
            {
                for (int i = 0; i < threads; i++)
                {
                    Thread myNewTread = new Thread(() => result += rectangleMethod(vals, high, high + parts));
                    myNewTread.Start();
                }
            }
            else
            {
                for (int i = 0; i < threads; i++)
                {
                    Thread myNewTread = new Thread(() => result += trapeezeMethod(vals, high, high + parts));
                    myNewTread.Start();
                }
            }

            sw.Stop();

            string final = "Результат: " + result + "\nВремя выполнения: " + sw.ElapsedMilliseconds;
            richTextBox1.Text = final;
        }
        
        static double trapeezeMethod(double[] vals, int begin, int end)
        {
            double value = 0;
            for (int i = begin; i < end; i++)
            {
                value += ((vals[i - 1] + vals[i]) / 2) * segmentation;
            }
            high += parts;
            return value;
        }

        static double rectangleMethod(double[] vals, int begin, int end)
        {
            double value = 0;
            for (int i = begin; i < end; i++)
            {
                value += vals[i] * segmentation;
            }
            high += parts;
            return value;
        }

        static double fun(double x)
        {
            return (x * x) / (x + 2);
        }

        
    }
}