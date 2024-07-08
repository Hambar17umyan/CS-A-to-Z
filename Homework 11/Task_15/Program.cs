namespace Task_15
{
    internal class Program
    {

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
    struct Line
    {
        public Point A { get; }
        public Point B { get; }

        public Line(Point A, Point B)
        {
            this.A = A;
            this.B = B;
        }
    }
}
