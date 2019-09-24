using System;
using System.IO;

namespace Day2Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.
            ;
        }
        public static void FilesNumberOfLines()
        {
            string path = @"./my-text.txt";
            try
            {
                string[] content = File.ReadAllLines(path);
                foreach (var line in content)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Could not read file: my-file.txt");
            }
        }
    }
}
