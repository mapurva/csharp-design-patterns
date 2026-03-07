namespace StatePattern
{
    public class NoCoinState : IState
    {
        private VendingMachine _machine;

        public NoCoinState(VendingMachine machine)
        {
            _machine = machine;
        }

        public void InsertCoin()
        {
            Console.WriteLine("Coin inserted.");
            _machine.State = new HasCoinState(_machine);
        }

        public void PressButton()
        {
            Console.WriteLine("Insert coin first.");
        }
    }
}