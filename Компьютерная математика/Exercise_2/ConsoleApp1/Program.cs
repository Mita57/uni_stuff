using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   char[] diver = { ' ', ',' };
            Console.WriteLine("Введите множество");
            m1:
            string input = Console.ReadLine();
            string[] elements = input.Split(diver);
            int [] parsed_elements = new int [0];
            int count = 0;
            try
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    if (parsed_elements.Contains(Convert.ToInt32(elements[i])))
                    {
                        Console.WriteLine("Элемент " + elements[i] + " повторяется");
                        continue;
                    }
                    else
                    {
                        Array.Resize(ref parsed_elements, parsed_elements.Length + 1);
                        parsed_elements[count] = int.Parse(elements[i]);
                        count++;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Введены неверные данные, пожалуйста повторите ввод");
                goto m1;
            }
            int N = parsed_elements.Length;
            int[] arr = new int[N];

            int N1 = Convert.ToInt32(Math.Pow(2, Convert.ToDouble(N)) - 1);
            string[] combs= new string[N1];


            for (int i=0;i<combs.Length; i++)
            {
                combs[i] = Convert.ToString(i, 2);  
                combs[i]=combs[i].PadLeft(N, '0');
            }

            for (int i=0; i < combs.Length; i++)
            {
                char[] ara = combs[i].ToCharArray();
                for (int j = 0; j < ara.Length; j++)
                {
                    if (ara[j] == '1') Console.Write(parsed_elements[j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
