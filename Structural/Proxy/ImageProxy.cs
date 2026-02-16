namespace ProxyPattern
{
    public class ImageProxy : IImage
    {
        private RealImage _realImage;
        private string _filename;

        public ImageProxy(string filename)
        {
            _filename = filename;
        }

        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_filename);
            }

            _realImage.Display();
        }
    }
}
