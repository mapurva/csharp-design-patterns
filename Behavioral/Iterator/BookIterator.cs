namespace IteratorPattern
{
    public class BookIterator : IIterator
    {
        private BookCollection collection;
        private int position = 0;

        public BookIterator(BookCollection collection)
        {
            this.collection = collection;
        }

        public bool HasNext()
        {
            return position < collection.GetBooks().Count;
        }

        public string Next()
        {
            return collection.GetBooks()[position++];
        }
    }
}