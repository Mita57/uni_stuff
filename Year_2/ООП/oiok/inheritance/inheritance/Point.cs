using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Point
    {
        protected double x;
        protected double y;

        public Point()
        {

        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(double dx, double dy)
        {
            x += dx;
            x += dy;
        }

        public string info()
        {
            return String.Format("Точка ({0,5:F1}, {1,5:F1})", x, y);
        }

        public void Simm()
        {
            this.x = -this.x;
            this.y = -this.y;
        }

        public double ReFrom(Point a)
        {
            return (Math.Round(Math.Sqrt(Math.Abs(this.x - a.x) + Math.Abs(this.y - a.y)), 2));
        }
    }
}
