namespace ChainOfResponsibilityPattern
{
    public class Manager : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level == 3)
            {
                Console.WriteLine("Manager handled the request.");
            }
            else
            {
                Console.WriteLine("Request cannot be handled.");
            }
        }
    }
}