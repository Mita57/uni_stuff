using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше слово");
            string word = Console.ReadLine();
            char[] a = word.ToCharArray();
            char[] a2= new char[0];
            int z = 0;
            for (int i=0; i<a.Length; i++)
            {
                
                if (a2.Contains(a[i])==false)
                {       
                    Array.Resize(ref a2, a2.Length+1);
                    a2[z] = a[i];
                    z++;
                }
            }
            for (int i = 0; i < a2.Length; i++)
            {
                Console.WriteLine(a2[i]);
            }
        }
    }
}
