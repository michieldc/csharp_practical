using System;

namespace RectangleArea
{
    class Program
    {
        static double RequestWidth()
        {
            Console.WriteLine("Please enter a width for your rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            return width;
        }

        static double RequestHeight()
        {
            Console.WriteLine("Please enter a width for your rectangle: ");
            double height = Convert.ToDouble(Console.ReadLine());
            return height;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the rectangle calculator");

            // TODO Request the width of the rectangle from the user
            double width = RequestWidth();

            // TODO Request the height of the rectangle from the user
            double height = RequestHeight();

            // Calculate area
            Rectangle rectangle = new Rectangle();
            double area = rectangle.CalculateArea(width, height);

            // TODO Generate message to the user stating the area (show appropriate message if width or height was < 0)
            if (area == 0)
            {
                Console.WriteLine("\nSorry you provided negative values. Cannot determine area.");
            }
            else
            {
                Console.WriteLine($"The area is {area}");
            }
        }
    }
}
