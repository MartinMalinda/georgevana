using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counterOne = new Counter(50);
            Console.WriteLine(counterOne.Get());
            counterOne.Reset();
            Console.WriteLine(counterOne.Get());
        }
    }
}
