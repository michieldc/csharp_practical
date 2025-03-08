using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_properties
{
    internal class Program
    {
        static void Welcome() {
            Console.WriteLine("Welcome to my number properties app.");
            Console.WriteLine("Input two integral numbers and I will tell you some important chacteristics about them.");
            Console.WriteLine("The difference of numbers.");
            Console.WriteLine("The biggest of the two numbers");
            Console.WriteLine("If the number is even or uneven (for each number).");
            Console.WriteLine("If the number is negative, zero or positive (for each number).");
            Console.WriteLine("The square of each number");
        }

        static int RequestNumber()
        {
            Console.WriteLine("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;

        }

        static void Sum(int first, int second)
        {
            Console.WriteLine($"The sum of {first} and {second} is " + (first+second));
            
        }

        static void Biggest(int first, int second)
        {
            if (first > second)
            {
                Console.WriteLine($"{first} is bigger than {second}");
            }else
            {
                Console.WriteLine($"{second} is bigger than {first}");
            }
        }

        static void Even(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is even.");
            }
            else
            {
                Console.WriteLine($"The number {number} is uneven.");
            }
        }

        static void Negative(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"{number} is negative number.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"{number} is a positive number.");
            }
            else if(number == 0)
            {
                Console.WriteLine($"{number} is both positive as negative");
            }
        }

        static void End()
        {
            Console.WriteLine("Thank you for using my application.");
        }

        static void Root(int number)
        {
            Console.WriteLine($"The square root of {number} is: " + Math.Sqrt(number));       
        }

        static void Square(int number)
        {
            Console.WriteLine($"The square of {number} is: " + (number*number));
        }

        static void Main(string[] args)
        {
            int userNumberOne = 0;
            int userNumberTwo = 0;

            Welcome();

            userNumberOne = RequestNumber();
            userNumberTwo = RequestNumber();
            
            Sum(userNumberOne, userNumberTwo);
            Biggest(userNumberOne, userNumberTwo);
            Even(userNumberOne);
            Even(userNumberTwo);
            Negative(userNumberOne);
            Negative(userNumberTwo);
            Root(userNumberOne);
            Root(userNumberTwo);
            Square(userNumberOne);
            Square(userNumberTwo);

            End();

        }
    }
}
