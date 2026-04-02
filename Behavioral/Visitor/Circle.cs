namespace VisitorPattern
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}