namespace FacadePattern
{
    public class HomeTheaterFacade
    {
        private DVDPlayer _dvd;
        private Projector _projector;
        private SoundSystem _sound;

        public HomeTheaterFacade()
        {
            _dvd = new DVDPlayer();
            _projector = new Projector();
            _sound = new SoundSystem();
        }

        public void WatchMovie()
        {
            Console.WriteLine("\nStarting Movie Night...");

            _projector.On();
            _projector.WideScreenMode();

            _sound.On();
            _sound.SetVolume(15);

            _dvd.On();
            _dvd.Play();
        }

        public void EndMovie()
        {
            Console.WriteLine("\nShutting Down Theater...");

            _dvd.Off();
            _sound.Off();
            _projector.Off();
        }
    }
}
