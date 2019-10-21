using System;
using System.Linq;

namespace LINQ_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the even numbers from the following array:
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            var evenNumbersQuery = from number in numbers
                                   where number % 2 == 0
                                   select number;

            //Write a LINQ Expression to get the average value of the odd numbers from the following array:

            var oddNumbers = numbers.Where(n => n % 2 != 0);
            var averageOfOddNumbers = oddNumbers.Sum() / oddNumbers.Count();

            var averageOfOddNumbersQuery = from number in numbers
                                           where number % 2 != 0
                                           select number;

            //Write a LINQ Expression to get the squared value of the positive numbers from the following array:


        }
    }
}
