using System;
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
            loadDrivers();
            tabControl1.Visible = false;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(tables.SelectedItem) == "Водители")
            {
                renderDrivers();
            }
        }

        driver[] drivers = new driver[0];
        driver[] allDrivers = new driver[0];
        int totalDrivers = 0;
        int removedDrivers = 0;



        //drivers
        private void loadDrivers()
        {
            //building the DGW
            Array.Resize(ref drivers, 0);
            Array.Resize(ref allDrivers, 0);
            totalDrivers = 0;
            //loading from XML
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("drivers.xml");
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
                    Array.Resize(ref drivers, drivers.Length + 1);
                    drivers[counter] = new driver(driverCode, driverName, category, bDay, removed);
                    counter++;
                }
                Array.Resize(ref allDrivers, allDrivers.Length + 1);
                allDrivers[totalDrivers] = new driver(driverCode, driverName, category, bDay, removed);
                totalDrivers++;
            }
        }
        private void renderDrivers()
        {
            editTB3.Width = 125;
            emptyLabel.Visible = false;
            grid1.ColumnCount = 0;
            if (drivers.Length > 0)
            {
                grid1.RowCount = drivers.Length - removedDrivers;
                removeKebab.Enabled = false;
                removeKebab.Visible = true;
                grid1.ColumnCount = 4;
                int counter = 0;
                for (int i = 0; i < drivers.Length; i++)
                {
                    if (!drivers[i].removed)
                    {
                        grid1.Rows[counter].Cells[0].Value = drivers[i].driverCode.ToString();
                        grid1.Rows[counter].Cells[1].Value = drivers[i].driverName;
                        grid1.Rows[counter].Cells[2].Value = drivers[i].category;
                        grid1.Rows[counter].Cells[3].Value = drivers[i].bDay;
                        counter++;
                    }
                }
                grid1.Columns[0].HeaderCell.Value = "Код водителя";
                grid1.Columns[0].Width = 70;
                grid1.Columns[1].HeaderCell.Value = "Имя водителя";
                grid1.Columns[1].Width = 300;
                grid1.Columns[2].Width = 150;
                grid1.Columns[2].HeaderCell.Value = "Категория";
                grid1.Columns[2].Width = 70;
                grid1.Columns[3].HeaderCell.Value = "Дата рождения";
                grid1.Columns[3].Width = 150;
                appear();
                editCB1.Visible = false;
                editCB2.Visible = false;
                addCB1.Visible = false;
                addCB3.Visible = false;
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
                addCB1.Visible = false;
                addCB3.Visible = false;
                addDTP2.Visible = true;
                addCodeTB.Text = (allDrivers.Length + 1).ToString();
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
            editCB1.Visible = true;
            editCB2.Visible = true;
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
            addCB1.Visible = true;
            addTB4.Visible = true;
            addCB3.Visible = true;
            addDTP2.Visible = true;
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
            foreach (driver obj in allDrivers)
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
            else
            {
                editCB1.SelectedIndex = (Convert.ToInt32(grid1.Rows[row].Cells[1].Value) - 1);
                editCB2.SelectedIndex = (Convert.ToInt32(grid1.Rows[row].Cells[2].Value) - 1);
            }

        }

        //add tab render ffs

        private void renderAddDriver()
        {
            addCodeTB.Text = (allDrivers.Length + 1).ToString();
        }



        private void RemoveKebab_Click(object sender, EventArgs e)
        {
            int selected = grid1.CurrentCell.RowIndex;
            if (Convert.ToString(tables.SelectedItem) == "Водители")
            {
                allDrivers[Convert.ToInt32(grid1.Rows[selected].Cells[0].Value) - 1].removeKebab();
                drivers[selected].removeKebab();
                removedDrivers++;
                renderDrivers();
            }
        }

        //changes

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            int selected = grid1.CurrentCell.RowIndex;
            if (Convert.ToString(tables.SelectedItem) == "Водители")
            {
                if (!string.IsNullOrWhiteSpace(editTB2.Text) && !string.IsNullOrWhiteSpace(editTB3.Text))
                {
                    string newDriverName = editTB2.Text;
                    string newCategory = editTB3.Text;
                    string newBDay = editDTP1.Value.ToShortDateString();
                    drivers[selected].change(newDriverName, newCategory, newBDay);
                    allDrivers[Convert.ToInt32(grid1.Rows[selected].Cells[0].Value.ToString()) - 1].change(newDriverName, newCategory, newBDay);
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
                Array.Resize(ref drivers, drivers.Length + 1);
                Array.Resize(ref allDrivers, allDrivers.Length + 1);
                int driverCode = Convert.ToInt32(addCodeTB.Text);
                string driverName = addTB2.Text;
                string category = addTB4.Text;
                string bDay = addDTP2.Value.ToShortDateString();
                drivers[drivers.Length - 1] = new driver(driverCode, driverName, category, bDay, false);
                allDrivers[driverCode - 1] = new driver(driverCode, driverName, category, bDay, false);
                renderDrivers();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }





        class driver
        {
            //props

            public int driverCode;
            public string driverName;
            public string category;
            public string bDay;
            public bool removed;

            //builder

            public driver(int driverCode, string name, string category, string bDay, bool removed)
            {
                this.driverCode = driverCode;
                this.driverName = name;
                this.category = category;
                this.bDay = bDay;
                this.removed = removed;
            }
            //methods

            public void change(string newDriverName, string newCategory, string newBDay)
            {
                this.driverName = newDriverName;
                this.category = newCategory;
                this.bDay = newBDay;
            }

            public void removeKebab()
            {
                this.removed = true;
            }

        }


    }
}
