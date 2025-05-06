using System;

namespace TeachTheTeacher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write your own main to test.");

            Teacher michiel = new Teacher();

            michiel.SetFirstname("Michiel");
            michiel.SetLastname("Decoster");
            Console.WriteLine(michiel.Email());
            Console.WriteLine(michiel.ToString());

        }
    }
}
