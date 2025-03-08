using System;

namespace SumAndDifference
{
    public class Program
    {
        static int RequestNumber()
        {
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();
            int number = Convert.ToInt32(userInput);
            return number;
        }

        static int Add(int first, int second)
        {
            return (first + second);
        }

        // TODO Create a method Subtract that substracts
        // a second argument from a first argument and returns the result.

        static int Substract(int first, int second)
        {
            return (first - second);
        }


        static void Main(string[] args)
        {
            // TODO Request two numbers from the user:
            int number1 = RequestNumber();
            int number2 = RequestNumber();



            // Show user the inputted numbers
            Console.WriteLine("You entered " + number1 + " and " + number2 + ".");

            // TODO Call the Add method and store the result in the variable sum.
            // Make sure to pass the two numbers as arguments to the method.
            int sum = Add(number1, number2);



            // Result of sum
            Console.WriteLine("\nTheir sum: " + sum);

            // TODO Call the Subtract method and store the result in the variable difference.
            // Make sure to pass the two numbers as arguments to the method.
            int difference = Substract(number1, number2);



            // Result of sum
            Console.WriteLine("\nTheir difference: " + difference);
        }
    }
}
