using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox_inheritance_exercise
{
    class Student : Person
    {
        public string PreviousOrganization { get; set; }
        public int SkippedDays { get; set; } = 0;

        public void GetGoal()
        {
            Console.WriteLine("Be junior developer.");
        }
        public void Introduce()
        {
            Console.WriteLine($"Hi, I'am {Name} a {Age} year old {PersonGender} from {previousOrganization} who skipped {skippedDays} days from the course already.");
        }
        public void SkipDays(int numberOfDays)
        {
            SkippedDays += numberOfDays;
        }
    }
}
