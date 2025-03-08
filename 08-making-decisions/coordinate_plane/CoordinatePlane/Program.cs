using System;

namespace CoordinatePlane
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Coordinate Plane App");

            // TODO Request point coordinates from user

            Console.WriteLine("Enter the X coördinate: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Y coördinate: ");
            int y = Convert.ToInt32(Console.ReadLine());

            // Create point
            Point point = new Point();
            point.X = x;        // Set user value
            point.Y = y;        // Set user value

            // TODO Output in which quadrant the point lies
            // Warning! Output different message if it lies in the origin
            string quadrant = point.Quadrant();

        }
    }
}
