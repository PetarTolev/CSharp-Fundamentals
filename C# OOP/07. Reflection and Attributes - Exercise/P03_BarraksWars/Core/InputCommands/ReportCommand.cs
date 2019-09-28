namespace _03BarracksFactory.Core.InputCommand
{
    using Contracts;
    using Factories;

    public class ReportCommand : Command
    {
        public ReportCommand(string[] data, UnitFactory unitFactory, IRepository unitRepository) 
            : base(data, unitFactory, unitRepository)
        {
        }

        public override string Execute()
        {
            string output = this.UnitRepository.Statistics;
            return output;
        }
    }
}
