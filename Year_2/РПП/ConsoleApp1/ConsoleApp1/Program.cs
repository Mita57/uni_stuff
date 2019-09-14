using System;

namespace ConsoleApp1
{



    class Circle
    {
        private int x;
        private int y;
        private int R;
        private double S;

        public string info()
        {
            return Convert.ToString(x+y+R+S);
        }

        public void simm()
        {
            this.x = -this.x;
            this.y = -this.y;
        }

        public Circle(int x, int y, int R)
        {
            this.x = x;
            this.y = y;
            this.R = R;
            getS();
        }
        public Circle()
        {

        }

        private void setS()
        {
            this.S = Math.PI * (R * R);
        }

        public double getS()
        {
            return this.S;
        }
        private void setX(int x)
        {
            this.x = x;
            setS();
        }

        private int getX()
        {
            return this.x;
        }

        private int getY()
        {
            return this.y;
        }
        
        private void setY(int Y)
        {
            this.y = Y;
            setS();
        }

        private void setR(int R)
        {
            this.R = R;
            setS();
        }

        private int getR(int R)
        {
            return this.R;
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
