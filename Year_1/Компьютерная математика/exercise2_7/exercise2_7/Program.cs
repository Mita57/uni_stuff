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
                bitArray = matrix(setSorted); //returns bitarray
            }
            else
            {
                bitArray = sets(setSorted); //actually both return bitarray
            }
            //рефлексивность
            bool checkReflex = true; //only if the D contains "1" only
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (j == i && bitArray[j, i] != 1)
                    {
                        checkReflex = false;
                        break;
                    }
                }
            }
            if (checkReflex) Console.WriteLine("Отношение рефлексивно");
            else Console.WriteLine("Отношение не рефлексивно");
            //антирефлексивность
            bool checkAntiReflex = true; //onlu if the D contains "0" only
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (j == i && bitArray[i, j] != 0)
                    {
                        checkAntiReflex = false;
                        break;
                    }
                }
            }
            if (checkAntiReflex)
            {
                Console.WriteLine("Отошение антисимметрично");
            }
            else
            {
                Console.WriteLine("Отношение не антисимметричное");
            }
            // симметричность 
            bool checkSymmetry = true;
            for (int i = 0; i < setSorted.Length; i++)// only if the elements relative to D are simmilar
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] != bitArray[setSorted.Length - i, setSorted.Length - j])
                    {
                        checkSymmetry = false;
                        break;
                    }
                }
            }
            if (checkSymmetry)
            {
                Console.WriteLine("Отношение симметрично");
            }
            else
            {
                Console.WriteLine("Отношение симметрично");
            }
            //антисимметрия 
            bool checkAntiSymmetry = true;
            for (int i = 0; i < setSorted.Length; i++)//only if the elements relative to D are different
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] == bitArray[setSorted.Length - i, setSorted.Length - j])
                    {
                        checkAntiSymmetry = false;
                        break;
                    }
                }
            }
            if (checkAntiSymmetry)
            {
                Console.WriteLine("Отношение антисимметрично");
            }
            else
            {
                Console.WriteLine("Отношение не антисимметрично");
            }
            //транзитивность перемножениие на саму себя должно давать изначальную матрицу так же антирефлексивность
            bool checkTransitive = true; //there should be at least 3 "1" in each columns and rows
            for (int i = 0; i < setSorted.Length; i++)
            {
                int counter = 0;
                int columnCounter = 0;
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] == 1)
                    {
                        counter++;
                    }
                    if (bitArray[j, i] == 1)
                    {
                        columnCounter++;
                    }
                }
                if (counter < 3 || columnCounter < 3)
                {
                    checkTransitive = false;
                    break;
                }
            }
            if (checkTransitive)
            {
                Console.WriteLine("Отношение тразитивно");
            }
            else
            {
                Console.WriteLine("Отношение не транзитивно");
            }
            //полнота
            bool checkFull = true; // only if the element is in the relation with anything except for itself
            for (int i = 0; i < setSorted.Length; i++)
            {
                int counterFull = 0;
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] == 1 && i != j)
                    {
                        counterFull++;
                    }
                }
                if (counterFull == 0)
                {
                    checkFull = false;
                    break;
                }
                if (!checkFull)
                {
                    break;
                }
            }
            if (checkFull)
            {
                Console.WriteLine("Отношение полное");
            }
            else
            {
                Console.WriteLine("Отношение не полное");
            }
            //Эквивалентность
            if (checkSymmetry && checkTransitive && checkReflex)
            {
                Console.WriteLine("Отношение эквивалентно");
            }
            //частичный порядок
            if (checkReflex && checkAntiSymmetry && checkTransitive)
            {
                Console.WriteLine("Отношение частично упорядочено");
            }
            //линейный порядок
            bool linearOrder = true;// i,j and j,i must be different, like Xor
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] == bitArray[j, i])
                    {
                        linearOrder = false;
                        break;
                    }
                    if (!linearOrder)
                    {
                        break;
                    }
                }
            }
            //полный порядок
            bool fullOrder = false;
            //полнота транзитивность антисимметричность
            if (linearOrder&&checkTransitive&&checkFull&&checkAntiSymmetry)
            {
                fullOrder = true;   
            }
            if (fullOrder)
            {
                Console.WriteLine("Отношение полностью упорядочено");
            }
            Console.ReadLine();
            check1();
            Console.WriteLine();
            check2();
            Console.WriteLine();
            check3();
        }

        //проверка1
        static void check1()
        {
            string[] setSorted = { "-8", "-2", "-1", "0", "1", "2", "8" };
            int[,] bitArray = { { 1, 0, 0, 0, 0, 0, 1 }, { 0, 1, 0, 0, 0, 1, 0 }, { 0, 0, 1, 0, 1, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 1, 0, 1, 0, 0 }, { 0, 1, 0, 0, 0, 1, 0 }, { 1, 0, 0, 0, 0, 0, 1 } };
            bool checkReflex = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (j == i && bitArray[j, i] != 1)
                    {
                        checkReflex = false;
                        break;
                    }
                }
            }
            //рефлексивность
            if (checkReflex) Console.WriteLine("Отношение рефлексивно");
            else Console.WriteLine("Отношение не рефлексивно");
            //антирефлексивность
            bool checkAntiReflex = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (j == i && bitArray[i, j] != 0)
                    {
                        checkAntiReflex = false;
                        break;
                    }
                }
            }
            if (checkAntiReflex)
            {
                Console.WriteLine("Отошение антисимметрично");
            }
            else
            {
                Console.WriteLine("Отношение не антисимметричное");
            }
            // симметричность
            bool checkSymmetry = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] != bitArray[setSorted.Length - i, setSorted.Length - j])
                    {
                        checkSymmetry = false;
                        break;
                    }
                }
            }
            if (checkSymmetry)
            {
                Console.WriteLine("Отношение симметрично");
            }
            else
            {
                Console.WriteLine("Отношение симметрично");
            }
            //антисимметрия
            bool checkAntiSymmetry = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] == bitArray[setSorted.Length - i, setSorted.Length - j])
                    {
                        checkAntiSymmetry = false;
                        break;
                    }
                }
            }
            if (checkAntiSymmetry)
            {
                Console.WriteLine("Отношение антисимметрично");
            }
            else
            {
                Console.WriteLine("Отношение не антисимметрично");
            }
            //транзитивность
            bool checkTransitive = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                int counter = 0;
                int columnCounter = 0;
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] == 1)
                    {
                        counter++;
                    }
                    if (bitArray[j, i] == 1)
                    {
                        columnCounter++;
                    }
                }
                if (counter < 3 || columnCounter < 3)
                {
                    checkTransitive = false;
                    break;
                }
            }
            if (checkTransitive)
            {
                Console.WriteLine("Отношение тразитивно");
            }
            else
            {
                Console.WriteLine("Отношение не транзитивно");
            }
            //полнота
            bool checkFull = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                int counterFull = 0;
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] == 1 && i != j)
                    {
                        counterFull++;
                    }
                }
                if (counterFull == 0)
                {
                    checkFull = false;
                    break;
                }
                if (!checkFull)
                {
                    break;
                }
            }
            if (checkFull)
            {
                Console.WriteLine("Отношение полное");
            }
            else
            {
                Console.WriteLine("Отношение не полное");
            }
            //Эквивалентность
            if (checkSymmetry && checkTransitive && checkReflex)
            {
                Console.WriteLine("Отношение эквивалентно");
            }
            //частичный порядок
            if (checkReflex && checkAntiSymmetry && checkTransitive)
            {
                Console.WriteLine("Отношение частично упорядочено");
            }
            //линейный порядок
            bool linearOrder = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] == bitArray[j, i])
                    {
                        linearOrder = false;
                        break;
                    }
                    if (!linearOrder)
                    {
                        break;
                    }
                }
            }
            //полный порядок
            bool fullOrder = false;
            //полнота транзитивность антисимметричность
            if (linearOrder && checkTransitive && checkFull && checkAntiSymmetry)
            {
                fullOrder = true;

            }
            if (fullOrder)
            {
                Console.WriteLine("Отношение полностью упорядочено");
            }
        }

            //check2




            static void check2()
        {
            string[] setSorted = { "1", "2", "3" };
            int[,] bitArray = { { 1, 1, 1 }, {1,1,0}, {1,0,0} };
            bool checkReflex = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (j == i && bitArray[j, i] != 1)
                    {
                        checkReflex = false;
                        break;
                    }
                }
            }
            //рефлексивность
            if (checkReflex) Console.WriteLine("Отношение рефлексивно");
            else Console.WriteLine("Отношение не рефлексивно");
            //антирефлексивность
            bool checkAntiReflex = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (j == i && bitArray[i, j] != 0)
                    {
                        checkAntiReflex = false;
                        break;
                    }
                }
            }
            if (checkAntiReflex)
            {
                Console.WriteLine("Отошение антисимметрично");
            }
            else
            {
                Console.WriteLine("Отношение не антисимметричное");
            }
            // симметричность
            bool checkSymmetry = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] != bitArray[setSorted.Length - i, setSorted.Length - j])
                    {
                        checkSymmetry = false;
                        break;
                    }
                }
            }
            if (checkSymmetry)
            {
                Console.WriteLine("Отношение симметрично");
            }
            else
            {
                Console.WriteLine("Отношение симметрично");
            }
            //антисимметрия
            bool checkAntiSymmetry = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] == bitArray[setSorted.Length - i, setSorted.Length - j])
                    {
                        checkAntiSymmetry = false;
                        break;
                    }
                }
            }
            if (checkAntiSymmetry)
            {
                Console.WriteLine("Отношение антисимметрично");
            }
            else
            {
                Console.WriteLine("Отношение не антисимметрично");
            }
            //транзитивность
            bool checkTransitive = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                int counter = 0;
                int columnCounter = 0;
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] == 1)
                    {
                        counter++;
                    }
                    if (bitArray[j, i] == 1)
                    {
                        columnCounter++;
                    }
                }
                if (counter < 3 || columnCounter < 3)
                {
                    checkTransitive = false;
                    break;
                }
            }
            if (checkTransitive)
            {
                Console.WriteLine("Отношение тразитивно");
            }
            else
            {
                Console.WriteLine("Отношение не транзитивно");
            }
            //полнота
            bool checkFull = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                int counterFull = 0;
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] == 1 && i != j)
                    {
                        counterFull++;
                    }
                }
                if (counterFull == 0)
                {
                    checkFull = false;
                    break;
                }
                if (!checkFull)
                {
                    break;
                }
            }
            if (checkFull)
            {
                Console.WriteLine("Отношение полное");
            }
            else
            {
                Console.WriteLine("Отношение не полное");
            }
            //Эквивалентность
            if (checkSymmetry && checkTransitive && checkReflex)
            {
                Console.WriteLine("Отношение эквивалентно");
            }
            //частичный порядок
            if (checkReflex && checkAntiSymmetry && checkTransitive)
            {
                Console.WriteLine("Отношение частично упорядочено");
            }
            //линейный порядок
            bool linearOrder = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] == bitArray[j, i])
                    {
                        linearOrder = false;
                        break;
                    }
                    if (!linearOrder)
                    {
                        break;
                    }
                }
            }
            //полный порядок
            bool fullOrder = false;
            //полнота транзитивность антисимметричность
            if (linearOrder && checkTransitive && checkFull && checkAntiSymmetry)
            {
                fullOrder = true;

            }
            if (fullOrder)
            {
                Console.WriteLine("Отношение полностью упорядочено");
            }
        }



        //check3

        static void check3()
        {
            string[] setSorted = { "abab", "a", "ab" };
            int[,] bitArray = { { 1, 0,1,0}, { 0, 1, 0, 0}, { 1, 0, 1, 0}, { 0, 0, 0, 1}};
            bool checkReflex = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (j == i && bitArray[j, i] != 1)
                    {
                        checkReflex = false;
                        break;
                    }
                }
            }
            //рефлексивность
            if (checkReflex) Console.WriteLine("Отношение рефлексивно");
            else Console.WriteLine("Отношение не рефлексивно");
            //антирефлексивность
            bool checkAntiReflex = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (j == i && bitArray[i, j] != 0)
                    {
                        checkAntiReflex = false;
                        break;
                    }
                }
            }
            if (checkAntiReflex)
            {
                Console.WriteLine("Отошение антисимметрично");
            }
            else
            {
                Console.WriteLine("Отношение не антисимметричное");
            }
            // симметричность
            bool checkSymmetry = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] != bitArray[setSorted.Length - i, setSorted.Length - j])
                    {
                        checkSymmetry = false;
                        break;
                    }
                }
            }
            if (checkSymmetry)
            {
                Console.WriteLine("Отношение симметрично");
            }
            else
            {
                Console.WriteLine("Отношение симметрично");
            }
            //антисимметрия
            bool checkAntiSymmetry = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] == bitArray[setSorted.Length - i, setSorted.Length - j])
                    {
                        checkAntiSymmetry = false;
                        break;
                    }
                }
            }
            if (checkAntiSymmetry)
            {
                Console.WriteLine("Отношение антисимметрично");
            }
            else
            {
                Console.WriteLine("Отношение не антисимметрично");
            }
            //транзитивность
            bool checkTransitive = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                int counter = 0;
                int columnCounter = 0;
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] == 1)
                    {
                        counter++;
                    }
                    if (bitArray[j, i] == 1)
                    {
                        columnCounter++;
                    }
                }
                if (counter < 3 || columnCounter < 3)
                {
                    checkTransitive = false;
                    break;
                }
            }
            if (checkTransitive)
            {
                Console.WriteLine("Отношение тразитивно");
            }
            else
            {
                Console.WriteLine("Отношение не транзитивно");
            }
            //полнота
            bool checkFull = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                int counterFull = 0;
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] == 1 && i != j)
                    {
                        counterFull++;
                    }
                }
                if (counterFull == 0)
                {
                    checkFull = false;
                    break;
                }
                if (!checkFull)
                {
                    break;
                }
            }
            if (checkFull)
            {
                Console.WriteLine("Отношение полное");
            }
            else
            {
                Console.WriteLine("Отношение не полное");
            }
            //Эквивалентность
            if (checkSymmetry && checkTransitive && checkReflex)
            {
                Console.WriteLine("Отношение эквивалентно");
            }
            //частичный порядок
            if (checkReflex && checkAntiSymmetry && checkTransitive)
            {
                Console.WriteLine("Отношение частично упорядочено");
            }
            //линейный порядок
            bool linearOrder = true;
            for (int i = 0; i < setSorted.Length; i++)
            {
                for (int j = 0; j < setSorted.Length; j++)
                {
                    if (bitArray[i, j] == bitArray[j, i])
                    {
                        linearOrder = false;
                        break;
                    }
                    if (!linearOrder)
                    {
                        break;
                    }
                }
            }
            //полный порядок
            bool fullOrder = false;
            //полнота транзитивность антисимметричность
            if (linearOrder && checkTransitive && checkFull && checkAntiSymmetry)
            {
                fullOrder = true;

            }
            if (fullOrder)
            {
                Console.WriteLine("Отношение полностью упорядочено");
            }
        тран




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
