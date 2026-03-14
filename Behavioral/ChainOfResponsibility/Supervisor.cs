namespace ChainOfResponsibilityPattern
{
    public class Supervisor : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level == 2)
            {
                Console.WriteLine("Supervisor handled the request.");
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(level);
            }
        }
    }
}