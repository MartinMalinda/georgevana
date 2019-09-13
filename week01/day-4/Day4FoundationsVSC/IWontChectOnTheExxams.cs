using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i+ " I wont cheat on the exam!");
            }
        }
    }
}


using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"
            int a = 0;
            while (a++ < 10)
            {
                Console.WriteLine("I wont cheat on the exams");
            }
        }
    }
}

using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"
            int a = 0;
            while (a < 10)
            {
                Console.WriteLine("I wont cheat on the exams");
                a++;
            }
        }
    }
}