using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanceHW
{
    class InsuranceCompany : Organization
    {
        private int kidneyPrice;
        public InsuranceCompany(string name, int openHour, int closeHour, string ownerName, string location, int kidneyPrice) : base(name, openHour, closeHour, ownerName, location)
        {
            this.kidneyPrice = kidneyPrice;
        }

        public override void PoshelNaRabotu()
        {
            Console.WriteLine("Страховка на почку ");
        }
        public override string info()
        {
            return ("Я юрорга, название: " + this.name + ", часы работы:" + this.OpenHours() + ", владелец: " + this.ownerName + ", местоположение: " + this.location + ", цена за почку: " + this.kidneyPrice);
        }
    }
}
