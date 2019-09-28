namespace P08_Military_Elite.Model.Privates.SpecialisedSoldiers
{
    using System.Collections.Generic;
    using Contracts.Privates.SpecialisedSoldiers;
    using System.Text;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps, List<Repair> repairs)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = repairs;
        }

        public ICollection<Repair> Repairs { get; }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine("Repairs:");

            foreach (var repair in this.Repairs)
            {
                result.AppendLine("  " + repair.ToString());
            }

            return result.ToString().TrimEnd();
        }
    }
}
