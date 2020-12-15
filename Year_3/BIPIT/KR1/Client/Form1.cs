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

        private class Supplier
        {
            public string Name { get; set; }

            public string Id { get; set; }

            public Supplier(string name, string id)
            {
                this.Name = name;
                this.Id = id;
            }

            public override string ToString()
            {
                return this.Name;
            }
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
                        getSuppliers();
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

            // suppliers

            res = service.GetData("supplier").ToArray();

            this.supplierCB.Items.Clear();
            foreach (var sas in res)
            {
                string[] vals = sas.ToArray();
                Supplier sup = new Supplier(vals[0], vals[1]);
                this.supplierCB.Items.Add(sup);
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();

            ArrayOfString cols = new ArrayOfString();
            cols.AddRange(new List<string>() {"date", "suppler_id","sum"} );

            ArrayOfString vals = new ArrayOfString();
            vals.AddRange(new List<string>() { this.wauBillDate.Value.ToString(), (this.supplierCB.SelectedItem as Supplier).Id, this.sumTB.Text });

            service.AddData("waybills", cols, vals);
            tabControl1_SelectedIndexChanged(sender, e);
        }


        private void getSuppliers()
        {
            ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();

            var res = service.GetData("supplier");

            int row = 0;
            this.supplierGrid.Rows.Clear();
            foreach (var sas in res)
            {
                string[] vals = sas.ToArray();
                this.supplierGrid.Rows[row].Cells[0].Value = vals[0];
                this.supplierGrid.Rows[row].Cells[1].Value = vals[1];
                row++;
            }

        }

        private void addSupplier_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();

            ArrayOfString cols = new ArrayOfString();
            cols.AddRange(new List<string>() { "name" });

            ArrayOfString vals = new ArrayOfString();
            vals.AddRange(new List<string>() { this.supplierName.Text, "" });

            service.AddData("waybills", cols, vals);

            tabControl1_SelectedIndexChanged(sender, e);
        }
    }
}
