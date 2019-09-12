using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap the values of the variables
            int a = 123;
            int b = 526;

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}