using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public abstract class Figure
    {
        private int _x;

        public int X
        {
            get { return _x; }
            set
            {
                if (Math.Abs(value) <= 8)
                {
                    _x = value;
                }
            }
        }

        private int _y;

        public int Y
        {
            get { return _y; }

            set
            {
                if (Math.Abs(value) <= 8)
                {
                    _y = value;
                }
            }
        }

        abstract public double S { get; set; }

        public void MoveTo(int x, int y)
        {
            if (Math.Abs(x) > 8 || Math.Abs(y) > 8)
            {
                return;
            }
            else
            {
                this.X = x;
                this.Y = y;
            }
        }

        public void MoveRef(int dX, int dY)
        {
            if (Math.Abs(X + dX) > 8 || Math.Abs(Y + dY) > 8)
            {
                return;
            }
            else
            {
                this.X += dX;
                this.Y += dY;
            }
        }

        public bool Equal(Figure fig)
        {
            if (this.S == fig.S && this.GetType().Name == fig.GetType().Name)
            {
                return true;
            }

            return false;
        }

        abstract public bool ZeroIn();

        abstract public string Dimensions();

        public override string ToString()
        {
            return this.GetType().Name + "; Mid:" + X + ", " + Y + "; Dims: " + Dimensions() + "; S=" + S +
                   "; ZeroIn:" + ZeroIn();
        }

        public Figure(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //TODO
        abstract public bool Crossing(Figure anotherFigure);
    }

    public class Point : Figure
    {
        public Point(int x, int y) : base(x, y)
        {
        }


        public override bool ZeroIn()
        {
            if (X == 0 && Y == 0)
            {
                return true;
            }

            return false;
        }

        public override string Dimensions()
        {
            return "";
        }

        public override double S
        {
            get { return 0; }
            set{return;}
        }

        public override bool Crossing(Figure anotherFigure)
        {
            if (anotherFigure.GetType() != this.GetType())
            {
                return anotherFigure.Crossing(this);
            }
            else
            {
                return (X == anotherFigure.X) && (Y == anotherFigure.Y);
            }
        }
    }

    public class Square : Figure
    {
        public Square(int x, int y, int side = 1) : base(x, y)
        {
            this.A = side;
        }

        private double _A;

        public double A
        {
            get { return _A; }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _A = value;
            }
        }

        public override double S
        {
            get { return (A * A); }
            set
            {
                this.A = Math.Sqrt(value);
            }
        }

        public override bool ZeroIn()
        {
            if (X / 2 <= 0 && Y / 2 <= 0 && (X + A) / 2 > 0 && (Y + A) / 2 > 0)
            {
                return true;
            }

            return false;
        }

        public override string Dimensions()
        {
            return "L = " + this.A.ToString();
        }

        //TODO
        public override bool Crossing(Figure anotherFigure)
        {
            if (anotherFigure is Point)
            {
                return (anotherFigure.Y <= Y + A / 2) && (anotherFigure.X <= X + A / 2)
                                                      && (anotherFigure.Y >= Y - A / 2) &&
                                                      (anotherFigure.X >= X - A / 2);
            }
            else if (anotherFigure is Circle)
            {
                Circle circle = (Circle) anotherFigure;
                return (circle.Y - circle.R <= Y + A / 2) && (circle.Y + circle.R >= Y - A / 2)
                                                          && (circle.X - circle.R <= X + A / 2) &&
                                                          (circle.X + circle.R >= X - A / 2);
            }
            else if (anotherFigure is Square)
            {
                Square square = (Square) anotherFigure;
                double R1 = X + A / 2;
                double R2 = square.X + square.A / 2;
                double L1 = X - A / 2;
                double L2 = square.X - square.A / 2;
                double T1 = Y + A / 2;
                double T2 = square.Y + square.A / 2;
                double B1 = Y - A / 2;
                double B2 = square.Y - square.A / 2;
                return !(T1 < T2 || B1 > T2 || B1 < L2 || L1 > B2);
            }

            return false;
        }
    }

    public class Circle : Figure
    {
        public Circle(int x, int y, int r) : base(x, y)
        {
            this.R = r;
        }

        public override double S
        {
            get { return 3.14 * R * R; }
            set
            {
                this.R = Math.Sqrt(value / Math.PI);
            }
        }

        public override bool ZeroIn()
        {
            return (Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2))) <= R;
        }

        private double _r;

        public double R
        {
            get { return _r; }
            set
            {
                if (value >= 0)
                {
                    _r = value;
                }
            }
        }

        public override string Dimensions()
        {
            return "R = " + R;
        }

        public override bool Crossing(Figure anotherFigure)
        {
            if (anotherFigure is Point)
            {
                return Math.Sqrt(Math.Pow(anotherFigure.X - X, 2) + Math.Pow(anotherFigure.Y - Y, 2)) <= R;
            }
            else if (anotherFigure is Circle)
            {
                Circle circle = (Circle) anotherFigure;
                return Math.Sqrt(Math.Pow(circle.X - X, 2) + Math.Pow(circle.Y - Y, 2)) - (this.R + circle.R) <= 0;
            }
            else
            {
                return this.Crossing(this);
            }
        }
    }
}