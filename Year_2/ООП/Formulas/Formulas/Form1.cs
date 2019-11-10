using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool flagTemp = false;
        bool flagMass = false;



        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void check()
        {
            if(flagMass && flagTemp)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double velocity = (3 * 8.314 * double.Parse(temperature.Text)) / (double.Parse(textBox1.Text)*0.001);
            velocity = Math.Sqrt(velocity);
            textBox2.Text = Math.Round(velocity, 3).ToString();
        }



        string lastMassCorrect = "";
        private void TextBox1_KeyDown(object sender, EventArgs e)
        {
            bool correct = double.TryParse(textBox1.Text, out double mass);
            if (!correct || mass <= 0)
            {
                textBox1.Text = lastMassCorrect;
                textBox1.Focus();
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.SelectionLength = 0;
            }
            else
            {
                lastMassCorrect = mass.ToString();
                flagMass = true;
            }
            check();
        }


        string lastTempCorrect = "";
        private void Temperature_KeyUp(object sender, EventArgs e)
        {
            bool correct = double.TryParse(temperature.Text, out double temp);
            if (!correct || temp < 0)
            {
                temperature.Text = lastTempCorrect;
                temperature.Focus();
                temperature.SelectionStart = temperature.Text.Length;
                temperature.SelectionLength = 0;
            }
            else
            {
                lastTempCorrect = temp.ToString();
                flagTemp = true;
            }
            check();
        }
    }
}
