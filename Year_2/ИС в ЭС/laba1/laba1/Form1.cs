using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void RenderButton_Click(object sender, EventArgs e)
        {
            inputDGW.Rows.Clear();
            inputDGW.RowCount = Convert.ToInt32(amountUpDown.Value);
            inputDGW.ColumnCount = Convert.ToInt32(amountUpDown.Value) + 2;
            for (int i = 2; i < Convert.ToInt32(amountUpDown.Value) + 2; i++)
            {
                inputDGW.Columns[i].Width = 40;
                inputDGW.Columns[i].HeaderText = (i - 1).ToString();
                inputDGW.Rows[i - 2].Cells[0].Value = (i - 1).ToString();
                inputDGW.Rows[i - 2].Cells[i].Value = 0;
                inputDGW.Rows[i - 2].Cells[i].ReadOnly = true;
            }
            inputDGW.Columns.Add("lal", "ИБЗ");
            inputDGW.Columns.Add("lalal", "Баллы 1");
            inputDGW.Columns.Add("lalal", "Баллы 2");
            inputDGW.Columns[Convert.ToInt32(amountUpDown.Value)+2].Width = 50;//ИБЗ
            inputDGW.Columns[Convert.ToInt32(amountUpDown.Value)+3].Width = 50;//баллы1
            inputDGW.Columns[Convert.ToInt32(amountUpDown.Value)+4].Width = 50;//баллы2
        }


        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            bool flag = false;
            for(int i = 0; i < Convert.ToInt32(amountUpDown.Value); i++)
            {
                if(inputDGW.Rows[i].Cells[1] == null)
                {
                    MessageBox.Show("Введите названия показателей");
                    flag = true;
                    break;
                }
                if (inputDGW.Rows[i].Cells[Convert.ToInt32(amountUpDown.Value) + 2].Value == null)
                {
                    MessageBox.Show("Проверьте индексы балло-значимости");
                    flag = true;
                    break;
                }
                if(inputDGW.Rows[i].Cells[Convert.ToInt32(amountUpDown.Value) + 3].Value == null)
                {
                    MessageBox.Show("Проверьте баллы 1");
                    flag = true;
                    break;
                }
                if (inputDGW.Rows[i].Cells[Convert.ToInt32(amountUpDown.Value) + 4].Value == null)
                {
                    MessageBox.Show("Проверьте баллы 2");
                    flag = true;
                    break;
                }

            }
            //check if the IBZ is equal to 1
            double cock = 0;
            for(int i = 0; i < Convert.ToInt32(amountUpDown.Value); i++)
            {
                cock += Convert.ToDouble(inputDGW.Rows[i].Cells[Convert.ToInt32(amountUpDown.Value) + 2].Value);
            }
            if (cock != 1)
            {
                MessageBox.Show("Сумма ИБЗ должна быть равна 1");
                flag = true;
            }

            //check if the score 1 is max of 10

            for (int i = 0; i < Convert.ToInt32(amountUpDown.Value); i++)
            {
                if(int.Parse(inputDGW.Rows[i].Cells[Convert.ToInt32(amountUpDown.Value) + 3].Value.ToString()) > 10 || int.Parse(inputDGW.Rows[i].Cells[Convert.ToInt32(amountUpDown.Value) + 3].Value.ToString()) < 0)
                {
                    MessageBox.Show("Проверьте баллы 1");
                    flag = true;
                    break;
                }
            }
            //check if the score 2 is max of 10

            for (int i = 0; i < Convert.ToInt32(amountUpDown.Value); i++)
            {
                if (int.Parse(inputDGW.Rows[i].Cells[Convert.ToInt32(amountUpDown.Value) + 4].Value.ToString()) > 10 || int.Parse(inputDGW.Rows[i].Cells[Convert.ToInt32(amountUpDown.Value) + 4].Value.ToString()) < 0)
                {
                    MessageBox.Show("Проверьте баллы 2");
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                renderDGW1();
                renderDGW2();
            }

        }

        private void renderDGW1()
        {
            int[] rowSum = new int[inputDGW.RowCount];
            int total = 0;
            for(int i = 0; i < rowSum.Length; i++)
            {
                rowSum[i] = 0;
                for(int j = 1; j < rowSum.Length; j++)
                {
                    rowSum[i] += int.Parse(inputDGW.Rows[0].Cells[j].Value.ToString());
                    total += int.Parse(inputDGW.Rows[0].Cells[j].Value.ToString());
                }
            }

            DGW1.RowCount = inputDGW.RowCount;

            for (int i = 0; i < inputDGW.RowCount; i++)
            {
                DGW1.Rows[i].Cells[0].Value = inputDGW.Rows[i].Cells[0];
                DGW1.Rows[i].Cells[1].Value = inputDGW.Rows[i].Cells[Convert.ToInt32(amountUpDown.Value) + 3].Value;
                DGW1.Rows[i].Cells[2].Value = rowSum[i] / total;
                DGW2.Rows[i].Cells[3].Value = double.Parse(DGW1.Rows[i].Cells[1].Value.ToString()) * double.Parse(DGW1.Rows[i].Cells[2].Value.ToString());
            }

        }


        private void renderDGW2()
        {
            int[] rowSum = new int[inputDGW.RowCount];
            int total = 0;
            for (int i = 0; i < rowSum.Length; i++)
            {
                rowSum[i] = 0;
                for (int j = 1; j < rowSum.Length; j++)
                {
                    rowSum[i] += int.Parse(inputDGW.Rows[0].Cells[j].Value.ToString());
                    total += int.Parse(inputDGW.Rows[0].Cells[j].Value.ToString());
                }
            }

            DGW1.RowCount = inputDGW.RowCount;

            for (int i = 0; i < inputDGW.RowCount; i++)
            {
                DGW1.Rows[i].Cells[0].Value = inputDGW.Rows[i].Cells[0];
                DGW1.Rows[i].Cells[1].Value = inputDGW.Rows[i].Cells[Convert.ToInt32(amountUpDown.Value) + 4].Value;
                DGW1.Rows[i].Cells[2].Value = rowSum[i] / total;
                DGW2.Rows[i].Cells[3].Value = double.Parse(DGW1.Rows[i].Cells[1].Value.ToString()) * double.Parse(DGW1.Rows[i].Cells[2].Value.ToString());
            }
        }
    }
}


