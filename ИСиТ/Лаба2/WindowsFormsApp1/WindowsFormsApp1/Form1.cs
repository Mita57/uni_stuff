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

        bool flag1 = true; bool flag2 = true; bool flag3 = false; bool flag4 = false;

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
                    }
                    else { MessageBox.Show("Повтор символа " + grid1.Rows[i].Cells[0].Value.ToString()); flag1 = false; }
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
                    }
                }
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
                    for (int i=0; i<grid1.Rows.Count; i++)
                    {
                        sum += double.Parse(grid1.Rows[i].Cells[1].Value.ToString());
                        if (sum > 1)
                        {
                            MessageBox.Show("Сумма вероятностей не может быть больше единицы");
                            flag4 = false;
                        }
                        else flag4 = true; 
                    }
                }
                catch { };
            }
            if (grid1.Rows.Count > 1 && flag1 && flag2 && flag3 && flag4)
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum=0;
            double ent = 0;
            for (int i = 0; i < grid1.RowCount-1; i++)
            {
                sum += double.Parse(grid1.Rows[i].Cells[1].Value.ToString());
            }
            if (sum != 1) MessageBox.Show("Сумма вероятностей должна быть равна 1");
            {
                
                for (int i = 0; i < grid1.RowCount-1; i++)
                {
                    double prob = double.Parse(grid1.Rows[i].Cells[1].Value.ToString());
                    ent += prob * Math.Log(prob, 2);
                }
                ent = -ent;
                textBox1.Text = Math.Round(ent, 3).ToString();
            }
        }
    }
}
