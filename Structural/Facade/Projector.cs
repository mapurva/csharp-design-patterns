namespace FacadePattern
{
    public class Projector
    {
        public void On() => Console.WriteLine("Projector ON");
        public void WideScreenMode() => Console.WriteLine("Projector in widescreen mode");
        public void Off() => Console.WriteLine("Projector OFF");
    }
}
