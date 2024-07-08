namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    struct Temperature
    {
        public double CelsiusDeg;
        public double Fahrenheit => this.ToFahrenheit();
        public double ToFahrenheit()
        {
            return this.CelsiusDeg * 1.8 + 32;
        }
    }
}
