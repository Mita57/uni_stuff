using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeHWOOPFFS
{
    class Time24
    {
        private int hours;
        private int minutes;

        public void setHours(int hours)
        {
            if(hours >= 0 && hours < 25)
            {
                this.hours = hours;
            }
        }

        public int getHours()
        {
            return this.hours;
        }

        public void setMinutes(int minutes)
        {
            if(minutes >= 0 && minutes < 60)
            {
                this.minutes = minutes;
            }
        }

        public string hourR()
        {
            return (this.hours + ":" + this.minutes);
        }

        public string dayTime()
        {
            if(this.hours > 5 && this.hours < 12)
            {
                return ("TOP OF THE MORNING TO YA LADIES MY NAME IS JACKSEPTICEYE");
            }
            if(this.hours > 11 && this.hours < 17)
            {
                return ("It's daytime");
            }

            if(this.hours > 16 && this.hours < 21)
            {
                return ("It's evening");
            }
            return ("It's the best time of the day");
        }


        public Time24(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }

        public Time24 (int hours)
        {
            this.hours = hours;
            this.minutes = 0;
        }

        public Time24 Create(int hours)
        {
            return new Time24(hours);
        }
    }
}
