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

            surnameTB.Text = "";
            nameTB.Text = "";
            parTB.Text = "";
            progCafTB.Text = "";
            groupTB.Text = "";
            debtsProgsTB.Text = "";
            yearNum.Value = 0;
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

        private void surnameTB_TextChanged(object sender, EventArgs e)
        {
            validateInputs();
        }
    }
}