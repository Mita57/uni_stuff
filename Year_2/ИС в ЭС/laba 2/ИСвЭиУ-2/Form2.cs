using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИСвЭиУ_2
{
    public partial class Form2 : Form
    {
        public int amount_el;
        public List<double> price_value = new List<double>();
        public double budget;
        public Form2()
        {
            InitializeComponent();
        }
        int matrix_size = 0;
        int columnIndex = 0;
        int rowIndex = 0;
        string set_num = "0";
        int total = 0;
        int result = 60;
        double index_grate = 0;
        double res = 0.0;
        int i = 0, j = 1;
        int index = 0;
        double value = 0;
        double part_of_price = 0;
        int id = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Name", "");
            if (textBox1.Text == "")
            {
                MessageBox.Show("Укажите кол-во функций!");
                return;
            }
            matrix_size = int.Parse(textBox1.Text);
            for (int s = 0; s < matrix_size; s++)
            {
                dataGridView1.Rows.Add("Ф"+ (s+1));
                dataGridView1.Rows[s].Cells[0].ReadOnly = true;
                dataGridView1.Columns.Add("newColumn", "Ф" + (s + 1).ToString());
            }
            dataGridView1.Rows.Add("Итого:");
            dataGridView1.Rows[matrix_size].ReadOnly = true;
            dataGridView1.Columns.Add("Sum", "Сумма ряда");
            dataGridView1.Columns.Add("Index", "Индекс балло-значимости");
            for (int k = 0; k < matrix_size; k++)
            {
                dataGridView1.Rows[k].Cells[matrix_size + 1].ReadOnly = true;
                dataGridView1.Rows[k].Cells[matrix_size + 2].ReadOnly = true;
            }
            for (i = 0; i < matrix_size; i++)
            {
                for (j = 1; j < matrix_size + 1; j++)
                {
                    if (i == j - 1)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = 0;
                        dataGridView1.Rows[i].Cells[j].ReadOnly = true;
                    }
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        dataGridView1.Rows[i].Cells[matrix_size + 1].Value = 0;
                    }
                }
            }
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (columnIndex > 0)
            {
                if (Convert.ToInt32(dataGridView1[columnIndex, rowIndex].Value) > 10)
                {
                    MessageBox.Show("Оценка должна быть ни меньше нуля и ни больше десяти!");
                    dataGridView1[columnIndex, rowIndex].Value = 0;
                }
                if (dataGridView1[columnIndex, rowIndex].Value == null)
                    dataGridView1[columnIndex, rowIndex].Value = set_num;
                else
                    set_num = dataGridView1[columnIndex, rowIndex].Value.ToString();
                dataGridView1.Rows[columnIndex - 1].Cells[rowIndex + 1].Value = 10 - int.Parse(set_num);
            }
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            rowIndex = dataGridView1.CurrentCell.RowIndex;
        }
        private void DataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (columnIndex > 0)
            {
                for (int r = 0; r < matrix_size; r++)
                {
                    for (int c = 1; c < matrix_size + 1; c++)
                    {
                        total += Convert.ToInt32(dataGridView1[c, r].Value);
                    }
                    dataGridView1.Rows[r].Cells[matrix_size + 1].Value = total;
                    result += total;
                    index_grate = Math.Round(Convert.ToDouble(dataGridView1.Rows[r].Cells[matrix_size + 1].Value) / Convert.ToDouble((matrix_size * matrix_size * 10 - matrix_size * 10) / 2), 2);
                    dataGridView1.Rows[r].Cells[matrix_size + 2].Value = index_grate;
                    res += index_grate;
                    total = 0;
                }
                dataGridView1.Rows[matrix_size].Cells[matrix_size + 1].Value = result;
                dataGridView1.Rows[matrix_size].Cells[matrix_size + 2].Value = res;
                result = 0;
                res = 0;
            }
        }
        private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb1 = (TextBox)e.Control;
            tb1.KeyPress -= tb_KeyPress;
            tb1.KeyPress += new KeyPressEventHandler(this.tb_KeyPress);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Вначале постройте таблицу 'Функциональная модель'!");
                return;
            }
            for (int j = 0; j < matrix_size; j++)
            {
               for(int i=0;i<matrix_size+1;i++)
                {
                    if (dataGridView1.Rows[j].Cells[i].Value == null)
                    {
                        MessageBox.Show("Таблица 'Матрица парных сравнений' заполнена не полностью!");
                        return;
                    }
                }
            }
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("Name", "Модули");
            dataGridView2.Columns.Add("Cost", "Стоимость");
            dataGridView2.Columns[1].ReadOnly = true;
            for (int k = 0; k < matrix_size; k++)
            {
                dataGridView2.Columns.Add("newColumn", "Ф" + (k + 1).ToString());
            }
            for (int s = 0; s < amount_el; s++)
            {
                dataGridView2.Rows.Add("Какой-то элемент");
                dataGridView2.Rows.Add("Денежная доля");
                dataGridView2.Rows[s].Cells[0].ReadOnly = true;
            }
            for(int y=0;y<dataGridView2.Rows.Count;y++)
            {
                if (y % 2 != 0)
                {
                    dataGridView2.Rows[y].ReadOnly = true;
                    dataGridView2.Rows[y].Cells[1].Value = price_value.ElementAt(index);
                    index++;
                }
            }
            index = 0;
            dataGridView2.Rows.Add("Итого:");
            dataGridView2.Rows.Add("В долях:");
            //dataGridView2.Rows.Count.ReadOnly = true;
            //dataGridView2.Rows[amount_el+2].ReadOnly = true;
        }
        private void DataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb2 = (TextBox)e.Control;
            tb2.KeyPress -= tb2_KeyPress;
            tb2.KeyPress += new KeyPressEventHandler(this.tb2_KeyPress);
        }
        double sum = 0;
        double cond = 0;
        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Вначале постройте таблицу 'Совемещенная модель'!");
                return;
            }
            for (int j = 0; j < matrix_size; j++)
            {
                for (int i = 0; i < matrix_size + 1; i++)
                {
                    if (dataGridView1.Rows[j].Cells[i].Value == null)
                    {
                        MessageBox.Show("Таблица 'Матрица парных сравнений' заполнена не полностью!");
                        return;
                    }
                }
            }
            for (int y = 0; y < amount_el*2; y++)
            {
                if (y % 2 != 0)
                { 
                    value = Convert.ToDouble(dataGridView2.Rows[y].Cells[1].Value);
                    for (int x = 2; x < dataGridView2.Columns.Count; x++)
                        cond += Convert.ToDouble(dataGridView2.Rows[id].Cells[x].Value);

                    for (int x = 2; x < dataGridView2.Columns.Count; x++)
                    {
                        if (cond<1 || cond>1)
                        {
                            break;
                        }
                        else
                            part_of_price = value * Convert.ToDouble(dataGridView2.Rows[id].Cells[x].Value);
                        if (part_of_price == 0)
                            dataGridView2.Rows[y].Cells[x].Value = "";
                        else
                            dataGridView2.Rows[y].Cells[x].Value = part_of_price;
                    }
                    part_of_price = 0;
                    id +=2;
                    cond = 0;
                }
            }
            id = 0;
            for(int c= 1;c<dataGridView2.Columns.Count;c++)
            {
                for(int r =0;r <amount_el*2;r++)
                {
                    if (r % 2 != 0)
                        if (dataGridView2.Rows[r].Cells[c].Value == "")
                            sum += 0;
                        else
                            sum += Convert.ToDouble(dataGridView2.Rows[r].Cells[c].Value);
                }
                dataGridView2.Rows[amount_el * 2].Cells[c].Value = sum;
                dataGridView2.Rows[amount_el * 2 + 1].Cells[c].Value = sum / budget;
                sum = 0;
            }
        }
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) & e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) & e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        int x = 0;
        bool condit = false;
        private void Button4_Click(object sender, EventArgs e)
        {
            if (condit == false)
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Вначале постройте таблицу 'Функциональная модель'!");
                    return;
                }
                for (int j = 0; j < matrix_size; j++)
                {
                    for (int i = 0; i < matrix_size + 1; i++)
                    {
                        if (dataGridView1.Rows[j].Cells[i].Value == null)
                        {
                            MessageBox.Show("Таблица 'Матрица парных сравнений' заполнена не полностью!");
                            return;
                        }
                    }
                }
                if (dataGridView2.Rows.Count == 0)
                {
                    MessageBox.Show("Вначале постройте таблицу 'Совмещенная модель'!");
                    return;
                }
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Visible = true;
                for (int y = 0; y < matrix_size; y++)
                {
                    try
                    {
                        x++;
                        chart1.Series[0].Points.AddXY(x, dataGridView1.Rows[y].Cells[matrix_size + 2].Value);
                        chart1.Series[1].Points.AddXY(x, (double)dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[y + 2].Value * 1.05);
                    }
                    catch
                    {
                        return;
                    }
                }
                condit = true;
                x = 0;
            }
            else
            {
                chart1.Visible = false;
                condit = false;
            }
        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        void tb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
    }
}
