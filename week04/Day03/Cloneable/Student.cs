using System;
using System.Collections.Generic;
using System.Text;

namespace Cloneable
{
    class Student : Person, ICloneable
    {
        public string PreviousOrganization { get; set; }
        public int SkippedDays { get; set; }

        public Student(string name, int age, Gender gender, string organization) : base(name, age, gender)
        {
            this.PreviousOrganization = organization;
        }
        public Student()
        {
            this.PreviousOrganization = "The school of life";
            this.SkippedDays = 0;
        }
        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Be a junior software developer.");
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'am {Name} a {Age} year old {PersonGender} from {PreviousOrganization} who skipped {SkippedDays} days from the course already.");
        }
        public void SkipDays(int numberOfDays)
        {
            SkippedDays += numberOfDays;
        }

        public object Clone()
        {
            return new Student(Name, Age, PersonGender, PreviousOrganization);
        }
    }
}
