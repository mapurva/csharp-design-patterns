namespace ChainOfResponsibilityPattern
{
    public class BasicSupport : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level == 1)
            {
                Console.WriteLine("Basic Support handled the request.");
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(level);
            }
        }
    }
}