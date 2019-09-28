namespace LoggerDemo.Loggers.Contracts
{
    public interface ILogger
    {
        void Info(string dateTime, string infoMessage);

        void Error(string dateTime, string errorMessage);

        void Warning(string dateTime, string infoMessage);

        void Critical(string dateTime, string infoMessage);

        void Fatal(string dateTime, string infoMessage);
    }
}