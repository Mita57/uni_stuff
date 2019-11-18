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
            double[] p = new double[(int)opsAmount];
            double znam1 = 0;
            for (int k = 0; k <= opsAmount; k++)
            {
                znam1 += Math.Pow(requestsStreamDensity, bufferVolume) / factorial(bufferVolume);
            }
            double znam2 = Math.Pow(requestsStreamDensity, opsAmount) / factorial(opsAmount);
            double znam3 = 0;
            for (int s = 1; s <= bufferVolume; s++)
            {
                znam3 += Math.Pow((requestsStreamDensity / opsAmount), s);
            }
            double p0 = 1 / (znam1 + (znam2 * znam3));

            //среднее число потерь заявок
            double serviceDenies = Math.Pow(requestsStreamDensity, opsAmount)/factorial(opsAmount);
            serviceDenies *= Math.Pow(requestsStreamDensity / opsAmount, bufferVolume);
            serviceDenies *= p0;
            deniedComplelely.Text = (Math.Round(serviceDenies, 3) * 100).ToString() + "%";

            //среднее число заявок в очереди
            double avgRequests = 0;
            for(int i = 1; i < bufferVolume; i++)
            {
                avgRequests += i * Math.Pow(requestsStreamDensity/opsAmount, i);
            }
            avgRequests *= Math.Pow(requestsStreamDensity, opsAmount) / factorial(opsAmount);
            avgRequests *= p0;
            avgBusyPed.Text = avgRequests.ToString();

            //среднее число занятых каналов

            double[] arr = new double[(int)opsAmount + (int)bufferVolume + 1];
            for (int k = 1; k <= opsAmount; k++)
            {
                arr[k] = (Math.Pow(requestsStreamDensity, bufferVolume) / factorial(k)) * p0;
            }
            for (int s = (int)opsAmount + 1; s < arr.Length; s++)
            {
                arr[s] = (Math.Pow(requestsStreamDensity, opsAmount) / factorial(opsAmount)) * (Math.Pow(requestsStreamDensity / opsAmount, s - opsAmount)) * p0;
            }
            double sum1 = 0;
            for (int s = 1; s <= (int)opsAmount; s++)
            {
                sum1 += (arr[s] * s);
            }
            double sum2 = 0;
            for (int s = (int)opsAmount + 1; s < arr.Length; s++)
            {
                sum2 += (arr[s] * opsAmount);
            }
            avgBusyLots.Text = (sum1 + sum2).ToString();

            //вероятность ожидания обслуживания


            for (int i = 1; i < p.Length; i++)
            {
                p[i] = (Math.Pow(requestsStreamDensity, i) / factorial(i)) * p0;
            }

            double serviceWaitProb = 1;
            for(int i = 0; i <p.Length; i++)
            {
                serviceWaitProb -= p[i];
            }
            serviceWaitProb *= 100;
            carsWaiting.Text = serviceWaitProb.ToString() +"%";


            //среднее число посетителей, не нашедших места 

            double haventGotPlace = strDensity * serviceDenies*8;
            eightHoursShit.Text = haventGotPlace.ToString();
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
