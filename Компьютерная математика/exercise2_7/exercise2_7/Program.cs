using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2_7
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
            int[,] bitArray;
            Console.WriteLine("Выберите способ задания отношения: \n 1. Булева матрица \n 2. Множество пар ");
            if (Console.ReadLine() == "1")
            {
                bitArray=matrix(setSorted);
            }
            else 
            {
                bitArray=sets(setSorted);
            }
            bool checkReflex = true;
            for(int i = 0; i < setSorted.Length; i++)
            {
                for(int j = 0; j < setSorted.Length; j++)
                {
                    if (j == i && bitArray[j,i] != 1)
                    {
                        checkReflex = false;
                    }
                }
            }
            //рефлексивность
            if (checkReflex) Console.WriteLine("Отношение рефлексивно");
            else Console.WriteLine("Отношение не рефлексивно");

        }


        static int[,] matrix(string[] set)
        {
            int[,] bitArray = new int[set.Length, set.Length];
            Console.WriteLine("Введите булеву матрицу");
            for (int i = 0; i < set.Length; i++)
            {
                string input = Console.ReadLine();
                string[] inputArr = input.Split(' ');
                for (int j = 0; j < set.Length; j++)
                {
                    bitArray[i, j] = int.Parse(inputArr[j]);
                }
            }
            return bitArray;
        }




        static int[,] sets(string[] set)
        {
            int [,]bitArray = new int[set.Length, set.Length];
            for(int i =0; i < set.Length; i++)
            {
                for(int j = 0; j < set.Length; j++)
                {
                    bitArray[i, j] = 0;
                }
            }
            Console.WriteLine("Введите пары элементов, образующие отношения");
            string relationString = Console.ReadLine();
            string[] relationElements = relationString.Split(',');
            for (int i = 0; i < relationElements.Length; i++)
            {
                relationElements[i] = relationElements[i].Replace(",", "");
                relationElements[i] = relationElements[i].Replace(" ", "");
                relationElements[i] = relationElements[i].Replace("(", "");
                relationElements[i] = relationElements[i].Replace(")", "");
                string[] RES = relationElements[i].Split(';');
                bool flag = false;
                foreach (string X in RES)
                {
                    if (set.Contains(X) == false)
                    {
                        Console.WriteLine("Неправильно введены данные");
                        flag = false;
                        break;
                    }
                    else flag = true;
                }
                if (flag == true)
                {
                    for (int k = 0; k < set.Length; k++)
                    {
                        for (int j = 0; j < set.Length; j++)
                        {
                            if (set[k] == RES[0] && set[j] == RES[1])
                            {
                                bitArray[k, j] = 1;
                            }
                            if (set[k] == RES[1] && set[j] == RES[0])
                            {
                                bitArray[k, j] = 1;
                            }
                        }
                    }
                }

            }
            return bitArray;
        }
        //end of sets



    }
}
