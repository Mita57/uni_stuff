using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int lotsAmount = Convert.ToInt32(pLotsAmount.Text);//количество парковочных мест n1
            int pedLots = Convert.ToInt32(pedestrianLots.Text);//количество мест на пешеходных дорожках n2
            int allLots = lotsAmount + pedLots;
            double streamDensity = Convert.ToDouble(strDensity.Text);//плотность потока lambda
            double avgTime = Convert.ToDouble(averageTIme.Text);//среднее время ожидания
            double serviceStream = 1 /avgTime;//поток обслуживаний myu
            double avgTIme = Convert.ToDouble(averageTIme.Text);
            double requestsStreamDensity = streamDensity / serviceStream;// плотноть потока заявок, ro
            double[] p = new double[lotsAmount + 1]; ;//вероятности
            for (int i = 0; i < lotsAmount; i++)
            {
                p[0] += (Math.Pow(requestsStreamDensity, i) / factorial(i));
            }
            p[0] += Math.Pow(requestsStreamDensity, opsAmount) / ((factorial(opsAmount - 1)) * (opsAmount - requestsStreamDensity));
            p[0] = Math.Abs(Math.Round(1 / p[0], 3));
            for (int i = 1; i < p.Length; i++)
            {
                p[i] = (Math.Pow(requestsStreamDensity, i) / factorial(i)) * p[0];
            }



        }


        private int factorial(int number)
        {
            if (number == 1 || number == 0)
                return 1;
            else
                return number * factorial(number - 1);
        }
    }
}
