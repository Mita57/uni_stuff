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

        public void simO()
        {
            this.x = -this.x;
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
        
        public delegate void onAxisDel(string oldx, string oldy);

        public event onAxisDel onAxis; // AXIS REST IN HELL 
    }

    public class Points
    {
        public int amount
        {
            get;
        }
        
        List<Point> points = new List<Point>();
        
        public Point this[int index]
        {
            get
            {
                return points[amount];
            }
        }

        public void setPoint(int i, Point p)
        {
            this.points[i] = p;
        }

        public void add(Point p)
        {
            this.points.Add(p);
        }

        public void Remove(int i)
        {
            try
            {
                this.points.RemoveAt(i);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public Points()
        {
        }

        public Points(int am)
        {
            Random rnd = new Random();
            for (int i = 0; i < am; i++)
            {
                this.points.Add(new Point(rnd.Next(-11, 11), rnd.Next(-11, 11))); 
            }
        }
        public delegate void alertChange();

        public event alertChange onChange;
    }

    internal class Program
    {
        static private Points pts;
        public static void Main(string[] args)
        {
            pts = new Points(15);

            for (int i = 0; i < pts.amount; i++)
            {
                pts[i].onChange += onChangeHandler;
                pts[i].onChanging += onChangingHandler;
                pts[i].onAxis += onAxisHandler;
            }
            
            while (true)
            {
                Console.WriteLine("Choissir quel vous voulez fais, s'il vous plait");
                Console.WriteLine("(1):Ajouter du point (add)");
                Console.WriteLine("(2):Éditer du point");
                Console.WriteLine("(3):Retirer du point (remove)");
                Console.WriteLine("(4):SimOX");
                Console.WriteLine("(5):SimOY");
                Console.WriteLine("(6):SimO");
                Console.WriteLine("(7):ReFrom");
                Console.WriteLine("(8):Applicer des restictions");
                Console.WriteLine("(X):Quitter l'application");
                string resp = Console.ReadLine();
                switch (resp)
                {
                    case "1":
                    {
                        addPoint();
                        break;
                    }
                    case "2":
                    {
                        editPoint();
                        break;
                    }
                    case "3":
                    {
                        removePoint();
                        break;
                    }
                    case "4":
                    {
                        applySimOx();
                        break;
                    }
                    case "5":
                    {
                        applySimOy();
                        break;
                    }
                    case "6":
                    {
                        applySimO();
                        break;
                    }
                    case "7":
                    {
                        reFrom();
                        break;
                    }
                    case "8":
                    {
                        //todo
                        break;
                    }
                    case "X":
                    {
                        return;
                    }
                    case "x":
                    {
                        return;
                    }
                        
                }
            }
        }

        public static void reFrom()
        {
            string ind1 = "cock";
            int i1 = 0;
            while (!int.TryParse(ind1, out i1))
            {
                Console.WriteLine("Entrer l'idnex");
                ind1 = Console.ReadLine();
            }

            string ind2 = "cock";
            int i2 = 0;
            while (!int.TryParse(ind2, out i2))
            {
                Console.WriteLine("Entrer l'idnex");
                ind2 = Console.ReadLine();
            }

            try
            {
                pts[i1].reFrom(i2);
            }
            catch
            {
                Console.WriteLine("L'index se trouve en dehors du tableau");
            }
            
        }

        public static void applySimO()
        {
            string ind = "cock";
            int i = 0;
            while (!int.TryParse(ind, out i))
            {
                Console.WriteLine("Entrer l'idnex");
                ind = Console.ReadLine();
            }
            
            try
            {
                pts[i].simO();
            }
            catch
            {
                Console.WriteLine("L'index se trouve en dehors du tableau");
            }
        }

        public static void applySimOx()
        {
            string ind = "cock";
            int i = 0;
            while (!int.TryParse(ind, out i))
            {
                Console.WriteLine("Entrer l'idnex");
                ind = Console.ReadLine();
            }
            
            try
            {
                pts[i].simOX();
            }
            catch
            {
                Console.WriteLine("L'index se trouve en dehors du tableau");
            }
        }

        public static void applySimOy()
        {
            string ind = "cock";
            int i = 0;
            while (!int.TryParse(ind, out i))
            {
                Console.WriteLine("Entrer l'idnex");
                ind = Console.ReadLine();
            }
            
            try
            {
                pts[i].simOY();
            }
            catch
            {
                Console.WriteLine("L'index se trouve en dehors du tableau");
            }
        }

        public static void addPoint()
        {
            string xCon = "cock";
            int x = 0;
            while (!int.TryParse(xCon, out x))
            {
                Console.WriteLine("Entrer le coordonner x");
                xCon = Console.ReadLine();
            }

            string yCon = "cock2";
            int y = 0;
            while (!int.TryParse(yCon, out y))
            {
                Console.WriteLine("Entrer le coordonner y");
                yCon = Console.ReadLine();
            }
            
            pts.add(new Point(x, y));
        }
        
        public static void editPoint()
        {
            string ind = "cock";
            int i = 0;
            while (!int.TryParse(ind, out i))
            {
                Console.WriteLine("Entrer l'idnex");
                ind = Console.ReadLine();
            }

            string xCon = "cock";
            int x = 0;
            while (!int.TryParse(xCon, out x))
            {
                Console.WriteLine("Entrer le coordonner x");
                xCon = Console.ReadLine();
            }
            
            string yCon = "cock2";
            int y = 0;
            while (!int.TryParse(yCon, out y))
            {
                Console.WriteLine("Entrer le coordonner y");
                yCon = Console.ReadLine();
            }
            

            try
            {
                pts[i].x = x;
                pts[i].y = y;
            }
            catch
            {
                Console.WriteLine("L'index se trouve en dehors du tableau");
            }
        }

        public static void removePoint()
        {
            string ind = "cock";
            int i = 0;
            while (!int.TryParse(ind, out i))
            {
                Console.WriteLine("Enter l'idnex");
                ind = Console.ReadLine();
            }

            string xCon = "cock";
            int x = 0;
            while (!int.TryParse(xCon, out x))
            {
                Console.WriteLine("Entrer le coordonner x");
                xCon = Console.ReadLine();
            }

            string yCon = "cock2";
            int y = 0;
            while (!int.TryParse(yCon, out y))
            {
                Console.WriteLine("Entrer le coordonner y");
                yCon = Console.ReadLine();
            }
            
            try
            {
                pts.Remove(i);
            }
            catch
            {
                Console.WriteLine("L'index se trouve en dehors du tableau");
            }
        }
        
        
        public static void onChangeHandler(string x, string y)
        {
            Console.WriteLine(string.Format("Произошел троллинг: {0} : {1}", x, y));
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
                    Console.WriteLine("Entrer un lettre Y ou un lettre N, s'il vous plait");
                }
            }

            return false;
        }

        public static void onAxisHandler(string dx, string dy)
        {
            Console.WriteLine(String.Format("Au moins une coordonnée est maintenant 0, les coordonnées précédentes: {0}, {1}"), dx, dy);
        }
    }
}