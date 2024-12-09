using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public class LibraryIterator : IIterator
    {
        private readonly Library _library;
        private int _current = 0;

        public LibraryIterator(Library library)
        {
            _library = library;
        }

        public bool HasNext()
        {
            return _current < _library.Count;
        }

        public Book Next()
        {
            if (!HasNext())
            {
                throw new InvalidOperationException("No more books in the library.");
            }
            return _library.GetBookAt(_current++);
        }
    }
}
