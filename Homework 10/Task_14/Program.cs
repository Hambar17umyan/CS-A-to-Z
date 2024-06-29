namespace Task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length: ");
            if (!int.TryParse(Console.ReadLine(), out var length))
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Console.WriteLine("Width: ");
            if (!int.TryParse(Console.ReadLine(), out var width))
            {
                Console.WriteLine("Wrong input");
                return;
            }

            var res = CalculateRectangleProperties(length, width);
            Console.WriteLine("Perimeter: " + res.P);
            Console.WriteLine("Area: " + res.S);
        }

        static (int P, int S) CalculateRectangleProperties(int length, int width)
        {
            return (2 * (width + length), width * length);
        }
    }
}
