namespace Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger a, b;
            a = new ConsoleLogger(); 
            b = new FileLogger();

            Service s1, s2;
            s1 = new Service(a, "Hello Console.");
            s2 = new Service(b, "Hello File.");
        }
    }

    class Service
    {
        public Service(ILogger logger, string message)
        {
            logger.Log(message);
        }
    }

    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    class FileLogger : ILogger
    {
        public void Log(string message)
        {
            string path = @"Output.txt";
            File.WriteAllText(path, message);
        }
    }

    interface ILogger
    {
        void Log(string s);
    }


}
