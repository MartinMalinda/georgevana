using System;
using System.Collections.Generic;

namespace Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            var john = new Student("John", 20, Gender.male, "BME");
            people.Add(john);
            Student johnTheClone = john.Clone() as Student;
            people.Add(johnTheClone);

            foreach (var person in people)
            {
                person.Introduce();
                person.GetGoal();
            }
        }
    }
}
