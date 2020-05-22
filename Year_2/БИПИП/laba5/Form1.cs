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

namespace TheFifthLab
{
    delegate double Func(double x);

    delegate double CheckFunc(double x);

    public partial class Form1 : Form
    {
        private Func func = (x) => { return x * x / (x + 2); };

        private CheckFunc checkFunc = (x) =>
        {
            return ((x + 2) * (x + 2)) / 2 - 4*(x + 2) + 2 * 2 * Math.Log(Math.Abs(x + 2));
        };

        public Form1()
        {
            InitializeComponent();
            methodsCB.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Integral integral = new Integral(func, checkFunc);
            int N = (int) iterNum.Value;
            int M = 4;
            int offset = N / M;
            double A = 0;
            double B = 1;
            double dx = (B - A) / N;

            Stopwatch sw = new Stopwatch();
            if (methodsCB.SelectedIndex == 0)
            {
                Thread[] threads = new Thread[M];

                sw.Start();
                for (int i = 0; i < M; i++)
                {
                    double start = A + i * offset * dx;
                    double end = start + offset * dx;
                    if (i == M - 1)
                    {
                        threads[i] = new Thread(() => { integral.Calculate(start, B, dx); });
                    }
                    else
                    {
                        threads[i] = new Thread(() => { integral.Calculate(start, end, dx); });
                    }

                    threads[i].Start();
                }

                for (int i = 0; i < M; i++)
                {
                    threads[i].Join();
                }

                sw.Stop();
            }
            else if (methodsCB.SelectedIndex == 1)
            {
                Task[] tasks = new Task[M];

                sw.Start();
                for (int i = 0; i < M; i++)
                {
                    double start = A + i * offset * dx;
                    double end = start + offset * dx;
                    if (i == M - 1)
                    {
                        tasks[i] = new Task(() => { integral.Calculate(start, B, dx); });
                    }
                    else
                    {
                        tasks[i] = new Task(() => { integral.Calculate(start, end, dx); });
                    }

                    tasks[i].Start();
                }

                for (int i = 0; i < M; i++)
                {
                    tasks[i].Wait();
                }

                sw.Stop();
            }
            else
            {
                Action[] actions = new Action[M];
                sw.Start();
                for (int i = 0; i < M; i++)
                {
                    double start = A + i * offset * dx,
                        end = start + offset * dx;
                    if (i == M - 1)
                        actions[i] = () => { integral.Calculate(start, B, dx); };
                    else
                        actions[i] = () => { integral.Calculate(start, end, dx); };
                }

                Parallel.Invoke(actions);
                sw.Stop();
            }

            textBox1.Text = integral.integral.ToString();
            textBox2.Text = integral.GetInaccuracy(A, B).ToString();
            textBox3.Text = sw.ElapsedMilliseconds.ToString();
        }
    }

    class Integral
    {
        Func func;
        CheckFunc checkFunc;
        public double integral { get; private set; }
        object locker = new object();

        public Integral(Func func, CheckFunc checkFunc)
        {
            this.func = func;
            this.checkFunc = checkFunc;
        }

        public void Calculate(double A, double B, double dx)
        {
            double sum = 0;
            for (double x = A; x <= B; x += dx)
            {
                double val = func(x) * dx;
                sum += val;
            }

            lock (locker)
            {
                integral += sum;
            }
        }

        public double GetInaccuracy(double A, double B)
        {
            double rightIntegral = checkFunc(B) - checkFunc(A);
            return Math.Abs(integral - rightIntegral);
        }
    }
}