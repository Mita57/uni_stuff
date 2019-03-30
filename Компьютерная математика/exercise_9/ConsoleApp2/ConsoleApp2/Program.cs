using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    char[] diver = { ' ', ',' };
                    Console.WriteLine("Введите множество");
                m1:
                    string input = Console.ReadLine();
                    string[] elements = input.Split(diver);
                    int[] parsed_elements = new int[elements.Length];
                    int count = 0;
                    try
                    {
                        for (int i = 0; i < elements.Length; i++)
                        {
                            parsed_elements[i] = int.Parse(elements[i]);
                            count++;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Введены неверные данные, пожалуйста повторите ввод");
                        goto m1;
                    }
                    int N = parsed_elements.Length;
                    int[] arr = new int[N];

                    int k = Convert.ToInt32(Math.Pow(2, Convert.ToDouble(N)));
                    string[] combs = new string[k];

                    for (int i = 0; i < combs.Length; i++)
                    {
                        combs[i] = Convert.ToString(i, 2);
                        combs[i] = combs[i].PadLeft(N, '0');
                    };
                    for (int i = 0; i < combs.Length; i++)
                    {

                        char[] a = combs[i].ToCharArray();
                        if (a.Contains('1') == false) Console.WriteLine("{0}");
                        for (int j = 0; j < a.Length; j++)
                        {
                            if (a[j] == '1') Console.Write(arr[j] + " ");
                        }
                        if (a.Contains('1')) Console.WriteLine();
                    }
                }
            }
        }
    }
}
