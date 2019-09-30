using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanceHW
{
    abstract class Organization
    {
        protected string name;
        protected int openHour;
        protected int closeHour;
        protected string ownerName;
        protected string location;

        public Organization(string name, int openHour, int closeHour, string ownerName, string location)
        {
            this.name = name;
            this.openHour = openHour;
            this.closeHour = closeHour;
            this.ownerName = ownerName;
            this.location = location;
        }

        public abstract void PoshelNaRabotu();
        public void BecomeAnOwner()
        {
            Console.WriteLine (this.ownerName + " has just mystriously disappeared and you became the owner");
        }

        public string Destroy()
        {
            return ("The nuclear missile has been launched to the location: " + this.location);
        }

        public string OpenHours()
        {
            return this.openHour.ToString() + "-" + this.closeHour.ToString();
        }

        


    }
}
