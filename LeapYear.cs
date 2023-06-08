using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LeapYear
    {
        public void leap()
        {
            int year = 2023; 

            bool isLeapYear = IsLeapYear(year);

            if (isLeapYear)
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }
        

        static bool IsLeapYear(int year)
        {

            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                return true;
            }

            return false;
        }
    }
    }
}
