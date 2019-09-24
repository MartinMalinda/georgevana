using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts the duplicated-chars.txt
            List<char[]> lines = new List<char[]>();
            foreach (string line in File.ReadAllText(@"./duplicated-chars.txt"))
            {
                lines.Append(line.ToCharArray());
            }
            char[] charArray = lines.ToArray();
        }
    }
}
