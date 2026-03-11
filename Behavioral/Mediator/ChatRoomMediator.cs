using System.Collections.Generic;

namespace MediatorPattern
{
    public class ChatRoomMediator : IChatMediator
    {
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, User sender)
        {
            foreach (var user in users)
            {
                if (user != sender)
                {
                    user.Receive(message);
                }
            }
        }
    }
}