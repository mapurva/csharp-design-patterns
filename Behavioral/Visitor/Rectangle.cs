namespace VisitorPattern
{
    public class Rectangle : IShape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}