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
            a.Val = 54;
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
            Console.ReadLine();
        }
    }
}
