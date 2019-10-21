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

            var positiveNumbers = numbers.Where(n => n > 0).Sum();
            var squaredValue = positiveNumbers * positiveNumbers;

            //Write a LINQ Expression to find which number squared value is more then 20 from the following array:
            int[] numbers2 = { 3, 9, 2, 8, 6, 5 };

            var squaredOfValue = numbers2.Where(n => n * n > 20);

        }
    }
}
