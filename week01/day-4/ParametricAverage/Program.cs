using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            SumAndAverage();
        }
        public static void SumAndAverage()
        {
            try
            {
                Console.WriteLine("Hello, how many numbers do you want to give me for sum and average?");
                int numberCount = Convert.ToInt32(Console.ReadLine());
                double numberOfNumbers = numberCount;
                double sum = 0;

                while (numberCount != 0)
                {
                    double number = Convert.ToDouble(Console.ReadLine());

                    sum += number;
                    numberCount--;
                }

                double average = sum / numberOfNumbers;
                Console.WriteLine("Sum: " + sum + ", " + "Average: " + average);
            }
            catch (Exception)
            {
                Console.WriteLine("You're a jackass, try again!");
            }
        }
    }
}