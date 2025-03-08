using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace higer_lower
{
    internal class Program
    {
        static void Welcome()
        {
            Console.WriteLine("Hello and welcome to the higher lower game!");
            Console.WriteLine("This is the most fun game on the planet!");
        }

        static void GuessesLeft(int guesses)
        {
            switch (guesses)
            {
                case 10:
                    Console.WriteLine("|..........| (10 guesses left)");
                    break;
                case 9:
                    Console.WriteLine("|X.........| (9 guesses left)");
                    break;
                case 8:
                    Console.WriteLine("|XX........| (8 guesses left)");
                    break;
                case 7:
                    Console.WriteLine("|XXX.......| (7 guesses left)");
                    break;
                case 6:
                    Console.WriteLine("|XXXX......| (6 guesses left)");
                    break;
                case 5:
                    Console.WriteLine("|XXXXX.....| (5 guesses left)");
                    break;
                case 4:
                    Console.WriteLine("|XXXXXX....| (4 guesses left)");
                    break;
                case 3:
                    Console.WriteLine("|XXXXXXX...| (3 guesses left)");
                    break;
                case 2:
                    Console.WriteLine("|XXXXXXXX..| (2 guesses left)");
                    break;
                case 1:
                    Console.WriteLine("|XXXXXXXXX.| (1 guess left)");
                    break;
            }
        }

        static void Game()
        {
            Console.WriteLine("Generating a very secret number between 0 and 100");
            Random randomNumberGenerator = new Random();
            int correctNumber = randomNumberGenerator.Next(0, 100);
            for ( int numberOfGuesses = 10; numberOfGuesses > 0; )
            {

                GuessesLeft(numberOfGuesses);

                Console.WriteLine("Please enter your guess: ");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == correctNumber)
                {
                    Console.WriteLine("You have guessed correctly!");
                    Console.WriteLine($"The number was: {correctNumber}");
                    break;
                }
                else if (userGuess < correctNumber)
                {
                    Console.WriteLine("That was too low! Guess again.");
                }
                else if (userGuess > correctNumber){
                    Console.WriteLine("That was too high! Guess again.");
                }

                numberOfGuesses--;
            }
        }

        static void ExitMessage()
        {
            Console.WriteLine("Thank you for playing! I hope you had fun!");
        }

        static void Main(string[] args)
        {
            Welcome();
            Game();
            ExitMessage();
        }
    }
}
