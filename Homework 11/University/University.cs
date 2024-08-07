﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University;

namespace University
{
    internal class University
    {
        //Properties
        private string ID;
        public decimal MonthlyFee { get; private set; }
        public string Name { get; private set; }
        public Rector Rector { get; private set; }
        public List<Teacher?> Teachers { get; private set; }
        public List<Student?> Students { get; private set; }
        public Teacher?[] Subjects;
        public decimal MonthlyIncome { get; private set; }
        public decimal MonthlyOutcome { get; private set; }
        public decimal Budget { get; private set; }
        public int StudentCount => Students.Count;
        public int TeacherCount => Teachers.Count;

        //Public Methods
        public University(string name, decimal initialBudget, Rector rector, decimal monthlyFee)
        {
            Name = name;
            Rector = rector;
            Budget = initialBudget;
            ID = CreateId();
            rector.SetUniversity(this, ID);
            Subjects = new Teacher?[7];
            Students = new List<Student?>();
            Teachers = new List<Teacher?>();
            MonthlyFee = monthlyFee;
        }
        public void Represent()
        {
            Console.WriteLine(this.GetType().ToString());
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Rector: " + Rector);

            Console.WriteLine("Students:");
            foreach (var student in Students)
            {
                Console.WriteLine(new string('-', 15));
                student.RepresentStudent();
            }
            Console.WriteLine();
            Console.WriteLine("Teachers:");

            for (int i = 1; i < Subjects.Length; i++)
            {
                Console.WriteLine(new string('-', 15));
                Console.WriteLine("Subject: " + ((Subject)i).ToString());
                if (Subjects[i] == null)
                {
                    continue;
                }
                Subjects[i].RepresentTeacher();
            }
        }
        public bool DeleteTeacher(Teacher t, Signature s)//Because they quit. Returns false if cannot succeed
        {
            if (!t.IsEmployed)
                return false;
            if (t.University != this)
                return false;
            if (t.AuthorizeTheSignature(s))
            {
                bool res = Teachers.Remove(t);
                if (!res)
                    return false;
                MonthlyOutcome -= t.Salary;
                Subjects[(int)t.Subject] = null;

                return true;
            }
            else return false;
        }
        public bool DeleteFiredTeacher(Teacher t, Signature s)
        {
            if (!t.IsEmployed)
                return false;
            if (t.University != this)
                return false;
            if (Rector.AuthorizeTheSignature(s))
            {
                Teachers.Remove(t);
                MonthlyOutcome -= t.Salary;
                Subjects[(int)t.Subject] = null;

                return t.GetFired(s); ;
            }
            else return false;
        }
        public bool AddTeacher(Teacher t, Signature s)
        {
            if (t.IsEmployed)
                return false;
            if (Rector.AuthorizeTheSignature(s) && !t.IsEmployed && t.Status == Status.OpenToWork && MonthlyIncome >= MonthlyOutcome + t.Salary && Subjects[(int)t.Subject] == null)
            {
                Teachers.Add(t);
                MonthlyOutcome += t.Salary;
                Subjects[(int)t.Subject] = t;

                return t.GetHired(s, this);
            }
            else return false;
        }
        public bool AddStudent(Student student, Signature signature)
        {
            if (student.InUniversity)
            {
                return false;
            }
            if (Rector.AuthorizeTheSignature(signature))
            {
                MonthlyIncome += MonthlyFee;
                Students.Add(student);
                return true;
            }
            else return false;
        }

        public bool RemoveStudent(Student student, Signature signature)
        {
            if (student.InUniversity)
            {
                return false;
            }
            if (Rector.AuthorizeTheSignature(signature))
            {
                MonthlyIncome -= MonthlyFee;
                Students.Remove(student);
                return true;
            }
            else return false;
        }

        public bool isAuthorized(string password)
        {
            if (password == this.ID)
                return true;
            return false;
        }
        //Static methods
        private static string CreateId()
        {
            StringBuilder sb = new StringBuilder();
            Random rd = new Random();
            for (int i = 0; i < 15; i++)
            {
                int j = rd.Next(0, 9);
                sb.Append(j + '0');
            }
            return sb.ToString();
        }
    }
}
