﻿using System;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            tables.SelectedIndex = 0;
            tabControl1.Visible = false;
            appear();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(tables.SelectedItem) == "Водители")
            {
                renderDrivers();
            }
        }

        Prods[] prods = new Prods[0];
        Prods[] allprods = new Prods[0];
        int totalProds = 0;
        int removedProds = 0;


        private void loadProds()
        {
            //building the DGW
            Array.Resize(ref prods, 0);
            Array.Resize(ref allprods, 0);
            totalProds = 0;
            //loading from XML
            XmlDocument xDoc = new XmlDocument();
            DialogResult = openFileDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                xDoc.Load(openFileDialog1.FileName);
                int counter = 0;
                XmlElement xRoot = xDoc.DocumentElement;
                foreach (XmlElement xnode in xRoot)
                {
                    int driverCode = 0;
                    string driverName = "";
                    string category = "";
                    string bDay = "";
                    bool removed = false;
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "driverCode")
                        {
                            driverCode = Convert.ToInt32(childnode.InnerText);
                        }

                        if (childnode.Name == "driverName")
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

                        if (childnode.Name == "removed")
                        {
                            removed = Convert.ToBoolean(childnode.InnerText);
                        }
                    }

                    if (!removed)
                    {
                        Array.Resize(ref prods, prods.Length + 1);
                        prods[counter] = new Prods(driverCode, driverName, category, bDay, removed);
                        counter++;
                    }

                    Array.Resize(ref allprods, allprods.Length + 1);
                    allprods[totalProds] = new Prods(driverCode, driverName, category, bDay, removed);
                    totalProds++;
                }
            }
        }

        private void renderDrivers()
        {
            editTB3.Width = 125;
            emptyLabel.Visible = false;
            grid1.ColumnCount = 0;
            if (prods.Length > 0)
            {
                grid1.RowCount = prods.Length - removedProds;
                removeKebab.Enabled = false;
                removeKebab.Visible = true;
                grid1.ColumnCount = 3;
                int counter = 0;
                for (int i = 0; i < prods.Length; i++)
                {
                    if (!prods[i].removed)
                    {
                        grid1.Rows[counter].Cells[0].Value = prods[i].driverCode.ToString();
                        grid1.Rows[counter].Cells[1].Value = prods[i].driverName;
                        grid1.Rows[counter].Cells[2].Value = prods[i].category;
                        grid1.Rows[counter].Cells[3].Value = prods[i].bDay;
                        counter++;
                    }
                }

                grid1.Columns[0].HeaderCell.Value = "Название";
                grid1.Columns[0].Width = 70;
                grid1.Columns[1].HeaderCell.Value = "Цена";
                grid1.Columns[1].Width = 300;
                grid1.Columns[2].Width = 150;
                grid1.Columns[2].HeaderCell.Value = "Кол-во";
                grid1.Columns[2].Width = 70;
                appear();
                saveButton.Enabled = true;
                saveButton.Visible = true;
                label1.Text = "Код водителя";
                label2.Text = "Имя водителя";
                label3.Text = "Категория";
                label4.Text = "Дата рождения";
                label8.Text = "Код водителя";
                label7.Text = "Имя водителя";
                label6.Text = "Категория";
                label5.Text = "Дата рождения";
                renderAddDriver();
            }
            else
            {
                tabControl1.Visible = true;
                emptyLabel.Visible = true;
                removeKebab.Visible = false;
                tabPage2.Focus();
                tabPage1.Enabled = false;
                label8.Text = "Код водителя";
                label7.Text = "Имя водителя";
                label6.Text = "Категория";
                label5.Text = "Дата рождения";
                label8.Visible = true;
                label7.Visible = true;
                label6.Visible = true;
                label5.Visible = true;
                addTB2.Visible = true;
                addTB4.Visible = true;
                addCodeTB.Text = (allprods.Length + 1).ToString();
            }
        }


        //make the add elements visible when loading grids
        private void appear()
        {
            //edit
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label8.Visible = true;
            label7.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            saveButton.Visible = true;
            tabControl1.Visible = true;
            removeKebab.Visible = true;
            addTB2.Visible = true;
            editTB2.Text = "";
            editTB3.Text = "";
            editCodeTB.Visible = true;
            editDTP1.Visible = true;
            editTB2.Visible = true;
            tabPage1.Enabled = true;
            editTB3.Visible = true;
            saveButton.Visible = true;
            //add
            label7.Visible = true;
            label6.Visible = true;
            addTB2.Text = "";
            addTB4.Text = "";
            label5.Visible = true;
            addTB2.Visible = true;
            addTB4.Visible = true;
            editTB3.Left = 296;
            addTB4.Left = 296;
            addTB2.Width = 125;
            editTB2.Width = 125;
            label3.Left = 317;
            label6.Left = 317;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(tables.SelectedItem) == "Водители")
            {
                saveDrivers();
            }
        }

        private void saveDrivers()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("drivers.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            xRoot.RemoveAll();
            xDoc.Save("drivers.xml");
            foreach (Prods obj in allprods)
            {
                XmlElement driverElem = xDoc.CreateElement("driver");
                XmlElement driverCode = xDoc.CreateElement("driverCode");
                XmlElement driverName = xDoc.CreateElement("driverName");
                XmlElement driverCategory = xDoc.CreateElement("category");
                XmlElement driverBDay = xDoc.CreateElement("bDay");
                XmlElement driverRemoved = xDoc.CreateElement("removed");
                XmlText codeText = xDoc.CreateTextNode(obj.driverCode.ToString());
                XmlText nameText = xDoc.CreateTextNode(obj.driverName);
                XmlText categoryText = xDoc.CreateTextNode(obj.category);
                XmlText BDAyText = xDoc.CreateTextNode(obj.bDay);
                XmlText driverRemovedText = xDoc.CreateTextNode(obj.removed.ToString());
                driverCode.AppendChild(codeText);
                driverName.AppendChild(nameText);
                driverBDay.AppendChild(BDAyText);
                driverCategory.AppendChild(categoryText);
                driverRemoved.AppendChild(driverRemovedText);
                driverElem.AppendChild(driverCode);
                driverElem.AppendChild(driverName);
                driverElem.AppendChild(driverCategory);
                driverElem.AppendChild(driverBDay);
                driverElem.AppendChild(driverRemoved);
                xRoot.AppendChild(driverElem);
            }

            xDoc.Save("drivers.xml");
        }

        //enables the remove button when the grid cell is clicked and some other shit, idk
        private void Grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            removeKebab.Enabled = true;
            int row = grid1.CurrentCell.RowIndex;
            editCodeTB.Text = grid1.Rows[row].Cells[0].Value.ToString();
            if (Convert.ToString(tables.SelectedItem) != "Штрафы")
            {
                editTB2.Text = grid1.Rows[row].Cells[1].Value.ToString();
                editTB3.Text = grid1.Rows[row].Cells[2].Value.ToString();
            }
        }

        //add tab render ffs

        private void renderAddDriver()
        {
            addCodeTB.Text = (allprods.Length + 1).ToString();
        }


        private void RemoveKebab_Click(object sender, EventArgs e)
        {
            int selected = grid1.CurrentCell.RowIndex;
            if (Convert.ToString(tables.SelectedItem) == "Водители")
            {
                allprods[Convert.ToInt32(grid1.Rows[selected].Cells[0].Value) - 1].removeKebab();
                prods[selected].removeKebab();
                removedProds++;
                renderDrivers();
            }
        }

        //changes

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            int selected = grid1.CurrentCell.RowIndex;
            if (Convert.ToString(tables.SelectedItem) == "Водители")
            {
                if (!string.IsNullOrWhiteSpace(editTB2.Text) && !string.IsNullOrWhiteSpace(editTB3.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    string newName = editTB2.Text;
                    int newPrice = int.Parse(editTB3.Text);
                    int newAmount = int.Parse(textBox1.Text);
                    prods[selected].change(newName, newPrice, newAmount, prods[selected].removed);
                    allprods[Convert.ToInt32(grid1.Rows[selected].Cells[0].Value.ToString()) - 1]
                        .change(newName, newPrice, newAmount, prods[selected].removed);
                    renderDrivers();
                }
                else
                {
                    MessageBox.Show("Заполните все поля");
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(tables.SelectedItem) == "Водители")
            {
                addDriver();
            }
        }

        private void addDriver()
        {
            if (!string.IsNullOrWhiteSpace(addTB2.Text) && !string.IsNullOrWhiteSpace(addTB4.Text))
            {
                Array.Resize(ref prods, prods.Length + 1);
                Array.Resize(ref allprods, allprods.Length + 1);
                int code = Convert.ToInt32(addCodeTB.Text);
                string name = addTB2.Text;
                int price = int.Parse(addTB4.Text);
                int amount = int.Parse(amounTB.Text);
                prods[prods.Length - 1] = new Prods(code, name, price, amount, false);
                allprods[code - 1] = new Prods(code, name, price, amount, false);
                renderDrivers();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }


        class Prods
        {
            //props

            public int code;
            public string name;
            public int price;
            public int amount;
            public bool removed;

            //builder

            public Prods(int code, string name, int price, int amount, bool removed)
            {
                this.code = code;
                this.name = name;
                this.price = price;
                this.amount = amount;
                this.removed = removed;
            }
            //methods

            public void change(string name, int price, int amount, bool removed)
            {
                this.name = name;
                this.price = price;
                this.amount = amount;
                this.removed = removed;
            }

            public void removeKebab()
            {
                this.removed = true;
            }
        }


        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadProds();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}