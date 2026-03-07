using StatePattern;

class Program
{
    static void Main(string[] args)
    {
        VendingMachine machine = new VendingMachine();

        machine.PressButton();
        machine.InsertCoin();
        machine.InsertCoin();
        machine.PressButton();
        machine.PressButton();
    }
}