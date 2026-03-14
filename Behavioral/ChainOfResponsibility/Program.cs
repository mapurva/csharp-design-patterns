using ChainOfResponsibilityPattern;

class Program
{
    static void Main(string[] args)
    {
        SupportHandler basic = new BasicSupport();
        SupportHandler supervisor = new Supervisor();
        SupportHandler manager = new Manager();

        basic.SetNext(supervisor);
        supervisor.SetNext(manager);

        basic.HandleRequest(1);
        basic.HandleRequest(2);
        basic.HandleRequest(3);
        basic.HandleRequest(4);
    }
}