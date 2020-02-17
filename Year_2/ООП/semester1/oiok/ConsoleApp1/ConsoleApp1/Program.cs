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
        {
            string cock = "MAMKA TVAYA";
            GetLastHalf(cock);
        }

        static string GetLastHalf(string text)
        {
            return (text.Replace(" ", "").Substring(text.Length / 2, text.Length));
        }
    }
}
