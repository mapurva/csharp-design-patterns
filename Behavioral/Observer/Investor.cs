namespace ObserverPattern
{
    public class Investor : IObserver
    {
        private string _name;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(double price)
        {
            Console.WriteLine($"{_name} notified: Stock price changed to {price}");
        }
    }
}