using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace finalCoursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(tables.SelectedItem) == "Водители")
            {
                loadDrivers();
            }
            if(Convert.ToString(tables.SelectedItem) == "Штрафы")
            {
                loadFines();
            }
            if(Convert.ToString(tables.SelectedItem) == "Нарушения")
            {
                loadViolations();
            }
            if(Convert.ToString(tables.SelectedItem) == "Общая")
            {
                loadAll();
            }
        }

        fine[] fines = new fine[0];
        violation[] violations = new violation[0];
        driver[] drivers = new driver[0];


        //fines
        private void loadFines()
        {
            //building the DGW
            Array.Resize(ref fines,0);
            grid1.ColumnCount = 0;
            grid1.Refresh();
            grid1.ColumnCount = 4;
            grid1.Columns[0].HeaderCell.Value = "Код штрафа";
            grid1.Columns[0].Width = 70;
            grid1.Columns[1].HeaderCell.Value = "Код водителя";
            grid1.Columns[1].Width = 70;
            grid1.Columns[2].HeaderCell.Value = "Код нарушения";
            grid1.Columns[2].Width = 70;
            grid1.Columns[3].HeaderCell.Value = "Дата";
            grid1.Columns[3].Width = 70;
            grid1.Width = 330;
            //loading from XML
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("fines.xml");
            int counter = 0;
            XmlElement xRoot = xDoc.DocumentElement;
            foreach(XmlElement xnode in xRoot)
            {
                Array.Resize(ref fines, fines.Length + 1);
                int fineCode = 0;
                int driverCode = 0;
                int violationCode = 0;
                string date = "";
                foreach(XmlNode childnode in xnode.ChildNodes)
                {
                    if(childnode.Name == "fineCode")
                    {
                        fineCode=Convert.ToInt32(childnode.InnerText);
                    }
                    if(childnode.Name == "driverCode")
                    {
                        driverCode = Convert.ToInt32(childnode.InnerText);
                    }
                    if(childnode.Name == "violationCode")
                    {
                        violationCode = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "date")
                    {
                        date = childnode.InnerText;
                    }
                }
                fines[counter] = new fine(date, fineCode,violationCode,driverCode);
                counter++;
            }
            grid1.RowCount = fines.Length;
            for(int i = 0; i < fines.Length; i++)
            {
                grid1.Rows[i].Cells[0].Value = fines[i].fineCode.ToString();
                grid1.Rows[i].Cells[1].Value = fines[i].driverCode.ToString();
                grid1.Rows[i].Cells[2].Value = fines[i].violationCode.ToString();
                grid1.Rows[i].Cells[3].Value = fines[i].date;
            }
        }

        //drivers
        private void loadDrivers()
        {
            //building the DGW
            Array.Resize(ref drivers, 0);
            grid1.ColumnCount = 0;
            grid1.Refresh();
            grid1.ColumnCount = 4;
            grid1.Columns[0].HeaderCell.Value = "Код водителя";
            grid1.Columns[0].Width = 70;
            grid1.Columns[1].HeaderCell.Value = "Имя водителя";
            grid1.Columns[2].Width = 150;
            grid1.Columns[2].HeaderCell.Value = "Категория";
            grid1.Columns[2].Width = 70;
            grid1.Columns[3].HeaderCell.Value = "Дата рождения";
            grid1.Columns[3].Width = 150;
            grid1.Width = 440;
            //loading from XML
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("drivers.xml");
            int counter = 0;
            XmlElement xRoot = xDoc.DocumentElement;
            foreach(XmlElement xnode in xRoot)
            {
                Array.Resize(ref drivers, drivers.Length + 1);
                int driverCode = 0;
                string driverName = "";
                string category = "";
                string bDay = "";
                foreach(XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "driverCode")
                    {
                        driverCode = Convert.ToInt32(childnode.InnerText);
                    }
                    if(childnode.Name == "driverName")
                    {
                        driverName = childnode.InnerText;
                    }
                    if (childnode.Name == "category")
                    {
                        category = childnode.InnerText;
                    }
                    if (childnode.Name == "bDay")
                    {
                        bDay = childnode.InnerText;
                    }
                }
                drivers[counter] = new driver(driverCode,driverName,category,bDay);
                counter++;
            }
            grid1.RowCount = drivers.Length;
            for(int i =0; i < drivers.Length; i++)
            {
                grid1.Rows[i].Cells[0].Value = drivers[i].driverCode;
                grid1.Rows[i].Cells[1].Value = drivers[i].driverName;
                grid1.Rows[i].Cells[2].Value = drivers[i].category;
                grid1.Rows[i].Cells[3].Value = drivers[i].bDay;
            }
        }


        //violations
        private void loadViolations()
        {
            //building the DGW
            Array.Resize(ref violations, 0);
            grid1.ColumnCount = 0;
            grid1.Refresh();
            grid1.ColumnCount = 3;
            grid1.Columns[0].HeaderCell.Value = "Код нарушения";
            grid1.Columns[0].Width = 70;
            grid1.Columns[1].HeaderCell.Value = "Название нарушения";
            grid1.Columns[1].Width = 150;
            grid1.Columns[2].HeaderCell.Value = "Наказание";
            grid1.Columns[2].Width = 150;
            grid1.Width = 420;
            //loading from XML
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("violations.xml");
            int counter = 0;
            XmlElement xRoot = xDoc.DocumentElement;
            foreach(XmlElement xnode in xRoot)
            {
                Array.Resize(ref violations, violations.Length + 1);
                int violationCode=0;
                string violationName="";
                string punishment = "";
                foreach(XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "violationCode")
                    {
                        violationCode = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "violationName")
                    {
                        violationName = childnode.InnerText;
                    }
                    if(childnode.Name == "punishment")
                    {
                        punishment = childnode.InnerText;
                    }
                }
                violations[counter] = new violation(violationCode, violationName, punishment);
                counter++;
            }
            grid1.RowCount = violations.Length;
            for(int i =0; i < violations.Length; i++)
            {
                grid1.Rows[i].Cells[0].Value = violations[i].violationCode.ToString();
                grid1.Rows[i].Cells[1].Value = violations[i].violationName;
                grid1.Rows[i].Cells[2].Value = violations[i].punishment;
            }
        }

        //all
        private void loadAll()
        {
            //building the DGW
            grid1.ColumnCount = 0;
            grid1.Refresh();
            loadDrivers();
            loadFines();
            loadViolations();
            grid1.ColumnCount = 8;
            grid1.Columns[0].HeaderCell.Value = "Код штрафа";
            grid1.Columns[0].Width = 70;
            grid1.Columns[1].HeaderCell.Value = "Название нарушения";
            grid1.Columns[1].Width = 150;
            grid1.Columns[2].HeaderCell.Value = "Код нарушения";
            grid1.Columns[2].Width = 70;
            grid1.Columns[3].HeaderCell.Value = "Дата";
            grid1.Columns[3].Width = 100;
            grid1.Columns[4].HeaderCell.Value = "Код водителя";
            grid1.Columns[4].Width = 70;
            grid1.Columns[5].HeaderCell.Value = "Имя водителя";
            grid1.Columns[5].Width = 150;
            grid1.Columns[6].HeaderCell.Value = "Категория";
            grid1.Columns[6].Width = 70;
            grid1.Columns[7].HeaderCell.Value = "Наказание";
            grid1.Columns[7].Width = 150;
            grid1.Width = 545;
            grid1.RowCount = fines.Length;
            for(int i = 0; i < fines.Length; i++)
            {
                grid1.Rows[i].Cells[0].Value = fines[i].violationCode.ToString();
                grid1.Rows[i].Cells[1].Value = violations[fines[i].violationCode-1].violationName;
                grid1.Rows[i].Cells[2].Value = violations[fines[i].violationCode-1].violationCode;
                grid1.Rows[i].Cells[3].Value = fines[i].date;
                grid1.Rows[i].Cells[4].Value = fines[i].driverCode.ToString();
                grid1.Rows[i].Cells[5].Value = drivers[fines[i].driverCode - 1].driverName;
                grid1.Rows[i].Cells[6].Value = drivers[fines[i].driverCode - 1].category;
                grid1.Rows[i].Cells[7].Value = violations[fines[i].violationCode - 1].punishment;
            }
        }
    }


    class driver
    {
        public int driverCode;
        public string driverName;
        public string category;
        public string bDay;

        public driver(int driverCode, string name, string category, string bDay)
        {
            this.driverCode = driverCode;
            this.driverName = name;
            this.category = category;
            this.bDay = bDay;
        }

    }

    class violation
    {
        public int violationCode;
        public string violationName;
        public string punishment;

        public violation(int violationCode, string violationName, string punishment)
        {
            this.violationCode = violationCode;
            this.violationName = violationName;
            this.punishment = punishment;
        }

    }


    class fine
    {
        public string date;
        public int fineCode;
        public int violationCode;
        public int driverCode;

        public fine(string date, int fineCode, int violationCode, int driverCode)
        {
            this.date = date;
            this.fineCode = fineCode;
            this.violationCode = violationCode;
            this.driverCode = driverCode;
        }
    }




}
