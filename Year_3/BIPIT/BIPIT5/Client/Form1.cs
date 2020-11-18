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

        // employees

        private void employee_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.employeeNameTB.Text))
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

        private void employeesPageLoad()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string[][] res = client.GetData("Employees");
            this.employeesGrid.RowCount = res.Length;

            for (int i = 0; i < res.Length; i++)
            {
                for (int j = 0; j < res[i].Length; j++)
                {
                    this.employeesGrid.Rows[i].Cells[j].Value = res[i][j];
                }
            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        employeesPageLoad();
                        break;
                    }
                case 1:
                    {
                        equipmentPageLoad();
                        break;
                    }
                case 2:
                    {
                        issuesPageLoad();
                        break;
                    }
            }
                

        }

        //equipment

        private void equipmentNameTb_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.equipmentNameTb.Text))
            {
                this.equipmentNameTb.BackColor = Color.Tomato;
                this.equipmentAddBtn.Enabled = false;
            }
            else
            {
                this.equipmentNameTb.BackColor = SystemColors.Window;
                this.equipmentAddBtn.Enabled = true;
            }
        }

        private void equipmentPageLoad()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string[][] res = client.GetData("Equipment");
            this.equipmentGrid.RowCount = res.Length;

            for (int i = 0; i < res.Length; i++)
            {
                for (int j = 0; j < res[i].Length; j++)
                {
                    this.equipmentGrid.Rows[i].Cells[j].Value = res[i][j];
                }
            }
        }
    }
}
