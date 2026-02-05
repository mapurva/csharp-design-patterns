namespace FactoryMethodPattern
{
    public class ConcreteProductA : IProduct
    {
        public string Operation()
        {
            return "Result of ConcreteProductA";
        }
    }

    public class ConcreteProductB : IProduct
    {
        public string Operation()
        {
            return "Result of ConcreteProductB";
        }
    }
}
