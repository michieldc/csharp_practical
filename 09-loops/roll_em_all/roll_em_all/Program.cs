using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roll_em_all
{
    internal class Program
    {
        static int RollTimes()
        {
            Console.WriteLine("Please enter how many dice to roll: ");
            int rolls = Convert.ToInt32(Console.ReadLine());
            return rolls;   
        }

        static int EyesOfDice()
        {
            Console.WriteLine("Please enter the amount of eyes: ");
            int eyes = Convert.ToInt32(Console.ReadLine());
            return eyes;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rolls = RollTimes();
            int eyes = EyesOfDice();
            for (int i = 1; i < rolls+1; i++) {
                Console.WriteLine($"Throw {i}: " + rnd.Next(1, eyes+1));
            }
        }
    }
}
