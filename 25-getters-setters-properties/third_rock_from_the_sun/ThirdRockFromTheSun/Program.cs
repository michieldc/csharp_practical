using System;

namespace ThirdRockFromTheSun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Sphere sphere = new Sphere();

            sphere.Radius = 6371;
            Console.WriteLine($"The Earth has a radius of is {sphere.Radius} km");
            Console.WriteLine($"The means its diameter is about {sphere.Diameter} km");
            Console.WriteLine($"It has a surface of about {Math.Round(sphere.Surface(),0)} squared kilometers");
            Console.WriteLine($"It's volume approximates {Math.Round(sphere.Volume(),0)} cubic kilometers");
        }
    }
}
