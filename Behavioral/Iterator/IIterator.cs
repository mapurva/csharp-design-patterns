namespace IteratorPattern
{
    public interface IIterator
    {
        bool HasNext();
        string Next();
    }
}