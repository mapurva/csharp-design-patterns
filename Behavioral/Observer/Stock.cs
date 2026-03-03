using System.Collections.Generic;

namespace ObserverPattern
{
    public class Stock : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private double _price;

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void SetPrice(double price)
        {
            _price = price;
            Notify();
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_price);
            }
        }
    }
}