using System;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = 100;
            Random rnd = new Random();
            double sum = 0;
            for (int i = 0; i < 100; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                double generated = -(Math.Log(1 - rnd.NextDouble())) / 2;
                if (generated >= 1)
                {
                    generated -= (int)generated;
                }
                sum += generated;
                dataGridView1.Rows[i].Cells[1].Value = generated;
            }
            fillChart();
            disp(sum);
            textBox6.Text = (sum / 100).ToString();
        }

        private void fillChart()
        {
            int[] freq = new int[10];

            double[] series = new double[10];
            for (int i = 0; i < series.Length; i++)
            {
                series[i] = (double)(i + 1) / 10;
            }
            for (int i = 0; i < 100; i++)
            {
                double value = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);

                for (int j = 0; j < 10; j++)
                {
                    if (value < series[j])
                    {
                        freq[j]++;
                        break;
                    }
                }
            }
            chart2.Series.Clear();

            for (int i = 0; i < 10; i++)
            {
                Series meme = chart2.Series.Add(series[i].ToString());
                meme.Points.Add(freq[i]);
            }


            chart1.Series[0].Points.Clear();

            for (int i = 1; i < 100; i++)
            {
                chart1.Series[0].Points.AddXY(Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value), Convert.ToDouble(dataGridView1.Rows[i - 1].Cells[1].Value));
            }

            hi(freq);
        }

        private void disp(double sum)
        {
            double disp = 0;
            sum = sum * 0.002;
            for (int i = 1; i < 100; i++)
            {
                double value = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value) - sum;
                disp += 0.002 * Math.Pow(value, 2);
            }
            textBox5.Text = Math.Sqrt(disp).ToString();
        }


        private void hi(int[] freq)
        {
            double hi = 0;
            for (int i = 0; i < freq.Length; i++)
            {
                hi += Math.Pow(((freq[i]) - 100 * 0.1), 2) / (100 * 0.1);
            }
            textBox4.Text = hi.ToString();
        }
    }
}
