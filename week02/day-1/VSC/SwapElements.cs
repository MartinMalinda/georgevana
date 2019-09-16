using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`
            string[] abc = { "first", "second", "third" };

            (abc[0], abc[2]) = (abc[2], abc[0]);

            foreach (var position in abc)
            {
                Console.WriteLine(position);
            }
        }
    }
}