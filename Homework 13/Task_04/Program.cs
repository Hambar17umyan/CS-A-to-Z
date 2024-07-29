namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    interface IStudent
    {
        string Name { get; }
        int Age { get; set; }
        int Grade { get; set; }
    }

    class Student : IStudent
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public int Grade { get; set; }
    }
}
