namespace Task_08
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
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

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.x + b.x, a.y + b.y);
        }
    }
}
