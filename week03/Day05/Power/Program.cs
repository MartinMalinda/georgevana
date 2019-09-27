using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given base and n that are both 1 or more, compute recursively(no loops) the value of base to the n power, so powerN(3, 2) is 9(3 squared).

            Console.WriteLine(Power(3, 50));
        }
        public static long Power(long n1, long n2)
        {
            if (n2 == 1)
            {
                return n1;
            }
            else
            {
                return n1 * Power(n1, n2 - 1);
            }
        }
    }
}
