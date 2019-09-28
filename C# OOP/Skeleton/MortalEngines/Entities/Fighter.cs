namespace MortalEngines.Entities
{
    using Contracts;
    using System.Text;

    public class Fighter : BaseMachine, IFighter
    {
        private bool aggressiveMode;

        public Fighter(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints += attackPoints + 50, defensePoints += defensePoints - 25, healthPoints: 200)
        {
            this.AggressiveMode = true;
        }

        public bool AggressiveMode { get; }

        public void ToggleAggressiveMode()
        {
            if (this.aggressiveMode == false)
            {
                this.aggressiveMode = true;

                this.AttackPoints += 50;
                this.DefensePoints -= 25;
            }
            else
            {
                this.aggressiveMode = false;

                this.AttackPoints -= 50;
                this.DefensePoints += 25;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($" - {base.Name}");
            result.AppendLine($" *Type: {nameof(Fighter)}");

            result.AppendLine(base.ToString());
            result.AppendLine(this.aggressiveMode ? " *Aggressive: ON" : " *Aggressive: OFF");

            return result.ToString().TrimEnd();
        }
    }
}
