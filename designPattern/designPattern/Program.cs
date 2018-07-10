using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BookShelf bookShelf = new BookShelf();
            bookShelf.appendBook(new Book("book1aa"));
            bookShelf.appendBook(new Book("book2b"));
            bookShelf.appendBook(new Book("book3ss"));
            bookShelf.appendBook(new Book("book4___"));
            bookShelf.appendBook(new Book("book5_a"));

            IIterator it = bookShelf.iterator();
            Book book;
            while (it.hasNext())
            {
                book = (Book)it.next();
                Console.WriteLine(book.name);
            }
            Console.ReadKey();

        }
    }

    interface IIterator
    {
        bool hasNext();
        Object next();
    }

    interface IAggregate
    {
        IIterator iterator();
    }

    class Book
    {
        public Book(string name_)
        {
            this.name = name_;
        }

        public string name { get; private set; }
    }

    class BookShelf : IAggregate
    {
        public BookShelf()
        {
            _books = new List<Book>();
        }

        public Book getBookAt(int index_)
        {
            return _books[index_];
        }

        public void appendBook(Book book_)
        {
            _books.Add(book_);
        }

        public int getLength()
        {
            return _books.Count();
        }

        public IIterator iterator()
        {
            return new BookShelfIterator(this);
        }

        List<Book> _books;
    }

    class BookShelfIterator : IIterator
    {
        public BookShelfIterator(BookShelf bookShelf_)
        {
            _bookShelf = bookShelf_;
            _index = 0;
        }

        public bool hasNext()
        {
            return (_index < _bookShelf.getLength());
        }

        public Object next()
        {
            Book book = _bookShelf.getBookAt(_index);
            _index++;
            return book;
        }

        BookShelf _bookShelf;
        int _index;
    }





}
