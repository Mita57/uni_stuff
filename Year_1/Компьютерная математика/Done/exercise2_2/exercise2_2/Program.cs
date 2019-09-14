using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace exercise2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите результат декартова произведения множеств");
            string init = Console.ReadLine();
            string[] arrA = new string[0];
            string[] arrB = new string[0];
            string[] subinit = init.Split(','); // only sets are left
            int countA = 0;
            int countB = 0;
            for (int i = 0; i < subinit.Length; i++)
            {
                //getting rid of useless elements, idk wut for but it was easier to debug
                subinit[i] = subinit[i].Replace(",", "");
                subinit[i] = subinit[i].Replace(" ", "");
                subinit[i] = subinit[i].Replace("(", "");
                subinit[i] = subinit[i].Replace(")", "");
                string[] SIE = subinit[i].Split(';');
                //first set getting rid of duplicates
                if (arrA.Contains(Convert.ToString(SIE[0])) == false)
                {
                    Array.Resize(ref arrA, arrA.Length + 1);
                    arrA[countA] = Convert.ToString(SIE[0]);
                    countA++;
                }
                //second set getting rid of duplicates
                if (arrB.Contains(Convert.ToString(SIE[1])) == false)
                {
                    Array.Resize(ref arrB, arrB.Length + 1);
                    arrB[countB] = Convert.ToString(SIE[1]);
                    countB++;
                }
            }
            string[] check = new string[0]; // a manual decartovo proizvedenie to check if the input was correct
            int checkCount = 0;
            for (int i = 0; i < arrA.Length; i++)
            {
                for (int j = 0; j < arrB.Length; j++)
                {
                    Array.Resize(ref check, check.Length + 1);
                    check[checkCount] = arrA[i].ToString() + ";" + arrB[j].ToString();
                    checkCount++;
                }
            }
            bool flag = true;
            for (int i = 0; i < check.Length; i++)
            {
                if (subinit.Contains(check[i]) == false) // if at least one of the elements doesn't exist in the check array then an error is thrown
                {
                    Console.WriteLine("Введены неверные данные");
                    flag = false;
                    break;
                }

            }

            if (flag == true) // only if the input is correct
            {
                string finalA = "(";
                for (int i = 0; i < arrA.Length; i++)
                {
                    // if this is the last element semicolon isn't added and a closing bracket is added
                    if (i == arrA.Length - 1) finalA += arrA[i] + ")";
                    else finalA += arrA[i].ToString() + "; ";
                }

                string finalB = "(";
                for (int i = 0; i < arrB.Length; i++)
                {
                    if (i == arrB.Length - 1) finalB += arrB[i] + ")";
                    else finalB += arrB[i].ToString() + "; ";
                }
                Console.WriteLine(finalA);
                Console.WriteLine(finalB);
            }
            Console.ReadLine();
        }
    }
}
