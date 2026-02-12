using DecoratorPattern;

class Program
{
    static void Main(string[] args)
    {
        ICoffee coffee = new SimpleCoffee();

        coffee = new MilkDecorator(coffee);
        coffee = new SugarDecorator(coffee);

        Console.WriteLine(coffee.GetDescription());
        Console.WriteLine("Total Cost: " + coffee.GetCost());
    }
}
