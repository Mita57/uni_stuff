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
            for(int i = 0; i < 33; i++)
            {
                Console.WriteLine(Convert.ToString(i, 18));
            }
            Console.ReadLine();
        }
    }
}
