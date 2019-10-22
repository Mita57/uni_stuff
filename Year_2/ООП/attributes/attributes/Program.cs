using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            N1 a = new N1("A");
            a.Show();
            N1 b = new N1("B");
            b.Show();
            a.Val = 98;
            a.Show();
            b.Val = -17;
            b.Show();
            a.D2 = 15;
            a.Show();
            b.D1 = 8;
            b.Show();
            a.Swap();
            a.Show();
            b.Swap();
            b.Show();
            Console.WriteLine("A<B - {0}", a.LessThan(b));
            Console.WriteLine("B<A - {0}", b.LessThan(a));
            Console.WriteLine("Симметричность: " + a.IsSimm(b));
            Console.WriteLine(a.Val);
            Console.WriteLine("DigSum: " + a.DigSum);
            a.DigSum = 13;
            Console.WriteLine("Бахнув a.DigSum(13):" + a.Val);
            Console.WriteLine("isS1mple: " + Convert.ToBoolean(a.DigPrime));
            a.DigPrime = 96;
            Console.WriteLine("Ближайшее простецкое числоу: " + a.Val);
            Console.ReadLine();
        }
    }
}
