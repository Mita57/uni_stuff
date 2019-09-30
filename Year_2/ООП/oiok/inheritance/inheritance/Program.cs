using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Point p1 = new Point();
        //    Point p2 = new Point(1, 2);
        //    Circle c1 = new Circle();
        //    Circle c2 = new Circle(4, 3, 5);
        //    Console.WriteLine(p1.info());
        //    Console.WriteLine(p2.info());
        //    Console.WriteLine(c1.info());
        //    Console.WriteLine(c2.info());
        //    Console.ReadLine();
        //}


        static void Main(string[] args)
        {
            const int n = 6;
            Point[] p;
            Create(out p, n);
            Show(p);
            Transform(p);
            Show3(p);
            invokeSimm(p);
            Console.WriteLine("Метод simm()");
            Show(p);
            Console.WriteLine("Метод RoFrom()");
            for (int i = 0; i < 7; i++)
            {
                if(i == 0)
                {
                    Console.Write(("").ToString().PadLeft(10));
                }
                else
                {
                    Console.Write((i-1).ToString().PadLeft(10));
                }
            }
            Console.Write(" \n_______________________________________________________________________________________ \n");
            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    if(j == 0)
                    {
                        Console.Write((i).ToString().PadLeft(10));
                    }
                    else
                    {
                        Console.Write(p[i].ReFrom(p[j-1]).ToString().PadLeft(10));
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        static void Create(out Point[] p, int k)
        {
            p = new Point[k];
            Random rnd = new Random();
            for(int i = 0; i < k; i++)
            {
                if(rnd.NextDouble() < 0.4)
                {
                    p[i] = new Point(rnd.Next(10), rnd.Next(10));
                }
                else
                {
                    p[i] = new Circle(rnd.Next(10), rnd.Next(10),rnd.Next(8));
                }
            }
        }

        static void invokeSimm(Point[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                p[i].Simm();
            }
        }

        static void Show(Point[] p)
        {
            int k = p.Length;
            for(int i = 0; i < k; i++)
            {
                Console.WriteLine("{0, 2} - {1}", i, p[i].info());
            }
            Console.WriteLine("---------------------------------------------");
        }

        static void Show2(Point[] p)
        {
            int k = p.Length;
            for (int i = 0; i < k; i++)
            {
                if (p[i] is Point)
                {
                    Console.WriteLine("{0, 2} - {1}", i, p[i].info());
                }
                else
                {
                    Console.WriteLine("{0, 2} - {1}", i, ((Circle)p[i]).info());
                }
            }
            Console.WriteLine("_________________________________________");
        }

        static void Show3(Point[] p)
        {
            int k = p.Length;
            for (int i = 0; i < k; i++)
            {
                if (p[i] is Circle)
                {
                    Console.WriteLine("{0, 2} - {1}", i, ((Circle)p[i]).info());
                }
                else
                {
                    Console.WriteLine("{0, 2} - {1}", i, p[i].info());
                }
            }
        }

        static void Transform(Point[] p)
        {
            for(int i = 0; i < p.Length; i++)
            {
                if(p[i] is Circle)
                {
                    ((Circle)p[i]).SetSquare(10);
                }
                else
                {
                    p[i].Move(5, 5);
                }
            }
        }

    }
}
