using System.Collections.Generic;

namespace IteratorPattern
{
    public class BookCollection : IAggregate
    {
        private List<string> books = new List<string>();

        public void AddBook(string book)
        {
            books.Add(book);
        }

        public List<string> GetBooks()
        {
            return books;
        }

        public IIterator CreateIterator()
        {
            return new BookIterator(this);
        }
    }
}