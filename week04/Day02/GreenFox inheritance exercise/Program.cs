﻿using System;

namespace GreenFox_inheritance_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Person();
            var studentTwo = new Person("George Wayne", 33, Gender.male);

            var student3 = new Student();
            var student4 = new Mentor();

            Console.WriteLine(student4.Name);
        }
    }
}
