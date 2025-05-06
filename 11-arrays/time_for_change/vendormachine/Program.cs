using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendormachine
{
    internal class Program
    {
        public static void OpeningMenu()
        {
            Console.WriteLine("Vending Machine Simulator.");
            Console.WriteLine("Please select a product: ");
            Console.WriteLine("1. Cola [2.2 euro]");
            Console.WriteLine("2. Fanta [2.2 euro]");
            Console.WriteLine("3. Water [1 euro]");
            Console.WriteLine("4. Red Bull [2.70 euro]");
        }

        public static int ChoiceSelection()
        {
            Console.Write("Enter your choice: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static double RequestPayment(int choice, int[] prices)
        {
            Console.WriteLine("Please insert at least: ");
            Console.WriteLine(prices[choice-1] + " eurocent");
            return prices[choice-1]; //-1 omdat we de choices laten beginnen bij 1 maar de array begint bij 0
        }

        public static double CalculateReturns(double price, double payment)
        {
            return payment - price;
        }

        public static double Paying()
        {
            Console.Write("Insert: ");
            double inserted = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"You inserted: {inserted} eurocent.");
            return inserted;
        }

        public static void ChangeCalulation(double change)
        {
            int[] returns = { 1, 2, 5, 10, 20, 50, 100, 200 };
            double rest = change;
            String uitkomst = "";
            Console.WriteLine($"Change variable = " + change);
            for (int i = returns.Length-1; i >= 0; i--)
            {
                if ((rest / returns[i] * 1.0) == 1)
                {
                    Console.WriteLine("We zitten in de eerste if.");
                    uitkomst += $"1x {returns[i]} eurocent";
                    break;
                }
                else if ((rest / returns[i] * 1.0)  > 1)
                {
                    Console.WriteLine("De rest is momenteel: " + rest);
                    Console.WriteLine("returns[i] is momenteel: " + returns[i]);
                    uitkomst += $"1x {returns[i]} eurocent";
                    rest = rest - returns[i];
                    Console.WriteLine($"De rest na de aftrekking van {returns[i]} = {rest} ");
                }

            }
            Console.WriteLine("Your change is: " + uitkomst);
        }


        public static void Application()
        {
            OpeningMenu();
            int[] prices = { 220, 220, 100, 270 };
            int[] returns = { 1, 2, 5, 10, 20, 50, 100, 200 };
            int choice = ChoiceSelection();
            double toPay = RequestPayment(choice, prices);
            double paying = Paying();
            double change = CalculateReturns(toPay, paying);
            string returning = "";

            Console.WriteLine($"Your change is : {change} eurocent");

            ChangeCalulation(change);
        }

        static void Main(string[] args)
        {
            Application();
        }
    }
}
