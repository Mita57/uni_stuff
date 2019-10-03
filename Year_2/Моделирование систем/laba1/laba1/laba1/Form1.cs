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
            int opsAmount = Convert.ToInt32(operatorsAmount.Text); // количетсво операторов
            double strDensity = Convert.ToDouble(streamDensity.Text);// плотность потока
            double avgTime = Convert.ToInt32(averageTime.Text);// среднее время обслуживания
            double serviceStream = 1 / avgTime; // поток обслуживаний
        }
    }
}
