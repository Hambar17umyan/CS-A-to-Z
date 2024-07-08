using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace University1
{
    internal class Rector : Human
    {
        public University University { get; private set; }

        //Public Methods
        public Rector(string name, string surname, Gender gender, int age, decimal budget):base(name, surname, gender, age, budget)
        {

        }

        public void RepresentRector()
        {
            this.Represent();
        }

        public bool SetUniversity(University university, string password)
        {
            if (university.isAuthorized(password))
            {
                University = university;
                return true;
            }
            else return false;
        }

        public bool Hire(Teacher teacher)
        {
            return University.AddTeacher(teacher, Signature);
        }

        public bool Fire(Teacher teacher)
        {
            return University.DeleteFiredTeacher(teacher, Signature);
        }
    }
}
