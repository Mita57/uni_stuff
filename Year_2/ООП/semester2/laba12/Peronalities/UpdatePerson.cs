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

        public void fillFieldsStud(string surname, string name, string papa, string prog, string group, string debts)
        {
            studentRB.Checked = true;
            surnameTB.Text = surname;
            nameTB.Text = name;
            papaTB.Text = papa;
            progCafTB.Text = prog;
            groupTB.Text = group;
            debtsProgsTB.Text = debts;
        }

        public void fillFieldsProf(string surname, string name, string papa, string caf, string progs)
        {
            tutorRB.Checked = true;
            surnameTB.Text = surname;
            nameTB.Text = name;
            papaTB.Text = papa;
            progCafTB.Text = caf;
            debtsProgsTB.Text = progs;
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

            Program.form.render();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}