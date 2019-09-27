using System;

namespace NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number: ");
            Console.WriteLine(AddNumbers(Convert.ToInt32(Console.ReadLine())));
        }
        public static int AddNumbers(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + AddNumbers(n - 1);
            }
        }
    }
}
