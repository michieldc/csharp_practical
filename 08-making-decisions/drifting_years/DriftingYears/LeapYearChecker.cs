using System;
using System.Collections.Generic;
using System.Text;

namespace DriftingYears
{
    public class LeapYearChecker
    {
        public bool IsLeapYear(int year)
        {
            // TODO: Check if year is a leap year and
            // place the result in the boolean variable below
            bool isLeapYear = false;
            if(year%4 == 0)
            {
                isLeapYear = true;
            }
            if (year % 100 == 0)
            {
                isLeapYear = false;
            }
            if (year % 400 == 0)
            {
                isLeapYear = true;
            }
            // Please dont change the code below (automatic unit tests)
            return isLeapYear;
        }
    }
}
