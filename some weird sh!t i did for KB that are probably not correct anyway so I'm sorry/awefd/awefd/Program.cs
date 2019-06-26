using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace awefd
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IRemoveDoubleWhiteSpaces
    {
        string remove();
    }

    class stringClass
    {
        protected int strLen;
        public string wholeString;
        public char[] stringChars;

        public stringClass(string In)
        {
            this.wholeString = In;
            this.strLen = In.Length;
            this.stringChars = In.ToCharArray();
        }


        public  virtual string getInfo()
        {
            string info = "";
            info += "Длина строки: " + this.strLen.ToString();
            info += "Полная строка: " + this.wholeString;
            info += "Символы строки: ";
            foreach(char X in this.stringChars)
            {
                info += X.ToString() + " ";
            }
            return info;
        }

        public void remove()
        {
            string tempo = this.wholeString;
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            tempo = regex.Replace(tempo, " ");
            this.wholeString = tempo;
        }

        public delegate void strstrstrstr(string message);
        public event strstrstrstr changed;
        public event strstrstrstr allAreNumbers;

        public void change(string newString)
        {
            this.wholeString = newString;
            changed("Произошло изменение строки");
            if(int.TryParse(newString, out int sdfsdf)){
                allAreNumbers("Все символы - цифры");
            }
        }

        public string concatStrings(string stringOne, string stringTwo)
        {
            string newString = "";
            newString += stringOne + " " + stringTwo;
            return newString;
        }
    }
}
