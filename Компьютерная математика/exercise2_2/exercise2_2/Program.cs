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
            string[] subinit = init.Split(',');
            int countA = 0;
            int countB = 0;
            for (int i = 0; i<subinit.Length; i++)
            {
                subinit[i]=subinit[i].Replace(",","");
                subinit[i] = subinit[i].Replace(" ", "");
                subinit[i] = subinit[i].Replace("(", "");
                subinit[i] = subinit[i].Replace(")", "");
                string[] SIE = subinit[i].Split(';');
                //first set
                if (arrA.Contains(Convert.ToString(SIE[0])) == false)
                {
                    Array.Resize(ref arrA, arrA.Length + 1);
                    arrA[countA] = Convert.ToString(SIE[0]);
                    countA++;
                }
                //second set
                if (arrB.Contains(Convert.ToString(SIE[1])) == false)
                {
                    Array.Resize(ref arrB, arrB.Length + 1);
                    arrB[countB] = Convert.ToString(SIE[1]);
                    countB++;
                }
            }
            string finalA="(";
            for (int i = 0; i < arrA.Length; i++)
            {
                // if this is the last element semicolon isn't added and a closing bracket
                if (i == arrA.Length-1) finalA += arrA[i]+")";
                else finalA+=arrA[i].ToString() +"; ";
            }

            string finalB = "(";
            for (int i = 0; i < arrB.Length; i++)
            {
                if (i == arrB.Length-1) finalB += arrB[i]+")";
                else finalB += arrB[i].ToString() + "; ";
            }
            Console.WriteLine(finalA);
            Console.WriteLine(finalB);
            Console.ReadLine();
        }
    }
}
