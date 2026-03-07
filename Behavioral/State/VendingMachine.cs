namespace StatePattern
{
    public class VendingMachine
    {
        public IState State { get; set; }

        public VendingMachine()
        {
            State = new NoCoinState(this);
        }

        public void InsertCoin()
        {
            State.InsertCoin();
        }

        public void PressButton()
        {
            State.PressButton();
        }
    }
}