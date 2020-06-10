using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace laba17
{
    public class Point
    {
        public string name { get; }
        
        public int x { get; set; }

        public int y { get; set; }

        public double rj { get; }

        public void setPoint(int newx, int newy)
        {
            this.x = newx;
            this.y = newy;
        }

        public void simOX()
        {
            this.x = -this.x;
        }

        public void simOY()
        {
            this.y = -this.y;
        }

        public void MoveRel(int dx, int dy)
        {
            this.x += dx;
            this.y += dy;
        }

        public double reFrom(Point p)
        {
            double dx = Math.Abs(this.x) + Math.Abs(p.x);
            double dy = Math.Abs(this.y) + Math.Abs(p.y);
            return (Math.Sqrt(dx * dx + dy * dy));
        }

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj is Point)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return string.Format("Точка-почка, X: {0}, Y: {1}", this.x, this.y);
        }
        

        public delegate void onChangeDel(string x, string y);

        public event onChangeDel onChange;
        

        public delegate bool onChangingDel();

        public event onChangingDel onChanging;
        
        public delegate void onAxisDel(int oldx, int oldy);

        public event onAxisDel onAxis; // AXIS REST IN HELL 
    }

    public class Points
    {
        public int i
        {
            get;
        }
        
        
        
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Point> points = new List<Point>();
            for (int i = 0; i < 15; i++)
            {
                Point o = new Point();
                o.onChange += onChangeHandler;
                
            }
        }
        
        public static void onChangeHandler(string x, string y)
        {
            Console.WriteLine(string.Format("Произошел троллинг: {0} : {1}", this.x, this.y));
        }

        public static bool onChangingHandler()
        {
            Console.WriteLine("Est-ce que vous voulez changer les coordonnées du point? (Y/N)");
            string res = "";
            while (res != "y" || res != "Y" || res != "X" || res != "x")
            {
                res = Console.ReadLine();
                if (res == "y" || res == "Y")
                {
                    return true;
                }
                if(res == "N" || res == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Ecrire un lettre Y ou un lettre N, s'il vous plait");
                }
            }
        }
        
        public static 
    }
}