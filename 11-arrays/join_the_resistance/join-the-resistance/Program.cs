using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace join_the_resistance
{
    internal class Program
    {
        public static void Welcome(){
            Console.WriteLine("Welcome to the Next-Gen Resistor Calculator\r\n\r\nFirst you will be asked for the foremost left color bands" +
                " that determine the value. Next you may provide the tolerance" +
                " band.\r\n\r\nPossible colors are: [black, brown, red, orange, yellow, green, blue, violet, grey, white]");
        }

        public static String GetZeroes(int amountOfZeroes, string output)
        {
            switch(amountOfZeroes)
            {
                case 0:
                    output = output + "";
                    break;
                case 1:
                    output = output + "0";
                    break;
                case 2:
                    output = output + "00";
                    break;
                case 3:
                    output = output + "000";
                    break;
                case 4:
                    output = output + "0000";
                    break;
                case 5:
                    output = output + "00000";
                    break;
                case 6:
                    output = output + "000000";
                    break;
                case 7:
                    output = output + "0000000";
                    break;
                case 8:
                    output = output + "000000000";
                    break;
                case 9:
                    output = output + "00000000000";
                    break;
            }
            return output;
        }

        public static String GetTolerance(int tolerance)
        {
            String output = "";
            switch (tolerance)
            {
                case 0:
                    output += "10% Tolerance";
                    break;
                case 1:
                    output += "5% Tolerance";
                    break;
                case 2:
                    output += "1% Tolerance";
                    break;
                case 3:
                    output += "2% Tolerance";
                    break;
                case 4:
                    output += "0.5% Tolerance";
                    break;
                case 5:
                    output += "0.25% Tolerance";
                    break;
                case 6:
                    output += "0.1% Tolerance";
                    break;
                case 7:
                    output += "0.05% Tolerance";
                    break;
            }
            return "The tolerance for the resistor is:  " + output;
                ;
        }

        public static void Application()
        {
            int amountOfColors = 0;
            String[] bands = new String[4];
            String[] colors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
            String[] tolerance = { "silver", "gold", "brown", "red", "green", "blue", "violet", "grey" };
            int[] colorValues = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            String resistanceValue = "";
            String toleranceValue = "";
            while (amountOfColors < bands.Length)
            {
                
                if (amountOfColors == 3)
                {
                    Console.WriteLine("Possible tolerance colors are: [silver, gold, brown, red, green, blue, violet, grey] \n");
                    Console.WriteLine("Tolerance band:");
                    bands[amountOfColors] = Console.ReadLine();
                    amountOfColors++;
                }
                else
                {
                    Console.WriteLine($"Band {amountOfColors + 1}:");
                    bands[amountOfColors] = Console.ReadLine().ToLower();
                    amountOfColors++;
                }
            }
            for (int i = 0; i < bands.Length; i++) { //-1 omdat we evenetjes tolerantie eruit halen
                
                if(i == 3)
                {
                    toleranceValue = GetTolerance(Array.IndexOf(tolerance, bands[i]));
                    break;
                }
                else if(i == 2)
                {
                    resistanceValue = GetZeroes(Array.IndexOf(colors, bands[i]), resistanceValue);
                }
                else{ 
                    resistanceValue = resistanceValue + Array.IndexOf(colors, bands[i]);
                }
            }


            Console.WriteLine(resistanceValue);
            Console.WriteLine(toleranceValue);
        }

        
        static void Main(string[] args)
        {
            Welcome();
            Application();
        }
    }
}
