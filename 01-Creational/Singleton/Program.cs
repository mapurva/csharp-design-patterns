using System;

class Program
{
    static void Main(string[] args)
    {
        // Try to get two instances
        Singleton s1 = Singleton.GetInstance();
        Singleton s2 = Singleton.GetInstance();

        s1.ShowMessage();

        // Check if both references point to same object
        if (s1 == s2)
        {
            Console.WriteLine("Both are same instance");
        }
        else
        {
            Console.WriteLine("Different instances");
        }
    }
}
