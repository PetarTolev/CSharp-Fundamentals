﻿namespace LoggerDemo.Appenders
{
    using Layouts.Contracts;
    using Loggers.Contracts;
    using Loggers.Enums;
    using System;
    using System.IO;

    public class FileAppender : Appender
    {
        private const string Path = @"..\..\..\log.txt";
        private ILogFile logFile;

        public FileAppender(ILayout layout, ILogFile logFile)
            : base(layout)
        {
            this.logFile = logFile;
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel <= reportLevel)
            {
                this.MessageCount++;
                string content = string.Format(this.Layout.Format, dateTime, reportLevel, message) + Environment.NewLine;

                this.logFile.Write(content);

                File.AppendAllText(Path, content);
            }
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, " +
                   $"Report level: {this.ReportLevel.ToString()}, Messages appended: {this.MessageCount}, " +
                   $"File size: {this.logFile.Size}";
        }
    }
}