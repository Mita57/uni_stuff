using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Peronalities
{
    public partial class AddPerson : Form
    {
        public AddPerson()
        {
            InitializeComponent();
        }

        private void AddPerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (studentRB.Checked)
            {
                List<string> sas = new List<string>(debtsProgsTB.Text.Split(','));
                Program.list.Add(new Stud(nameTB.Text, surnameTB.Text, Convert.ToInt32(yearNum.Value), parTB.Text, progCafTB.Text, groupTB.Text, sas));
            }
            else
            {
                List<string> sas = new List<string>(debtsProgsLabel.Text.Split(','));
                Program.list.Add(new Prof(nameTB.Text, progCafTB.Text, surnameTB.Text, parTB.Text, Convert.ToInt32(yearNum.Value), sas));
            }
            save();
        }

        private void save()
        {
            if (string.IsNullOrEmpty(Program.form.path))
            {
                DialogResult = saveFileDialog1.ShowDialog();
                if (DialogResult == DialogResult.OK)
                {
                    string filePath = saveFileDialog1.FileName;
                    Program.form.path = filePath;
                    string serialze = "";
                    foreach (Person per in Program.list)
                    {
                        if (per is Prof)
                        {
                            Prof perPr = (Prof) per;
                            string progs = "";
                            foreach (string dis in perPr.Disciplines)
                            {
                                progs += dis + "&";
                            }
                            serialze += String.Format("prof%{0}%{1}%{2}%{3}%{4}%{5}~", perPr.Name, perPr.Dep, perPr.Surname, perPr.Patronymic, perPr.Year, progs);
                        }
                        else
                        {
                            Stud perSt = (Stud) per;
                            string debts = "";
                            foreach (string debt in perSt.Uncomms)
                            {
                                debts += debts + "&";
                            }
                            
                            serialze += String.Format("stud%{0}%{1}%{2}%{3}%{4}%{5}%{6}~", perSt.Name, perSt.Surname, perSt.Year, perSt.Patronymic, perSt.Spec, perSt.Group, debts);
                        }
                    }
                    File.WriteAllText(filePath, serialze);
                }
            }
            else
            {
                string serialze = "";
                foreach (Person per in Program.list)
                {
                    if (per is Prof)
                    {
                        Prof perPr = (Prof) per;
                        string progs = "";
                        foreach (string dis in perPr.Disciplines)
                        {
                            progs += dis + "&";
                        }
                        serialze += String.Format("prof%{0}%{1}%{2}%{3}%{4}%{5}~", perPr.Name, perPr.Dep, perPr.Surname, perPr.Patronymic, perPr.Year, progs);
                    }
                    else
                    {
                        Stud perSt = (Stud) per;
                        string debts = "";
                        foreach (string debt in perSt.Uncomms)
                        {
                            debts += debts + "&";
                        }
                            
                        serialze += String.Format("stud%{0}%{1}%{2}%{3}%{4}%{5}%{6}~", perSt.Name, perSt.Surname, perSt.Year, perSt.Patronymic, perSt.Spec, perSt.Group, debts);
                    }
                }
                File.WriteAllText(Program.form.path, serialze);
            }
        }
        

        private void cancelButton_Click(object sender, EventArgs e)
        {
            surnameTB.Text = "";
            nameTB.Text = "";
            parTB.Text = "";
            progCafLabel.Text = "";
            groupTB.Text = "";
            yearNum.Value = 0;
            this.Hide();
        }

        private void validateInputs()
        {
            bool nameFlag = false;
            bool surnameFlag = false;
            bool parFlag = false;
            bool progCafFlag = false;
            bool groupFlag = false;

            if (!String.IsNullOrEmpty(surnameTB.Text))
            {
                surnameFlag = true;
            }

            if (!string.IsNullOrEmpty(nameTB.Text))
            {
                nameFlag = true;
            }

            if (!string.IsNullOrEmpty(parTB.Text))
            {
                parFlag = true;
            }

            if (!string.IsNullOrEmpty(progCafTB.Text))
            {
                progCafFlag = true;
            }

            if (!string.IsNullOrEmpty(groupTB.Text))
            {
                groupFlag = true;
            }

            if (nameFlag && surnameFlag && parFlag && progCafFlag && groupFlag)
            {
                addButton.Enabled = true;
            }
            else
            {
                addButton.Enabled = false;
            }
        }

        private void studentRB_CheckedChanged(object sender, EventArgs e)
        {
            if (studentRB.Checked)
            {
                progCafTB.Text = "";
                progCafLabel.Text = "Направление";
                groupLabel.Visible = true;
                groupTB.Text = "";
                groupTB.Visible = true;
                yearLabel.Text = "Год обучения";
                debtsProgsLabel.Text = "Долги";
            }
        }

        private void tutorRB_CheckedChanged(object sender, EventArgs e)
        {
            if (tutorRB.Checked)
            {
                progCafLabel.Text = "Кафедра";
                groupLabel.Visible = false;
                groupTB.Visible = false;
                yearLabel.Text = "Стаж";
                debtsProgsLabel.Text = "Предметы";
                groupTB.Text = "cock";
            }
        }
    }
}