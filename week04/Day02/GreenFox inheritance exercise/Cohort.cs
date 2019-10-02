using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox_inheritance_exercise
{
    class Cohort
    {
        public string CohortName { get; set; }
        public List<Student> Students { get; private set; }
        public List<Mentor> Mentors { get; private set; }

        public Cohort(string name)
        {
            this.CohortName = name;
            this.Students = new List<Student>();
            this.Mentors = new List<Mentor>();
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void AddMentor(Mentor mentor)
        {
            Mentors.Add(mentor);
        }
        public void Info()
        {
            Console.WriteLine($"The {CohortName} cohort has {Students.Count} students and {Mentors.Count} mentors.");
        }
    }
}
