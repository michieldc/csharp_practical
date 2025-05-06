using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point center = new Point();
            Console.WriteLine($"Start location of point [{center.x}, {center.y}]");

            center.Move(12.2, 13.3);

            Console.WriteLine($"Moved point to [{center.x}, {center.y}]");
        }
    }
}
