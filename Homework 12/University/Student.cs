using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Student
    {
        //Private fields
        private Signature Signature; //Unique signature for later authentification.

        //Public properties
        public string FirstName { get; } //First name
        public string LastName { get; } //Last name
        public string ID { get; } //Passport id

        public decimal[] AdmissionExamGrades; //Exam grades(the i-th index correspondes to the i-th enum of Exam type).
        private List<ApplicationResume> Applications;

        //Ctor
        public Student(string firstName, string lastName, string id)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            AdmissionExamGrades = new decimal[7]; //The size is 7, inasmuch as there are 7 exams at all.
            Signature = new Signature(CreatePassword()); //Create a unique signiture for identifiction.
        }

        //Methods

        public void Apply(University university, University.Faculty faculty)
        {
            ApplicationResume resume = new ApplicationResume(this, university, faculty, Signature);
            faculty.GetApplication(resume, Signature);
            Applications.Add(resume);
        }

        public void SetGrade(Exam subject, int grade)//Pass the exam and set the grade
        {
            AdmissionExamGrades[(int)subject] = grade;
        }

        public bool CheckSignature(Signature signature) => (signature == Signature); //Check if the signiture in parameters is equal to the student's signature.

        private static string CreatePassword()//Creating a unique password for the signature.
        {
            StringBuilder sb = new StringBuilder();
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int j = rd.Next(0, 9);
                sb.Append(j + '0');
            }
            return sb.ToString();
        }
    }
}
