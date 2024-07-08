namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geolocation Yerevan = new Geolocation(726, 5689);
        }
    }

    struct Geolocation
    {
        public double Latitude;
        public double Longitude;

        public Geolocation(double latitude, double longitude) 
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
