using System.Linq;

namespace P08_Military_Elite.Model.Privates
{
    using Contracts.Privates;
    using System.Collections.Generic;
    using System.Text;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary, List<Private> privates)
            : base(id, firstName, lastName, salary)
        {
            this.Privates = privates;
        }

        public ICollection<Private> Privates { get; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(base.ToString());
            result.AppendLine("Privates:");

            foreach (var @private in this.Privates)
            {
                result.AppendLine("  " + @private.ToString());
            }

            return result.ToString().TrimEnd();
        }
    }
}
