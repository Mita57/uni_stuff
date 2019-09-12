using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime
{
    class MyDate
    {
        private int day;
        private int month;
        private int year;
        private DateTime fuckCS;

        public MyDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        private void getDateTime()
        {
            this.fuckCS = new DateTime(this.year, this.month, this.day);
        }

        public string showNormal()
        {
            return (this.day + "." + this.month + "." + this.year);
        }

        public string showFakinAmericano()
        {
            return (this.month + "." + this.day + "." + this.year);

        }

        public int countDifference(string date)
        {
            string[] parts = date.Split('.');
            getDateTime();
            DateTime thisDate = new DateTime(int.Parse(parts[2]),int.Parse(parts[1]), int.Parse(parts[0]));
            return Math.Abs((thisDate - fuckCS).Days);
        }

        public void setDay(int day)
        {
            this.day = day;
        }

        public void setMonth(int month)
        {
            this.month = month;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        
        public void changeDays(int days)
        {
            this.fuckCS = this.fuckCS.AddDays(days);
            setDay(this.fuckCS.Day);
            setMonth(this.fuckCS.Month);
            setYear(this.fuckCS.Year);
        }



    }
}
