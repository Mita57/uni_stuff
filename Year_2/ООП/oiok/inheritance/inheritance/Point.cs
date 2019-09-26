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
            return String.Format("Точка "+ this.x + " " + this.y);
        }
    }
}
