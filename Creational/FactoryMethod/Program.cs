using FactoryMethodPattern;

class Program
{
    static void Main(string[] args)
    {
        Creator creatorA = new ConcreteCreatorA();
        Console.WriteLine(creatorA.SomeOperation());

        Creator creatorB = new ConcreteCreatorB();
        Console.WriteLine(creatorB.SomeOperation());
    }
}
