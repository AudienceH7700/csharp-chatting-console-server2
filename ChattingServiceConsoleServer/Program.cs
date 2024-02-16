namespace ChattingServiceConsoleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            MainServer server = new MainServer();
            server.ConsoleView();
        }
    }
}