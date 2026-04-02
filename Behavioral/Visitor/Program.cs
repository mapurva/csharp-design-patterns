using VisitorPattern;

class Program
{
    static void Main(string[] args)
    {
        List<IShape> shapes = new List<IShape>
        {
            new Circle(5),
            new Rectangle(4, 6)
        };

        IVisitor areaVisitor = new AreaVisitor();
        IVisitor drawVisitor = new DrawVisitor();

        Console.WriteLine("Calculating Areas:");
        foreach (var shape in shapes)
        {
            shape.Accept(areaVisitor);
        }

        Console.WriteLine("\nDrawing Shapes:");
        foreach (var shape in shapes)
        {
            shape.Accept(drawVisitor);
        }
    }
}