using System;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1a_Click(object sender, EventArgs e)
        {
            double X = Convert.ToDouble(xInit1a.Text);
            dataGridView1a.Rows.Clear();
            dataGridView1a.RowCount = 500;
            double m = Convert.ToDouble(mTextBox.Text);
            double a = Convert.ToInt32(aTextBox.Text);
            for (int i = 0; i < 500; i++)
            {
                double nextX = Convert.ToDouble((a * X) % m);
                double U = nextX / m;
                dataGridView1a.Rows[i].Cells[0].Value = (i + 1).ToString();
                dataGridView1a.Rows[i].Cells[1].Value = U.ToString();
                X = nextX;
            }

            fillChart();
        }



        private void fillChart()
        {
            int[] freq = new int[10];

            double[] series = new double[10];
            for (int i = 0; i < series.Length; i++)
            {
                series[i] = (double)i / 10;
            }

            for (int i = 0; i < 500; i++)
            {
                double value = Convert.ToDouble(dataGridView1a.Rows[i].Cells[1].Value);
                if (value < series[1])
                {
                    freq[0]++;
                    continue;
                }
                if (value < series[2])
                {
                    freq[1]++;
                    continue;
                }
                if (value < series[3])
                {
                    freq[2]++;
                    continue;
                }
                if (value < series[4])
                {
                    freq[3]++;
                    continue;
                }
                if (value < series[5])
                {
                    freq[4]++;
                    continue;
                }
                if (value < series[6])
                {
                    freq[5]++;
                    continue;
                }
                if (value < series[7])
                {
                    freq[6]++;
                    continue;
                }
                if (value < series[8])
                {
                    freq[7]++;
                    continue;
                }
                if (value < series[9])
                {
                    freq[8]++;
                    continue;
                }
                else
                {
                    freq[9]++;
                    continue;
                }

            }
            chart2.Series.Clear();

            for (int i = 0; i < 10; i++)
            {
                Series meme = chart2.Series.Add(series[i].ToString());
                meme.Points.Add(freq[i]);
            }


            chart1.Series[0].Points.Clear();

            for (int i = 1; i < 500; i++)
            {
                chart1.Series[0].Points.AddXY(Convert.ToDouble(dataGridView1a.Rows[i].Cells[1].Value), Convert.ToDouble(dataGridView1a.Rows[i - 1].Cells[1].Value));
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            mTextBox.Text = "100000001";
            aTextBox.Text = "23";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            mTextBox.Text = "2147483399";
            aTextBox.Text = "40692";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            dataGridView1a.Rows.Clear();
            double m1 = 100000001;
            double a1 = 23;
            double m2 = 2147483399;
            double a2 = 40692;
            double X1 = Convert.ToDouble(xInit1a.Text);
            double X2 = X1;
            dataGridView1a.RowCount = 500;
            for (int i = 0; i < 500; i++)
            {
                double value1 = (a1 * X1) % m1;
                double value2 = (a2 * X2) % m2;
                double U1 = value1 / m1;
                double U2 = value2 / m2;
                double united = Math.Abs((U1*m1 - U2*m2) % (m1 - 1));
                united /=  m1;
                dataGridView1a.Rows[i].Cells[0].Value = i + 1;
                dataGridView1a.Rows[i].Cells[1].Value = united;
                X1 = value1;
                X2 = value2;
            }
            fillChart();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            dataGridView1a.Rows.Clear();
            dataGridView1a.RowCount = 500;
            Random rnd = new Random();
            for(int i = 0; i < 500; i++)
            {
                dataGridView1a.Rows[i].Cells[0].Value = i + 1;
                dataGridView1a.Rows[i].Cells[1].Value = rnd.NextDouble();
            }
            fillChart();
        }
    }
}

