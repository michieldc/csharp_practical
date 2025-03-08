using System;

namespace FundamentalCalculus
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Welcome to Fundamental Calculus\n");

            Console.WriteLine($"3 + 5 = {calculator.Add(3, 5)}");
            Console.WriteLine($"3 + (-5) = {calculator.Add(3, -5)}");

            Console.WriteLine($"7 - 2 = {calculator.Subtract(7, 2)}");
            Console.WriteLine($"7 - (-2) = {calculator.Subtract(7, -2)}");

            Console.WriteLine($"4 * 6 = {calculator.Multiply(4, 6)}");
            Console.WriteLine($"4 * (-6) = {calculator.Multiply(4, -6)}");

            // TODO: Add further examples yourself

            Console.WriteLine($"10 squared = {calculator.Square(10)}");

            Console.WriteLine($"The absolute value of -20 = {calculator.AbsoluteValue(-20)}");

            Console.WriteLine($"The inverse of -20 = {calculator.Inverse(-20)}");
        }
    }
}
