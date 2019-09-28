namespace MortalEngines.Entities
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Pilot : IPilot
    {
        private string name;
        private readonly List<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get => this.name;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Pilot name cannot be null or empty string.");
                }

                this.name = value;
            }
        }

        public List<IMachine> Machines { get; }

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new NullReferenceException("Null machine cannot be added to the pilot.");
            }

            this.machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"{this.name} - {this.machines.Count} machines");

            foreach (var machine in this.machines)
            {
                result.AppendLine($"- {machine.Name}");
                result.AppendLine($" *Type: {nameof(machine)}");
                result.AppendLine($" *Health: {machine.HealthPoints}");
                result.AppendLine($" *Attack: {machine.AttackPoints}");
                result.AppendLine($" *Defense: {machine.DefensePoints}");

                if (machine.Targets.Count == 0)
                {
                    result.AppendLine(" *Targets: None");
                }
                else
                {
                    result.AppendLine($" *Targets: {string.Join(", ", machine.Targets)}");
                }
            }

            return result.ToString().TrimEnd();
        }
    }
}
