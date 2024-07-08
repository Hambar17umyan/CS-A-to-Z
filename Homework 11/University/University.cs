using System.Numerics;

namespace University
{
    internal class University
    {
        public decimal MonthlyIncome { get; private set; }
        public decimal MonthlyOutcome { get; private set; }

        public Rector? Rector { get; private set; }
        public decimal Budget { get; private set; }

        public int StudentCount => Students.Count;
        public int TeacherCount => Teachers.Count;

        public Teacher[] SubjectTeacher;

        public List<Teacher>? Teachers { get; }
        public List<Student>? Students { get; }

        public University(decimal initialBudget, Rector rector)
        {
            Budget = initialBudget;
            Teachers = new List<Teacher>();
            Students = new List<Student>();
            SubjectTeacher = new Teacher[7];
            Rector = rector;
            bool b = rector.SetUniversity(this);
            if (!b)
            {
                throw new Exception("The rector has already been employed in other university!");
            }
        }

        public void TryHireTeacher(Teacher newTeacher, Rector rector, out bool success)
        {
            success = true;
            if (newTeacher.Subject == Subject.None)
            {
                success = false;
                return;
            }
            if (newTeacher.Status == UnemployedStatus.OpenToWork && !newTeacher.IsEmployed)
            {
                if (Rector == rector)
                {
                    if (SubjectTeacher[(int)newTeacher.Subject] != null)
                    {
                        if (SubjectTeacher[(int)newTeacher.Subject].Salary < newTeacher.Salary)
                        {
                            FireTeacher(SubjectTeacher[(int)newTeacher.Subject]);
                            HireTeacher(newTeacher);
                            newTeacher.TryAddUniversity(this, signiture, out success);
                            return;

                        }
                    }
                    else if (newTeacher.Salary + MonthlyOutcome <= MonthlyIncome)
                    {
                        HireTeacher(newTeacher);
                        newTeacher.TryAddUniversity(this, signiture, out success);
                        return;
                    }
                }
            }
            success = false;
        }

        private void FireTeacher(Teacher oldTeacher)
        {
            Teachers.Remove(oldTeacher);
            MonthlyOutcome -= oldTeacher.Salary;
            SubjectTeacher[(int)oldTeacher.Subject] = null;
        }
        public void TryFireTeacher(Teacher oldTeacher, Signiture signiture, out bool success)
        {
            success = true;
            if (Rector.isValidSigniture(signiture))
            {
                FireTeacher(oldTeacher);
                oldTeacher.TryRemoveUniversity(this, signiture, out success);
                return;
            }
            success = false;
        }

        public void TryRemoveTeacher(Teacher oldTeacher, Signiture signiture, out bool success)
        {
            success = true;
            if (oldTeacher.isValidSigniture(signiture))
            {
                RemoveTeacher(oldTeacher);
                return;
            }
            success = false;
        }

        private void RemoveTeacher(Teacher teacher)
        {
            Teachers.Remove(teacher);
            MonthlyOutcome -= teacher.Salary;
            SubjectTeacher[(int)teacher.Subject] = null;
        }

        private void HireTeacher(Teacher newTeacher)
        {
            Teachers.Add(newTeacher);
            MonthlyOutcome += newTeacher.Salary;
            SubjectTeacher[(int)newTeacher.Subject] = newTeacher;
        }
    }

    enum Subject
    {
        None = 0,
        English = 1,
        Mathematics = 2,
        Physics = 3,
        Informatics = 4,
        PE = 5,
        Art = 6
    }

    enum UnemployedStatus
    {
        OpenToWork,
        CloseToWork
    }
}
