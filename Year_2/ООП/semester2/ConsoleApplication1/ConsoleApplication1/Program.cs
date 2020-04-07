using System;

namespace ConsoleApplication1
{
    public class A
    {
        public virtual void M()
        {
            Console.WriteLine("This is A");
        }
    }

    public class B: A
    {
        public new void M()
        {
            Console.WriteLine("This is B");
        }
    }
    
    
    class Program
    {
        static void Main(String[] args)
        {
            B b = new B();
            A a = b;
            a.M();\public static voud mianjdasfgefwffewfef
        }

    }
}