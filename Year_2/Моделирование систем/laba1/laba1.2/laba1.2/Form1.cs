using System;
using System.Windows.Forms;

namespace laba1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double n = Convert.ToInt32(lotsAmount.Text); //количество операторов n
            double k = Convert.ToInt32(storageVolume.Text);//емкость накопителя, m
            double a = Convert.ToDouble(streamDensity.Text);//плотность потока, Lambda
            double t0 = Convert.ToDouble(averageTime.Text);//среднее обслуживание, Tao0
            double u = 60 / t0; // поток обслуживаний, Myu, converted to hours
            double pa = a / u;// плотность потока заявок, ro
            double p0 = 0;
            for (int i = 0; i <= n; i++)
            {
                p0 += Math.Pow(pa, i) / factorial(i);
            }
            p0 += (Math.Pow(pa, n + 1) * (1 - Math.Pow(pa / n, k))) / (n * factorial(n) * (1 - pa / n));
            p0 = 1/p0;
            double potk = (Math.Pow(pa, n + k) / (Math.Pow(n, k) * factorial(n))) * p0; //среднее число отказов в обслуживании
            deniedComplelely.Text = (Math.Round(potk, 3)*100).ToString();
            double loch = (Math.Pow(pa, n + 1) * p0 * (1 - (k + 1 - k * (pa / n)) * Math.Pow(pa / n, k))) / (n * factorial(n) * Math.Pow((1 - pa / n), 2)); //среднее число заявок в очереди
            double kk = pa * (1 - (Math.Pow(pa, n + k) / (Math.Pow(n, k) * factorial(n))) * p0); //среднее число занятых каналов
            carsWaiting.Text = (Math.Round((loch / kk)*100, 3)).ToString();
            avgBusyLots.Text = Math.Round(kk, 2).ToString();
            avgBusyPed.Text = Math.Round(loch, 3).ToString();
            eightHoursShit.Text = Math.Round((a * 8) * potk, 3).ToString();
        }


        private double factorial(double number)
        {
            if (number == 1 || number == 0)
                return 1;
            else
                return number * factorial(number - 1);
        }
    }
}
