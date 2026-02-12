namespace DecoratorPattern
{
    public class SimpleCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Plain Coffee";
        }

        public double GetCost()
        {
            return 50;
        }
    }
}
