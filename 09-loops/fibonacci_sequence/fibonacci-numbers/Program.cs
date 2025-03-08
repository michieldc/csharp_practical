using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_numbers
{
    internal class Program
    {
        static void Fibonnaci()
        {
            int a = 1;
            int b = 1;
            int c = 0;
            for (int i = 0; i < 20; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write($"{c},");
            }
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            Fibonnaci();
        }
    }
}
