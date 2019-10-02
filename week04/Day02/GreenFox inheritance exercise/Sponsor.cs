using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox_inheritance_exercise
{
    class Sponsor : Person
    {
        public string Company { get; set; }
        public int HiredStudents { get; set; }

        public Sponsor()
        {
            this.Company = "Google";
            this.HiredStudents = 0;
        }
        public Sponsor(string name, int age, Gender gender, string company) : base(name, age, gender)
        {
            this.Company = company;
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {PersonGender} who represents {Company} and hired {HiredStudents} students so far.");
        }
        public void Hire()
        {
            HiredStudents++;
        }
        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }
    }
}
