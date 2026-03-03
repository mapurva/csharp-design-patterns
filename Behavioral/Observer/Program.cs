using ObserverPattern;

class Program
{
    static void Main(string[] args)
    {
        Stock stock = new Stock();

        Investor investor1 = new Investor("Apurva");
        Investor investor2 = new Investor("Rahul");

        stock.Attach(investor1);
        stock.Attach(investor2);

        stock.SetPrice(1000);
        stock.SetPrice(1200);

        stock.Detach(investor1);

        stock.SetPrice(1500);
    }
}