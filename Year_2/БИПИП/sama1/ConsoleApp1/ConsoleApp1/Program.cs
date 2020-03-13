using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] argss)
        {
            int partitionAmount = 0;
            Console.WriteLine("Количество разбиений: ");
            partitionAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество потоков: ");
            int threadsAmount = 0;
            threadsAmount = int.Parse(Console.ReadLine());
            int partition = partitionAmount / threadsAmount;
            double[] args = new double[partitionAmount];
            args[0] = 0;
            for(int i = 1; i < args.Length; i++)
            {
                args[i] = args[i - 1] + partition;
            }
            double result = 0;
            double[] vals = new double[partition];
            for(int i = 0; i < vals.Length; i++)
            {
                vals[i] = args[i] * args[i];
            }

            int start = 0;
            for(int i = 0; i < threadsAmount; i++)
            {
                Thread t = new Thread(() => result += rectangleMethod(vals, partition, start, start + partition));
                t.Start();
                t.Join();
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static double rectangleMethod(double[] vals, int partition, int begin, int end)
        {
            double value = 0;
            for (int i = begin; i < end -1; i++)
            {
                value += vals[i] * 1 / partition;
            }
            begin += partition;
            return value;
        }
    }
}
