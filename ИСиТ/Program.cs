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
            Console.WriteLine("First Test");
            char[] set1 = {'a', 'b', 'c', 'd' };
            int k = 6;
            printAllKLength(set1, k);
        }

        static void printAllKLength(char[] set, int k)
        {
            int n = set.Length;
            printAllKLengthRec(set, "", n, k);
        }

       
        static void printAllKLengthRec(char[] set, String prefix, int n, int k)
        {
            if (k == 0)
            {
                Console.WriteLine(prefix);
                return;
            }
            for (int i = 0; i < n; ++i)
            {
                String newPrefix = prefix + set[i];
                printAllKLengthRec(set, newPrefix, n, k - 1);
            }
        }
    }
}
