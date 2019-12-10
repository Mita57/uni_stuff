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
            double sum = 0;
            double a = Convert.ToInt32(aTextBox.Text);
            for (int i = 0; i < 500; i++)
            {
                double nextX = Convert.ToDouble((a * X) % m);
                double U = nextX / m;
                sum += U;
                dataGridView1a.Rows[i].Cells[0].Value = (i + 1).ToString();
                dataGridView1a.Rows[i].Cells[1].Value = U.ToString();
                X = nextX;
            }
            avgTextBox.Text = (sum / 500).ToString();
            fillChart();
            disp(sum);
            double firstElem = Convert.ToDouble(dataGridView1a.Rows[0].Cells[1].Value);
            X = Convert.ToDouble(xInit1a.Text);
            if (checkBox1.Checked)
            {
                findPeriod(a, Convert.ToDouble(xInit1a.Text), m);
            }
        }

        private void findPeriod(double a, double X, double m)
        {
            int period = 1;
            double lX = X;
            while (true)
            {
                double nextX = Convert.ToDouble((a * lX) % m);
                double U = nextX / m;
                if (Math.Round(U,8) == (Math.Round(Convert.ToDouble(dataGridView1a.Rows[0].Cells[1].Value), 8)) && period != 1)
                {
                    break;
                }
                lX = nextX;
                period++;
            }
            textBox5.Text = period.ToString();
        }

        private void fillChart()
        {
            int[] freq = new int[10];

            double[] series = new double[10];
            for (int i = 0; i < series.Length; i++)
            {
                series[i] = (double)(i+1) / 10;
            }
            for (int i = 0; i < 500; i++)
            {
                double value = Convert.ToDouble(dataGridView1a.Rows[i].Cells[1].Value);

                for (int j = 0; j < 10; j++)
                {
                    if(value < series[j])
                    {
                        freq[j]++;
                        break;
                    }
                }
            }
            chart2.Series.Clear();
            Series meme = new Series();
            meme.ChartType = SeriesChartType.Column;
            meme.Name = "Попадания";
            chart2.Series.Add(meme);
            for (int i = 0; i < 10; i++)
            {
                chart2.Series["Попадания"].Points.AddXY((double)i/10, freq[i]);
            }


            chart1.Series[0].Points.Clear();

            for (int i = 1; i < 500; i++)
            {
                chart1.Series[0].Points.AddXY(Convert.ToDouble(dataGridView1a.Rows[i].Cells[1].Value), Convert.ToDouble(dataGridView1a.Rows[i - 1].Cells[1].Value));
            }

            hi(freq);
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
            double sum = 0;
            dataGridView1a.RowCount = 500;
            for (int i = 0; i < 500; i++)
            {
                double value1 = (a1 * X1) % m1;
                double value2 = (a2 * X2) % m2;
                double U1 = value1 / m1;
                double U2 = value2 / m2;
                double united = Math.Abs((U1*m1 - U2*m2) % (m1 - 1));
                united /=  m1;
                sum += united;
                dataGridView1a.Rows[i].Cells[0].Value = i + 1;
                dataGridView1a.Rows[i].Cells[1].Value = united;
                X1 = value1;
                X2 = value2;
            }
            avgTextBox.Text = (sum/500).ToString();
            fillChart();
            disp(sum);

            m1 = 100000001;
            a1 = 23;
            m2 = 2147483399;
            a2 = 40692;
            X1 = Convert.ToDouble(xInit1a.Text);
            X2 = X1;
            int period = 1;
            while (true)
            {
                double value1 = (a1 * X1) % m1;
                double value2 = (a2 * X2) % m2;
                double U1 = value1 / m1;
                double U2 = value2 / m2;
                double united = Math.Abs((U1 * m1 - U2 * m2) % (m1 - 1));
                united /= m1;
                if (Math.Round(united, 8) == (Math.Round(Convert.ToDouble(dataGridView1a.Rows[0].Cells[1].Value), 8)) && period != 1)
                {
                    break;
                }
                X1 = value1;
                X2 = value2;
                period++;
            }
            textBox5.Text = period.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            dataGridView1a.Rows.Clear();
            dataGridView1a.RowCount = 500;
            Random rnd = new Random();
            double sum = 0;
            for(int i = 0; i < 500; i++)
            {
                dataGridView1a.Rows[i].Cells[0].Value = i + 1;
                dataGridView1a.Rows[i].Cells[1].Value = rnd.NextDouble();
                sum += Convert.ToDouble(dataGridView1a.Rows[i].Cells[1].Value);
            }
            avgTextBox.Text = (sum / 500).ToString();
            fillChart();
            disp(sum);
        }


        private void disp(double sum)
        {
            double disp = 0;
            sum = sum * 0.002;
            for(int i = 1; i < 500; i++)
            {
                double value = Convert.ToDouble(dataGridView1a.Rows[i].Cells[1].Value) - sum;
                disp += 0.002 * Math.Pow(value, 2);
            }
            standDevTextBox.Text = Math.Sqrt(disp).ToString();
        }

        private void hi (int[] freq)
        {
            double hi = 0;
            for(int i = 0; i < freq.Length; i++)
            {
                hi += Math.Pow(((freq[i]) - 500 * 0.1), 2) / (500 * 0.1);
            }
            textBox2.Text = hi.ToString();
        }


    }
}

