using System;
using System.Collections.Generic;
using System.Text;

namespace Cloneable
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender PersonGender { get; set; }

        public Person()
        {
            this.Name = "Jane Doe";
            this.Age = 30;
            this.PersonGender = Gender.female;
        }
        public Person(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.PersonGender = gender;
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I am {Name} a {Age} years old {PersonGender}");
        }
        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
