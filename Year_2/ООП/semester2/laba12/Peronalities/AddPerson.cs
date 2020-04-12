using System;
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
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void validateInputs()
        {
            bool nameFlag = false;
            bool surnameFlag = false;
            bool parFlag = false;
            
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
    }
}