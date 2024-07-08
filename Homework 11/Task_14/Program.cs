namespace Task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    struct Money
    {
        public int EUR;
        public int USD;
        public int PS;

        public Money(int eur, int usd, int ps)
        {
            EUR = eur;
            USD = usd;
            PS = ps;
        }
        public static Money operator +(Money a, Money b)
        {
            return new Money(a.EUR + b.EUR, a.USD + b.USD, a.PS + b.PS);
        }
        public static Money operator -(Money a, Money b)
        {
            return new Money(a.EUR - b.EUR, a.USD - b.USD, a.PS - b.PS);
        }

    }
}
