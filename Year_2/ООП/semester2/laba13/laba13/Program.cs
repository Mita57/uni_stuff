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
            //TODO
            abstract public bool Crossing { get; }
        }

      public class Point : Figure
      {
          public Point(int x, int y) : base(x, y)
          {
              
          }

          public override bool Crossing { get; }

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
      }

      public class Square : Figure
      {
          public Square(int x, int y, int side = 1) : base(x, y)
          {
              this.Side = side;
          }

          public int Side
          {
              get { return Side; }
              set
              {
                  if (value < 0)
                  {
                      return;
                  }
                  else
                  {
                      Side = value;
                  }
              }
          }

          public override double S
          {
              get { return (Side * Side); }
          }

          public override bool ZeroIn()
          {
              if (X <= 0 && Y <= 0 && X + Side > 0 && Y + Side > 0)
              {
                  return true;
              }

              return false;
          }

          public override string Dimensions()
          {
              return "L = " +  this.Side.ToString();
          }

          //TODO
          public override bool Crossing { get; }
      }

      public class Circle : Figure
      {
          public Circle(int x, int y) : base(x, y)
          {
          }

          public override double S
          {
              get { return 3.14 * R * R; }
          }

          public override bool ZeroIn()
          {
              throw new NotImplementedException();
          }

          public int R
          {
              get { return R; }; set
              {
                  if (value >= 0)
                  {
                      R = value;
                  }
              };
          }

          public override string Dimensions()
          {
              return "R = " + R;
          }

          public override bool Crossing { get; }
      }
        
            
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}