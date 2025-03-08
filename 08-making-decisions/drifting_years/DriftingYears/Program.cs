using System;

namespace DriftingYears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the latest and greatest leap year checker.\n");

            // TODO: Request year from the user
            Console.WriteLine("Enter a year to check if its a leap year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            // Creating a leap year checker object
            LeapYearChecker leapChecker = new LeapYearChecker();

            // Checking if year is a leap year
            bool isUserYearLeapYear = leapChecker.IsLeapYear(year);

            // TODO: Output message to the user
            // Build if - else and use isUserYearLeapYear as condition
            if (isUserYearLeapYear == true)
            {
                Console.WriteLine("This is a leapyear");

            }
            else {
                Console.WriteLine("This is not a leap year");
            }

            // Done
            Console.WriteLine("\nThank for using our app.");
        }
    }
}
