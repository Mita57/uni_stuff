using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое множество");
            char[] splitter = {' '};
            string [] strA = Console.ReadLine().Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            List<string> setA = new List<string>();
            for(int i = 0; i <strA.Length; i++)
            {
                setA.Add(strA[i]);
            }
            setA=setA.Distinct().ToList();
            Console.WriteLine("Введите второе множество");
            string[] strB = Console.ReadLine().Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            List<string> setB = new List<string>();
            for (int i = 0; i<strB.Length; i++)
            {
                setB.Add(strB[i]);
            }
            setB=setB.Distinct().ToList();
            Console.WriteLine();
            for(int i = 0; i < setA.Count; i++)
            {
                for (int j = 0; j < setB.Count; j++)
                {
                    Console.Write(" (" + setA[i] + "; " + setB[j] + "),");
                }
            }
            Console.ReadLine();
        }
    }
}
