using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanceHW
{
    class ShipBuilding:Organization
    {
        private int amountOfDrunks;
        public ShipBuilding(string name, int openHour, int closeHour, string ownerName, string location, int amountOfDrunks) : base(name, openHour, closeHour, ownerName, location)
        {
            this.amountOfDrunks = amountOfDrunks;
        }

        public override void PoshelNaRabotu()
        {
            Console.WriteLine("Буль блуь");
        }
        public override string info()
        {
            return ("Я судостроительная компания, название: " + this.name + ", часы работы: " + this.OpenHours() + ", владелец: " + this.ownerName + ", местоположение: " + this.location + ", у нас бухих: " + this.amountOfDrunks);
        }
    }
}
