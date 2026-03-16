namespace IteratorPattern
{
    public interface IAggregate
    {
        IIterator CreateIterator();
    }
}