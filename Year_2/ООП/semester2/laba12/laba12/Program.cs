using System;
using System.Data;
using System.Globalization;

namespace laba12
{
    abstract class Person
    {
        public string Name { get; private set; }

        public Person(string name)
        {
            Name = name;
        }

        public abstract string Info();
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


    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}