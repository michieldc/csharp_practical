using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_roots
{
    internal class Program
    {
        static void Welcome()
        {
            Console.WriteLine("Welcome to my Square root application!");
        }
        static int GetNumber()
        {
            Console.WriteLine("Please enter an integral value to get the roots: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void GetRoot(int number)
        {
            if(number > 0)
            {
                int root = Convert.ToInt32(Math.Sqrt(number));
                Console.WriteLine($"The root of {number} is {root} and -{number}");
            }
            if (number < 0)
            {
                int root = Convert.ToInt32(Math.Sqrt(Math.Abs(number)));
                Console.WriteLine($"The root of {number} is {root}i and -{root}i");
            }

        }
        static void Main(string[] args)
        {
            Welcome();
            int root = GetNumber();
            GetRoot(root);

        }
    }
}
