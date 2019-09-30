using System;

namespace inheritanceHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Organization [] cock= new Organization[3];
            cock[0] = new Factory("dicks", "zavod imeni Linusa Torvaldsa", 9, 18, "Linus Torvalds", "Finland");
            cock[1] = new ShipBuilding("Кораблезавод имени Пахома", 5, 23, "Сергей Пахомов", "Яма", 228);
            cock[2] = new InsuranceCompany("Почку продаш", 8, 17, "Игорь Крупкин", "ООО Тензор", 1337);
            for(int i = 0; i < cock.Length; i++)
            {
                Console.WriteLine(cock[i].GetType());
                Console.WriteLine(cock[i].info());
                cock[i].PoshelNaRabotu();
                Console.WriteLine("___________________________________________________");
            }
            Console.ReadLine();
        }
    }
}
