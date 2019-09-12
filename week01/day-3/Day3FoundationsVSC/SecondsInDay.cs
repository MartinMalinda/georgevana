using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables
            int secondsOfDay = 24 * 60 * 60;
            Console.WriteLine(secondsOfDay - currentHours * 60 * 60 - currentMinutes * 60 - currentSeconds);
        }
    }
}