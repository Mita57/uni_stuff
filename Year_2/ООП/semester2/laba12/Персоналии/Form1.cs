using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Персоналии
{
    public partial class Form1 : Form
    {
        
        abstract class Person
        {
            public string Name { get; private set; }

            public Person(string name)
            {
                Name = name;
            }

            public abstract string Info();

            public override string ToString()
            {
                return Info();
            }
        }

        class Stud : Person
        {
            string Spec { get; set; }
            private string Group { get; set; }

            public Stud(string nam, string sp, string gr) : base(nam)
            {
                Spec = sp;
                Group = gr;
            }

            public override string Info()
            {
                return string.Format("Студент: {0}, специальность: \"{1}\", группа {2}", Name, Spec, Group);
            }
        }

        class Prof : Person
        {
            private string Dep { get; set; }

            public Prof(string nam, string dp) : base(nam)
            {
                Dep = dp;
            }

            public override string Info()
            {
                return String.Format("Преподователь:{0}, кафедра \"{1}\"", Name, Dep);
            }
        }

        List <Person> list = new List<Person>();
        
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
            }
        }

        private void tutorRB_CheckedChanged(object sender, EventArgs e)
        {
            if (tutorRB.Checked)
            {
                progCafLabel.Text = "Кафедра";
                groupLabel.Visible = false;
                groupTB.Visible = false;
            }
        }
    }
}