using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double prob1 = 0;
        double prob2 = 0;
        bool flag1 = false; bool flag2 = false; bool flag3 = false; bool flag4 = false; bool flag5 = false; bool flag6 = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grid1.RowCount = 2;
        }

        private void grid1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (grid1.Rows[0].Cells[0].Value!= null)
            {
                if (grid1.Rows[0].Cells[0].Value.ToString().Length > 1)
                {
                    grid1.Rows[0].Cells[0].Style.BackColor = Color.Tomato;
                    flag1 = false;
                }
                else
                {
                    flag1 = true;
                    grid1.Rows[0].Cells[0].Style.BackColor = Color.White;
                }
            }


            if (grid1.Rows[1].Cells[0].Value!= null)
            {
                if (grid1.Rows[1].Cells[0].Value.ToString().Length > 1)
                {
                    grid1.Rows[1].Cells[0].Style.BackColor = Color.Tomato;
                    flag2 = false;
                }
                else
                {
                    flag2 = true;
                    grid1.Rows[1].Cells[0].Style.BackColor = Color.White;
                }
            }



            if (grid1.Rows[0].Cells[1].Value!= null)
            {
                try { double Z=double.Parse(grid1.Rows[0].Cells[1].Value.ToString());
                    prob1 = Z;
                    grid1.Rows[0].Cells[1].Style.BackColor = Color.White;
                    flag3 = true;
                }
                catch
                {
                    grid1.Rows[0].Cells[1].Style.BackColor = Color.Tomato;
                    flag3 = false;
                }
            }

            if (grid1.Rows[1].Cells[1].Value!= null)
            {
                try {
                    double L = double.Parse(grid1.Rows[1].Cells[1].Value.ToString());                 
                    prob2 = L;
                    grid1.Rows[1].Cells[1].Style.BackColor = Color.White;
                    flag4 = true;
                }
                catch
                {
                    grid1.Rows[1].Cells[1].Style.BackColor = Color.Tomato;
                    flag4 = false;
                    MessageBox.Show("asd");
                }
            }
            if (flag3 && flag4)
            {
                if (prob1 + prob2 > 1)
                {
                    MessageBox.Show("Сумма вероятностей не может быть больше единицы");
                    flag5 = false;
                }
                else if (prob1 + prob2 != 1)
                {
                    MessageBox.Show("Сумма вероятностей должна быть равна единице");
                    flag5 = false;
                }
                else flag5 = true;
            }
           
            if(grid1.Rows[1].Cells[0].Value!= null&& grid1.Rows[0].Cells[0].Value.ToString() != null)
            {
                if (grid1.Rows[1].Cells[0].Value.ToString() == grid1.Rows[0].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Введены два одинаковых символа");
                    flag6 = false;
                }
                else flag6 = true;
            }
            if (flag1 && flag2 && flag3 && flag4 && flag5 && flag6)
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double entropy = 0;
            entropy += prob1*(Math.Log(prob1, 2));
            entropy += prob2*(Math.Log(prob2, 2));
            entropy = -entropy;
            textBox1.Text = Math.Round(entropy, 4).ToString();

            char char1 = char.Parse(grid1.Rows[0].Cells[0].Value.ToString());
            char char2 = char.Parse(grid1.Rows[1].Cells[0].Value.ToString());
            double probar1 = (prob1*prob1);
            grid2.RowCount = 4;
            //aa
            grid2.Rows[0].Cells[0].Value = (char1.ToString() + char1.ToString());
            grid2.Rows[0].Cells[1].Value = probar1;
            //ab
            double probar2 = (prob1 * prob2);
            grid2.Rows[1].Cells[0].Value = (char1.ToString() + char2.ToString());
            grid2.Rows[1].Cells[1].Value = probar2;
            //ba
            grid2.Rows[2].Cells[0].Value = (char2.ToString() + char1.ToString());
            grid2.Rows[2].Cells[1].Value = probar2;
            //bb
            double probar3 = prob2 * prob2;
            grid2.Rows[3].Cells[0].Value = (char2.ToString() + char2.ToString());
            grid2.Rows[3].Cells[1].Value = probar3;
        }
    }
}
