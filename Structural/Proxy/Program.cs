using ProxyPattern;

class Program
{
    static void Main(string[] args)
    {
        IImage image = new ImageProxy("photo.png");

        Console.WriteLine("Image created but not displayed yet...\n");

        Console.WriteLine("Now displaying image:");
        image.Display();

        Console.WriteLine("\nDisplaying again:");
        image.Display();
    }
}
