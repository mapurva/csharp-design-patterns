namespace ProxyPattern
{
    public class RealImage : IImage
    {
        private string _filename;

        public RealImage(string filename)
        {
            _filename = filename;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Loading image {_filename} from disk...");
            Thread.Sleep(3000); // simulate heavy loading
        }

        public void Display()
        {
            Console.WriteLine($"Displaying {_filename}");
        }
    }
}
