using System;
using System.Collections.Generic;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>();

            Console.WriteLine(names.Count);
            Console.WriteLine();

            names.Add("William");

            if (names.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine("not empty");
            }

            names.Add("John");
            names.Add("Amanda");

            Console.WriteLine(names.Count);
            Console.WriteLine();
            Console.WriteLine(names[2]);

            Console.WriteLine();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + names[i]);
            }

            names.RemoveAt(1);
            names.Reverse();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.Clear();
        }
    }
}