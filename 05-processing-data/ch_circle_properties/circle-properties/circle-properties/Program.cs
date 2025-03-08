using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle_properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = 2.15;
            double pi = Math.PI;
            double diameter = 4.30;

            double area = (radius * radius * pi);
            double circumference = ((2 * radius) * pi);

            Console.WriteLine("Hello and welcome to the circle properties app \n");

            Console.WriteLine("The radius = " + Math.Round(radius, 2) + " meters");
            Console.WriteLine("The diameter = " + Math.Round(diameter, 2) + " meters");
            Console.WriteLine("The circumference = " + Math.Round(circumference, 2) + " meters");
            Console.WriteLine("The area = " + Math.Round(area, 2) + " square meters \n");


            Console.WriteLine("Thanks for using the app.");
        }
    }
}
