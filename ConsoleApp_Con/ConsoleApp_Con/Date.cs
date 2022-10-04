using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Con
{
    public class Date
    {
        // 0,  1,  2, 3, etc..
        private static readonly int[] DaysToMonth365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] DaysToMonth366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 31, 30, 31, 30, 31 };

        private readonly int day = 01;
        private readonly int month = 01;
        private readonly int year = 01;
        public Date(int day, int month, int year)
        {
            var isLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);


            if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
            {

                int[] days = isLeap ? DaysToMonth366 : DaysToMonth365;
                if (day >= 1 && day <= days[month])
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;
                }

            }
        }

        public Date(int year) : this(01, 01, year)
        {
        }
        public Date(int month, int year) : this(01, month, year)
        {

        }
        public string Print()
        {

            return $"Day: {this.day.ToString().PadLeft(2, '0')}, Month: {this.month.ToString().PadLeft(2, '0')}, Year: {this.year.ToString().PadLeft(4, '0')} ";
        }

    }
}
