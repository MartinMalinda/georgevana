using System;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes 3 parameters: a path, a word and a number
            // and is able to write into a file.
            // The path parameter should be a string that describes the location of the file you wish to modify
            // The word parameter should also be a string that will be written to the file as individual lines
            // The number parameter should describe how many lines the file should have.
            // If the word is 'apple' and the number is 5, it should write 5 lines
            // into the file and each line should read 'apple'
            // The function should not raise any errors if it could not write the file.
            WriteMultipleLines();
        }
        public static void WriteMultipleLines()
        {
            string path = @"./my-text.txt";
            Console.WriteLine("Give a word");
            string word = Console.ReadLine();
            Console.WriteLine("Give me a number");
            int number = Convert.ToInt32(Console.ReadLine());
            try
            {
                for (int i = 0; i < number; i++)
                {
                    File.AppendAllText(path, word + "\n");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("HHAHAHA");
            }
        }
    }
}
