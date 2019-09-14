using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите множество");
            string setString = Console.ReadLine();
            string[] setNotSorted = setString.Split(' ');
            string[] setSorted = new string[0];
            int sortCounter = 0; //removing all the duplicates
            for (int i = 0; i < setNotSorted.Length; i++)
            {
                if (!setSorted.Contains(setNotSorted[i]))
                {
                    Array.Resize(ref setSorted, setSorted.Length + 1);
                    setSorted[sortCounter] = setNotSorted[i];
                    sortCounter++;
                }
            }
            Console.WriteLine("Введите булеву матрицу");
            int[,] bitArray = new int[setSorted.Length, setSorted.Length];
            for (int i = 0; i < setSorted.Length; i++)
            {
                string inputRow = Console.ReadLine();
                string[] inputRowArray = inputRow.Split(' ');
                if (inputRowArray.Length == setSorted.Length)
                {
                    for (int j = 0; j < inputRowArray.Length; j++)
                    {
                        if (inputRowArray[j] == "0" || inputRowArray[j] == "1")
                        {
                            bitArray[i, j] = int.Parse(inputRowArray[j]);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Введена неправильная строка попробуйте снова");
                    i--;
                }
            }//output
            for(int i = 0; i<setSorted.Length; i++)
            {
                for(int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] == 1)
                    {
                        Console.WriteLine("(" + setSorted[i] + "; " + setSorted[j] +")");
                    }
                }
            }
            Console.ReadLine();
            Console.WriteLine();
            check1();
            Console.WriteLine();
            check2();
            Console.WriteLine();
            check3();
            Console.WriteLine();
            Console.ReadLine();
        }


        static void check1()
        {
            string[] setSorted = { "-8", "-2", "-1", "0", "1", "2", "8" };
            int[,] bitArray = { { 1, 0, 0, 0, 0, 0, 1 }, { 0, 1, 0, 0, 0, 1, 0 }, { 0, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 1, 0, 1, 0, 0 }, { 0, 1, 0, 0, 0, 1, 0 }, { 1, 0, 0, 0, 0, 0, 1 } };
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] == 1)
                    {
                        Console.WriteLine("(" + setSorted[i] + " ;" + setSorted[j] + ")");
                    }
                }
            }
        }

        static void check2()
        {
            string[] setSorted = { "1", "2", "3"};
            int[,] bitArray = { { 1, 1,1}, { 1, 1, 0}, {1, 0, 0}};
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] == 1)
                    {
                        Console.WriteLine("(" + setSorted[i] + " ;" + setSorted[j] + ")");
                    }
                }
            }
        }
        static void check3()
        {
            string[] setSorted = { "abab", "a", "ab", "b" };
            int[,] bitArray = { { 1, 0, 1, 0 }, { 0, 1, 0, 0 }, { 1, 0, 1, 0 }, {0, 0, 0 , 1 } };
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] == 1)
                    {
                        Console.WriteLine("(" + setSorted[i] + " ;" + setSorted[j] + ")");
                    }
                }
            }
        }
    }
}
