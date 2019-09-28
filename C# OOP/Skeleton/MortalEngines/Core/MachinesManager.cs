using System.Reflection;

namespace MortalEngines.Core
{
    using Contracts;
    using Entities;
    using Entities.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class MachinesManager : IMachinesManager
    {
        private List<IPilot> pilots;
        private List<IMachine> machines;

        public MachinesManager()
        {
            this.pilots = new List<IPilot>();
            this.machines = new List<IMachine>();
        }

        public string HirePilot(string name)
        {
            if (!this.pilots.Any(x => x.Name == name))
            {
                IPilot pilot = new Pilot(name);
                pilots.Add(pilot);

                return $"Pilot {name} hired";
            }

            return $"Pilot {name} is hired already";
        }

        public string ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            if (!this.machines.Any(x => x.Name == name))
            {
                ITank tank = new Tank(name, attackPoints, defensePoints);
                machines.Add(tank);

                return $"Tank {name} manufactured - attack: {tank.AttackPoints:F2}; defense: {tank.DefensePoints:F2}";
            }

            return $"Machine {name} is manufactured already";
        }

        public string ManufactureFighter(string name, double attackPoints, double defensePoints)
        {
            if (!this.machines.Any(x => x.Name == name))
            {
                IFighter fighter = new Fighter(name, attackPoints, defensePoints);
                machines.Add(fighter);

                return $"Fighter {name} manufactured - attack: {fighter.AttackPoints:F2}; defense: {fighter.DefensePoints:F2}; aggressive: ON";
            }

            return $"Machine {name} is manufactured already";
        }

        public string EngageMachine(string selectedPilotName, string selectedMachineName)
        {
            Pilot pilot = (Pilot)this.pilots.FirstOrDefault(x => x.Name == selectedPilotName);

            if (pilot == null)
            {
                return $"Pilot {selectedPilotName} could not be found";
            }

            IMachine machine = this.machines.FirstOrDefault(x => x.Name == selectedMachineName);

            if (machine == null)
            {
                return $"Machine {selectedMachineName} could not be found";
            }

            if (machine.Pilot == null)
            {
                machine.Pilot = pilot;

                return $"Pilot {selectedPilotName} engaged machine {selectedMachineName}";
            }
            else
            {
                return $"Machine {selectedMachineName} is already occupied";
            }
        }

        public string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            BaseMachine attackingMachine = (BaseMachine)this.machines.FirstOrDefault(x => x.Name == attackingMachineName);

            if (attackingMachine == null)
            {
                return $"Machine {attackingMachineName} could not be found";
            }

            if (attackingMachine.HealthPoints == 0)
            {
                return $"Dead machine {attackingMachineName} cannot attack or be attacked";
            }

            BaseMachine defendingMachine = (BaseMachine)this.machines.FirstOrDefault(x => x.Name == defendingMachineName);

            if (defendingMachine == null)
            {
                return $"Machine {defendingMachineName} could not be found";
            }

            if (defendingMachine.HealthPoints == 0)
            {
                return $"Dead machine {defendingMachineName} cannot attack or be attacked";
            }
            
            attackingMachine.Attack(defendingMachine);

            return $"Machine {defendingMachineName} was attacked by machine {attackingMachineName} - current health: {defendingMachine.HealthPoints:F2}";
        }

        public string PilotReport(string pilotReporting)
        {
            IPilot pilot = this.pilots.FirstOrDefault(x => x.Name == pilotReporting);

            if (pilot != null)
            {
                return pilot.Report();
            }

            return null; //todo
        }

        public string MachineReport(string machineName)
        {
            var machine = this.machines.FirstOrDefault(x => x.Name == machineName);

            if (machine != null)
            {
                return machine.ToString();
            }

            return null; //todo
        }

        public string ToggleFighterAggressiveMode(string fighterName)
        {
            Fighter fighter = (Fighter) machines.FirstOrDefault(x => x.Name == fighterName);

            if (fighter != null)
            {
                fighter.ToggleAggressiveMode();

                return $"Fighter {fighterName} toggled aggressive mode";
            }

            return $"Machine {fighterName} could not be found";
        }

        public string ToggleTankDefenseMode(string tankName)
        {
            Tank tank = (Tank)this.machines.FirstOrDefault(x => x.Name == tankName);

            if (tank != null)
            {
                tank.ToggleDefenseMode();

                return $"Tank {tankName} toggled defense mode";
            }

            return $"Machine {tankName} could not be found";
        }
    }
}