using System;
using System.Diagnostics;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace WordExcelStuff
{
    public partial class Form1 : Form
    {
        static double segmentation = 0;
        static double trapeezeMethod(double[] vals)
        {
            double value = 0;
            for (int i = 1; i < vals.Length; i++)
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
            return (x * x) * Math.Acos(x);
        }

        static double accuracy(double sum)
        {
            return 0.008;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            int iterations = (int)iterationsAmount.Value + 1;
            double result = 0;
            segmentation = (double)1 / iterations;

            double[] args = new double[iterations];
            double[] vals = new double[iterations];

            args[0] = -1;

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
            resultField.Text = result.ToString();
            timeEscalatedField.Text = sw.ElapsedMilliseconds.ToString();
            accuracyTextbox.Text = accuracy(result).ToString();
        }
    }
}
