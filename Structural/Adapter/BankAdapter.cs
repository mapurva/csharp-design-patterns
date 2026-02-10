namespace AdapterPattern
{
    public class BankAdapter : IPaymentProcessor
    {
        private LegacyBankAPI _legacyBank;

        public BankAdapter()
        {
            _legacyBank = new LegacyBankAPI();
        }

        public void Pay(double amount)
        {
            // Translating request
            _legacyBank.MakePayment(amount);
        }
    }
}
