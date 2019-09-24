using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that is able to manipulate a file
            // By writing your name into it as a single line
            // The file should be named "my-file.txt"
            // In case the program is unable to write the file,
            // It should print the following error message: "Unable to write file: my-file.txt"
            WriteSingleLine();
        }
        public static void WriteSingleLine()
        {
            string text = Console.ReadLine();
            string path = @"./my-text.txt";
            try
            {
                File.WriteAllText(path, text);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
        }
    }
}
