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

        public abstract void PoshelNaRabotu();
        public string BecomeAnOwner()
        {
            return (this.ownerName + " has just mystriously disappeared and you became the owner");
        }

        public string Destroy()
        {
            return ("The nuclear missile has been launched to the location: " + this.location);
        }


    }
}
