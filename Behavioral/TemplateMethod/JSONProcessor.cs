namespace TemplateMethodPattern
{
    public class JSONProcessor : DataProcessor
    {
        protected override void LoadData()
        {
            Console.WriteLine("Loading JSON data...");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Processing JSON data...");
        }
    }
}