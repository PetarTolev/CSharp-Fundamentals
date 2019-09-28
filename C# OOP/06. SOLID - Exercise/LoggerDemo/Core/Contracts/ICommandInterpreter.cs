namespace LoggerDemo.Core.Contracts
{
    public interface ICommandInterpreter
    {
        void AddAppender(string[] args);

        void AddReports(string[] args);

        void PrintInfo();
    }
}