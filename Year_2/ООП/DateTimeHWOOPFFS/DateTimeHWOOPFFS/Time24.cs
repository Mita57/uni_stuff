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
            if (hours >= 0 && hours < 25)
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
            if (minutes >= 0 && minutes < 60)
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
            if (this.hours > 5 && this.hours < 12)
            {
                return ("TOP OF THE MORNING TO YA LADIES MY NAME IS JACKSEPTICEYE");
            }
            if (this.hours > 11 && this.hours < 17)
            {
                return ("It's daytime");
            }

            if (this.hours > 16 && this.hours < 21)
            {
                return ("It's evening");
            }
            return ("It's the best time of the day");
        }

        public void assign(string time)
        {
            string[] cock = time.Split(':');
            this.setHours(Convert.ToInt32(cock[0]));
            this.setMinutes(Convert.ToInt32(cock[1]));
        }

        public bool compare(string time)
        {
            string[] cock = time.Split(':');
            if (this.hours == Convert.ToInt32(cock[0]) && this.minutes == Convert.ToInt32(cock[1]))
            {
                return true;
            }
            return false;
        }

        public void nextMin()
        {
            if (this.minutes == 59)
            {
                this.minutes = 0;
                if (this.hours == 23)
                {
                    this.hours = 0;
                }
                else
                {
                    this.hours++;
                }
            }
            else
            {
                this.minutes++;
            }
        }

        public void prevMin()
        {
            if (this.minutes == 0)
            {
                this.minutes = 59;
                if (this.hours == 0)
                {
                    this.hours = 23;
                }
                else
                {
                    this.hours--;
                }
            }
            else
            {
                this.minutes--;
            }
        }

        public int minDifference(string time)
        {
            string[] cock = time.Split(':');
            int thisMinutes = this.hours * 60 + this.minutes;
            int timeMinutes = Convert.ToInt32(cock[0]) * 60 + Convert.ToInt32(cock[1]);
            return (thisMinutes - timeMinutes);
        }

        public double hoursDifference(string time)
        {
            return Math.Round(((double)minDifference(time) / 60), 3);
        }

        public Time24 timeRemain()
        {
            return new Time24(23 - this.hours, 60 - this.minutes);
        }

        public void nearHour()
        {
            if (this.minutes > 30)
            {
                if (this.hours == 23)
                {
                    this.hours = 0;
                }
                else
                {
                    this.hours++;
                }
            }
            this.minutes = 0;
        }

        public string info()
        {
            return this.hourR() + ", " + this.dayTime() ;
        }

        public void show()
        {
            Console.WriteLine(this.info());
        }

        public bool checkIfAsleep()
        {
            if(this.hours > 20 && this.hours < 10)
            {
                return false;
            }
            return true;
        }

        public void stupidAmericano()
        {
            if(this.hours < 12)
            {
                Console.WriteLine("Stupid americano format: " + this.hourR() + "am");
            }
            else
            {
                Console.WriteLine("Stupid americano format: " + this.hourR() + "pm");
            }
        }

        public Time24 timeTill420am()
        {
            if(this.hours == 4 && this.minutes == 20)
            {
                Console.WriteLine("Ня пока");
                return new Time24(0, 0);
            }
            if(this.hours >= 4 && this.minutes >= 21)
            {
                return new Time24(27 - this.hours, 80 - this.minutes);
            }
            if (this.hours >= 4 && this.minutes < 21)
            {
                return new Time24(27 - this.hours, 60 - this.minutes);
            }
            if(this.hours < 4 && this.minutes >=21)
            {
                return new Time24(4 - this.hours, 80-this.minutes);
            }
            {
                return new Time24(4-this.hours, 60 - this.minutes);
            }


        }



        public Time24(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }


        static public Time24 Create(int hours)
        {
            return new Time24(hours, 0);
        }
    }
}
