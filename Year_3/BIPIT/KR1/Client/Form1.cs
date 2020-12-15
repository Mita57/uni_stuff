using Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(this.sumTB.Text, out int s))
            {
                this.sumTB.BackColor = Color.Tomato;
            }
            else
            {
                this.sumTB.BackColor = SystemColors.Window;
            }

            comboBox1_SelectedIndexChanged(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.supplierCB.SelectedIndex > 0 && !string.IsNullOrEmpty(sumTB.Text))
            {
                this.addButton.Enabled = true;
            }
            else
            {
                this.addButton.Enabled = false;
            }
        }

        private void supplierName_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(supplierName.Text))
            {
                this.addSupplier.Enabled = false;
            }
            else
            {
                this.addSupplier.Enabled = true;
            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        getWayBills();
                        break;
                    }
                case 1:
                    {
                        break;
                    }
            }
        }

        // dem waybills

        private void getWayBills()
        {
            ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
            var res = service.GetData("waybills").ToArray();
            this.waybillTable.Rows.Clear();
            this.waybillTable.RowCount = res.Length;

            int row = 0;
            foreach (var sas in res)
            {
                string[] vals = sas.ToArray();
                this.waybillTable.Rows[row].Cells[0].Value = vals[0];
                this.waybillTable.Rows[row].Cells[1].Value = vals[1];
                this.waybillTable.Rows[row].Cells[2].Value = vals[2];
                this.waybillTable.Rows[row].Cells[3].Value = vals[3];

                row++;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();

            service.AddData("waybills", );
        }


        private void getSuppliers()
        {
            ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();

        }

        private void addSupplier_Click(object sender, EventArgs e)
        {

        }
    }
}
