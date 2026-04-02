namespace VisitorPattern
{
    public interface IShape
    {
        void Accept(IVisitor visitor);
    }
}