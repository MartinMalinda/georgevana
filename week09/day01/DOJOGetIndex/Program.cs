using System;
using System.Collections.Generic;

namespace DOJOGetIndex
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int GetIndex(List<int> list, int value)
        {
            int index = -1;
            if (list.Contains(value))
            {
                return list.IndexOf(value);
            }
            return index;
        }
    }
}
