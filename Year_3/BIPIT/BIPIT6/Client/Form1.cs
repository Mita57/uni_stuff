﻿using System;
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
            this.tabControl1_SelectedIndexChanged(sender, e);
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

        // equipment

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

        private void equipmentAddBtn_Click(object sender, EventArgs e)
        {
            List<string> cols = new List<string>()
            {
                "Name",
                "price",
                "Added"
            };

            List<string> vals = new List<string>()
            {
                this.equipmentNameTb.Text,
                this.equpmentPrice.Value.ToString(),
                DateTime.Now.ToString()
            };
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            client.NewRec(vals.ToArray(), cols.ToArray(), "Equipment");
            this.tabControl1_SelectedIndexChanged(sender, e);
        }

        // issues 

        private void issuesPageLoad()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string[][] res = client.GetData("Issues");
            this.issuesData.RowCount = res.Length;

            for (int i = 0; i < res.Length; i++)
            {
                for (int j = 0; j < res[i].Length; j++)
                {
                    this.issuesData.Rows[i].Cells[j].Value = res[i][j];
                }
            }

            eqCb.Items.Clear();
            res = client.GetData("Equipment");
            for (int i = 0; i < res.Length; i++)
            {
                eqCb.Items.Add(res[i].ToString());
            }

            empCb.Items.Clear();
            res = client.GetData("Employees");
            for(int i = 0; i < res.Length; i++)
            {
                empCb.Items.Add(res[i].ToString());
            }
        }

        private void issuesAddBtn_Click(object sender, EventArgs e)
        {
            List<string> cols = new List<string>()
            {
                "issued_at",
                "equipment",
                "employee",
                "Added"
            };

            List<string> vals = new List<string>()
            {
                this.issuedAt.Value.ToString(),
                this.eqCb.Text,
                this.eqCb.Text,
                DateTime.Now.ToString()
            };
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            client.NewRec(vals.ToArray(), cols.ToArray(), "Issues");
            this.tabControl1_SelectedIndexChanged(sender, e);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tabControl1_SelectedIndexChanged(sender, e);
        }
    }
}
