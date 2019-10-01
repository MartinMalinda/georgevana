using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox_inheritance_exercise
{
    class Mentor : Person
    {
        public EducationLevel Level { get; set; } = EducationLevel.intermediate;

        public Mentor()
        {

        }
        public Mentor(string name, int age, Gender gender, EducationLevel level) : base(name, age, gender)
        {
            this.Level = level;
        }
        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {PersonGender} {Level} mentor.");
        }
    }
}
