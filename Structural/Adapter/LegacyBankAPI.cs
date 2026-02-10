namespace AdapterPattern
{
    // This is external library code — cannot be changed
    public class LegacyBankAPI
    {
        public void MakePayment(double value)
        {
            Console.WriteLine($"Payment of {value} processed by Legacy Bank System");
        }
    }
}
