namespace MortalEngines.Core
{
    using Contracts;
    using System;

    public class Engine : IEngine
    {
        public void Run()
        {
            MachinesManager machinesManager = new MachinesManager();

            while (true)
            {
                string input = Console.ReadLine();

                string[] splitedInput = input.Split();
                string command = splitedInput[0];

                if (command == "Quit")
                {
                    break;
                }

                if (command == "HirePilot")
                {
                    string name = splitedInput[1];

                    Console.WriteLine(machinesManager.HirePilot(name));
                }
                else if (command == "PilotReport")
                {
                    string name = splitedInput[1];

                    Console.WriteLine(machinesManager.PilotReport(name));
                }
                else if (command == "ManufactureTank")
                {
                    string name = splitedInput[1];
                    double attack = double.Parse(splitedInput[2]);
                    double defense = double.Parse(splitedInput[3]);

                    Console.WriteLine(machinesManager.ManufactureTank(name, attack, defense));
                }
                else if (command == "ManufactureFighter")
                {
                    string name = splitedInput[1];
                    double attack = double.Parse(splitedInput[2]);
                    double defense = double.Parse(splitedInput[3]);

                    Console.WriteLine(machinesManager.ManufactureFighter(name, attack, defense));
                }
                else if (command == "MachineReport")
                {
                    string name = splitedInput[1];

                    Console.WriteLine(machinesManager.MachineReport(name));
                }
                else if (command == "AggressiveMode")
                {
                    string name = splitedInput[1];

                    Console.WriteLine(machinesManager.ToggleFighterAggressiveMode(name));
                }
                else if (command == "DefenseMode")
                {
                    string name = splitedInput[1];

                    Console.WriteLine(machinesManager.ToggleTankDefenseMode(name));
                }
                else if (command == "Engage")
                {
                    string pilotName = splitedInput[1];
                    string machineName = splitedInput[2];

                    Console.WriteLine(machinesManager.EngageMachine(pilotName, machineName));
                }
                else if (command == "Attack")
                {
                    string attackingMachineName = splitedInput[1];
                    string defensingMachineName = splitedInput[2];

                    Console.WriteLine(machinesManager.AttackMachines(attackingMachineName, defensingMachineName));
                }
            }
        }
    }
}
