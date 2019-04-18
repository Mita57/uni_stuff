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
            char[] splitter = { ' ', ',',')', '(' };
            var setA = Console.ReadLine().Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Введите второе множество");
            var setB = Console.ReadLine().Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i<setA.Length; i++)
            {
                for(int j = 0; j<setB.Length; j++)
                {
                    Console.WriteLine(setA[i].ToString()+ "; "+ setB[j].ToString());
                }
            }
            Console.ReadLine();
        }
    }
}
