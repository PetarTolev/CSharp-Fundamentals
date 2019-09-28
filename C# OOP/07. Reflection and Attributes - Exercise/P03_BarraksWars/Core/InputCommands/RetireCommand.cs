namespace _03BarracksFactory.Core.InputCommand
{
    using Contracts;
    using Factories;

    public class RetireCommand : Command
    {
        public RetireCommand(string[] data, UnitFactory unitFactory, IRepository unitRepository) 
            : base(data, unitFactory, unitRepository)
        {
        }

        public override string Execute()
        {
            string unitType = this.Data[1];

            this.UnitRepository.RemoveUnit(unitType);

            return $"{unitType} retired!";
        }
    }
}
