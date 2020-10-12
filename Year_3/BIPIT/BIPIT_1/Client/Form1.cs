using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntegralCalculation.WebService1 obj = new IntegralCalculation.WebService1();
            label2.Text = obj.Calculate((int)numericUpDown1.Value, (int)numericUpDown2.Value);
        }
    }
}