using System.Collections;

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CityAttractions attractions = new CityAttractions();

            attractions.Add(new Attraction("Botanical Park", "A park in Avan with a great green area.", AttractionCategory.Park));
            attractions.Add(new Attraction("Museum of History", "The museum of Armenian history.", AttractionCategory.Museum));
            attractions.Add(new Attraction("Kovkas", "A tavern with Armenian national kitchen.", AttractionCategory.Restaurant));

            foreach (var attraction in attractions)
            {
                attraction.Introduction();
            }
        }
    }

    class CityAttractions : IEnumerable<Attraction>
    {
        private Node _sartingPoint;
        private Node _LastElement;
        public CityAttractions()
        {
            _sartingPoint = new Node(null);
            _LastElement = _sartingPoint;
        }

        public void Add(Attraction attraction)
        {
            var a = new Node(attraction);
            _LastElement.Next = a;
            _LastElement = a;
        }
        public IEnumerator<Attraction> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class Node
        {
            public Attraction? Current;
            public Node? Next;
            public Node(Attraction attraction)
            {
                Current = attraction;
            }
        }

        private class Enumerator : IEnumerator<Attraction>
        {
            private CityAttractions _attractions;
            private Node CurrentNode;
            public Enumerator(CityAttractions attractions)
            {
                _attractions = attractions;
                CurrentNode = _attractions._sartingPoint;
            }

            Attraction IEnumerator<Attraction>.Current => CurrentNode.Current;

            object IEnumerator.Current => throw new NotImplementedException();

            void IDisposable.Dispose()
            {

            }

            bool IEnumerator.MoveNext()
            {
                CurrentNode = CurrentNode.Next;
                if(CurrentNode == null)
                {
                    return false;
                }
                return true;
            }

            void IEnumerator.Reset()
            {
                CurrentNode = _attractions._sartingPoint;
            }
        }
    }


    class Attraction
    {
        public readonly string Name;
        public readonly string Describtion;
        public readonly AttractionCategory Category;

        public Attraction(string name, string describtion, AttractionCategory category)
        {
            Name = name;
            Describtion = describtion;
            Category = category;
        }

        public void Introduction()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Describtion: " + Describtion);
            Console.WriteLine("Categroy: " + Category);
            Console.WriteLine(new string('-', 20));
        }
    }

    enum AttractionCategory
    {
        Museum,
        Park,
        Restaurant,
        Gallery
    }
}
