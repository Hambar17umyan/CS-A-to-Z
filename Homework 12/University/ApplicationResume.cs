using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class ApplicationResume
    {
        //Public properties
        public University University { get; } //The university that the student wants to apply for.
        public Student Student { get; } //The student.
        public University.Faculty Faculty { get; } //The exact faculty that the student wants to apply for.
        public ApplicationStatus Status { get; private set; } //The status of application. Is waiting initially
        public (decimal a, decimal b) RequiredGrades => (Student.AdmissionExamGrades[(int)Faculty.RequiredExams.a], Student.AdmissionExamGrades[(int)Faculty.RequiredExams.b]);
        //Scores of the exams that are required for the course..


        //Private field
        private Signature StudentSignature; //Signature of the student.

        //Ctor
        public ApplicationResume(Student student, University university, University.Faculty faculty, Signature signature)
        {
            Student = student;
            Faculty = faculty;
            University = university;
            if (!student.CheckSignature(signature))
                throw new Exception("Student's signature is not correct!");
            Status = ApplicationStatus.Waiting;
        }

        public void ChangeStatus(ApplicationStatus status, string password)
        {
            Status = status;
            if (!University.CheckPassword(password))
                throw new Exception("The method ChangeStatus has been called from an unaccepted caller.");
        }

        public static bool operator <(ApplicationResume a, ApplicationResume b)
        {
            return a.RequiredGrades.a + a.RequiredGrades.a < b.RequiredGrades.a + b.RequiredGrades.b;
        }
        public static bool operator >(ApplicationResume a, ApplicationResume b)
        {
            return a.RequiredGrades.a + a.RequiredGrades.a > b.RequiredGrades.a + b.RequiredGrades.b;
        }
        public static bool operator <=(ApplicationResume a, ApplicationResume b)
        {
            return a.RequiredGrades.a + a.RequiredGrades.a <= b.RequiredGrades.a + b.RequiredGrades.b;
        }
        public static bool operator >=(ApplicationResume a, ApplicationResume b)
        {
            return a.RequiredGrades.a + a.RequiredGrades.a >= b.RequiredGrades.a + b.RequiredGrades.b;
        }
    }

    enum ApplicationStatus
    {
        Waiting,
        Accepted,
        Rejected
    }
}
