using System.Collections;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint y = uint.Parse(Console.ReadLine());
            FibonacciSequence a = new FibonacciSequence(y);
            foreach (ulong i in a)
                Console.WriteLine(i);
        }
    }

    class FibonacciSequence : IEnumerable<ulong>
    {
        public readonly uint Count;
        private ulong[] seq;

        public FibonacciSequence(uint count)
        {
            if (count > 93)
            {
                throw new ArgumentException("Too big count. Try something less than 94!");
            }

            Count = count;
            seq = new ulong[count];
            if (count >= 1)
            {
                seq[0] = 1;
            }
            if (count >= 2)
            {
                seq[1] = 1;
            }

            for (var i = 2; i < count; i++)
            {
                seq[i] = seq[i - 1] + seq[i - 2];
            }
        }

        public IEnumerator<ulong> GetEnumerator()
        {
            for (var i = 0; i < Count; i++)
                yield return seq[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
