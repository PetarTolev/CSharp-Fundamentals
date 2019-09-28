namespace _03BarracksFactory.Core.InputCommand
{
    using Contracts;
    using Factories;
    using System;

    public class FightCommand : Command
    {
        public FightCommand(string[] data, UnitFactory unitFactory, IRepository unitRepository) : base(data, unitFactory, unitRepository)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return string.Empty;
        }
    }
}
