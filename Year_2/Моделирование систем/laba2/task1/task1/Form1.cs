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
            double X = Convert.ToInt32(xInit1a.Text);
            dataGridView1a.Rows.Clear();
            dataGridView1a.RowCount = 500;
            int m = 100000001;
            int a = 23;
            int c = Convert.ToInt32(c1a.Text);
            int min = 2147483647;
            int max = 0;
            for (int i = 0; i < 500; i++)
            {
                int nextX = Convert.ToInt32((a * X + c) % m);
                if (nextX < min)
                {
                    min = nextX;
                }
                if (nextX > max)
                {
                    max = nextX;
                }
                dataGridView1a.Rows[i].Cells[0].Value = (i + 1).ToString();
                dataGridView1a.Rows[i].Cells[1].Value = nextX.ToString();
                X = nextX;
            }
            int delta = (max - min) / 10;
            int[] series = new int[10];
            series[0] = min;
            for (int i = 1; i < series.Length; i++)
            {
                series[i] = series[i - 1] + delta;
            }

            int[] freq = new int[10];

            for (int i = 0; i < 500; i++)
            {
                int value = Convert.ToInt32(dataGridView1a.Rows[i].Cells[1].Value);
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
            chart1.Series.Clear();

            for(int i = 0; i < 10; i++)
            {
                Series meme = chart1.Series.Add(series[i].ToString());
                meme.Points.Add(freq[i]);
            }


        }

    }
}

