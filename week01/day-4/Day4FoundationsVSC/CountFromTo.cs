using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
            Console.WriteLine("Give me first number");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give me second number");
            double number2 = Convert.ToDouble(Console.ReadLine());

            if (number1 >= number2)
            {
                Console.WriteLine("Second number should be bigger");
            }
            else
            {
                for (double i = number1; number1 <= number2; number1++)
                {
                    Console.WriteLine(number1);
                }
            }

        }
    }
}