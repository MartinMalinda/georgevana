using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox_inheritance_exercise
{
    class Person
    {
        public string Name { get; set; } = "Jane Doe";
        public int Age { get; set; } = 30;
        public Gender PersonGender { get; set; } = Gender.female;

        public Person()
        {

        }
        public Person(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.PersonGender = gender;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, I am {Name} a {Age} years old {PersonGender}");
        }
        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
