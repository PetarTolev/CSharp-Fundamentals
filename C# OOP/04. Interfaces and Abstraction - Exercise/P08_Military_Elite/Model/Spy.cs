namespace P08_Military_Elite.Model
{
    using Contracts;
    using System.Text;

    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int codeNumber) 
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(base.ToString());
            result.Append($"CodeNumber: {this.CodeNumber}");
            
            return result.ToString();
        }
    }
}
