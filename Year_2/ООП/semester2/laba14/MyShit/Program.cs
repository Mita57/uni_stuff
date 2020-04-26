using System;

namespace MyShit
{
    internal class Program
    {
        public delegate int operation(int x, int y);

        public static int sum(int x, int y)
        {
            return x + y;
        }

        public static int extract(int x, int y)
        {
            return x - y;
        }

        public static int mult(int x, int y)
        {
            return x * y;
        }
        
        public static int div(int x, int y)
        {
            return x / y;
        }
        
        
        
        public static void Main(string[] args)
        {
            int x = 4;
            int y = 2;

            operation op = new operation(sum);
            Console.WriteLine(op(x, y));
            
            op = new operation(extract);
            Console.WriteLine(op(x, y));

            op = new operation(mult);
            Console.WriteLine(op(x, y));
            
            op = new operation(div);
            Console.WriteLine(op(x, y));

            Console.ReadKey();

        }
    }
}