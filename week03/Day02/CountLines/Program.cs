using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.
            FilesCountOfLines();
        }
        public static void FilesCountOfLines()
        {
            string path = @"./FileToRead.txt";
            try
            {
                string[] content = File.ReadAllLines(path);
                Console.WriteLine($"Number of Lines: {content.Length}");
            }
            catch (Exception)
            {
                Console.WriteLine("0");
            }
        }
    }
}
