using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool flag1 = false; bool flag2 = true; bool flag3 = false; bool flag4 = false;

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string[] values = new string[0];
            int count = 0;
            for (int i = 0; i < grid1.Rows.Count; i++)
            {
                if (grid1.Rows[i].Cells[0].Value != null)
                {
                    if (values.Contains(grid1.Rows[i].Cells[0].Value.ToString()) == false)
                    {
                        Array.Resize(ref values, values.Length + 1);
                        values[count] = grid1.Rows[i].Cells[0].Value.ToString();
                        count++;
                        flag1 = true;
                    }
                    else
                    {
                        MessageBox.Show("Повтор символа " + grid1.Rows[i].Cells[0].Value.ToString());
                        flag1 = false;
                        break;
                    }
                }
            }

            for (int i = 0; i < grid1.Rows.Count; i++)
            {
                if (grid1.Rows[i].Cells[0].Value != null)
                {
                    if (grid1.Rows[i].Cells[0].Value.ToString().Length > 1)
                    {
                        grid1.Rows[i].Cells[0].Style.BackColor = Color.Tomato;
                        flag2 = false;
                    }
                    else
                    {
                        grid1.Rows[i].Cells[0].Style.BackColor = Color.White;
                        flag2 = true;
                    }
                }
                else flag2 = false;
            }

            // cool check if the prob is double and if it's greater than 1

            for (int i = 0; i<grid1.Rows.Count; i++)
            {
                if (grid1.Rows[i].Cells[1].Value != null)
                {
                    try
                    {
                        if (double.Parse(grid1.Rows[i].Cells[1].Value.ToString()) > 1)
                        {
                            grid1.Rows[i].Cells[1].Style.BackColor = Color.Tomato;
                            flag3 = false;
                        }
                        else { grid1.Rows[i].Cells[1].Style.BackColor = Color.White; flag3 = true; }
                    }
                    catch
                    {
                        flag3 = false;
                        grid1.Rows[i].Cells[1].Style.BackColor = Color.Tomato;
                    }
                }
            }

            //check if the summary of probs is greater than 1
            if (grid1.Rows.Count > 1)
            {
                try
                {
                    double sum = 0;
                    for (int i = 0; i < grid1.Rows.Count; i++)
                    {
                        sum += double.Parse(grid1.Rows[i].Cells[1].Value.ToString());
                        if (sum > 1)
                        {
                            flag4 = false;
                        }
                        else flag4 = true;
                    }
                }
                catch
                {
                    flag4 = false;
                }
            }
            if (grid1.Rows.Count > 1 && flag1 && flag2 && flag3)
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag5 = false;
            for (int i = 0; i < grid1.Rows.Count; i++)
            {
                if (grid1.Rows[i].Cells[1].Value == null)
                {
                    grid1.Rows[i].Cells[1].Style.BackColor = Color.Tomato;
                    flag5 = false;
                    break;
                }
                else
                {
                    grid1.Rows[i].Cells[1].Style.BackColor = Color.White;
                    flag5 = true;
                }
            }
            if (!flag4)
            {
                MessageBox.Show("Сумма вероятностей должна быть равна 1");
            }
            else if (flag5)
            {
                double ent = 0;
                for (int i = 0; i < grid1.RowCount; i++)
                {
                    double prob = Convert.ToDouble(grid1.Rows[i].Cells[1].Value.ToString());
                    ent += -prob * Math.Log(prob, 2);
                }
                textBox1.Text = Math.Round(ent, 3).ToString();
            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            grid1.RowCount = Convert.ToInt32(numericUpDown1.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grid1.RowCount = Convert.ToInt32(numericUpDown1.Value);
        }
    }
}
