using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class StudentModel : Student
    {
        //Public properties
        public Student Student { get; } //The student that has been taken as a student model in the university.
        public University? University { get; private set; } //The university of model(Null if graduated or has been eliminated).
        public DateTime AdmissionDate { get; } //The DateTime of admission to the university
        public decimal GPA { get; private set; } //The Grade Point Avarage.

        //Ctor
        public StudentModel(Student student, University university, string password) : base(student.FirstName, student.LastName, student.ID)
        {
            if (university == null)
            {
                throw new Exception("The university cannot be null when creating new model.");
            }
            if(!university.CheckPassword(password)) //Check if the method is called within the class of university or not.
            {
                throw new Exception("Method called from an unintented caller.");
            }
            University = university;
            Student = student;
            AdmissionDate = DateTime.Now;
            GPA = 0;
        }

        //Methods
        public void ChangeGPA(decimal newGPA, string password)
        {
            if (!University.CheckPassword(password)) //Check if the method is called within the class of university or not.
            {
                throw new Exception("Method called from an unintented caller.");
            }
            GPA = newGPA;
        }

        public void GetRemoved(string password) //Quit the university
        {
            if (!University.CheckPassword(password)) //Check if the method is called within the class of university or not.
            {
                throw new Exception("Method called from an unintented caller.");
            }
            University = null;
        }
    }
}
