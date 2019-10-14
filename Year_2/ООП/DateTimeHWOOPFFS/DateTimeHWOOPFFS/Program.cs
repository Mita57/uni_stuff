using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeHWOOPFFS
{
    class Program
    {
        static void Main(string[] args)
        {
            Time24 hammerTime = new Time24(13, 37);
            Console.WriteLine("hammer Time info: " + hammerTime.info());
            hammerTime.show();
            Time24 nowItsTimeToDiiiiie = Time24.Create(12);
            Console.WriteLine("nowItsTimeToDie info: " + nowItsTimeToDiiiiie.info());
            nowItsTimeToDiiiiie.assign("13:37");
            Console.WriteLine("Приравняли время к 13:37: " + nowItsTimeToDiiiiie.info());
            Console.WriteLine("Сравним эти два времени: " + hammerTime.compare(nowItsTimeToDiiiiie.hourR()));
            hammerTime.nextMin();
            Console.WriteLine("Добавили минуту к hammerTime: " + hammerTime.info());
            hammerTime.prevMin();
            Console.WriteLine("Убрали миунту от hammerTime: " + hammerTime.info());
            Console.WriteLine("Время до конца дня: " +hammerTime.timeRemain().hourR());
            hammerTime.nearHour();
            Console.WriteLine("Округленное до часа: " + hammerTime.hourR());
            hammerTime.setHours(13);
            hammerTime.setMinutes(37);
            hammerTime.show();
        }
    }
}
