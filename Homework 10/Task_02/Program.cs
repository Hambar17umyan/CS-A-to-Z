namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the variable x: ");
            if (!char.TryParse(Console.ReadLine(), out var x))
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            Console.Write("Enter the variable y: ");
            if (!char.TryParse(Console.ReadLine(), out var y))
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            Swap(ref x, ref y);

            Console.WriteLine($"x: {x}\ny: {y}");
        }

        static void Swap(ref char a, ref char b)
        {
            char y = a;
            a = b;
            b = y;
        }
    }
}
