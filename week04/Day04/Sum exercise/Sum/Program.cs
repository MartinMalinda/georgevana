using System;
using System.Collections.Generic;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Suma
    {
        public int SumIntegers(List<int> list)
        {
            int sum = 0;
            if (list == null)
            {
                return sum;
            }
            foreach (var item in list)
            {
                sum += item;
            }
            return sum;
        }
    }
}
