using TemplateMethodPattern;

class Program
{
    static void Main(string[] args)
    {
        DataProcessor csv = new CSVProcessor();
        csv.Process();

        Console.WriteLine();

        DataProcessor json = new JSONProcessor();
        json.Process();
    }
}