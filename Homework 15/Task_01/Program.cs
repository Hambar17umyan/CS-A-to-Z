using System.Collections;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new RangeGenerator(17, 26);
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }

    class RangeGenerator : IEnumerable<int>
    {
        public readonly int StartValue;
        public readonly int EndValue;

        public RangeGenerator(int start, int end)
        {
            StartValue = start;
            EndValue = end;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for(int i = StartValue; i <= EndValue; i++)
                yield return i;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
