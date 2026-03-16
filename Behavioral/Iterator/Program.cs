using IteratorPattern;

class Program
{
    static void Main(string[] args)
    {
        BookCollection collection = new BookCollection();

        collection.AddBook("Design Patterns");
        collection.AddBook("Clean Code");
        collection.AddBook("Refactoring");

        IIterator iterator = collection.CreateIterator();

        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Next());
        }
    }
}