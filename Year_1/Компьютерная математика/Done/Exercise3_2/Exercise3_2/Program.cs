using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_2
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите число");
            int N = int.Parse(Console.ReadLine());
            int factorial = 1;
            try
            {
                for (int i = 1; i < N + 1; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine("Через цикл: " + factorial.ToString());
                string reco = rec(N).ToString();
                Console.WriteLine("Через рекурсию: " + reco);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Неверные данные");
            }
            Console.ReadLine();
        }



        static int rec(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return (n*rec(n - 1));
            }
        }
    }
}
