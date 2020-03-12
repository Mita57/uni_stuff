using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
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

        static double segmentation = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            int iterations = (int)iterationsAmount.Value + 1;
            double result = 0;
            segmentation = (double)1 / iterations;

            double[] args = new double[iterations];
            double[] vals = new double[iterations];

            args[0] = 1;

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
                result = rectangleMethod(vals);
            }
            else
            {
                result = trapeezeMethod(vals);
            }

            sw.Stop();
        }
        
        static double trapeezeMethod(double[] vals, int begin, int end)
        {
            double value = 0;
            for (int i = begin; i < end; i++)
            {
                value += ((vals[i - 1] + vals[i]) / 2) * segmentation;
            }
            return value;
        }

        static double rectangleMethod(double[] vals)
        {
            double value = 0;
            for (int i = 0; i < vals.Length; i++)
            {
                value += vals[i] * segmentation;
            }
            return value;
        }

        static double fun(double x)
        {
            return (x * x) / (x + 2);
        }

        
    }
}