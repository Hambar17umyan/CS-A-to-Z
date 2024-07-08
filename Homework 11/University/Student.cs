using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University;

namespace University
{
    internal class Student : Human
    {
        University? University;
        public bool InUniversity { get; private set; }

        public Student(string name, string surname, Gender gender, int age, decimal budget) : base(name, surname, gender, age, budget)
        {
            InUniversity = false;
        }

        public void RepresentStudent()
        {
            Represent();
        }

        public bool GetAdmittedToUniversity(University university, Signature signature)
        {
            if (InUniversity)
                return false;
            if (university.Rector.AuthorizeTheSignature(signature))
            {
                University = university;
                InUniversity = true;
                return true;
            }
            return false;
        }

        public bool GetBannedFromUniversity(Signature signature)
        {
            if (!InUniversity)
                return false;
            if (University.Rector.AuthorizeTheSignature(signature))
            {
                University = null;
                InUniversity = false;
                return true;
            }
            return false;
        }
    }
}
