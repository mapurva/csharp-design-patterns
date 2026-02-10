using AdapterPattern;

class Program
{
    static void Main(string[] args)
    {
        IPaymentProcessor paymentProcessor = new BankAdapter();

        paymentProcessor.Pay(1500.50);
    }
}
