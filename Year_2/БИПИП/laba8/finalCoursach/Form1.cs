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

        private string path = null;
        
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
                renderGoods();
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
                path = openFileDialog1.FileName;
                xDoc.Load(path);
                int counter = 0;
                XmlElement xRoot = xDoc.DocumentElement;
                foreach (XmlElement xnode in xRoot)
                {
                    int code = 0;
                    string name = "";
                    int price = 0;
                    int amount = 0;
                    bool removed = false;
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "code")
                        {
                            code = Convert.ToInt32(childnode.InnerText);
                        }

                        if (childnode.Name == "name")
                        {
                            name = childnode.InnerText;
                        }

                        if (childnode.Name == "price")
                        {
                            price = int.Parse(childnode.InnerText);
                        }

                        if (childnode.Name == "amount")
                        {
                            amount = int.Parse(childnode.InnerText);
                        }

                        if (childnode.Name == "removed")
                        {
                            removed = Convert.ToBoolean(childnode.InnerText);
                        }
                    }

                    if (!removed)
                    {
                        Array.Resize(ref prods, prods.Length + 1);
                        prods[counter] = new Prods(code, name, price,amount, removed);
                        counter++;
                    }

                    Array.Resize(ref allprods, allprods.Length + 1);
                    allprods[totalProds] = new Prods(code, name, price,amount, removed);
                    totalProds++;
                }
            }
            renderGoods();
        }

        private void renderGoods()
        {
            editTB3.Width = 125;
            emptyLabel.Visible = false;
            grid1.ColumnCount = 0;
            if (prods.Length > 0)
            {
                grid1.RowCount = prods.Length - removedProds;
                removeKebab.Enabled = false;
                removeKebab.Visible = true;
                grid1.ColumnCount = 4;
                int counter = 0;
                for (int i = 0; i < prods.Length; i++)
                {
                    if (!prods[i].removed)
                    {
                        grid1.Rows[counter].Cells[0].Value = prods[i].code.ToString();
                        grid1.Rows[counter].Cells[1].Value = prods[i].name;
                        grid1.Rows[counter].Cells[2].Value = prods[i].price;
                        grid1.Rows[counter].Cells[3].Value = prods[i].amount;
                        counter++;
                    }
                }

                grid1.Columns[0].HeaderCell.Value = "ID";
                grid1.Columns[0].Width = 70;
                grid1.Columns[1].HeaderCell.Value = "Название";
                grid1.Columns[1].Width = 300;
                grid1.Columns[2].Width = 150;
                grid1.Columns[2].HeaderCell.Value = "Цена";
                grid1.Columns[2].Width = 70;
                grid1.Columns[3].HeaderCell.Value = "Кол-во";
                appear();
                renderAddDriver();
            }
            else
            {
                tabControl1.Visible = true;
                emptyLabel.Visible = true;
                removeKebab.Visible = false;
                tabPage2.Focus();
                tabPage1.Enabled = false;
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
            tabControl1.Visible = true;
            removeKebab.Visible = true;
            addTB2.Visible = true;
            editTB2.Text = "";
            editTB3.Text = "";
            editCodeTB.Visible = true;
            editTB2.Visible = true;
            tabPage1.Enabled = true;
            editTB3.Visible = true;
            //add
            label7.Visible = true;
            label6.Visible = true;
            addTB2.Text = "";
            addTB4.Text = "";
            amounTB.Text = "";
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
            save();
        }

        private void save()
        {
            if (path == null)
            {
                DialogResult = saveFileDialog1.ShowDialog();
                if (DialogResult == DialogResult.OK)
                {
                    path = saveFileDialog1.FileName;
                }
                else
                {
                    return;
                }
            }
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);
            XmlElement xRoot = xDoc.DocumentElement;
            xRoot.RemoveAll();
            xDoc.Save(path);
            foreach (Prods obj in allprods)
            {
                XmlElement driverElem = xDoc.CreateElement("driver");
                XmlElement driverCode = xDoc.CreateElement("code");
                XmlElement driverName = xDoc.CreateElement("name");
                XmlElement driverCategory = xDoc.CreateElement("price");
                XmlElement driverBDay = xDoc.CreateElement("amount");
                XmlElement driverRemoved = xDoc.CreateElement("removed");
                XmlText codeText = xDoc.CreateTextNode(obj.code.ToString());
                XmlText nameText = xDoc.CreateTextNode(obj.name);
                XmlText categoryText = xDoc.CreateTextNode(obj.price.ToString());
                XmlText BDAyText = xDoc.CreateTextNode(obj.amount.ToString());
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

            xDoc.Save(path);
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
                renderGoods();
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
                    renderGoods();
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
                addGood();
            }
        }

        private void addGood()
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
                renderGoods();
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


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.prods = new Prods[0];
            this.allprods = new Prods[0];
            this.grid1.Rows.Clear();
        }

        private void открытьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            loadProds();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }
    }
}