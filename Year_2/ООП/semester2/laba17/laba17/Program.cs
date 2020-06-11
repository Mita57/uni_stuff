using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            get { return this.points.Count; }
        }

        List<Point> points = new List<Point>();

        public Point this[int index]
        {
            get { return points[amount]; }
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
            catch (Exception ex)
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
        private static bool writeAtChange = false;
        private static bool axisForbidden = false;
        private static bool threeUnits = false;
        private static bool eightStuff = false;
        private static bool sameStuff = false;


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
                Console.WriteLine("(8):Basculer des restictions(toggle)");
                Console.WriteLine("(9):Imprimer des informations sur les points");
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
                        applyRestrictions();
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

        public static void applyRestrictions()
        {
            string input = "cock";
            while (true)
            {
                Console.WriteLine("Entrer les numeros des restrictions vous voulez appliquer");
                Console.WriteLine("(1):Chaque changement des points imprime les résultats");
                Console.WriteLine("(2):Interdire de placer des points sur l'axes");
                Console.WriteLine(
                    "(3):Si apres le changement des points il y a moins du trois unités entre eux , le point autre se deplace au cinq unites dans un côté aléatoire");
                Console.WriteLine("(4):Intredire les points depssser le (-8;x,y,+8) intervalle");
                Console.WriteLine("(5):Intredire les points avoir le mêmes x et y coordonners");
                Console.WriteLine("(9):Tous lmao");
                Console.WriteLine("(X):Annuler");
                input = Console.ReadLine();
                string[] inputsAr = input.Split(',');
                for (int i = 0; i < inputsAr.Length; i++)
                {
                    inputsAr[i] = inputsAr[i].Replace(" ", "");
                }

                string sas = "cock";
                foreach (string str in inputsAr)
                {
                    if (int.TryParse(str, out _))
                    {
                        switch (sas)
                        {
                            case "1":
                            {
                                writeAtChange = !writeAtChange;
                                break;
                            }
                            case "2":
                            {
                                axisForbidden = !axisForbidden;
                                break;
                            }
                            case "3":
                            {
                                threeUnits = !threeUnits;
                                break;
                            }
                            case "4":
                            {
                                eightStuff = !eightStuff;
                                break;
                            }
                            case "5":
                            {
                                sameStuff = !sameStuff;
                                break;
                            }
                            case "x":
                            {
                                return;
                            }
                            case "X":
                            {
                                return;
                            }
                        }
                    }
                }
            }
        }

        public static void reFrom()
        {
            Console.WriteLine("Si vous voulez annuler ca, entrer x");
            string ind1 = "cock";
            int i1 = 0;
            while (!int.TryParse(ind1, out i1))
            {
                Console.WriteLine("Entrer l'idnex du point 1");
                ind1 = Console.ReadLine();
                if (ind1 == "x" || ind1 == "X")
                {
                    return;
                }
            }

            string ind2 = "cock";
            int i2 = 0;
            while (!int.TryParse(ind2, out i2))
            {
                Console.WriteLine("Entrer l'idnex du point 2");
                ind2 = Console.ReadLine();
            }

            try
            {
                pts[i1].reFrom(pts[i2]);
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
                if (int.TryParse(xCon, out int sas))
                {
                    if (axisForbidden)
                    {
                        if (sas == 0)
                        {
                            Console.WriteLine("Le coordonner ne peux pas etre sur l'axe");
                            xCon = "cock";
                        }
                    }

                    if (eightStuff)
                    {
                        if (Math.Abs(sas) > 8)
                        {
                            Console.WriteLine("Le coordonner doit pas etre dans le (-8;x,y,+8) intervalle");
                            xCon = "cock";
                        }
                    }
                }
            }

            string yCon = "cock2";
            int y = 0;
            while (!int.TryParse(yCon, out y))
            {
                Console.WriteLine("Entrer le coordonner y");
                yCon = Console.ReadLine();
                if (int.TryParse(yCon, out int sas))
                {
                    if (axisForbidden)
                    {
                        if (sas == 0)
                        {
                            Console.WriteLine("Le coordonner ne peux pas etre sur l'axe");
                            yCon = "cock";
                        }
                    }

                    if (eightStuff)
                    {
                        if (Math.Abs(sas) > 8)
                        {
                            Console.WriteLine("Le coordonner doit pas etre dans le (-8;x,y,+8) intervalle");
                            yCon = "cock";
                        }
                    }

                    if (sameStuff)
                    {
                        if (xCon == yCon)
                        {
                            Console.WriteLine("les coordonnées ne peuvent pas être les mêmes");
                            yCon = "cock";
                        }
                    }

                    if (threeUnits)
                    {
                        Point po = new Point(x, y);
                        for (int i = 0; i < pts.amount; i++)
                        {
                            if (pts[i].reFrom(po) < 3)
                            {
                                Console.WriteLine("au moins le point est à moins de 3 points de l'autre");
                                yCon = "cock";
                            }
                        }
                    }
                }
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
                if (int.TryParse(xCon, out int sas))
                {
                    if (axisForbidden)
                    {
                        if (sas == 0)
                        {
                            Console.WriteLine("Le coordonner ne peux pas etre sur l'axe");
                            xCon = "cock";
                        }
                    }

                    if (eightStuff)
                    {
                        if (Math.Abs(sas) > 8)
                        {
                            Console.WriteLine("Le coordonner doit pas etre dans le (-8;x,y,+8) intervalle");
                            xCon = "cock";
                        }
                    }
                }
            }

            string yCon = "cock2";
            int y = 0;
            while (!int.TryParse(yCon, out y))
            {
                Console.WriteLine("Entrer le coordonner y");
                yCon = Console.ReadLine();
                if (int.TryParse(yCon, out int sas))
                {
                    if (axisForbidden)
                    {
                        if (sas == 0)
                        {
                            Console.WriteLine("Le coordonner ne peux pas etre sur l'axe");
                            yCon = "cock";
                        }
                    }

                    if (eightStuff)
                    {
                        if (Math.Abs(sas) > 8)
                        {
                            Console.WriteLine("Le coordonner doit pas etre dans le (-8;x,y,+8) intervalle");
                            yCon = "cock";
                        }
                    }

                    if (sameStuff)
                    {
                        if (xCon == yCon)
                        {
                            Console.WriteLine("les coordonnées ne peuvent pas être les mêmes");
                            yCon = "cock";
                        }
                    }

                    if (threeUnits)
                    {
                        Point po = new Point(x, y);
                        for (int ia = 0; ia < pts.amount; ia++)
                        {
                            if (pts[ia].reFrom(po) < 3)
                            {
                                Console.WriteLine("au moins le point est à moins de 3 points de l'autre");
                                long rand = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                                if (rand % 2 == 0)
                                {
                                    y += 5;
                                }
                                else
                                {
                                    y -= 5;
                                }
                            }
                        }
                    }
                }


                try
                {
                    pts[i].x = x;
                    pts[i].y = y;
                }
                catch
                {
                    Console.WriteLine("L'index se trouve en dehors du tableau");
                    yCon = "dwqd";
                }
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

            try
            {
                pts.Remove(i);
            }
            catch
            {
                Console.WriteLine("L'index se trouve en dehors du tableau");
                ind = "dsad";
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

                if (res == "N" || res == "n")
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
            Console.WriteLine(
                String.Format("Au moins une coordonnée est maintenant 0, les coordonnées précédentes: {0}, {1}"), dx,
                dy);
        }
    }
}