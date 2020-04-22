using System;
using System.Globalization;
using System.Reflection;

namespace laba13
{
    public abstract class Figure
    {
        public int X
        {
            get { return X; }

            set
            {
                if (Math.Abs(value) > 8)
                {
                    X = value;
                }
                else
                {
                    return;
                }
            }
        }

        public int Y
        {
            get { return Y; }

            set
            {
                if (Math.Abs(value) > 8)
                {
                    Y = value;
                }
                else
                {
                    return;
                }
            }
        }

        abstract public double S { get; }

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

        public int A
        {
            get { return A; }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    A = value;
                }
            }
        }

        public override double S
        {
            get { return (A * A); }
        }

        public override bool ZeroIn()
        {
            if (X <= 0 && Y <= 0 && X + A > 0 && Y + A > 0)
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
                     && (anotherFigure.Y >= Y - A / 2) && (anotherFigure.X >= X - A / 2);
            }
            else if (anotherFigure is Circle)
            {
                Circle circle = (Circle) anotherFigure;
                return (circle.Y - circle.R <= Y + A / 2) && (circle.Y + circle.R >= Y - A / 2)
                    && (circle.X - circle.R <= X + A / 2) && (circle.X + circle.R >= X - A / 2);
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
        }

        public override bool ZeroIn()
        {
            return Math.Pow(X, 2) + Math.Pow(Y, 2) <= R;
        }

        public int R
        {
            get { return R; }
            set
            {
                if (value >= 0)
                {
                    R = value;
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


    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}