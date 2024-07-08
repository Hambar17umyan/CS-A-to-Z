namespace Task_07
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

        public static bool operator ==(Point a, Point b)
        {
            return (a.x == b.x && a.y == b.y);
        }
        public static bool operator !=(Point a, Point b)
        {
            return !(a == b);
        }
    }
}
