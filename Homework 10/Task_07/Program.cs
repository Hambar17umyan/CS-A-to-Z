namespace Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the first number:");
            if (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            Console.WriteLine("Enter the second number:");
            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            int sum, product;
            Calculator(a, b, out product, out sum);

            Console.WriteLine($"The sum: {sum}");
            Console.WriteLine($"The product: {product}");
        }

        static void Calculator(int a, int b, out int product, out int sum)
        {
            sum = a + b;
            product = a * b;
        }
    }
}
