using System;
using System.IO;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
            CopyFile(@"./my-text.txt", @"./my-text2.txt");
        }
        public static void CopyFile(string CopyFromFile, string CopyToFile)
        {
            try
            {
                string[] fileText = File.ReadAllLines(CopyFromFile);
                foreach (string line in fileText)
                {
                    File.WriteAllLines(CopyToFile, fileText);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Somethings wrong");
            }
            if (File.Exists(@"./my-text2.txt"))
            {
                Console.WriteLine("Copy was sucessfull");
            }
            else
            {
                Console.WriteLine("Copy not sucessfull");
            }
        }
    }
}
