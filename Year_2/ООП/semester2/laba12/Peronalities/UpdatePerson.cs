using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Peronalities
{
    public partial class UpdatePerson : Form
    {
        public UpdatePerson()
        {
            InitializeComponent();
        }

        private void UpdatePerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void fillFields()
        {
            RadioButton sas =  (RadioButton)Program.form.Controls["studentRB"];
            if (sas.Checked)
            {
                studentRB.Checked = true;
            }
            else
            {
                tutorRB.Checked = true;
            }
            surnameTB.Text = Program.form.Controls["surnameTB"].Text;
            nameTB.Text = Program.form.Controls["nameTB"].Text;
            papaTB.Text = Program.form.Controls["patTB"].Text;
            progCafTB.Text = Program.form.Controls["progCafTB"].Text;
            groupTB.Text = Program.form.Controls["groupTB"].Text;
        }

        private void studentRB_CheckedChanged(object sender, EventArgs e)
        {
            if (studentRB.Checked)
            {
                progCafLabel.Text = "Направление";
                yearLabel.Text = "Год обучения";
                groupLabel.Visible = true;
                groupTB.Visible = true;
                debtsProgsLabel.Text = "Долги";
            }
        }

        private void tutorRB_CheckedChanged(object sender, EventArgs e)
        {
            if (tutorRB.Checked)
            {
                progCafLabel.Text = "Кафедра";
                yearLabel.Text = "Стаж";
                groupLabel.Visible = false;
                groupTB.Visible = false;
                debtsProgsLabel.Text = "Предметы";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (studentRB.Checked)
            {

                Program.list[Program.form.index].Name = nameTB.Text;
                Program.list[Program.form.index].Patronymic = papaTB.Text;
                Program.list[Program.form.index].Surname = surnameTB.Text;
                Program.list[Program.form.index].Year = (int) yearNum.Value;
                ((Stud) Program.list[Program.form.index]).Spec = progCafTB.Text;
                ((Stud) Program.list[Program.form.index]).Group = groupTB.Text;

                string[] debts = debtsProgsTB.Text.Split(',');
                ((Stud) Program.list[Program.form.index]).Uncomms = new List<string>(debts);
            }
            else
            {
                Program.list[Program.form.index].Name = nameTB.Text;
                Program.list[Program.form.index].Patronymic = papaTB.Text;
                Program.list[Program.form.index].Surname = surnameTB.Text;
                Program.list[Program.form.index].Year = (int) yearNum.Value;
                ((Prof) Program.list[Program.form.index]).Dep = progCafTB.Text;
                
                string[] debts = debtsProgsTB.Text.Split(',');
                ((Prof) Program.list[Program.form.index]).Disciplines = new List<string>(debts);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}