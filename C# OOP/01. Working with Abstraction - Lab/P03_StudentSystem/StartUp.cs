namespace P03_StudentSystem
{
    using Commands;
    using Students;

    public class StartUp
    {
        public static void Main()
        {
            var commandParser = new CommandParser();
            var studentSystem = new StudentSystem();
            var engine = new Engine(commandParser, studentSystem);

            engine.Run();
        }
    }
}