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
            double opsAmount = Convert.ToInt32(lotsAmount.Text); //количество операторов opsAmount
            double bufferVolume = Convert.ToInt32(storageVolume.Text);//емкость накопителя, m
            double strDensity = Convert.ToDouble(streamDensity.Text);//плотность потока, Lambda
            double avgTime = Convert.ToDouble(averageTime.Text);//среднее обслуживание, Tao0
            double serviceStream = 60 / avgTime; // поток обслуживаний, Myu, converted to hours
            double requestsStreamDensity = strDensity / serviceStream;// плотность потока заявок, ro
            double p0 = 0;
            for (int i = 0; i <= opsAmount; i++)
            {
                p0 += Math.Pow(requestsStreamDensity, i) / factorial(i);
            }
            p0 += (Math.Pow(requestsStreamDensity, opsAmount + 1) * (1 - Math.Pow(requestsStreamDensity / opsAmount, bufferVolume))) / (opsAmount * factorial(opsAmount) * (1 - requestsStreamDensity / opsAmount));
            p0 = 1 / p0;
            //среднее число отказов в обслуживании
            double serviceDenies = (Math.Pow(requestsStreamDensity, opsAmount + bufferVolume) / (Math.Pow(opsAmount, bufferVolume) * factorial(opsAmount))) * p0;
            deniedComplelely.Text = (Math.Round(serviceDenies, 3) * 100).ToString();
            //среднее число заявок в очереди
            double avgRequests = (Math.Pow(requestsStreamDensity, opsAmount + 1) * p0 * (1 - (bufferVolume + 1 - bufferVolume * (requestsStreamDensity / opsAmount)) * Math.Pow(requestsStreamDensity / opsAmount, bufferVolume))) / (opsAmount * factorial(opsAmount) * Math.Pow((1 - requestsStreamDensity / opsAmount), 2));
            //среднее число занятых каналов
            double avgBusy = requestsStreamDensity * (1 - (Math.Pow(requestsStreamDensity, opsAmount + bufferVolume) / (Math.Pow(opsAmount, bufferVolume) * factorial(opsAmount))) * p0);
            carsWaiting.Text = (Math.Round((avgRequests / avgBusy) * 100, 3)).ToString();
            avgBusyLots.Text = Math.Round(avgBusy, 2).ToString();
            avgBusyPed.Text = Math.Round(avgRequests, 3).ToString();
            eightHoursShit.Text = Math.Round((strDensity * 8) * serviceDenies, 3).ToString();
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
