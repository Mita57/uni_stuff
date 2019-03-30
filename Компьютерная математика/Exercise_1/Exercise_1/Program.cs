using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program { 
        static void Main(string[] args)
        {
            int x = 1;
            int[] ar = new int[0];
            while (x < 7)
            {
                Array.Resize(ref ar, ar.Length+1);
                ar[x-1]=3*x;
                x++;
            }
            foreach (int z in ar) Console.Write(z + " ") ;
            Console.WriteLine("Мощность множества " + ar.Length);
        }
    }
}
