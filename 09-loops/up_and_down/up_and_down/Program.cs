using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace up_and_down
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping [0, 10]: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\nLooping [1, 10]: ");
            for (int i = 1; i < 11; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\nLooping [10, 0]: ");
            for (int i = 10; i >= 0; i--)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\nLooping [0, 10] (even numbers): ");
            for (int i = 0; i < 11; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine("\nLooping [0, 100] (Multitudes of 11): ");
            for(int i = 1; i < 100; i++)
            {
                if (i % 11 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine("\nLooping [1, 10000] (i times 5): ");
            for (int i = 1; i < 10000;)
            {
                Console.Write($"{i} ");
                i = i * 5;
            }
            Console.WriteLine("\nLooping [4096, 0] (divided by 2): ");
            for(int i = 4096; i > 0;)
            {
                Console.Write($"{i} ");
                i = i / 2;
            }
        }
    }
}
