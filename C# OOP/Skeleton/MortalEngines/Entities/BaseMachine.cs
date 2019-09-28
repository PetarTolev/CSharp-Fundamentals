namespace MortalEngines.Entities
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class BaseMachine : IMachine
    {
        private string name;
        private IPilot pilot;
        private double healthPoints;
        private double attackPoints;
        private double defensePoints;
        private IList<string> targets;

        protected BaseMachine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.Name = name;
            this.attackPoints = attackPoints;
            this.defensePoints = defensePoints;
            this.healthPoints = healthPoints;
            targets = new List<string>();
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Machine name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get => this.pilot;

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Pilot cannot be null.");
                }

                this.pilot = value;
            }
        }

        public double HealthPoints { get; set; }

        public double AttackPoints { get; protected set; }
        
        public double DefensePoints { get; protected set; }

        public IList<string> Targets { get; }

        public void Attack(IMachine target)
        {
            if (target == null)
            {
                 throw new NullReferenceException("Target cannot be null");
            }

            target.HealthPoints -= target.DefensePoints - this.attackPoints;

            if (target.HealthPoints < 0)
            {
                target.HealthPoints = 0;
            }

            targets.Add(target.Name);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            
            result.AppendLine($" *Health: {this.healthPoints:F2}");
            result.AppendLine($" *Attack: {this.attackPoints:F2}");
            result.AppendLine($" *Defense: {this.defensePoints:F2}");

            result.AppendLine(this.targets.Count == 0
                ? " *Targets: None"
                : $"* Targets: {string.Join(", ", this.targets)}");

            return result.ToString().TrimEnd();
        }
    }
}
