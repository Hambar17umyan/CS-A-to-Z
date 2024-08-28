using System.Collections;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList<int>list = new CustomLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            foreach (int i in list)
                Console.WriteLine(i);

            list.Remove(1);
            list.RemoveAt(0);
            foreach (int i in list)
                Console.WriteLine(i);
        }
    }

    class CustomLinkedList<T> : IEnumerable<T>
    {
        private Node<T>? Last;
        private Node<T>? First;
        public int Count { get; private set; }
        public IEnumerator<T> GetEnumerator()
        {
            Node<T>? node = First;
            while (node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T newItem)
        {

            if (Last == null)
            {
                Last = new Node<T>(newItem);
                First = Last;
            }
            else
            {
                var newNode = new Node<T>(newItem);
                Last.Next = newNode;
                newNode.Previous = Last;
                Last = newNode;
            }
            Count++;
        }

        public void Remove(T value)//remove first
        {
            Node<T>? node = First;
            while (node != null)
            {
                if (value.Equals(node.Value))
                {
                    if (node.Previous != null)
                    {
                        node.Previous.Next = node.Next;
                    }
                    else
                    {
                        First = node.Next;
                    }
                    if (node.Next != null)
                    {
                        node.Next.Previous = node.Previous;
                    }
                    Count--;
                    break;
                }
            }
        }

        public void RemoveAt(int index)
        {
            Node<T>? node = First;
            if(index >= Count)
                throw new IndexOutOfRangeException();

            Node<T> a = First;
            for (int i = 0; i < index; i++)
            {
                a = a.Next;
            }

            if (node.Previous != null)
            {
                node.Previous.Next = node.Next;
            }
            else
            {
                First = node.Next;
            }
            if (node.Next != null)
            {
                node.Next.Previous = node.Previous;
            }
            Count--;
        }

        public void RemoveAll(T value)
        {
            Node<T>? node = First;
            while (node != null)
            {
                if (value.Equals(node.Value))
                {
                    if (node.Previous != null)
                    {
                        node.Previous.Next = node.Next;
                    }
                    if (node.Next != null)
                    {
                        node.Next.Previous = node.Previous;
                    }
                    Count--;
                }
            }
        }

        private class Node<T1>
        {
            public T1 Value;
            public Node<T1>? Next;
            public Node<T1>? Previous;

            public Node(T1 value)
            {
                Value = value;
            }
        }
    }
}
