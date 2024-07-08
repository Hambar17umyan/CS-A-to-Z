namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    struct Rectangle
    {
        public int Width;
        public int Height;
        public Point UpperLeftPoint;
    }

    struct Point
    {
        public double x { get; }
        public double y { get; }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
