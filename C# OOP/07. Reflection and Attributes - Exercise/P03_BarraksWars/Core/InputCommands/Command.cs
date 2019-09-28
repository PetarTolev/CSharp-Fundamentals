namespace _03BarracksFactory.Core.InputCommand
{
    using Contracts;
    using Factories;

    public abstract class Command : IExecutable
    {
        private string[] data;
        private UnitFactory unitFactory;
        private IRepository unitRepository;

        protected Command(string[] data, UnitFactory unitFactory, IRepository unitRepository)
        {
            this.data = data;
            this.unitFactory = unitFactory;
            this.unitRepository = unitRepository;
        }

        protected string[] Data => this.data;

        protected IUnitFactory UnitFactory => this.unitFactory;

        protected IRepository UnitRepository => this.unitRepository;

        public abstract string Execute();
    }
}
