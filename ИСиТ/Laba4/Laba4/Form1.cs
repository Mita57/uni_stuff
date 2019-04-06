using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grid1.RowCount = Convert.ToInt32(amval.Value.ToString());
        }

        private void amval_ValueChanged(object sender, EventArgs e)
        {
            grid1.RowCount = Convert.ToInt32(amval.Value.ToString());
        }

        private void grid1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool flagre = false; bool flaggr1 = false;


            // check for repeating elements
            char[] elems = new char[0];
            int counter = 0;
            for (int i = 0; i < grid1.RowCount; i++)
            {
                if (grid1.Rows[i].Cells[0].Value!=null&&elems.Contains(Convert.ToChar(grid1.Rows[i].Cells[0].Value.ToString())) == false)
                {
                    Array.Resize(ref elems, elems.Length + 1);
                    elems[counter] = Convert.ToChar(grid1.Rows[i].Cells[0].Value.ToString());
                    flagre = true;
                }
                else if(grid1.Rows[i].Cells[0].Value != null)
                {
                    MessageBox.Show("Повтор символа " + grid1.Rows[i].Cells[0].Value.ToString());
                    flagre = false;
                }
            }



            //check if the prob is written correctly
            for (int i = 0; i < grid1.RowCount; i++)
            {
                try
                {
                    if (grid1.Rows[i].Cells[1].Value != null)
                    {
                        if (Convert.ToDouble(grid1.Rows[i].Cells[1].Value.ToString()) > 1)
                        {
                            grid1.Rows[i].Cells[1].Style.BackColor = Color.Tomato;
                            flaggr1 = false;
                        }
                        else
                        {
                            grid1.Rows[i].Cells[1].Style.BackColor = Color.White;
                            flaggr1 = true;
                        }
                    }
                }
                catch //if the prob didn't convert to double
                {
                    grid1.Rows[i].Cells[1].Style.BackColor = Color.Tomato;
                    flaggr1 = false;
                }
            }
            if (flagre && flaggr1)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }


        }

        static string[] vals; //possible variants
        private void button1_Click(object sender, EventArgs e)
        {
            //check if the sum of probs isn't 1
            double sum = 0;
            for (int i = 0; i < grid1.RowCount; i++)
            {
                double S=0;
                if (grid1.Rows[i].Cells[1].Value!=null && Double.TryParse(grid1.Rows[i].Cells[1].Value.ToString(), out S) == false)
                {
                    break;
                }
                else
                {
                    sum += S;
                }
            }

            if (Math.Round(sum) != 1)
            {
                MessageBox.Show("Сумма вероятностей должна быть равна единице");
            }
            else
            {
                char[] elems = new char[grid1.RowCount];
                for (int j = 0; j < grid1.RowCount; j++)
                {
                    elems[j] = Convert.ToChar(grid1.Rows[j].Cells[0].Value.ToString());
                }
                int k = Convert.ToInt32(power.Value.ToString()); 
                double rows2 = Math.Pow(elems.Length, k); //amout of possible variants
                grid2.RowCount = Convert.ToInt32(rows2);
                Array.Resize(ref vals ,Convert.ToInt32(rows2));
                printAllKLength(elems, k); //getting all varitants
                double [] probs = new double[Convert.ToInt32(grid1.RowCount)];
                for(int i = 0; i < probs.Length; i++)
                {
                    probs[i] = Convert.ToDouble(grid1.Rows[i].Cells[1].Value.ToString());
                }
                for (int i = 0; i < vals.Length; i++)
                {
                    grid2.Rows[i].Cells[0].Value = vals[i].ToString();
                    double prob=1;
                    char[] ar = vals[i].ToCharArray();
                    for(int j = 0; j < ar.Length; j++)
                    {
                        for(int z = 0; z < grid1.RowCount; z++)
                        {
                            if (ar[j] == Convert.ToChar(grid1.Rows[z].Cells[0].Value.ToString()))
                            {
                                prob *= probs[z];
                            }
                        }
                    }
                    grid2.Rows[i].Cells[1].Value = prob.ToString();
                }
                double entropy = 0;
                for (int i = 0; i<probs.Length; i++)
                {
                    entropy += probs[i] * Math.Log(2, probs[i]);
                }
                entropy = -entropy;
                textBox1.Text = entropy.ToString();
            }

        }




        static void printAllKLength(char[] set, int k)
        {
            int n = set.Length;
            printAllKLengthRec(set, "", n, k);
        }
        static int row = 0;

        static void printAllKLengthRec(char[] set, String prefix, int n, int k)
        {
            if (k == 0)
            {
                vals[row] = prefix;
                row++;
                return;
            }
            for (int i = 0; i < n; ++i)
            {
                String newPrefix = prefix + set[i];
                printAllKLengthRec(set, newPrefix, n, k - 1);
            }
        }


    }
}

