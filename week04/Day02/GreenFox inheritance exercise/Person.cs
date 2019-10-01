using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox_inheritance_exercise
{
    class Person
    {
        private string name = "Jane Doe";
        private int age = 30;
        private Gender gender = Gender.female;

        public Person()
        {

        }
        public Person(string name, int age, Gender gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, I am {name} a {age} years old {gender}");
        }
        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
