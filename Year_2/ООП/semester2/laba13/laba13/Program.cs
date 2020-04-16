using System;
using System.Globalization;

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

            abstract public double S { get;}

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
                return this.GetType().Name +"; Mid:" + X + ", " + Y +  "; Dims: " + Dimensions() + "; S=" + S + "; ZeroIn:" + ZeroIn();
            }

            public Figure(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }

      public class Point : Figure
      {
          public Point(int x, int y) : base(x, y)
          {
              
          }
          
          public override bool ZeroIn()
          {
              if (x == 0 && y == 0)
              {
                  return true;
              }

              return false;
          }

          public override string Dimensions()
          {
              throw new NotImplementedException();
          }

          public override double S
          {
              get { return 0; }
          }
      }
        
            
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}