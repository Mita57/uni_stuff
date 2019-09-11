using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime
{
    class myDate
    {
        private int day;
        private int month;
        private int year;
        private DateTime fuckCS;

        public myDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            getDateTime();
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
            DateTime thisDate = new DateTime(int.Parse(parts[2]),int.Parse(parts[1]), int.Parse(parts[0]));
            return (thisDate - fuckCS).Days;
        }

        public void setDay(int day)
        {
            this.day = day;
            getDateTime();
        }

        public void setMonth(int month)
        {
            this.month = month;
            getDateTime();
        }

        public void setYear(int year)
        {
            this.year = year;
            getDateTime();
        }

        public void changeDays(int days)
        {
            this.fuckCS.AddDays(days);
            this.day = fuckCS.Day;
            this.month = fuckCS.Month;
            this.year = fuckCS.Year;
        }

    }
}
