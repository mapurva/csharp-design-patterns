using FacadePattern;

class Program
{
    static void Main(string[] args)
    {
        HomeTheaterFacade theater = new HomeTheaterFacade();

        theater.WatchMovie();
        theater.EndMovie();
    }
}
