using System;
using System.Collections;

namespace laba14
{
    class Student
    {
        public int ID;
        public int Course;
        public string Name;
        public string Surname;
        public string Papa;
        public string Spec;

        public Student(int aID, string aName, string aSpec, int aCourse, string aSurname, string aPapa)
        {
            ID = aID;
            Name = aName;
            Spec = aSpec;
            Course = aCourse;
            Surname = aSurname;
            Papa = aPapa;
        }
    }

    class Students
    {
        public static ArrayList Studs = new ArrayList();

        public delegate bool LessRule(Student S1, Student S2);

        public delegate string PrintRule();

        public static string full()
        {
            string outism = "";
            foreach (var stud in Studs)
            {
                outism += (stud as Student).Surname + "; ";
                outism += (stud as Student).Name + "; ";
                outism += (stud as Student).Papa + "; Спец.: ";
                outism += (stud as Student).Spec + "; Курс: ";
                outism += (stud as Student).Course + "\n";
            }
            
            return outism;
        }

        public static string brief()
        {
            string outism = "";
            foreach (var stud in Studs)
            {
                outism += (stud as Student).Surname + " ";
                outism += (stud as Student).Name.Substring(0,1) + ".";
                try
                {
                    outism += (stud as Student).Papa.Substring(0, 1) + "\n";
                }
                catch{}
            }
            return outism;
        }

        public static string coolGuys()
        {
            string outism = "";
            foreach (var stud in Studs)
            {
                outism += (stud as Student).Surname + "; ";
                outism += (stud as Student).Name + "; ";
                outism += (stud as Student).Papa + "; Спец.: ";
                outism += (stud as Student).Spec + "; Курс: ";
                outism += (stud as Student).Course + "; ";
                if ((stud as Student).Spec == "ИСиТ")
                {
                    outism += "Cool dude ( ͡° ͜ʖ ͡°)";
                }
                else
                {
                    outism += "Lalka kakaya-to";
                }
                
                outism += (stud as Student).Course + "\n";
            }
            return outism;
        }
        
        

        public static bool LessID(Student S1, Student S2)
        {
            return S1.ID <= S2.ID;
        }

        public static bool LessName(Student S1, Student S2)
        {
            return string.Compare(S1.Surname, S2.Surname) <= 0;
        }
        
        public static bool LessSpec(Student S1, Student S2)
        {
            return string.Compare(S1.Spec, S2.Spec) <= 0;
        }

        public static bool LessCourse(Student S1, Student S2)
        {
            return S1.Course <= S2.Course;
        }

        public static void SortStud(LessRule Less)
        {
            for (int i = 0; i < Studs.Count - 1; i++)
            {
                for (int j = 0; j < Studs.Count; j++)
                {
                    if (!Less((Studs[i] as Student),(Studs[j] as Student)))
                    {
                        Student s=Studs[i] as Student;
                        Studs[i]=Studs[j];
                        Studs[j]=s;
                    }

                }
            }
        }
        
        public static void PrintStuds(string st)
        {
            Console.WriteLine(st);
            for (int i = 0; i < Studs.Count; i++)
            {
                Console.WriteLine("{0, 2}. {1, -16}, {2, -8}, {3} курс.", (Studs[i] as Student).ID,
                    (Studs[i] as Student).Name, (Studs[i] as Student).Spec, (Studs[i] as Student).Course);
            }
        }
        
        static void Main()
        {
            Studs.Add(new Student(1, "Александр", "МОиАИС", 2, "Петров", "Сергеевич"));
            Studs.Add(new Student(2, "Дмитрий", "ПИ", 1, "Иванов", "Иванович"));
            Studs.Add(new Student(3, "Людмила", "МОиАИС", 3, "Аагапова", "Валерьевна"));
            Studs.Add(new Student(4, "Ашот", "ИСТ", 4, "Закарян", ""));

            PrintStuds("\nСписок студентов");

            LessRule LR = new LessRule(LessName);
            SortStud(LR);
            PrintStuds("\nСортировка по фамилии");

            LR = LessSpec;
            SortStud(LR);
            PrintStuds("\nСортировка по специальности");

            SortStud(LessCourse);
            PrintStuds("\nСортировка по курсу");

            SortStud(LessID);
            PrintStuds("\nСортировка по номеру");
            
            PrintRule PR = new PrintRule(full);
            
            Console.WriteLine(PR());
            
            PR = new PrintRule(brief);
            
            Console.WriteLine(PR());
            
            PR = new PrintRule(coolGuys);
            
            Console.WriteLine(PR());

            Console.ReadLine();
        }
    }
    
}