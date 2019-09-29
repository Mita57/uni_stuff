using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Circle:Point
    {
        protected double r;

        public Circle(double x, double y, double r) : base(x, y)
        {
            if (r < 0)
            {
                r = 1;
            }
                this.r = r;
        }

        public Circle()
        {
            this.r = 1;
        }

        public new string info()
        {
            return String.Format("Круг ({0,5:F1}, {1,5:F1}), R = {2,5:F1}", x, y, r);
        }

        public void SetSquare(double value)
        {
            if (value > 0)
            {
                r = Math.Sqrt(value/Math.PI);
            }
        }

        public double GetSquare()
        {
            return Math.PI * r * r;
        }
        public new double ReFrom(Point a)
        {
            return (Math.Round(Math.Sqrt(Math.Abs(this.x - a.x) + Math.Abs(this.y - a.y)), 2))-r;
        }
    }
}
