namespace MediatorPattern
{
    public class ChatUser : User
    {
        public ChatUser(IChatMediator mediator, string name)
            : base(mediator, name) {}

        public override void Send(string message)
        {
            Console.WriteLine($"{name} sends: {message}");
            mediator.SendMessage(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{name} receives: {message}");
        }
    }
}