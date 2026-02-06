using AbstractFactoryPattern;

class Program
{
    static void Main(string[] args)
    {
        IUIFactory factory;

        // Simulate OS choice
        // string os = "Windows";
        string os = "Mac";

        factory = os == "Windows"
            ? new WindowsFactory()
            : new MacFactory();

        IButton button = factory.CreateButton();
        ICheckbox checkbox = factory.CreateCheckbox();

        button.Render();
        checkbox.Render();
    }
}
