using MediatorPattern;

class Program
{
    static void Main(string[] args)
    {
        ChatRoomMediator chatRoom = new ChatRoomMediator();

        User user1 = new ChatUser(chatRoom, "Apurva");
        User user2 = new ChatUser(chatRoom, "Rahul");
        User user3 = new ChatUser(chatRoom, "Neha");

        chatRoom.AddUser(user1);
        chatRoom.AddUser(user2);
        chatRoom.AddUser(user3);

        user1.Send("Hello everyone!");
    }
}