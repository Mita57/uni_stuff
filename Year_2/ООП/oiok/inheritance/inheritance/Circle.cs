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

        }

        public string info()
        {
            return String.Format("Точка " + this.x + " " + this.y + " R:" + this.r);
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
    }
}
