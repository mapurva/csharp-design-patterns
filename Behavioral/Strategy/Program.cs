using StrategyPattern;

class Program
{
    static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();

        cart.SetPaymentStrategy(new CreditCardPayment());
        cart.Checkout(1500);

        cart.SetPaymentStrategy(new UPIPayment());
        cart.Checkout(750);

        cart.SetPaymentStrategy(new PayPalPayment());
        cart.Checkout(2200);
    }
}