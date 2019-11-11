using System;
using System.IO;
using System.Windows.Forms;

namespace Formulas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check()
        {
            if(!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(temperature.Text))
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
            string outism = "( ͡° ͜ʖ ͡°)( ͡° ͜ʖ ͡°)( ͡° ͜ʖ ͡°)( ͡° ͜ʖ ͡°)( ͡° ͜ʖ ͡°)( ͡° ͜ʖ ͡°)( ͡° ͜ʖ ͡°)( ͡° ͜ʖ ͡°)( ͡° ͜ʖ ͡°)( ͡° ͜ʖ ͡°) \n";
            outism += "%username% ";
            outism += DateTime.Now.ToString("F");
            outism += " \nИсходные данные: \n";
            outism += "Молярная масса молекулы: " + textBox1.Text;
            outism += "\nТемпература: " + temperature.Text;
            outism += "\nРезультаты \n";
            if (double.Parse(textBox1.Text) <= 0)
            {
                outism += "Массас не может быть <= 0, лул \n";
            }
            if (double.Parse(temperature.Text) < 0)
            {
                outism += "Абсолютный нолб переоценен \n";
            }

            if (double.Parse(textBox1.Text) > 0 && double.Parse(temperature.Text) >= 0)
            {
                double velocity = (3 * 8.314 * double.Parse(temperature.Text)) / (double.Parse(textBox1.Text) * 0.001);
                velocity = Math.Sqrt(velocity);
                outism += "Среднеквадратичная скорость движения молекул: " + Math.Round(velocity, 3).ToString() + "\n";
                textBox2.Text = Math.Round(velocity, 3).ToString();
            }
            else
            {
                textBox2.Text = "ЪЕЪ";
                outism += "ЪЕЪЕЪЕЪЕЪЕЪЕЪЕЪЕЪЕЪЕЪЕЪЕЪЕЪЕЪЕЪЕЪЕЪЕЪЕЪЕЪЕЪЕЪЕЪЕ\n";
            }
            System.IO.File.AppendAllText(@"C:\Users\57thr\Documents\GitHub\uni_stuff\Year_2\ООП\Formulas\Formulas\Log.txt", outism);
        }



        string lastMassCorrect = "";
        private void TextBox1_KeyDown(object sender, EventArgs e)
        {
            bool correct = double.TryParse(textBox1.Text, out double mass) || textBox1.Text == "";
            if (!correct)
            {
                try
                {
                    int pos = textBox1.SelectionStart - 1;
                    textBox1.Text = lastMassCorrect;
                    textBox1.Focus();
                    textBox1.SelectionStart = pos;
                    textBox1.SelectionLength = 0;
                }
                catch
                {
                    textBox1.Text = "";
                }
            }
            else
            {
                lastMassCorrect = mass.ToString();
            }
            check();
        }


        string lastTempCorrect = "";
        private void Temperature_KeyUp(object sender, EventArgs e)
        {
            bool correct = double.TryParse(temperature.Text, out double temp) || temperature.Text == "";
            if (!correct)
            {
                try
                {
                    int pos = temperature.SelectionStart - 1;
                    temperature.Text = lastTempCorrect;
                    temperature.Focus();
                    temperature.SelectionStart = pos;
                    temperature.SelectionLength = 0;
                }
                catch
                {
                    temperature.Text = "";
                }
            }
            else
            {
                lastTempCorrect = temp.ToString();
            }
            check();
        }
    }
}
