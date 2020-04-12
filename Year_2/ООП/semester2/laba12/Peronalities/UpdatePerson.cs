using System;
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
            throw new System.NotImplementedException();
        }
    }
}