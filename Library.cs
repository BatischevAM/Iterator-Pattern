using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public class Library
    {
        private readonly List<Book> _books;

        public Library()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public int Count => _books.Count;

        public Book GetBookAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
            return _books[index];
        }

        public IIterator CreateIterator()
        {
            return new LibraryIterator(this);
        }
    }

}
