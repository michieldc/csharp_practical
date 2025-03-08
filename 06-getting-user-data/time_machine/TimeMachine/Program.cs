using System;

namespace TimeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();

            Console.WriteLine("Welcome to your personal time machine.\n");

            Console.WriteLine("The current time is");
            clock.PrintToTerminal();
            Console.WriteLine("Please enter the amount of minutes you want to jump forward: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the amount of hours you want to jump forward: ");
            int hours = Convert.ToInt32(Console.ReadLine());


            clock.AddHours(hours);
            clock.AddMinutes(minutes);
            // TODO: Add the actual values to the current clock time
            // Call the AddMinutes() method
            // Call the AddHours() method

            Console.WriteLine("\nCongratz. You jumped forward in time to");
            clock.PrintToTerminal();
        }
    }
}
