using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            double avgTime = Convert.ToInt32(averageTime.Text);// среднее время обслуживания, Tao
            double serviceStream = 1 / avgTime; // поток обслуживаний, Myu
            double requestsStreamDensity = strDensity / serviceStream;// плотноть потока заявок, ro
            double[] p = new double[opsAmount+1]; ;//вероятности
            for (int i = 0; i < opsAmount; i++)
            {
                p[0] += (Math.Pow(requestsStreamDensity, i) / factorial(i));
                MessageBox.Show(p[0].ToString());
            }
            p[0] += Math.Pow(requestsStreamDensity, opsAmount) / ((factorial(opsAmount - 1)) * (opsAmount - requestsStreamDensity));
            p[0] = Math.Round(1 / p[0],3);
            for (int i = 1; i < p.Length; i++)
            {
                p[i] = Math.Round(((Math.Pow(serviceStream, i) / factorial(i)) * p[0]),3);
            }
            DGW.RowCount = opsAmount + 1;


            for (int i = 0; i < p.Length; i++)
            {
                DGW.Rows[i].Cells[0].Value = i;
                DGW.Rows[i].Cells[1].Value = p[i];
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
