namespace TemplateMethodPattern
{
    public class CSVProcessor : DataProcessor
    {
        protected override void LoadData()
        {
            Console.WriteLine("Loading CSV data...");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Processing CSV data...");
        }
    }
}