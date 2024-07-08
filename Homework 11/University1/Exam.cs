using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University1
{
    internal class Exam
    {
        public Student Student { get; private set; }
        public Teacher Teacher { get; private set; }

        public Exam(Student student, Teacher teacher)
        {
            Teacher = teacher;
            Student = student;
        }

        private Grade Result;

        public bool SetGrade(Signature signature, Grade grade)
        {
            if(Teacher.AuthorizeTheSignature(signature))
            {
                Result = grade;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Grade GetResult(out bool success)
        {
            success = true;
            if(Result == Grade.NotTaken)
                success = false;
            return Result;
        }
    }
}
