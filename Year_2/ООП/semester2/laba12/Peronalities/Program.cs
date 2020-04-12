using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peronalities
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        
        public static List<Person> list = new List<Person>();
    }
    
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

            public Stud(string nam, string surname, int year, string par, string sp, string gr, List<string> uncomms) :
                base(nam, surname, par, year)
            {
                Spec = sp;
                Group = gr;
                Uncomms = uncomms;
            }

            public override string BriefInfo()
            {
                return string.Format("Студент: {0}, специальность: \"{1}\", группа {2}, долги: {3}",
                    Name + " " + Surname, Spec, Group, Uncomms.Count);
            }

            public override string FullInfo()
            {
                string cock = "";
                foreach (string meme in Uncomms)
                {
                    cock += meme + "; ";
                }

                return string.Format("{0} {1} {2}, студент {3} курса специальности {4}, долги: {5}", Name, Surname,
                    Patronymic, Year, Spec, cock);
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

            public Prof(string nam, string dp, string surname, string papa, int year, List<string> discs) : base(nam,
                surname, papa, year)
            {
                Dep = dp;
                Disciplines = discs;
            }

            public override string BriefInfo()
            {
                return String.Format("Преподователь:{0}, кафедра \"{1}\", читает {2} предметов", Name + " " + Surname,
                    Dep, Disciplines.Count);
            }

            public override string FullInfo()
            {
                string cock = "";
                foreach (string meme in Disciplines)
                {
                    cock += meme + ", ";
                }

                return String.Format("Преподователь:{0}, кафедра \"{1}\", стаж работы: {2}, читает предметы: {3}",
                    Name + " " + Surname + "" + Patronymic, Dep, Year, cock);
            }

            public override void NextYear()
            {
                this.Year++;
            }
        }
        

}