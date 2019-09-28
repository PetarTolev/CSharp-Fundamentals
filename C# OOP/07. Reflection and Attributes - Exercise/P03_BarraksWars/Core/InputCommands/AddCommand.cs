namespace _03BarracksFactory.Core.InputCommand
{
    using Contracts;
    using Factories;

    public class AddCommand : Command
    {
        public AddCommand(string[] data, UnitFactory unitFactory, IRepository unitRepository) 
            : base(data, unitFactory, unitRepository)
        {
        }

        public override string Execute()
        {
            string unitType = Data[1];
            IUnit unitToAdd = this.UnitFactory.CreateUnit(unitType);
            this.UnitRepository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}
