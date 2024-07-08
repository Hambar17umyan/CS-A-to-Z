using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using University;

namespace University
{
    internal class Rector : Human
    {
        public University? University { get; private set; }

        //Public Methods
        public Rector(string name, string surname, Gender gender, int age, decimal budget) : base(name, surname, gender, age, budget)
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
            if (University == null)
                return false;
            return University.AddTeacher(teacher, Signature);
        }

        public bool Fire(Teacher teacher)
        {
            if (University == null)
                return false;
            return University.DeleteFiredTeacher(teacher, Signature);
        }

        public bool AdmitStudent(Student student)
        {
            if (University == null)
            {
                return false;
            }

            return student.GetAdmittedToUniversity(University, Signature) && University.AddStudent(student, Signature);
        }

        public bool BanStudent(Student student)
        {
            if (University == null)
            {
                return false;
            }

            return student.GetBannedFromUniversity(Signature) && University.RemoveStudent(student, Signature);

        }
    }
}
