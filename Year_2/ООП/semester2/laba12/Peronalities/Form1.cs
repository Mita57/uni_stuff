using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peronalities
{
    public partial class Form1 : Form
    {
        private AddPerson addForm = null;

        private UpdatePerson updateForm = null;

        public string path = "";

        public int index = 0;

        public Form1()
        {
            InitializeComponent();
            Program.form = this;
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
            }
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            if (this.updateForm == null)
            {
                this.updateForm = new UpdatePerson();
                this.updateForm.Show();
            }
            else
            {
                this.updateForm.Show();
                this.updateForm.Focus();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (this.updateForm == null)
            {
                this.addForm = new AddPerson();
                this.addForm.Show();
            }
            else
            {
                this.addForm.Show();
                this.addForm.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void listAll_Click(object sender, EventArgs e)
        {
            string meme = "";
            foreach (Person succ in Program.list)
            {
                meme += succ.BriefInfo() + "; ";
            }

            MessageBox.Show(meme);
        }

        private void listStudents_Click(object sender, EventArgs e)
        {
            string meme = "";
            foreach (Person succ in Program.list)
            {
                if (succ is Stud)
                {
                    meme += succ.BriefInfo() + "; ";
                }
            }

            MessageBox.Show(meme);
        }

        private void listTutors_Click(object sender, EventArgs e)
        {
            string meme = "";
            foreach (Person succ in Program.list)
            {
                if (succ is Prof)
                {
                    meme += succ.BriefInfo() + "; ";
                }
            }

            MessageBox.Show(meme);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            DialogResult = openFileDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string content = File.ReadAllText(filePath);
                path = filePath;
                Program.list.Clear();

                string[] entries = content.Split('~');
                foreach (string entry in entries)
                {
                    string[] parts = entry.Split('%');
                    if (parts[0] == "prof")
                    {
                        string[] progs = parts[6].Split('&');
                        List<string> sas = new List<string>(progs);
                        Program.list.Add(
                            new Prof(parts[1], parts[2], parts[3], parts[4], int.Parse(parts[5]), sas));
                    }
                    else
                    {
                        string[] debts = parts[7].Split('&');
                        List<string> sas = new List<string>(debts);
                        Program.list.Add(new Stud(parts[1], parts[2], int.Parse(parts[3]), parts[4], parts[5], parts[6],
                            sas));
                    }
                }
            }
        }

        private void render()
        {
            if (index == 0)
            {
                prevButton.Enabled = false;
                startButton.Enabled = false;
                nextButton.Enabled = true;
                lastButton.Enabled = true;
            }
            else
            {
                if (index == Program.list.Count - 1)
                {
                    prevButton.Enabled = true;
                    startButton.Enabled = true;
                    nextButton.Enabled = false;
                    lastButton.Enabled = false;
                }

                else
                {
                    prevButton.Enabled = true;
                    startButton.Enabled = true;
                    nextButton.Enabled = true;
                    lastButton.Enabled = true;
                }
            }

            Person pers = Program.list[index];

            if (pers is Stud)
            {
                studentRB.Checked = true;
                Stud persStud = (Stud) pers;
                surnameTB.Text = persStud.Surname;
                nameTB.Text = persStud.Name;
                patTB.Text = persStud.Patronymic;
                progCafTB.Text = persStud.Spec;
                groupTB.Text = persStud.Group;
                debtsProgsTB.Text = "";
                foreach (string debt in persStud.Uncomms)
                {
                    debtsProgsTB.Text += debt + ", ";
                }
                yearNum.Value = pers.Year;
            }

            else
            {
                Prof persProf = (Prof) pers;
                tutorRB.Checked = true;
                surnameTB.Text = persProf.Surname;
                nameTB.Text = persProf.Name;
                patTB.Text = persProf.Patronymic;
                progCafTB.Text = persProf.Dep;
                debtsProgsTB.Text = "";
                foreach (string prog in persProf.Disciplines)
                {
                    debtsProgsTB.Text += prog + ", ";
                }
                yearNum.Value = persProf.Year;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.index = 0;
            render();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            index--;
            render();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            index++;
            render();
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            index = Program.list.Count - 1;
            render();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Program.list.RemoveAt(index);
        }
    }
}