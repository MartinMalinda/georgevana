using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it
            Console.WriteLine("Hello, enter the value you want to convert from miles to km:");
            double kmToMile = 1.60934;
            double milesDistance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(milesDistance * kmToMile);
        }
    }
}