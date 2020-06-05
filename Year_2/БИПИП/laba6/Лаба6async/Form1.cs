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

namespace Лаба6async
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int N = 0;
        static int M = 0;
        static double x0;
        static int amount;
        static bool checkfirst;
        static double delta;
        static double res;
        static double x;
        static double y;
        static double ssqleft;
        static double strap;
        static double[] vals;
        public static Thread[] th;
        public static List<Task> tasks;
        public static Action[] act;
        private async void button1_Click(object sender, EventArgs e)
        {
            double a = 1;
            double b = 2;
            double analit = (1 / (-b * 2) + (a / (b * b)) * Math.Log(Math.Abs((a * 2 + b) / 2))) - (1 / (-b * 1) + (a / (b * b)) * Math.Log(Math.Abs((a * 1 + b) / 1)));

            res = 0;
            x = 0;
            y = 0;
            ssqleft = 0;
            strap = 0;
            vals = new double[Convert.ToInt32(numericUpDown1.Value)];
            
            checkfirst = true;
            a = 1;
            b = 2;
            if (!int.TryParse(textBox1.Text, out N))
            {
                return;
            }
            amount = (int)N;
            delta = 1 / (double)amount;
            x0 = (double)a + (double)(b - a) / amount - delta * 2;
            M = Convert.ToInt32(numericUpDown1.Value);
            th = new Thread[M];
            textBox2.Text += "Thread start...";
            Stopwatch st = Stopwatch.StartNew();

            await thread();

            st.Stop();
            textBox2.Text += " Done.\r\n";
            for (int i = 0; i < M; i++)
            {
                res += vals[i];
            }
            textBox2.Text += "Thread: int = " + Math.Round(res, 4) + " t=" + Math.Round((decimal)st.ElapsedMilliseconds / 1000, 4)+"\r\n";

            res = 0;
            x = 0;
            y = 0;
            ssqleft = 0;
            strap = 0;
            vals = new double[Convert.ToInt32(numericUpDown1.Value)];
            checkfirst = true;
            a = 1;
            b = 2;
            if (!int.TryParse(textBox1.Text, out N))
            {
                return;
            }
            amount = (int)N;
            delta = 1 / (double)amount;
            x0 = (double)a + (double)(b - a) / amount - delta * 2;

            M = Convert.ToInt32(numericUpDown1.Value);
            var summ = new Sum[M];
            for (int i = 0; i < summ.Length; i++)
            {
                summ[i] = new Sum(i);
            }
            tasks = new List<Task>();
            foreach(var val in summ)
            {
                tasks.Add(new Task(() => val.work()));
            }
            textBox2.Text += "Task start...";
            st = Stopwatch.StartNew();

            await task();

            st.Stop();
            textBox2.Text += " Done.\r\n";
            for (int i = 0; i < M; i++)
            {
                res += vals[i];
            }
            textBox2.Text += "Task: int = " + Math.Round(res, 4) + " t=" + Math.Round((decimal)st.ElapsedMilliseconds / 1000, 4) + "\r\n";

            res = 0;
            x = 0;
            y = 0;
            ssqleft = 0;
            strap = 0;
            vals = new double[Convert.ToInt32(numericUpDown1.Value)];
            
            checkfirst = true;
            a = 1;
            b = 2;
            if (!int.TryParse(textBox1.Text, out N))
            {
                return;
            }
            amount = (int)N;
            delta = 1 / (double)amount;
            x0 = (double)a + (double)(b - a) / amount - delta * 2;

            M = (int)numericUpDown1.Value;

            act = new Action[M];
            summ = new Sum[M];
            for (int i = 0; i < summ.Length; i++)
            {
                summ[i] = new Sum(i);
            }
            int j = 0;
            foreach(var val in summ)
            {
                act[j] = new Action(()=>val.work());
                ++j;
            }
            textBox2.Text += "Invoke start...";
            st = Stopwatch.StartNew();

            await invoke();

            st.Stop();
            textBox2.Text += " Done.\r\n";
            for (int i = 0; i < M; i++)
            {
                res += vals[i];
            }
            textBox2.Text += "Invoke: int = " + Math.Round(res, 4) + " t=" + Math.Round((decimal)st.ElapsedMilliseconds / 1000, 4) + "\r\n\r\n";
        }

        public static void doThread()
        {
            for (int i = 0; i < th.Count(); i++)
            {
                th[i] = new Thread(Summa);
                th[i].Start(i);
            }

            for (int i = 0; i < th.Count(); i++)
            {
                th[i].Join();
            }
        }

        public static Task thread()
        {
            Task f = Task.Run(() => doThread());
            return f;
        }

        public static void doTask()
        {
            foreach (var t in tasks)
            {
                t.Start();
            }

            foreach (var t in tasks)
            {
                t.Wait();
            }
        }

        public static Task task()
        {
            Task f = Task.Run(() => doTask());
            return f;
        }

        public static void doInvoke()
        {
            Parallel.Invoke(act);
        }

        public static Task invoke()
        {
            Task f = Task.Run(() => doInvoke());
            return f;
        }

        public static void Summa(object input)
        {
            int number = (int)input;
            double a = 1;
            double b = 2;
            for (int i = number; i < N; i += M)
            {
                x = x0 + (double)i * delta;
                y = 1 / ((x * x) * ((double)a * x + (double)b) * (x * x) * ((double)a * x + (double)b));
                double yminone = 1 / (((x - delta) * (x - delta)) * ((double)a * (x - delta) + (double)b));
                vals[number] += (y + yminone) / 2 * (delta);
            }
        }

        class Sum
        {
            int number;
            public Sum(object input)
            {
                number = (int)input;
            }

            public void work()
            {
                double a = 1;
                double b = 2;
                for (int i = number; i < N; i += M)
                {
                    x = x0 + (double)i * delta;
                    y = 1 / ((x * x) * ((double)a * x + (double)b) * (x * x) * ((double)a * x + (double)b));
                    double yminone = 1 / (((x - delta) * (x - delta)) * ((double)a * (x - delta) + (double)b));
                    vals[number] += (y + yminone) / 2 * (delta);
                }
            }
        }
    }
}
