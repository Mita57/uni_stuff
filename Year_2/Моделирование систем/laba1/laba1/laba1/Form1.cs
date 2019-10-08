using System;
using System.Windows.Forms;

namespace laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int opsAmount = Convert.ToInt32(operatorsAmount.Text); // количетсво операторов, n
            double strDensity = Convert.ToDouble(streamDensity.Text);// плотность потока, Lambda
            double avgTime = Convert.ToDouble(averageTime.Text);// среднее время обслуживания, Tao
            double serviceStream = 1 / avgTime; // поток обслуживаний, Myu
            double requestsStreamDensity = strDensity / serviceStream;// плотноть потока заявок, ro
            if (requestsStreamDensity > opsAmount)
            {
                MessageBox.Show("Установившегося режима нет");
            }
            else
            {
                double[] p = new double[opsAmount + 1]; ;//вероятности
                for (int i = 0; i < opsAmount; i++)
                {
                    p[0] += (Math.Pow(requestsStreamDensity, i) / factorial(i));
                }
                p[0] += Math.Pow(requestsStreamDensity, opsAmount) / ((factorial(opsAmount - 1)) * (opsAmount - requestsStreamDensity));
                p[0] = Math.Abs(Math.Round(1 / p[0], 3));
                for (int i = 1; i < p.Length; i++)
                {
                    p[i] = (Math.Pow(requestsStreamDensity, i) / factorial(i)) * p[0];
                }
                DGW.RowCount = opsAmount + 1;

                //rendering the probs DGW
                for (int i = 0; i < p.Length; i++)
                {
                    DGW.Rows[i].Cells[0].Value = i;
                    DGW.Rows[i].Cells[1].Value = p[i];
                }

                //textboxes

                //вероятность очереди
                double sumOfProbs = 0;
                foreach (double x in p)
                {
                    sumOfProbs += x;
                }

                QProbability.Text = (1 - sumOfProbs).ToString();

                //средняя длина очереди L

                double allAreBusy = (Math.Pow(requestsStreamDensity, opsAmount) / (factorial(opsAmount - 1) * (opsAmount - requestsStreamDensity))) * p[0]; //Pi
                avgQLength.Text = (Math.Round(requestsStreamDensity * allAreBusy / (opsAmount - requestsStreamDensity), 2)).ToString();

                //среднее время ожидания в очереди Tср
                avgQTime.Text = (Math.Round(allAreBusy / (serviceStream * (opsAmount - requestsStreamDensity)), 3)).ToString();

                //среднее число занятых каналов Nзан
                double avgFreeOps = 0;
                for (int i = 0; i < opsAmount; i++)
                {
                    avgFreeOps += (opsAmount - i) * p[i]; //N своб
                }

                avgBusyOps.Text = (Math.Round((opsAmount - avgFreeOps), 2)).ToString();

                //необходиомое количество операторов

                while ((allAreBusy / (serviceStream * (opsAmount - requestsStreamDensity)) > Convert.ToDouble(textBox1.Text)))
                {
                    opsAmount++;
                }
                opsRequired.Text = opsAmount.ToString();

                //вероятность более одного доступного оператора
                double[] p2 = new double[opsAmount + 1]; ;//вероятности
                for (int i = 0; i < opsAmount; i++)
                {
                    p2[0] += (Math.Pow(requestsStreamDensity, i) / factorial(i));
                }
                p2[0] += Math.Pow(requestsStreamDensity, opsAmount) / ((factorial(opsAmount - 1)) * (opsAmount - requestsStreamDensity));
                p2[0] = Math.Round(1 / p2[0], 3);
                for (int i = 1; i < p.Length; i++)
                {
                    p2[i] = (Math.Pow(requestsStreamDensity, i) / factorial(i)) * p2[0];
                }


                double probAddedOps = 0;
                for (int i = 0; i < p2.Length - 1; i++)
                {
                    probAddedOps += p2[i];
                }

                probs2.Text = (Math.Round(probAddedOps, 3)).ToString();
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
