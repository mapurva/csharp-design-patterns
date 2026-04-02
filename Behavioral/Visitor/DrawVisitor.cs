namespace VisitorPattern
{
    public class DrawVisitor : IVisitor
    {
        public void Visit(Circle circle)
        {
            Console.WriteLine("Drawing Circle");
        }

        public void Visit(Rectangle rectangle)
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
}