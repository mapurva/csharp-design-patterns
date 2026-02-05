namespace FactoryMethodPattern
{
    public abstract class Creator
    {
        // Factory Method
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            IProduct product = FactoryMethod();
            return $"Creator: working with {product.Operation()}";
        }
    }
}
