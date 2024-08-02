using System.Collections;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Route Route = new Route();
            Route.Add(new Station("Sasuntsi Davit", "Yerevan"));
            Route.Add(new Station("Shirak Station", "Gyumri"));
            Route.Add(new Station("Batumi Station", "Batumi"));

            foreach (var item in Route)
            {
                item.Introduction();
            }
        }
    }

    class Route : IEnumerable<Station>
    {
        private List<Station> _stations;

        public Route()
        {
            _stations = new List<Station>();
        }
        public IEnumerator<Station> GetEnumerator()
        {
            return new Enumerator(this);
        }

        public void Add(Station station)
        {
            _stations.Add(station);
        }

        public Station GetStation(int ind)
        {
            return _stations[ind];
        }

        IEnumerator<Station> IEnumerable<Station>.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count => _stations.Count;

        private class Enumerator : IEnumerator<Station>
        {
            private List<Station> _stations => _route._stations;
            private Route _route;
            private int _index;
            public Enumerator(Route route)
            {
                _route = route;
                _index = -1;
            }
            public Station Current => _stations[_index];

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                _index++;
                if( _index >= _stations.Count )
                    return false;
                return true;
            }

            public void Reset()
            {
                _index = 0;
            }
        }
    }

    class Station
    {
        public readonly string Name;
        public readonly string CityName;
        public Station(string name, string cityName)
        {
            Name = name;
            CityName = cityName;
        }

        public void Introduction()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Name of the city: " + CityName);
            Console.WriteLine(new string('-', 15));
        }
    }
}
