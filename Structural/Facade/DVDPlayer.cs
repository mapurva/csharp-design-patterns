namespace FacadePattern
{
    public class DVDPlayer
    {
        public void On() => Console.WriteLine("DVD Player ON");
        public void Play() => Console.WriteLine("Playing movie...");
        public void Off() => Console.WriteLine("DVD Player OFF");
    }
}
