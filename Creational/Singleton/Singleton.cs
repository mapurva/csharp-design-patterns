namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();

        private Singleton()
        {
            // Private constructor prevents instantiation
        }

        public static Singleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton instance is working.");
        }
    }
}
