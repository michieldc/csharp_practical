using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace childsplay
{
    internal class Program
    {
        static void Welcome()
        {
            Console.WriteLine("Welcome to Child's play. Your source for math practice");
        }

        static void EndGame()
        {
            Console.WriteLine("Thanks for playing!");
        }

        static string CheckAnswer(int guess, int firstNumber, int secondNumber){
            if(guess == (firstNumber + secondNumber))
            {
                return "Correct";
            }
            else
            {
                return $"Incorrect. Correct answer was {firstNumber + secondNumber}";
            };
        }
        static int SelectDifficulty(int difficulty)
        {
            if (difficulty == 1)
            {
                Console.WriteLine("You selected difficulty level 1");
                return 1;
            }
            if (difficulty == 2)
            {
                Console.WriteLine("You selected difficulty level 2");
                return 2;
            }if (difficulty == 3)
            {
                Console.WriteLine("You selected difficulty level 3");
                return 3;
            }
            return 0;
        }
        static void Game()
        {
            Random generator = new Random();
            string answers = "";

            Welcome();
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Please select your difficulty: ");
            Console.WriteLine(" 1: Easy");
            Console.WriteLine(" 2: Normal");
            Console.WriteLine(" 3: Hard");
            Console.Write("Your choice: ");
            int difficulty = SelectDifficulty(Convert.ToInt32(Console.ReadLine()));


            Console.WriteLine("Press enter when ready ...");
            Console.ReadKey();
            
            for (int i = 0; i < 3; i++)
            {
                stopwatch.Start();
                int firstRandom = 0;
                int secondRandom = 0;
                if (difficulty == 1)
                {
                    firstRandom = generator.Next(0, 50);
                    secondRandom = generator.Next(0, 50);
                }
                else if (difficulty == 2)
                {
                    {
                        firstRandom = generator.Next(0, 100);
                        secondRandom = generator.Next(0, 100);
                    }
                }
                else if (difficulty == 3)
                {
                    firstRandom = generator.Next(0, 1000);
                    secondRandom = generator.Next(0, 1000);
                }

                Console.Write($"{firstRandom} + {secondRandom} = ? ");
                int guess = Convert.ToInt32(Console.ReadLine());
                answers = answers + $"\n{firstRandom} + {secondRandom} = {guess} \n{CheckAnswer(guess, firstRandom, secondRandom)} ";
            }
            stopwatch.Stop();
            Console.WriteLine(answers);
            Console.WriteLine("Time: " + stopwatch.Elapsed.ToString("mm\\:ss\\.ff"));
            EndGame();
        }
        static void Main(string[] args)
        {
            Game();
        }
    }
}
