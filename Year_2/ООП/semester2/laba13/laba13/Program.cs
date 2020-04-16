using System;

namespace laba13
{
    internal class Program
    {
        abstract class Figure
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

            public double S;

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
        }
        
        


        public static void Main(string[] args)
        {
        }
    }
}