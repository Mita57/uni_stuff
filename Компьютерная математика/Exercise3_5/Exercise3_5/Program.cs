using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите элементы");
            string init = Console.ReadLine();
            string[] initSplit = init.Split(' ');
            try
            {
                int[] values = new int[initSplit.Length];
                int temp;
                for(int i =0; i < initSplit.Length; i++)
                {
                    values[i] = Convert.ToInt32(initSplit[i]); 
                }
                for(int i = 0; i< values.Length; i++)
                {
                    for(int j = 0; j < values.Length-1; j++)
                    {
                        if (values[j] > values[j + 1])
                        {
                            temp = values[j + 1];
                            values[j + 1] = values[j];
                            values[j] = temp;
                        }
                    }
                }
                foreach(int x in values)
                {
                    Console.Write(x +" ");
                }
            }
            catch
            {
                Console.WriteLine("Неправильно введены данные");
            }
            Console.ReadLine();
        }
    }
}
