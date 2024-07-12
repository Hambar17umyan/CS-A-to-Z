using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class University
    {
        //Private fields
        private List<Faculty> Faculties; //The listed faculties of this university.
        private string Password; //A hidden string which contains a unique password for later authentification.
        private decimal Budget; //The budget of the university

        //Public properties
        public string Name { get; } //The name of the university.
        public DateTime FoundedDate { get; } //The DateTime of the university creation. Is set in ctor.
        public int AvailableSeatCount { get; private set; } //Currently available free seats in the university.
        public int TotalSeatCount { get; private set; } //Total number if seats in university(free or taken).

        //ctor
        public University(string name, int seatCount, decimal initialBudget)
        {
            Name = name;
            FoundedDate = DateTime.Now;
            AvailableSeatCount = TotalSeatCount = seatCount;
            Faculties = new List<Faculty>();
            Budget = initialBudget;

            Password = CreatePassword(); //Unique password
        }

        //Methods
        public void DonateMoney(decimal money)//Donates money to the university budget
        {
            Budget += money;
        }
        public void AddFaculty(string title, TimeSpan programLength, Exam firstRequiredExam, Exam secondRequiredExam, int seatCount)//Add a faculty to the university
        {
            Faculties.Add(new Faculty(this, title, programLength, firstRequiredExam, secondRequiredExam, seatCount, Password));
        }
        public int MaximalNewSeatNumber() => (int)(Budget / ConstructionCompany.MoneyForSingleSeat); //How many seats the university can add to its record if it uses all of its budget.
        public void AddNewSeats(int count) //Ads seats to the university with its budget
        {
            int max = MaximalNewSeatNumber();
            if (max < count)
                throw new Exception("There is no money for that amount of seats to be added");

            TotalSeatCount += count;
            AvailableSeatCount += count;
            Budget -= ConstructionCompany.MoneyForSingleSeat * count;
        }
        private static string CreatePassword() //Creates a password for later authentification.
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
        public bool CheckPassword(string password) => password == Password; //Authentifies the university with its password.


        //Nested class University.Faculty
        internal class Faculty
        {
            //Private fields
            private string Password; //A hidden string which contains a unique password for later authentification. Matches with its university password.
            private List<ApplicationResume> Applications; //Application list that needs to be reviewd.
            private List<StudentModel> Students;//Students that are currently in that faculty.

            //Public properties
            public string Title { get; } //The title of the faculty(f.e. "Applied Mathematics")
            public University University { get; } //The university that contains the faculty.
            public TimeSpan ProgramLength { get; } //Time required for the course in that faculty.
            public (Exam a, Exam b) RequiredExams { get; } //Required exams that are going to be taken in count while admitting students
            public int SeatCount { get; } //The amount of seats that the faculty can use.
            public int AvailableSeatCount { get; private set; } //The remaining amount of free seats in that faculty.

            //Ctor
            public Faculty(University university, string title, TimeSpan programLength, Exam firstRequiredExam, Exam secondRequiredExam, int seatCount, string password)
            {
                if (seatCount > university.AvailableSeatCount) //Ordering more seats for the faculty than the university is able to offer.
                {
                    throw new Exception("There are no enough seats in the University.");
                }
                if (!university.CheckPassword(password)) //As the faculties are created within the university class, this method gets sure that they are not called from another space, as the password is only visiable there.
                {
                    throw new Exception("Method called from an unintented caller.");
                }
                Title = title;
                University = university;
                ProgramLength = programLength;
                RequiredExams = (firstRequiredExam, secondRequiredExam);
                SeatCount = AvailableSeatCount = seatCount;

                Password = password;
                Students = new List<StudentModel>();
                Applications = new List<ApplicationResume>();
            }

            public void GetApplication(ApplicationResume application, Signature signature)//Receive an application from a student.
            {
                if (application.Student.CheckSignature(signature))//Making sure that the method was called with the approval of the student
                    Applications.Add(application);
                else
                    throw new Exception("Student's signature is not correct!");
            }

            public void StartAdmission() //Stop taking applications and start approving and rejecting.
            {
                Applications.Sort(); //Sorting the applications in increasing order of the sum of the required exam grades.

                for (int i = Applications.Count - 1; i >= 0; i--) //Selecting the best applicants due to their high scores.
                {
                    if (AvailableSeatCount == 0) //If there is no more seats for the university, reject the ones with less score.
                    {
                        Applications[i].ChangeStatus(ApplicationStatus.Rejected, Password); //Inform them that their application has been rejected.
                        continue;
                    }
                    AvailableSeatCount--; //Allocate a single seat for the current student.
                    Students.Add(new StudentModel(Applications[i].Student, University, Password)); //Add the record of the student to the list.
                    Applications[i].ChangeStatus(ApplicationStatus.Accepted, Password);//Inform them that their application has been approved.
                }
                Applications.Clear(); //Delete all aplications from the list
            }

            public void StartGraduation() //Start the graduation process by making the students who have been in the university for a while to leave the university.
            {
                List<StudentModel> newList = new List<StudentModel>(); //The new student list.
                DateTime now = DateTime.Now;

                foreach (StudentModel student in Students)
                {
                    if (now - student.AdmissionDate >= ProgramLength) //Passed the entire course.
                    {
                        student.GetRemoved(Password);//Remove the student.
                        continue;//Do not let them appear in the new list, as they have graduated.
                    }
                    newList.Add(student);//Add the student to the new list, as they did not graduate.
                }

                Students = new List<StudentModel>(newList); //Assign the new list to the main one to kep the record
            }
        }
    }
    enum Exam
    {
        Math,
        Science,
        ComputerScience,
        History,
        Linguistics,
        Art,
        Humanism
    }
}
