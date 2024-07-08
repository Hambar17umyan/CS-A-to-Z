using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University1
{
    internal class Student : Human
    {
        (int count, Grade grade)[] Grades;
        University University;
        public Student(string name, string surname, Gender gender, int age, decimal budget) : base(name, surname, gender, age, budget)
        {
            Grades = new (int count, Grade grade)[7];
        }

        public void 

        public void RepresentStudent()
        {
            this.Represent();
        }
    }
    public enum Grade
    {
        NotTaken = 0,
        F = 1,
        D = 2,
        C = 3,
        B = 4,
        A = 5
    }
}
