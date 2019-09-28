namespace MortalEngines.Entities
{
    using Contracts;
    using System.Text;

    public class Tank : BaseMachine, ITank
    {
        private bool defenseMode;

        public Tank(string name, double attackPoints, double defensePoints) 
            : base(name, attackPoints += attackPoints - 40, defensePoints += defensePoints + 30, healthPoints: 100)
        {
            this.DefenseMode = true;
        }

        public bool DefenseMode { get; }

        public void ToggleDefenseMode()
        {
            if (this.defenseMode)
            {
                this.defenseMode = false;

                this.AttackPoints += 40;
                this.DefensePoints -= 30;
            }
            else
            {
                this.defenseMode = true;

                this.AttackPoints -= 40;
                this.DefensePoints += 30;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($" - {base.Name}");
            result.AppendLine($" *Type: {nameof(Tank)}");

            result.AppendLine(base.ToString());
            result.AppendLine(this.defenseMode ? " *Defense: ON" : " *Defense: OFF");

            return result.ToString().TrimEnd();
        }
    }
}
