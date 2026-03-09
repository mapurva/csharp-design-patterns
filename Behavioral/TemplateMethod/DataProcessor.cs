namespace TemplateMethodPattern
{
    public abstract class DataProcessor
    {
        public void Process()
        {
            LoadData();
            ProcessData();
            SaveResults();
        }

        protected abstract void LoadData();
        protected abstract void ProcessData();

        protected void SaveResults()
        {
            Console.WriteLine("Saving results...");
        }
    }
}