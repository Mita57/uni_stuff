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
            double opsAmount = Convert.ToInt32(lotsAmount.Text); //количество операторов n
            double storageVol = Convert.ToInt32(storageVolume.Text);//емкость накопителя, m
            double strDensity = Convert.ToDouble(streamDensity.Text);//плотность потока, Lambda
            double avgTime = Convert.ToDouble(averageTime.Text);//среднее обслуживание, Tao
            double serviceStream = 1 / avgTime; // поток обслуживаний, Myu
            double requestsStreamDensity = strDensity / serviceStream;// плотность потока заявок, ro
            double p0 = 0;
            for (int i = 0; i < opsAmount; i++)
            {
                p0 += (Math.Pow(requestsStreamDensity, i) / factorial(i));
            }
            p0 += Math.Pow(requestsStreamDensity, opsAmount) / ((factorial(opsAmount - 1)) * (opsAmount - requestsStreamDensity));
            p0 = Math.Abs(Math.Round(1 / p0, 3));

            //среднее число отказов в обслуживании
            double serviceDenies = (Math.Pow(requestsStreamDensity, opsAmount + storageVol) / (Math.Pow(opsAmount, storageVol) * factorial(opsAmount))) * p0;
            //среднее число заявок в очереди
            double pedWaiting = (Math.Pow(requestsStreamDensity, opsAmount + 1) * p0 * (1 - (storageVol + 1 - storageVol * (requestsStreamDensity / opsAmount)) * Math.Pow(requestsStreamDensity / opsAmount, storageVol))) / (opsAmount * factorial(opsAmount) * Math.Pow((1 - requestsStreamDensity / opsAmount), 2));
            //среднее число занятых мест на парковке
            double parkingAvgBusy = requestsStreamDensity * (1 - (Math.Pow(requestsStreamDensity, opsAmount + storageVol) / (Math.Pow(opsAmount, storageVol) * factorial(opsAmount))) * p0);
            //rendering stuff

            lotsUsed.Text = Math.Round(serviceDenies * 100, 3).ToString();
            carsWaiting.Text = Math.Round((pedWaiting/parkingAvgBusy)*100, 3).ToString();
            avgBusyLots.Text = Math.Round(parkingAvgBusy, 3).ToString();
            avgBusyPed.Text = Math.Round(pedWaiting, 3).ToString();
            eightHoursShit.Text = Math.Round(serviceDenies * strDensity * 8).ToString();


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
