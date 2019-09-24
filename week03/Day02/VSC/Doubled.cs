using System;
using System.IO;
using System.Text;

namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts the duplicated-chars.txt
            try
            {
                FixDoubled("./duplicated-chars.txt");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
            }
        }
        public static void FixDoubled(string path)
        {
            string[] textLines = File.ReadAllLines(path);
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < textLines.Length; i++)
            {
                builder.Append(textLines[i]);

                for(int j = 0; j < textLines[i].Length-j; j++)
                {
                    builder.Remove(j, 1);
                }
                textLines[i] = builder.ToString();
                builder.Clear();
            }
            File.WriteAllLines(path, textLines);
        }
    }
}
