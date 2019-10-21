using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //Write a LINQ Expression to get the even numbers from the following array:
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            var evenNumbersQuery = from number in numbers
                                   where number % 2 == 0
                                   select number;

            //Exercise 2
            //Write a LINQ Expression to get the average value of the odd numbers from the following array:

            var oddNumbers = numbers.Where(n => n % 2 != 0).Average();

            var averageOfOddNumbersQuery = (from number in numbers
                                            where number % 2 != 0
                                            select number)
                                           .Average();

            //Exercise 3
            //Write a LINQ Expression to get the squared value of the positive numbers from the following array:

            var positiveNumbers = numbers.Where(n => n > 0).Select(n => n * n);


            //Exercise 4
            //Write a LINQ Expression to find which number squared value is more then 20 from the following array:
            int[] numbers2 = { 3, 9, 2, 8, 6, 5 };

            var squaredOfValue = numbers2.Where(n => n * n > 20);

            
            //Exercise 5
            //Write a LINQ Expression to find the frequency of numbers in the following array:
            int[] numbers3 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            //var numberFrequency = numbers3.GroupBy(n => n).ToList();

            var test = numbers3.GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());

            //alternatively
            var dictionary = new Dictionary<int, int>();
            numbers3.GroupBy(n => n).ToList().ForEach(n => dictionary.Add(n.Key, n.Count()));

            
            //Exercise 6
            //Write a LINQ Expression to find the frequency of characters in a given string.
            string input = "testing with the spaces";
            var alphabetsCount = input.GroupBy(x => x).Where(x => x.Key != 32).ToDictionary(n => n.Key, n => n.Count());

            //Alternatively
            //var alphabetsCount = input.GroupBy(x => x).Select(x => new {Character = x.Key, Count = x.Count()});

            //Exercise 7
            //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var theChosenOnes = cities.Where(w => w.StartsWith('A') && w.EndsWith('I'));

            //Exercise 8
            //Write a LINQ Expression to find the uppercase characters in a string.
            string input2 = "TESTING With The Uppercase word";
            var uppercaseWords = input2.Split(' ').Where(w => string.Equals(w, w.ToUpper(), StringComparison.Ordinal));

            string input3 = "Testing With The Uppercases";
            var uppercases = input3.Where(i => char.IsUpper(i));

            //Exercise 9
            //Write a LINQ Expression to convert a char array to a string.
            char[] exampleCharArray = new char[] { 'a', 'b', 'c', 'd' };

            var chararrayToStringArray = string.Join(",", exampleCharArray.Select(p => p.ToString()));
        }
    }
}
