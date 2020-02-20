using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanceHW
{
    class Factory:Organization
    {
        private string production;

        public Factory(string production, string name, int openHour, int closeHour, string ownerName, string location):base(name, openHour, closeHour, ownerName, location)
        {
            this.production = production;
        }

        public override void PoshelNaRabotu()
        {
            Console.WriteLine("Эх щас бы на завод после школы  24/7");
        }

        public override string info()
        {
            return ("Я завод, название: " + this.name + ", часы работы: " + this.OpenHours() + ", владелец: " + this.ownerName + ", местоположение: " + this.location + ", мы производим: " + this.production);
        }
    }
}
