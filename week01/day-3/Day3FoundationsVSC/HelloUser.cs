using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modify this program to greet user instead of the World!
            // The program should ask for the name of the user

            Console.WriteLine("Hello, what is your name, user?");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);
        }
    }
}