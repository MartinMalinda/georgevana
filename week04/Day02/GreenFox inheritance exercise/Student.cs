using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox_inheritance_exercise
{
    class Student : Person
    {
        public string PreviousOrganization { get; set; } = "The School of Life";
        public int SkippedDays { get; set; } = 0;

        public Student(string name, int age, Gender gender, string organization) : base(name, age, gender)
        {
            this.PreviousOrganization = organization;
        }
        public Student()
        {

        }
        public void GetGoal()
        {
            Console.WriteLine("Be junior developer.");
        }
        public void Introduce()
        {
            Console.WriteLine($"Hi, I'am {Name} a {Age} year old {PersonGender} from {PreviousOrganization} who skipped {SkippedDays} days from the course already.");
        }
        public void SkipDays(int numberOfDays)
        {
            SkippedDays += numberOfDays;
        }
    }
}
