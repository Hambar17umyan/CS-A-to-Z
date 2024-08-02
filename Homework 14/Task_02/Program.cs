using System.Collections;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libriary libriary = new Libriary();
            libriary.Add(new Book("Murder on the Orient Express", "Agatha Christie", Genre.Detective | Genre.Criminal));
            libriary.Add(new Book("Dracula", "Bram Stoker", Genre.Melodrama));
            libriary.Add(new Book("A Song of Ice and Fire", "George R. R. Martin", Genre.Fantastic | Genre.Thriller));
            foreach(var a in libriary)
            {
                a.Introduction();
            }
        }
    }

    class Libriary : IEnumerable<Book>
    {
        private List<Book> _books;
        public Libriary()
        {
            _books = new List<Book>();
        }

        public void Add(Book book)
        {
            _books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private class Enumerator : IEnumerator<Book>
        {
            private Libriary _libriary;
            private List<Book> _books => _libriary._books;
            private int index;

            public Book Current 
            {
                get
                {
                    if(index >= 0)
                    {
                        return _books[index];
                    }
                    throw new IndexOutOfRangeException();
                }
            }

            public Enumerator(Libriary libriary)
            {
                _libriary = libriary;
                index = -1;
            }
            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                index++;
                if(index >= _books.Count)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public void Reset()
            {
                index = 0;
            }
        }
    }

    class Book
    {
        public readonly string Name;
        public readonly string AuthorName;
        public readonly Genre Genre;

        public Book(string name, string authorName, Genre genre)
        {
            Name = name;
            AuthorName = authorName;
            Genre = genre;
        }

        public void Introduction()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Aithor's name: " + AuthorName);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine(new string('-', 20));
        }
    }

    [Flags]
    enum Genre
    {
        Fantastic = 1,
        Detective = 2,
        Criminal = 4,
        Melodrama = 8,
        Comedy = 16,
        Thriller = 32
    }
}
