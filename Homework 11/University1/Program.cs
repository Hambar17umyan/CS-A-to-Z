namespace University1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rector rector = new Rector("Arman", "Sargsyan", Gender.Male, 50, 0);
            University physmath = new University("Physmath", 1000, rector);
            Teacher teacher = new Teacher("Vardan", "Vardanyan", Gender.Male, 61, 1000, Status.OpenToWork, Subject.Mathematics, 0);

            rector.RepresentRector();
            Console.WriteLine();
            teacher.RepresentTeacher();
            Console.WriteLine();
            physmath.Represent();
            Console.WriteLine();

            rector.Hire(teacher);
            Console.WriteLine();
            physmath.Represent();
        }
    }
}
