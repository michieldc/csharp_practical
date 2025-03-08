using System;
using System.Runtime.InteropServices;

namespace Converternator
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Build an application that allows the user to convert units.
            // Request action from the user by showing him/her the following options
            // 1. Miles to kilometers
            // 2. Kilometers to miles
            // 3. Pounds to kilograms
            // 4. Kilograms to pounds
            // 5. Exit
            Console.WriteLine("What would you like to convert?");
            Console.WriteLine("1. Miles to kilometers");
            Console.WriteLine("2. Kilometers to miles");
            Console.WriteLine("3. Pounds to kilograms");
            Console.WriteLine("4.Kilograms to pounds");
            Console.WriteLine("5.Exit");
            // Converter object
            Converter converter = new Converter();
            double toConvert = 0;
            Console.WriteLine("Please enter your number:");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 0:
                    Console.WriteLine("Goodbye");
                    break;
                case 1:
                    Console.WriteLine("Please enter the amount of miles");
                    toConvert = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(converter.MileToKilometer(toConvert));
                    break;
                case 2:
                    Console.WriteLine("Please enter the amount of kilometers");
                    toConvert = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(converter.KilometerToMile(toConvert));
                    break;
                case 3:
                    Console.WriteLine("Please enter the amount of pounds");
                    toConvert = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(converter.PoundToKilogram(toConvert));
                    break;
                case 4:
                    Console.WriteLine("Please enter the amount of kilograms");
                    toConvert = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(converter.KilogramToPound(toConvert));
                    break;
            }
            Console.WriteLine("Thanks for using the application. I hope you enjoyed your conversion!");

            // Example useage:
            // double miles = converter.KilometerToMile(34);
        }
    }
}
