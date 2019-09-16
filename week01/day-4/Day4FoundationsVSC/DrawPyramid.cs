using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            Console.WriteLine("Enter number of rows of your pyramid: ");
            int val = Convert.ToInt32(Console.ReadLine());
            int i, j;
            int k = val - 1;
            for (j = 1; j <= val; j++)
            {
                for (i = 1; i <= k; i++)
                {
                    Console.Write(" ");
                }
                for (i = 1; i <= 2 * j - 1; i++)
                {
                    Console.Write("*");
                }
                k--;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}