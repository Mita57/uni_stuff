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
            if(String.IsNullOrEmpty(this.employeeNameTB.Text))
            {
                this.employeeNameTB.BackColor = Color.Tomato;
                this.employeeAddBtn.Enabled = false;
            }
            else
            {
                employeeNameTB.BackColor = SystemColors.Window;
                this.employeeAddBtn.Enabled = true;
            }
        }

        private void employeeAddBtn_Click(object sender, EventArgs e)
        {
            List<string> cols = new List<string>()
            {
                "Name",
                "Birth_date",
                "Added"
            };

            List<string> vals = new List<string>()
            {
                this.employeeNameTB.Text,
                this.employeeBirth.Text,
                DateTime.Now.ToString()
            };
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            client.NewRec(vals.ToArray(), cols.ToArray(), "Employees");
        }
    }
}
