namespace LoggerDemo.Appenders
{
    using Contracts;
    using Layouts.Contracts;
    using Loggers.Enums;

    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        protected ILayout Layout { get; }

        public ReportLevel ReportLevel { get; set; }

        public int MessageCount { get; protected set; }

        public abstract void Append(string dateTime, ReportLevel reportLevel, string message);
    }
}
