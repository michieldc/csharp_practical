using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visual_rectangle
{
    internal class Program
    {
        static void Welcome()
        {
            Console.WriteLine("Hi! Welcome to the Rectangle Visualiser.");
            Console.WriteLine("Please choose your next action:");
            Console.WriteLine("- Filled: Draw a filled rectangle.");
            Console.WriteLine("- Outline: Draw a non-filled rectangle.");
        }
        static String SelectRectangle()
        {
            Console.WriteLine("Please make a choice: ");
            return Console.ReadLine();
        }

        static int SelectWidth()
        {
            Console.Write("How many characters would you like to use for the width? ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int SelectHeight() 
        {
            Console.Write("How many characters would you like to use for the height? ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static string SelectCharacter() 
        {
            Console.Write("Please enter a character you want to use for the rectangle: ");
            return Console.ReadLine();
        }

        static void DrawingApp()
        {
            Welcome();
            string choice = SelectRectangle();
            string character = SelectCharacter();
            if (choice == "filled")
            {
                int width = SelectWidth();
                Console.WriteLine(width);
                int height = SelectHeight();
                Console.WriteLine(height);
                string draw = "";

                for (int i = 0; i < height; i++) // loopt doorheen hoogte
                {
                    for (int j = 0; j < width; j++) // loopt iedere keer dat er door de hoogte gelopen wordt door de breedte gelopen en zoveel chars geplaatst
                    {
                        draw = draw + $" {character} "; ;
                    }
                    draw = draw + " \n"; //tekent een new line op het einde van de 
                }
                Console.WriteLine(draw);

            }
            else if (choice == "outline")
            {
                int width = SelectWidth();
                Console.WriteLine(width);
                int height = SelectHeight();
                Console.WriteLine(height);
                string draw = "";

                for(int i = 0; i < height; i++) // loopt doorheen hoogte
                {
                   for(int j = 0; j < width; j++) // loopt iedere keer dat er door de hoogte gelopen wordt door de breedte gelopen en zoveel chars geplaatst
                    {
                        if(i == 0 || i == height-1) // als de hoogte 0 is m.a.w de eerste lijn moeten we hem vullen alsook de laatste lijn (-1 omdat de loop niet meer runt als hij gelijk is aan de hoogte)
                        {
                         draw = draw + $" {character} ";
                        }
                        else if(j == 0 || j == width-1){ // als de breedte de eerste lijn is dan moeten we hem volledig vullen. Hetzelfde met de laatste lijn width-1 want hij loopt niet meer als hij gelijk is aan de breedte.
                            draw = draw + $" {character} ";
                        }else // bij alle andere zaken vullen we hem niet.
                        {
                            draw = draw + "   ";
                        }
                        
                    }
                    draw = draw + " \n"; // op het einde van de loop, als 1 lijn doorlopen is gaan we met een next line naar de volgende
                }
                Console.WriteLine(draw);
            }
        }
        static void Main(string[] args)
        {
            DrawingApp();
        }
    }
}
