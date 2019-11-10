using System;

using System.Windows.Forms;

namespace ИСвЭиУ_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int amount_elem = 0;
        int sum_days = 0;
        double budget = 0;
        double one_value = 0;
        double price = 0;
        int days = 0;
        double total_horizon = 0;
        double total_vertic = 0;
        double total = 0;
        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (textBox7.Text == "")
            {
                MessageBox.Show("Укажите количество структурных элементов!");
                return;
            }
            amount_elem = int.Parse(textBox7.Text);
            for (int i = 0; i <= amount_elem;i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = "Элемент " + (i + 1);
            }
            dataGridView1.Rows[amount_elem].Cells[0].Value = "Итого";
            dataGridView1.Rows[amount_elem].ReadOnly = true;
        }
        private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb1 = (TextBox)e.Control;
            tb1.KeyPress -= tb_KeyPress;
            tb1.KeyPress += new KeyPressEventHandler(this.tb_KeyPress);
        }
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) & e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void TextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) & e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) 
            {
                e.Handled = true;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }
            if(dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Вначале постройте таблицу структурных элементов!");
                return;
            }
            budget = int.Parse(textBox1.Text);
            for (int i = 0; i < amount_elem; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value == null || dataGridView1.Rows[i].Cells[3].Value == null ||
                    dataGridView1.Rows[i].Cells[5].Value == null || dataGridView1.Rows[i].Cells[7].Value == null)
                {
                    MessageBox.Show("Таблица заполнена не полностью!");
                    return;
                }
                for (int j = 1; j < 9; j++)
                    if (j % 2 != 0)
                        sum_days += Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
            }
            one_value = Math.Round(budget / sum_days,2);
            for (int r = 0; r < amount_elem; r++)
            {
                for (int c = 1; c < 9; c++)
                {
                    if (c % 2 != 0)
                    {
                        days = Convert.ToInt32(dataGridView1.Rows[r].Cells[c].Value);
                        price = Math.Round(days * one_value,2);
                        dataGridView1.Rows[r].Cells[c + 1].Value = price;
                        total_horizon += price;
                    }
                    dataGridView1.Rows[r].Cells[9].Value = Math.Ceiling(total_horizon);
                }
                total_horizon = 0;
            }
            for (int c = 2; c < 10; c++)
            {
                if (c % 2 == 0)
                {
                    for (int r = 0; r < amount_elem; r++)
                        total_vertic += Math.Ceiling(Convert.ToDouble(dataGridView1.Rows[r].Cells[c].Value));
                    dataGridView1.Rows[amount_elem].Cells[c].Value = total_vertic;
                    total += Math.Ceiling(total_vertic);
                    total_vertic = 0;
                }
                else
                    dataGridView1.Rows[amount_elem].Cells[c].Value = "";
                dataGridView1.Rows[amount_elem].Cells[9].Value = budget; 
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Сперва постройте таблицу затрат для структурных элементов!");
                return;
            }
            for (int i = 0; i < amount_elem; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value == null || dataGridView1.Rows[i].Cells[4].Value == null ||
                    dataGridView1.Rows[i].Cells[6].Value == null || dataGridView1.Rows[i].Cells[8].Value == null)
                {
                    MessageBox.Show("Таблица заполнена не полностью!");
                    return;
                }
            }
                Form2 form2 = new Form2();
            form2.amount_el = amount_elem;
            form2.budget = budget;
            for(int r =0;r<amount_elem;r++)
                form2.price_value.Add(Convert.ToDouble(dataGridView1.Rows[r].Cells[9].Value));
            form2.ShowDialog();
        }


    }
}
