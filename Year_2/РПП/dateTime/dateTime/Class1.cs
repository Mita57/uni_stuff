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
        private DateTime DTClass;
        public MyDate(int day, int month, int year)
        {
            if (day < 32 && day > 0 && month > 0 && month < 13)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
            else
            {
                Console.WriteLine("Неправиьный формат");
            }
        }
        private void getDateTime()
        {
            this.DTClass = new DateTime(this.year, this.month, this.day);
        }
        public string showNormal()
        {
            return (this.day + "." + this.month + "." + this.year);
        }
        public string showAmericano()
        {
            return (this.month + "." + this.day + "." + this.year);

        }
        public int countDifference(string date)
        {
            string[] parts = date.Split('.');
            getDateTime();
            DateTime thisDate = new DateTime(int.Parse(parts[2]),int.Parse(parts[1]), int.Parse(parts[0]));
            return Math.Abs((thisDate - DTClass).Days);
        }
        public void setDay(int day)
        {
            if (day > 0 && day < 32)
            {
                this.day = day;
            }
            else
            {
                Console.WriteLine("Неправильный формат");
            }
        }
        public void setMonth(int month)
        {
            if (month > 0 && month < 13)
            {
                this.month = month;
            }
            else
            {
                Console.WriteLine("Неправиьный формат");
            }
        }
        public void setYear(int year)
        {
            this.year = year;
        }
        public int getDay()
        {
            return this.day;
        }
        public int getYear()
        {
            return this.year;
        }
        public int getMonth()
        {
            return this.month;
        }
        public void changeDays(int days)
        {
            this.DTClass = this.DTClass.AddDays(days);
            setDay(this.DTClass.Day);
            setMonth(this.DTClass.Month);
            setYear(this.DTClass.Year);
        }
        public String checkLeap()
        {
            if (DateTime.IsLeapYear(this.DTClass.Year))
            {
                return ("Год високосный");
            }
            else
            {
                return ("Год не високосный");
            }
        }
    }
}
