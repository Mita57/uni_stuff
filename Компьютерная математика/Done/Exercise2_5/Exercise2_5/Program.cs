using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_5
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
            bool[,] bitArray = new bool[setSorted.Length, setSorted.Length]; // a bitarray is created 
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    bitArray[i, j] = false; //setting all bitarray valuse to false
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
                    if (setSorted.Contains(X) == false)
                    {
                        Console.WriteLine("Неправильно введены данные");
                        flag = false;
                        break;
                    }
                    else flag = true;
                }
                if (flag == true)
                {
                    for (int k = 0; k < setSorted.Length; k++)
                    {
                        for (int j = 0; j < setSorted.Length; j++)
                        {
                            if (setSorted[k] == RES[0] && setSorted[j] == RES[1])
                            {
                                bitArray[k, j] = true;
                            }
                            if (setSorted[k] == RES[1] && setSorted[j] == RES[0])
                            {
                                bitArray[k, j] = true;
                            }
                        }
                    }
                }

            }
            //writing the elements on Ox
            foreach (string x in setSorted)
            {
                Console.Write(x.PadLeft(10, ' '));
            }
            for (int i = 0; i < setSorted.Length; i++)
            {
                Console.WriteLine();
                Console.Write(setSorted[i]); //writing the elements on Oy
                for (int j = 0; j < setSorted.Length; j++)
                {
                    Console.Write((Convert.ToString(bitArray[i, j]) + " ").PadLeft(10, ' '));
                }

            }
            Console.ReadLine();
            check1();
            Console.WriteLine();
            check2();
            Console.WriteLine();
            check3();
            Console.ReadLine();
        }





        static void check1()
        {
            string[] setSorted = { "-8", "-2", "-1", "0", "1", "2", "8" };
            bool[,] bitArray = new bool[setSorted.Length, setSorted.Length]; // a bitarray is created 
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    bitArray[i, j] = false; //setting all bitarray valuse to false
                }
            }
            string[] relationElements = { "(-8;8)", "(-2;2)", "(-1;1)", "(-8;-8)", "(-2;-2)", "(-1;-1)", "(0;0)", "(1;1)", "(2;2)", "(8;8)", "(1;-1)", "(8;-8)", "(2;-2)", };
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
                    if (setSorted.Contains(X) == false)
                    {
                        Console.WriteLine("Неправильно введены данные");
                        flag = false;
                        break;
                    }
                    else flag = true;
                }
                if (flag == true)
                {
                    for (int k = 0; k < setSorted.Length; k++)
                    {
                        for (int j = 0; j < setSorted.Length; j++)
                        {
                            if (setSorted[k] == RES[0] && setSorted[j] == RES[1])
                            {
                                bitArray[k, j] = true;
                            }
                            if (setSorted[k] == RES[1] && setSorted[j] == RES[0])
                            {
                                bitArray[k, j] = true;
                            }
                        }
                    }
                }

            }
            foreach (string x in setSorted)
            {
                Console.Write(x.PadLeft(10, ' '));
            }
            Console.WriteLine();
            for (int i = 0; i < setSorted.Length; i++)
            {
                Console.WriteLine();
                Console.Write(setSorted[i]);
                for (int j = 0; j < setSorted.Length; j++)
                {
                    Console.Write((Convert.ToString(bitArray[i, j]) + " ").PadLeft(10, ' '));
                }

            }
            Console.ReadLine();
        }





        static void check2()
        {
            string[] setSorted = { "1", "2", "3" };
            bool[,] bitArray = new bool[setSorted.Length, setSorted.Length]; // a bitarray is created 
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    bitArray[i, j] = false; //setting all bitarray valuse to false
                }
            }
            string[] relationElements = { "(1;1)", "(2;2)", "(1;2)", "(2;1)", "(1;3)", "(3;1)" };
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
                    if (setSorted.Contains(X) == false)
                    {
                        Console.WriteLine("Неправильно введены данные");
                        flag = false;
                        break;
                    }
                    else flag = true;
                }
                if (flag == true)
                {
                    for (int k = 0; k < setSorted.Length; k++)
                    {
                        for (int j = 0; j < setSorted.Length; j++)
                        {
                            if (setSorted[k] == RES[0] && setSorted[j] == RES[1])
                            {
                                bitArray[k, j] = true;
                            }
                            if (setSorted[k] == RES[1] && setSorted[j] == RES[0])
                            {
                                bitArray[k, j] = true;
                            }
                        }
                    }
                }

            }
            foreach (string x in setSorted)
            {
                Console.Write(x.PadLeft(10, ' '));
            }
            Console.WriteLine();
            for (int i = 0; i < setSorted.Length; i++)
            {
                Console.WriteLine();
                Console.Write(setSorted[i]);
                for (int j = 0; j < setSorted.Length; j++)
                {
                    Console.Write((Convert.ToString(bitArray[i, j]) + " ").PadLeft(10, ' '));
                }

            }
            Console.ReadLine();
        }



        static void check3()
        {
            string[] setSorted = { "abab", "a", "ab", "b" };
            bool[,] bitArray = new bool[setSorted.Length, setSorted.Length]; // a bitarray is created 
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    bitArray[i, j] = false; //setting all bitarray valuse to false
                }
            }
            string[] relationElements = { "(abab;abab)", "(a;a)", "(ab;ab)", "(b;b)", "(abab;ab)", "(ab;abab)"};
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
                    if (setSorted.Contains(X) == false)
                    {
                        Console.WriteLine("Неправильно введены данные");
                        flag = false;
                        break;
                    }
                    else flag = true;
                }
                if (flag == true)
                {
                    for (int k = 0; k < setSorted.Length; k++)
                    {
                        for (int j = 0; j < setSorted.Length; j++)
                        {
                            if (setSorted[k] == RES[0] && setSorted[j] == RES[1])
                            {
                                bitArray[k, j] = true;
                            }
                            if (setSorted[k] == RES[1] && setSorted[j] == RES[0])
                            {
                                bitArray[k, j] = true;
                            }
                        }
                    }
                }

            }Console.Write("         ");
            foreach (string x in setSorted)
            {
                Console.Write(x.PadLeft(10, ' '));
            }
            Console.WriteLine();
            for (int i = 0; i < setSorted.Length; i++)
            {
                Console.WriteLine();
                Console.Write((Convert.ToString(setSorted[i]) + " ").PadLeft(10, ' '));
                for (int j = 0; j < setSorted.Length; j++)
                {
                    Console.Write((Convert.ToString(bitArray[i, j]) + " ").PadLeft(10, ' '));
                }

            }
            Console.ReadLine();
        }

    }
}