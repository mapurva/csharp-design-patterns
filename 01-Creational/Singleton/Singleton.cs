public class Singleton
{
    // Step 1: private static variable to hold the single instance
    private static Singleton _instance;

    // Step 2: private constructor so no one can create object using new
    private Singleton()
    {
        Console.WriteLine("Singleton instance created");
    }

    // Step 3: public static method to get the instance
    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }

    // Example method
    public void ShowMessage()
    {
        Console.WriteLine("Hello from Singleton");
    }
}
