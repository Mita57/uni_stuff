using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peronalities
{
    public partial class Form1 : Form
    {
        abstract class Person
        {
            public string Name { get; private set; }

            public string Surname { get; private set; }

            public string Patronymic { get; private set; }

            public int Year { get; set; }


            public Person(string name, string surname, string patronymic, int year)
            {
                Name = name;
                Surname = surname;
                Patronymic = patronymic;
                Year = year;
            }

            public abstract string FullInfo();

            public abstract string BriefInfo();

            public override string ToString()
            {
                return BriefInfo();
            }

            public abstract void NextYear();
        }

        class Stud : Person
        {
            string Spec { get; set; }
            private string Group { get; set; }

            private List<string> Uncomms { get; set; }

            public Stud(string nam, string surname, int year, string par, string sp, string gr, List<string> uncomms) : base(nam, surname,par, year)
            {
                Spec = sp;
                Group = gr;
                Uncomms = uncomms;
            }

            public override string BriefInfo()
            {
                return string.Format("Студент: {0}, специальность: \"{1}\", группа {2}, долги: {3}", Name + " "+Surname, Spec, Group, Uncomms.Length);
            }

            public override string FullInfo()
            {
                foreach (var VARIABLE in COLLECTION)
                {
                    
                }
                return string.Format("{0} {1} {2}, студент {3} курса специальности {4}, долги: {5}", Name, Surname, Patronymic, Year, Spec, );
            }

            public override void NextYear()
            {
                this.Year++;
            }
        }

        class Prof : Person
        {
            private string Dep { get; set; }
            
            public List<string> Disciplines { get; set; }

            public Prof(string nam, string dp, string surname, string papa, int year, List<string> discs) : base(nam, surname, papa, year)
            {
                Dep = dp;
                Disciplines = discs;
            }

            public override string BriefInfo()
            {
                return String.Format("Преподователь:{0}, кафедра \"{1}\", читает {2} предметов", Name, Dep, Disciplines.Length);
            }

            public override string FullInfo()
            {
                
            }

            public override void NextYear()
            {
                this.Year++;
            }
        }

        List<Person> list = new List<Person>();

        private AddPerson addForm = null;

        private UpdatePerson updateForm = null;

        public Form1()
        {
            InitializeComponent();
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
    }
}