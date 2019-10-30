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
            int c = Convert.ToInt32(c1a.Text);
            for (int i = 0; i < 500; i++)
            {
                int nextX = Convert.ToInt32((a * X + c) % m);
                double U = (double)nextX / m;
                dataGridView1a.Rows[i].Cells[0].Value = (i + 1).ToString();
                dataGridView1a.Rows[i].Cells[1].Value = U.ToString();
                X = nextX;
            }

            fillChart();
        }



        private void fillChart()
        {

            chart1.Series[0].Points.Clear();

            for (int i = 1; i < 500; i++)
            {
                chart1.Series[0].Points.AddXY(Convert.ToDouble(dataGridView1a.Rows[i].Cells[1].Value), Convert.ToDouble(dataGridView1a.Rows[i-1].Cells[1].Value));
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
    }
}

