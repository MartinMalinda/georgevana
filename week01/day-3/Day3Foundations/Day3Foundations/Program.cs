﻿using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // The first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people
            double imputOne;
            double imputTwo;

            Console.WriteLine("Hello, how many girls is going to the party");
            imputOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ok, cool, and how many boys is going to the party?");
            imputTwo = Convert.ToDouble(Console.ReadLine());
        }
    }
}