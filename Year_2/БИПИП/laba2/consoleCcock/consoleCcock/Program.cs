using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleCcock
{
    class Program
    {
        static void Main(string[] argss)
        {
            double[] args = new double[21];
            args[0] = 1;
            for(int i = 1; i < args.Length; i++)
            {
                args[i] = args[i - 1] + 0.05;
            }
            double[] vals = new double[21];
            for(int i = 0; i < vals.Length; i++)
            {
                vals[i] = fun(args[i]);
            }

            Console.WriteLine("Трапеции" + trapeezeMethod(vals));
            Console.WriteLine("Прямоугольник" + rectangleMethod(vals));
            Console.ReadKey();
        }

        static double fun(double x)
        {
            return (x * x) / (x + 2);
        }

        static double trapeezeMethod(double[] vals)
        {
            double value = 0;
            for(int i = 1; i < vals.Length; i++)
            {
                value += ((vals[i - 1] + vals[i]) / 2) * 0.05;
            }
            return value;
        }

        static double rectangleMethod(double[] vals)
        {
            double value = 0;
            for(int i = 0; i < vals.Length; i++)
            {
                value += vals[i] * 0.05;
            }
            return value;
        }
    }
}
