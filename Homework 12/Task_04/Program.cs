namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A obj;
            B obj1 = new B();
            obj = obj1;
            B obj2 = (B)obj;

            //This will cause an exception
            C obj3 = (C)obj;
        }
    }

    internal class A
    {
        public int a;
        public int b;
    }

    internal class B : A
    {
        public int c;
    }

    internal class C : A
    {
        public string d;
    }

}
