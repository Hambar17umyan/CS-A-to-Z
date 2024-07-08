namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDate d = new MyDate(9, Month.November, 2001);
            d.NextDay.show();
            Console.WriteLine();

            d = new MyDate(29, Month.February, 2016);
            d.NextDay.show();
            Console.WriteLine();

            d = new MyDate(28, Month.February, 2016);
            d.NextDay.show();
            Console.WriteLine();

            d = new MyDate(28, Month.February, 2017);
            d.NextDay.show();
            Console.WriteLine();

            d = new MyDate(30, Month.November, 2001);
            d.NextDay.show();
            Console.WriteLine();

            d = new MyDate(30, Month.November, 2001);
            d.NextDay.show();
            Console.WriteLine();

            d = new MyDate(30, Month.December, 2001);
            d.NextDay.show();
            Console.WriteLine();

            d = new MyDate(31, Month.December, 2001);
            d.NextDay.show();
            Console.WriteLine();

            d = new MyDate(31, Month.November, 2001);
            d.NextDay.show();
            Console.WriteLine();
        }
    }

    struct MyDate
    {
        public int Year { get; private set; }
        public Month Month { get; private set; }
        public int Day { get; private set; }
        public MyDate NextDay => this.CalculateNextDay();

        public MyDate(int day, Month month, int year)
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;

            if(month == Month.February)
            {
                if(day > 29)
                {
                    throw new Exception("Invalid date.");
                }
                else if(day == 29)
                {
                    if(!isLeapYear(year))
                    {
                        throw new Exception("Invalid date.");
                    }
                }
            }
            else
            {
                if(day > 31)
                {
                    throw new Exception("Invalid date.");
                }
                else if(day == 31)
                {
                    if(month == Month.April || month == Month.June || month == Month.September || month == Month.November)
                    {
                        throw new Exception("Invalid date.");
                    }
                }
            }
        }

        static bool isLeapYear(int year)
        {
            if (year % 400 == 0)
                return true;
            if (year % 100 == 0)
                return false;
            if (year % 4 == 0)
                return true;
            return false;
        }

        public MyDate CalculateNextDay()
        {
            MyDate NextDay;
            NextDay = this;
            NextDay.Day++;
            if (NextDay.Day == 29)
            {
                if (NextDay.Month == Month.February)
                {
                    if (!isLeapYear(NextDay.Year))
                    {
                        NextDay.Day = 1;
                        NextDay.Month = Month.March;
                    }
                }
            }
            else if (NextDay.Day == 30)
            {
                if (NextDay.Month == Month.February)
                {
                    NextDay.Day = 1;
                    NextDay.Month = Month.March;
                }
            }
            else if (NextDay.Day == 31)
            {
                if (NextDay.Month == Month.April || NextDay.Month == Month.June || NextDay.Month == Month.September || NextDay.Month == Month.November)
                {
                    NextDay.Day = 1;
                    NextDay.Month++;
                }
            }
            else if(NextDay.Day == 32)
            {
                NextDay.Day = 1;
                if(NextDay.Month == Month.December)
                {
                    NextDay.Month = Month.January;
                    NextDay.Year++;
                }
                else
                {
                    NextDay.Month++;
                }
            }

            return NextDay;
        }

        public void show()
        {
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Month: " + Month.ToString());
            Console.WriteLine("Day: " + Day);
        }
    }

    enum Month
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }


}
