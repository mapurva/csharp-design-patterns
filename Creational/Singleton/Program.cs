using SingletonPattern;

class Program
{
    static void Main(string[] args)
    {
        Singleton s1 = Singleton.Instance;
        Singleton s2 = Singleton.Instance;

        s1.DoSomething();

        if (ReferenceEquals(s1, s2))
        {
            Console.WriteLine("Both references point to the same instance.");
        }
    }
}
