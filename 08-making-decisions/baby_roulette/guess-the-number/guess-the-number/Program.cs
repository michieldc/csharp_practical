using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess_the_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Please enter a Random number between 1 and 10 (both included): ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            int chosenNumber = random.Next(1, 10);
            Console.WriteLine("Rolling the ball!");
            System.Threading.Thread.Sleep(5000);
            if (userNumber == chosenNumber)
            {
                Console.WriteLine($"Congratulations! You guessed {userNumber}, which was the correct number!");
            }
            else
            {
                if(userNumber > chosenNumber)
                {
                    Console.WriteLine($"Damn. You guessed too high. The number was {chosenNumber}");
                }
                else
                {
                    Console.WriteLine($"Damn. You guessed too low. The number was {chosenNumber}");
                }
                Console.WriteLine("Better luck next time!");
                
            }

        }
    }
}
