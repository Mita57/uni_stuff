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

namespace Laba6
{
    public partial class Form1 : Form
    {
        static private double threadResult = 0;
        static private double part = 0;
        static private List<double> vals = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }
        
        static double fun(double x)
        {
            return (x * x) / (x + 2);
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            int threadsAmount = (int) threadsAmountNum.Value;
            int N = (int) amountNum.Value;
            part = 1 / threadsAmount;
            double arg = 1;

            for (int i = 0; i < N; i++)
            {
                vals.Add(fun(arg + part));
                arg += part;
            }

            
            
            int threadsPart = N / threadsAmount;
            int localLeft = 0;

            for (int i = 0; i < threadsAmount; i += threadsPart)
            {
                Thread newThread = new Thread(() => threadMethod(localLeft + 1, localLeft + threadsPart));
                newThread.Start();
                localLeft += threadsPart;
            }

            MessageBox.Show(threadResult.ToString());

        }

        public static void threadMethod(int left, int right)
        {
            for (int i = left; i < right; i++)
            {
                threadResult += ((vals[i - 1] + vals[i]) / 2) * part;
            }
        }
    }
}