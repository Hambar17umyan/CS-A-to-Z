namespace Task_03
{
    internal class Motorcycle : Vechile
    {
        public readonly string Color;
        public Motorcycle(int maxSpeed, string color) : base(maxSpeed)
        {
            Color = color;
        }

        public override void Information()
        {
            Console.WriteLine("Maximal speed: " + MaxSpeed);
            Console.WriteLine("Color: " + Color);
        }
    }
}