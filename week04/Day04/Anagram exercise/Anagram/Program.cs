using System;

namespace Anagram
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Write a function, that takes two strings and returns a boolean value based
            // on if the two strings are Anagramms or not.
            // Create a test for that.
        }
        public static bool IsAnagram(string input1, string input2)
        {
            char[] array1 = input1.ToCharArray();
            Array.Sort(array1);
            string sortedInput1 = array1.ToString();

            char[] array2 = input2.ToCharArray();
            Array.Sort(array2);
            string sortedInput2 = array2.ToString();

            if (sortedInput1 == sortedInput2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
