using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] div = { ' ', ',' };
            //Universum
            Console.WriteLine("Введите универсум");
            string[] U_init = Console.ReadLine().Split(div);
            string[] U = new string[0];
            int place = 0;
            for (int i = 0; i < U_init.Length; i++)
            {
                if (U.Contains(U_init[i]) == false)
                {
                    Array.Resize(ref U, U.Length + 1);
                    U[place] = U_init[i];
                    place++;
                }
                else Console.WriteLine("Элемент " + U_init[i] + " был убран из-за повтора");
            }
            //select amount of sets
            Console.WriteLine("Введите количество множеств (2 или 3)");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первое множество");
            string[] a_init = Console.ReadLine().Split(div);
            string[] a = new string[0];
            place = 0;
            for (int i = 0; i < a_init.Length; i++)
            {
                if (a.Contains(a_init[i]) == false&&U.Contains(a_init[i]))
                {
                    Array.Resize(ref a, a.Length + 1);
                    a[place] = a_init[i];
                    place++;
                }
                else Console.WriteLine("Элемент " + a_init[i] +" был убран из-за повтора или он не принадлежит униерсуму");
            }
            Console.WriteLine("Введите второе множество");
            string [] b_init = Console.ReadLine().Split(div);
            string [] b = new string[0];
            place = 0;
            for (int i = 0; i < b_init.Length; i++)
            {
                if (b.Contains(b_init[i]) == false&&U.Contains(b_init[i]))
                {
                    Array.Resize(ref b, b_init.Length + 1);
                    b[place] = b_init[i];
                    place++;
                }
                else Console.WriteLine("Элемент " + b_init[i] + " был убран из-за повтора или он не принадлежит универсуму");
            }
            string[] c = new string[0];
            if (amount == 3)
            {
                Console.WriteLine("Введите третье множество");
                string[] c_init = Console.ReadLine().Split(div);
                place = 0;
                for (int i = 0; i < c_init.Length; i++)
                {
                    if (c.Contains(c_init[i]) == false&& U.Contains(c[i]))
                    {
                        Array.Resize(ref c, c_init.Length + 1);
                        c[place] = c_init[i];
                        place++;
                    }
                    else Console.WriteLine("Элемент " + c_init[i] + " был убран из-за повтора или он не принадлежит унверсуму");
                }
            }
            else c = b;
            Console.WriteLine("Объединение множеств: " + union(a,b,c));
            Console.WriteLine("Пересечение множеств: " + cross(a, b, c));
            Console.WriteLine("Разность множеств A и B: " + minus(a, b));
            Console.WriteLine("Разность множеств B и A: " + minus(b, a));
            if (amount == 3)
            {
                Console.WriteLine("Разность множеств A и C: " + minus(a, c));
                Console.WriteLine("Разность множеств B и C: " + minus(b, c));
                Console.WriteLine("Разность множеств C и A: " + minus(c, a));
                Console.WriteLine("Разность множеств C и B: " + minus(c, b));
            }
            Console.WriteLine("Дополнение множества A до универсума: "+complete(a, U));
            Console.WriteLine("Дополнение множества B до универсума: " + complete(b, U));
            if(amount==3) Console.WriteLine("Дополнение множества C до универсума: " + complete(c, U));
            Console.ReadLine();
            Console.WriteLine("________________________________________________________________________"); 
            check1();
            check2();
            check3();
            Console.ReadLine();
        }







        static string union(string [] a, string[] b, string[] c)
        {
            string[] uni = a;
            int counter = uni.Length;
            for (int i = 0; i < b.Length; i++)
            {
                if (uni.Contains(b[i]) == false)
                {
                    Array.Resize(ref uni, uni.Length + 1);
                    uni[counter] = b[i];
                    counter++;
                }
            }
            for(int i =0; i < c.Length; i++)
            {
                if (uni.Contains(c[i]) == false)
                {
                    Array.Resize(ref uni, uni.Length + 1);
                    uni[counter] = c[i];
                }
            }
            string result = "";
            for (int i = 0; i < uni.Length; i++)
            {
                if (uni[i] == "") continue;
                result += uni[i] + " ";
            }
            return result;
        }



        static string cross(string[] a, string[] b, string[] c)
        {
            string[] cross = new string[0];
            int counter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (b.Contains(a[i]) && c.Contains(a[i]))
                {
                    Array.Resize(ref cross, cross.Length + 1);
                    cross[counter] = a[i];
                    counter++;
                }
            }
            string result = "";
            for (int i =0; i < cross.Length; i++)
            {
                if (cross[i] == "") continue;
                result += cross[i] + " ";
            }
            return result;
        }



        static string minus (string[] a, string[] b)
        {
            string[] minus = new string[0];
            int counter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (b.Contains(a[i]) == false)
                {
                    Array.Resize(ref minus, minus.Length + 1);
                    minus[counter] = a[i];
                    counter++;
                }
            }
            string result =""; 
            for (int i = 0; i < minus.Length; i++)
            {
                result += minus[i] + " ";
            }
            return result;
        }


        static string complete (string [] a, string[] U)
        {
            string[] complete = new string[0];
            int counter = 0;
            for (int i =0; i < U.Length; i++)
            {
                if (a.Contains(U[i]) == false)
                {
                    Array.Resize(ref complete, complete.Length+1);
                    complete[counter] = U[i];
                    counter++;
                }
            }
            string result="";
            for (int i =0; i<complete.Length; i++)
            {
                result += complete[i]+" ";
            }
            return result;
        }
        static void check1()
        {
            char[] diver = { ' ', ',' };
            //part1
            string[] U = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] A = { "1", "3", "6", "7", "9" };
            string[] B = { "2", "4", "8" };
            string[] AnB = cross(A, B, B).Split(diver);
            string[] mB = complete(B, U).Split(diver);
            string[] Anmb = cross(A, mB, mB).Split(diver);
            string[] mA = complete(A, U).Split(diver);
            string[] mAnB = cross(mA, B, B).Split(diver);
            string full = union(mAnB, Anmb, AnB);
            Console.WriteLine(full);
            Console.WriteLine(union(A, B, B));
        }
        //part2
        static void check2() {
            char[] diver = { ' ', ',' };
            string[] U = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] A = { "0", "2", "3", "4", "6","7" };
            string[] B = { "1", "3", "5","7","9" };
            string[] C = {"1", "2", "4", "5", "7", "8" };
            string[] mC = complete(C, U).Split(diver);
            string[] AvBvmC = union(A, B, mC).Split(diver);
            string[] BvC = union(B,C,C).Split(diver);
            string final = minus(AvBvmC, BvC);
            Console.WriteLine(final);
            string[] mB = complete(B, U).Split(diver);
            Console.WriteLine(cross(mB, mC,mC));
                }
        //part3
        static void check3()
        {
            char[] diver = { ' ', ',' };
            string[] U = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] B = { "1", "3", "5", "7", "9"};
            string[] C = { "4", "8"};
            string[] mC = complete(C, U).Split(diver);
            string[] mB = complete(B, U).Split(diver);
            string[] BnmC = cross(B, mC,mC).Split(diver);
            string[] mBnmC = cross(mB, mC, mC).Split(diver);
            string[] BnC = cross(B, C, C).Split(diver);
            string[] lul = union(BnmC, mBnmC, BnC).Split(diver);
            string final = complete(lul, U);
            Console.WriteLine(final);
            Console.WriteLine(cross(C,mB,mB));
        }
         
    }
}

