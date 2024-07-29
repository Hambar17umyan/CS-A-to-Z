namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapes = { new Triangle(3, 4, 5), new Rectangle(7, 9), new Circle(5) };
            foreach(var a in shapes)
            {
                Console.WriteLine(a.CalculateArea());
            }
        }
    }
}
