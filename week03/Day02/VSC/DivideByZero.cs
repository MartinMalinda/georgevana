using System;

namespace Day2Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0
            DivisorOfTen();
        }
        public static void DivisorOfTen()
        {
            Console.WriteLine("Divide 10 by number: ");
            try
            {
                int divisor = int.Parse(Console.ReadLine());
                int result = 10 / divisor;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Fail");
            }
            catch (Exception)
            {
                // Do not translate content of WriteLine!
                Console.WriteLine("tos posral, kamo");
            }
        }
    }
}
