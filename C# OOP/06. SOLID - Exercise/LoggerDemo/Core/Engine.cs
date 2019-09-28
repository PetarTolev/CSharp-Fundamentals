namespace LoggerDemo.Core
{
    using Contracts;
    using System;

    public class Engine : IEngine
    {
        private ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            int appendersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < appendersCount; i++)
            {
                string[] appnderArgs = Console.ReadLine()
                    .Split();

                this.commandInterpreter.AddAppender(appnderArgs);
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] reportArgs = input
                    .Split("|");

                this.commandInterpreter.AddReports(reportArgs);

                input = Console.ReadLine();
            }

            this.commandInterpreter.PrintInfo();
        }
    }
}
