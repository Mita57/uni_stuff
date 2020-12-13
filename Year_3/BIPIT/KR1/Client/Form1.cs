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
    }
}
