using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDate cock = new MyDate(11, 09, 2001);
            Console.WriteLine("stupid americano format: " + cock.showAmericano());
            Console.WriteLine("Православный формат: "+ cock.showNormal());
            Console.WriteLine("Разница с моим ДР: " + cock.countDifference("18.04.2000"));
            cock.changeDays(1337);
            Console.WriteLine("Добавим 1337 дней: " + cock.showNormal());
            Console.WriteLine(cock.checkLeap());
            cock.setDay(-323232);
            Console.ReadLine();
        }
    }
}
