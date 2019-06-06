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
            loadFines();
            loadViolations();
            tabControl1.Visible = false;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(tables.SelectedItem) == "Водители")
            {
                renderDrivers();
            }
            if (Convert.ToString(tables.SelectedItem) == "Штрафы")
            {
                renderFines();
            }
            if (Convert.ToString(tables.SelectedItem) == "Нарушения")
            {
                renderViolations();
            }
            if (Convert.ToString(tables.SelectedItem) == "Общая")
            {
                renderAll();
            }
        }

        fine[] fines = new fine[0];
        violation[] violations = new violation[0];
        driver[] drivers = new driver[0];

        fine[] allFines = new fine[0];
        violation[] allViolations = new violation[0];
        driver[] allDrivers = new driver[0];

        int totalFines = 0;
        int totalViolations = 0;
        int totalDrivers = 0;

        //in the current session!!!
        int removedFines = 0;
        int removedViolations = 0;
        int removedDrivers = 0;

        //fines
        private void loadFines()
        {
            Array.Resize(ref fines, 0);
            Array.Resize(ref allFines, 0);
            totalFines = 0;
            //loading from XML
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("fines.xml");
            int counter = 0;
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlElement xnode in xRoot)
            {
                int fineCode = 0;
                int driverCode = 0;
                int violationCode = 0;
                string date = "";
                bool removed = false;
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "fineCode")
                    {
                        fineCode = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "driverCode")
                    {
                        driverCode = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "violationCode")
                    {
                        violationCode = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "date")
                    {
                        date = childnode.InnerText;
                    }
                    if (childnode.Name == "removed")
                    {
                        removed = Convert.ToBoolean(childnode.InnerText);
                    }
                }
                if (!removed)
                {
                    Array.Resize(ref fines, fines.Length + 1);
                    fines[counter] = new fine(date, fineCode, violationCode, driverCode, removed);
                    counter++;
                }
                Array.Resize(ref allFines, allFines.Length + 1);
                allFines[totalFines] = new fine(date, fineCode, violationCode, driverCode, removed);
                totalFines++;
            }

        }
        private void renderFines()
        {
            editTB3.Width = 125;
            //building the DGW
            grid1.ColumnCount = 0;
            grid1.Refresh();
            if (fines.Length > 0)
            {
                grid1.ColumnCount = 4;
                int counter = 0;
                grid1.Columns[0].HeaderCell.Value = "Код штрафа";
                grid1.Columns[0].Width = 70;
                grid1.Columns[1].HeaderCell.Value = "Код водителя";
                grid1.Columns[1].Width = 70;
                grid1.Columns[2].HeaderCell.Value = "Код нарушения";
                grid1.Columns[2].Width = 70;
                grid1.Columns[3].HeaderCell.Value = "Дата";
                grid1.Columns[3].Width = 70;
                grid1.RowCount = fines.Length - removedFines;
                for (int i = 0; i < fines.Length; i++)
                {
                    if (!fines[i].removed)
                    {
                        grid1.Rows[counter].Cells[0].Value = fines[i].fineCode.ToString();
                        grid1.Rows[counter].Cells[1].Value = fines[i].driverCode.ToString();
                        grid1.Rows[counter].Cells[2].Value = fines[i].violationCode.ToString();
                        grid1.Rows[counter].Cells[3].Value = fines[i].date;
                        counter++;
                    }
                }
                appear();
                editCB1.Items.Clear();
                editCB2.Items.Clear();
                saveButton.Enabled = true;
                saveButton.Visible = true;
                label1.Text = "Код штрафа";
                label2.Text = "Код водителя";
                label3.Text = "Код нарушения";
                label4.Text = "Дата";
                label8.Text = "Код штрафа";
                label7.Text = "Код водителя";
                label6.Text = "Код нарушения";
                label5.Text = "Дата";
                editTB2.Visible = false;
                editTB3.Visible = false;
                addTB2.Visible = false;
                addTB4.Visible = false;
                for (int i = 0; i < drivers.Length; i++)
                {
                    editCB1.Items.Add(drivers[i].driverCode + " " + drivers[i].driverName);
                }
                for (int i = 0; i < violations.Length; i++)
                {
                    editCB2.Items.Add(violations[i].violationCode + " " + violations[i].violationName);
                }
                renderAddFine();
            }
            else
            {
                renderAddFine();
                tabControl1.Visible = true;
                emptyLabel.Visible = true;
                removeKebab.Visible = false;
                tabPage2.Focus();
                tabPage1.Enabled = false;
                addCB1.Visible = true;
                addCB3.Visible = true;
                addDTP2.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
                label6.Visible = true;
                label5.Visible = true;
                label8.Text = "Код штрафа";
                label7.Text = "Код водителя";
                label6.Text = "Код нарушения";
                label5.Text = "Дата";
                addTB2.Visible = false;
                addTB4.Visible = false;
                addCodeTB.Text = (allFines.Length + 1).ToString();
            }
        }

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


        //violations
        private void loadViolations()
        {
            //building the DGW
            Array.Resize(ref violations, 0);
            Array.Resize(ref allViolations, 0);
            totalViolations = 0;
            //loading from XML
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("violations.xml");
            int counter = 0;
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlElement xnode in xRoot)
            {
                int violationCode = 0;
                string violationName = "";
                string punishment = "";
                bool removed = false;
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "violationCode")
                    {
                        violationCode = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "violationName")
                    {
                        violationName = childnode.InnerText;
                    }
                    if (childnode.Name == "punishment")
                    {
                        punishment = childnode.InnerText;
                    }
                    if (childnode.Name == "removed")
                    {
                        removed = Convert.ToBoolean(childnode.InnerText);
                    }
                }
                if (!removed)
                {
                    Array.Resize(ref violations, violations.Length + 1);
                    violations[counter] = new violation(violationCode, violationName, punishment, removed);
                    counter++;
                }
                Array.Resize(ref allViolations, allViolations.Length + 1);
                allViolations[totalViolations] = new violation(violationCode, violationName, punishment, removed);
                totalViolations++;
            }
        }

        private void renderViolations()
        {
            tabControl1.Visible = true;
            removeKebab.Visible = true;
            grid1.ColumnCount = 0;
            emptyLabel.Visible = false;
            grid1.Refresh();
            if (violations.Length > 0)
            {
                grid1.ColumnCount = 3;
                grid1.Columns[0].HeaderCell.Value = "Код нарушения";
                grid1.Columns[0].Width = 70;
                grid1.Columns[1].HeaderCell.Value = "Название нарушения";
                grid1.Columns[1].Width = 390;
                grid1.Columns[2].HeaderCell.Value = "Наказание";
                grid1.Columns[2].Width = 390;
                grid1.RowCount = violations.Length - removedViolations;
                removeKebab.Enabled = false;
                saveButton.Enabled = true;
                saveButton.Visible = true;
                int counter = 0;
                for (int i = 0; i < violations.Length; i++)
                {
                    if (!violations[i].removed)
                    {
                        grid1.Rows[counter].Cells[0].Value = violations[i].violationCode;
                        grid1.Rows[counter].Cells[1].Value = violations[i].violationName;
                        grid1.Rows[counter].Cells[2].Value = violations[i].punishment;
                        counter++;
                    }
                }
                appear();
                editDTP1.Visible = false;
                addDTP2.Visible = false;
                editCB1.Visible = false;
                editCB2.Visible = false;
                addCB1.Visible = false;
                addCB3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label1.Text = "Код нарушения";
                label2.Text = "Название нарушения";
                label3.Text = "Наказание";
                label8.Text = "Код нарушения";
                label7.Text = "Название нарушения";
                label6.Text = "Наказание";
                editTB3.Width = 125;
                addTB4.Left = 450;
                editTB3.Left = 450;
                editTB2.Width = 250;
                addTB2.Width = 250;
                label3.Left = 470;
                label6.Left = 470;
                renderAddViolation();
            }
            else
            {
                tabControl1.Visible = true;
                emptyLabel.Visible = true;
                removeKebab.Visible = false;
                tabPage2.Focus();
                tabPage1.Enabled = false;
                label8.Text = "Код нарушения";
                label7.Text = "Название нарушения";
                label6.Text = "Наказание";
                label8.Visible = true;
                label7.Visible = true;
                label6.Visible = true;
                addTB4.Left = 450;
                label5.Visible = false;
                addCB1.Visible = false;
                addCB3.Visible = false;
                addDTP2.Visible = false;
                addTB2.Visible = true;
                addTB4.Visible = true;
                addTB2.Width = 250;
                label3.Left = 470;
                label6.Left = 470;
                addCodeTB.Text = (allViolations.Length + 1).ToString();
            }
        }

        //all
        private void renderAll()
        {
            if (fines.Length > 0)
            {
                tabControl1.Visible = false;
                saveButton.Visible = false;
                removeKebab.Enabled = false;
                removeKebab.Visible = false;
                saveButton.Enabled = false;
                saveButton.Visible = false;
                //building the DGW
                grid1.ColumnCount = 0;
                grid1.Refresh();
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
                grid1.RowCount = fines.Length;
                for (int i = 0; i < fines.Length; i++)
                {
                    grid1.Rows[i].Cells[0].Value = fines[i].fineCode.ToString();
                    grid1.Rows[i].Cells[1].Value = violations[fines[i].violationCode - 1].violationName;
                    grid1.Rows[i].Cells[2].Value = violations[fines[i].violationCode - 1].violationCode;
                    grid1.Rows[i].Cells[3].Value = fines[i].date;
                    grid1.Rows[i].Cells[4].Value = fines[i].driverCode.ToString();
                    grid1.Rows[i].Cells[5].Value = drivers[fines[i].driverCode - 1].driverName;
                    grid1.Rows[i].Cells[6].Value = drivers[fines[i].driverCode - 1].category;
                    grid1.Rows[i].Cells[7].Value = violations[fines[i].violationCode - 1].punishment;
                }
            }
            else
            {
                emptyLabel.Visible = true;
                removeKebab.Visible = false;
                tabPage2.Focus();
                tabPage1.Enabled = false;
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
            pickGB.Visible = true;
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
            if (Convert.ToString(tables.SelectedItem) == "Штрафы")
            {
                saveFines();
            }
            if (Convert.ToString(tables.SelectedItem) == "Нарушения")
            {
                saveViolations();
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

        private void saveFines()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("fines.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            xRoot.RemoveAll();
            xDoc.Save("fines.xml");
            foreach (fine obj in allFines)
            {
                XmlElement fineElem = xDoc.CreateElement("fine");
                XmlElement fineCode = xDoc.CreateElement("fineCode");
                XmlElement driverCode = xDoc.CreateElement("driverCode");
                XmlElement violationCode = xDoc.CreateElement("violationCode");
                XmlElement fineDate = xDoc.CreateElement("date");
                XmlElement fineRemoved = xDoc.CreateElement("removed");
                XmlText fineCodeText = xDoc.CreateTextNode(obj.fineCode.ToString());
                XmlText driverCodeText = xDoc.CreateTextNode(obj.driverCode.ToString());
                XmlText violationCodeText = xDoc.CreateTextNode(obj.violationCode.ToString());
                XmlText fineDateText = xDoc.CreateTextNode(obj.date);
                XmlText fineRemovedText = xDoc.CreateTextNode(obj.removed.ToString());
                fineCode.AppendChild(fineCodeText);
                driverCode.AppendChild(driverCodeText);
                violationCode.AppendChild(violationCodeText);
                fineDate.AppendChild(fineDateText);
                fineRemoved.AppendChild(fineRemovedText);
                fineElem.AppendChild(fineCode);
                fineElem.AppendChild(driverCode);
                fineElem.AppendChild(violationCode);
                fineElem.AppendChild(fineDate);
                fineElem.AppendChild(fineRemoved);
                xRoot.AppendChild(fineElem);
            }
            xDoc.Save("fines.xml");
        }

        private void saveViolations()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("violations.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            xRoot.RemoveAll();
            xDoc.Save("violations.xml");
            foreach (violation obj in allViolations)
            {
                XmlElement violationElem = xDoc.CreateElement("violation");
                XmlElement violationCode = xDoc.CreateElement("violationCode");
                XmlElement violationName = xDoc.CreateElement("violationName");
                XmlElement violationPunishment = xDoc.CreateElement("punishment");
                XmlElement violationRemoved = xDoc.CreateElement("removed");
                XmlText violationCodeText = xDoc.CreateTextNode(obj.violationCode.ToString());
                XmlText violationNameText = xDoc.CreateTextNode(obj.violationName);
                XmlText violationPunishmentText = xDoc.CreateTextNode(obj.punishment);
                XmlText violationRemovedText = xDoc.CreateTextNode(obj.removed.ToString());
                violationCode.AppendChild(violationCodeText);
                violationName.AppendChild(violationNameText);
                violationPunishment.AppendChild(violationPunishmentText);
                violationRemoved.AppendChild(violationRemovedText);
                violationElem.AppendChild(violationCode);
                violationElem.AppendChild(violationName);
                violationElem.AppendChild(violationPunishment);
                violationElem.AppendChild(violationRemoved);
                xRoot.AppendChild(violationElem);
            }
            xDoc.Save("violations.xml");
        }





        //enbles the remove button when the grid cell is clicked and some other shit, idk
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

        private void renderAddFine()
        {
            addCodeTB.Text = (allFines.Length + 1).ToString();
            addCB1.Items.Clear();
            addCB3.Items.Clear();
            for (int i = 0; i < drivers.Length; i++)
            {
                addCB1.Items.Add(drivers[i].driverCode + " " + drivers[i].driverName);
            }
            for (int i = 0; i < violations.Length; i++)
            {
                addCB3.Items.Add(violations[i].violationCode + " " + violations[i].violationName);
            }

        }
        private void renderAddViolation()
        {
            addCodeTB.Text = (allViolations.Length + 1).ToString();

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
            if (Convert.ToString(tables.SelectedItem) == "Штрафы")
            {
                allFines[Convert.ToInt32(grid1.Rows[selected].Cells[0].Value) - 1].removeKebab();
                fines[selected].removeKebab();
                removedFines++;
                renderFines();
            }
            if (Convert.ToString(tables.SelectedItem) == "Нарушения")
            {
                allViolations[Convert.ToInt32(grid1.Rows[selected].Cells[0].Value) - 1].removeKebab();
                violations[selected].removeKebab();
                removedViolations++;
                renderViolations();
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
            if (Convert.ToString(tables.SelectedItem) == "Штрафы")
            {
                if (editCB1.SelectedIndex != -1 && editCB2.SelectedIndex != -1)
                {
                    int newDriverCode = drivers[editCB1.SelectedIndex].driverCode;
                    int newViolationCode = violations[editCB2.SelectedIndex].violationCode;
                    string newDate = addDTP2.Value.ToShortDateString();
                    fines[selected].change(newDate, newViolationCode, newDriverCode);
                    allFines[Convert.ToInt32(grid1.Rows[selected].Cells[0].Value.ToString()) - 1].change(newDate, newViolationCode, newDriverCode);
                    renderFines();
                }
                else
                {
                    MessageBox.Show("Заполните все поля");
                }
            }
            if (Convert.ToString(tables.SelectedItem) == "Нарушения")
            {
                if (!string.IsNullOrWhiteSpace(editTB2.Text) && !string.IsNullOrWhiteSpace(editTB3.Text))
                {
                    string newViolationName = editTB2.Text;
                    string newPunishment = editTB3.Text;
                    violations[selected].change(newViolationName, newPunishment);
                    allViolations[Convert.ToInt32(grid1.Rows[selected].Cells[0].Value.ToString()) - 1].change(newViolationName, newPunishment);
                    renderViolations();
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
            if (Convert.ToString(tables.SelectedItem) == "Штрафы")
            {
                addFine();
            }
            if (Convert.ToString(tables.SelectedItem) == "Нарушения")
            {
                addViolation();
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

        private void addFine()
        {
            if (addCB1.SelectedIndex != -1 && addCB3.SelectedIndex != -1)
            {
                Array.Resize(ref fines, fines.Length + 1);
                Array.Resize(ref allFines, allFines.Length + 1);
                int fineCode = Convert.ToInt32(addCodeTB.Text);
                int violationCode = violations[addCB1.SelectedIndex].violationCode;
                int driverCode = drivers[addCB3.SelectedIndex].driverCode;
                string date = addDTP2.Value.ToShortDateString();
                fines[fines.Length - 1] = new fine(date, fineCode, violationCode, driverCode, false);
                allFines[fineCode - 1] = new fine(date, fineCode, violationCode, driverCode, false);
                renderFines();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void addViolation()
        {
            if (!string.IsNullOrWhiteSpace(addTB2.Text) && !string.IsNullOrWhiteSpace(addTB4.Text))
            {
                Array.Resize(ref violations, violations.Length + 1);
                Array.Resize(ref allViolations, allViolations.Length + 1);
                int violationCode = Convert.ToInt32(addCodeTB.Text);
                string violationName = addTB2.Text;
                string punishment = addTB4.Text;
                violations[violations.Length - 1] = new violation(violationCode, violationName, punishment, false);
                allViolations[violationCode - 1] = new violation(violationCode, violationName, punishment, false);
                renderViolations();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void PickerOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickerArgsCB.SelectedIndex == -1 || pickerOption.SelectedIndex == -1)
            {
                pickerShowBtn.Enabled = false;
            }
            else
            {
                pickerShowBtn.Enabled = true;
            }
            if (fines.Length < 1)
            {
                pickerEmptyLabel.Visible = true;
                pickerShowBtn.Enabled = false;
            }
            else
            {
                pickerEmptyLabel.Visible = false;
                pickerArgsCB.Items.Clear();
                if (Convert.ToString(pickerOption.SelectedItem) == "Водители")
                {
                    foreach (driver X in drivers)
                    {
                        pickerArgsCB.Items.Add(X.driverCode + " " + X.driverName);
                    }
                }
                if (Convert.ToString(pickerOption.SelectedItem) == "Нарушения")
                {
                    foreach (violation X in violations)
                    {
                        pickerArgsCB.Items.Add(X.violationCode + " " + X.violationName);
                    }
                }

            }

        }

        private void PickerShowBtn_Click(object sender, EventArgs e)
        {
            pickerGrid.Rows.Clear();
            pickerEmptyLabel.Visible = false;
            if (Convert.ToString(pickerOption.SelectedItem) == "Нарушения")
            {
                pickerRenderViolation();
            }
            if (Convert.ToString(pickerOption.SelectedItem) == "Водители")
            {
                pickerRenderDriver();
            }
        }

        private void pickerRenderViolation()
        {
            int amountOfRows = 0;
            for (int i = 0; i < fines.Length; i++)
            {
                if (fines[i].violationCode == violations[pickerArgsCB.SelectedIndex].violationCode)
                {
                    amountOfRows++;
                }
            }
            if (amountOfRows == 0)
            {
                pickerEmptyLabel.Visible = true;
            }
            else
            {
                pickerGrid.RowCount = amountOfRows;
                pickerGrid.ColumnCount = 2;
                pickerGrid.Columns[0].HeaderCell.Value = "Водитель";
                pickerGrid.Columns[1].HeaderCell.Value = "Дата";
                pickerGrid.Columns[0].Width = 105;
                pickerGrid.Columns[1].Width = 105;
                int row = 0;
                for (int i = 0; i < fines.Length; i++)
                {
                    if (fines[i].violationCode == violations[pickerArgsCB.SelectedIndex].violationCode)
                    {
                        pickerGrid.Rows[row].Cells[0].Value = allDrivers[fines[i].driverCode - 1].driverName.ToString();
                        pickerGrid.Rows[row].Cells[1].Value = allFines[fines[i].driverCode - 1].date; //fuck my life
                        row++;
                    }
                }
            }

        }

        private void pickerRenderDriver()
        {
            int amountOfRows = 0;
            for (int i = 0; i < fines.Length; i++)
            {
                if (fines[i].driverCode == drivers[pickerArgsCB.SelectedIndex].driverCode)
                {
                    amountOfRows++;
                }
            }
            if (amountOfRows == 0)
            {
                pickerEmptyLabel.Visible = true;
            }
            else
            {
                pickerGrid.RowCount = amountOfRows;
                pickerGrid.ColumnCount = 3;
                pickerGrid.Columns[0].HeaderCell.Value = "Нарушение";
                pickerGrid.Columns[1].HeaderCell.Value = "Дата";
                pickerGrid.Columns[2].HeaderCell.Value = "Штраф";
                pickerGrid.Columns[0].Width = 70;
                pickerGrid.Columns[1].Width = 70;
                pickerGrid.Columns[2].Width = 70;
                int row = 0;
                for (int i = 0; i < fines.Length; i++)
                {
                    if (fines[i].violationCode == violations[pickerArgsCB.SelectedIndex].violationCode)
                    {
                        pickerGrid.Rows[row].Cells[0].Value = allViolations[fines[i].violationCode - 1].violationName.ToString();
                        pickerGrid.Rows[row].Cells[1].Value = allFines[fines[i].fineCode - 1].date.ToString(); //foxtrot uniform charlie kilo tango hotel india sierra sierra hotel idnia tango
                        pickerGrid.Rows[row].Cells[2].Value = allViolations[fines[i].violationCode - 1].punishment;
                        row++;
                    }
                }
            }
        }


        private void PickerArgsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickerArgsCB.SelectedIndex == -1 || pickerOption.SelectedIndex == -1)
            {
                pickerShowBtn.Enabled = false;
            }
            else
            {
                pickerShowBtn.Enabled = true;
            }
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

    class violation
    {
        //properties
        public int violationCode;
        public string violationName;
        public string punishment;
        public bool removed;
        //constructor
        public violation(int violationCode, string violationName, string punishment, bool removed)
        {
            this.violationCode = violationCode;
            this.violationName = violationName;
            this.punishment = punishment;
            this.removed = removed;
        }
        //methods
        public void change(string newViolationName, string newPunishment)
        {
            this.violationName = newViolationName;
            this.punishment = newPunishment;
        }

        public void removeKebab() //best method evar
        {
            this.removed = true;
        }

    }



    class fine
    {
        public string date;
        public int fineCode;
        public int violationCode;
        public int driverCode;
        public bool removed;

        public fine(string date, int fineCode, int violationCode, int driverCode, bool removed)
        {
            this.date = date;
            this.fineCode = fineCode;
            this.violationCode = violationCode;
            this.driverCode = driverCode;
            this.removed = removed;
        }


        public void change(string newDate, int newViolationCode, int newDriverCode)
        {
            this.date = newDate;
            this.violationCode = newViolationCode;
            this.driverCode = newDriverCode;
        }

        public void removeKebab()
        {
            this.removed = true;
        }


    }

}
