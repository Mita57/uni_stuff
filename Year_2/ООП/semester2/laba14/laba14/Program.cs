using System;
using System.Collections;

namespace laba14
{
    class Student
    {
        public int ID;
        public int Course;
        public string Name;
        public string Spec;

        public Student(int aID, string aName, string aSpec, int aCourse)
        {
            ID = aID;
            Name = aName;
            Spec = aSpec;
            aCourse = aCourse;
        }
    }

    class Students
    {
        public static ArrayList Studs = new ArrayList();

        public delegate bool LessRule(Student S1, Student S2);

        public static bool LessID(Student S1, Student S2)
        {
            return S1.ID <= S2.ID;
        }

        public static bool LessName(Student S1, Student S2)
        {
            return string.Compare(S1.Name, S2.Name) <= 0;
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
            Studs.Add(new Student(1, "Петров А.С.", "МОиАИС", 2));
            Studs.Add(new Student(2, "Иванов Д.И.", "ПИ", 1));
            Studs.Add(new Student(3, "Агапова Л.В.", "МОиАИС", 3));
            Studs.Add(new Student(4, "Закарян Ашот", "ИСТ", 4));

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

            Console.ReadLine();
        }
    }
    
}