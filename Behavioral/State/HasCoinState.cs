namespace StatePattern
{
    public class HasCoinState : IState
    {
        private VendingMachine _machine;

        public HasCoinState(VendingMachine machine)
        {
            _machine = machine;
        }

        public void InsertCoin()
        {
            Console.WriteLine("Coin already inserted.");
        }

        public void PressButton()
        {
            Console.WriteLine("Dispensing item...");
            _machine.State = new NoCoinState(_machine);
        }
    }
}