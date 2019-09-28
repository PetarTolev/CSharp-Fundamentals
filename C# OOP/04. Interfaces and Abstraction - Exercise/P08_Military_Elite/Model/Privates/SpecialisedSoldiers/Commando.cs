using System.Text;

namespace P08_Military_Elite.Model.Privates.SpecialisedSoldiers
{
    using Contracts.Privates.SpecialisedSoldiers;
    using System.Collections.Generic;
    using System.Linq;

    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, decimal salary, string corps, List<Mission> missions) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = missions;
        }

        public ICollection<Mission> Missions { get; }

        public void CompleteMission(string codeName)
        {
            Mission mission = Missions
                .FirstOrDefault(x => x.CodeName == codeName);

            if (mission != null)
            {
                mission.State = "Complete";
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine("Missions:");

            foreach (var mission in this.Missions)
            {
                result.AppendLine("  " + mission.ToString());
            }

            return result.ToString().TrimEnd();
        }
    }
}
