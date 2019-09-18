namespace P01_Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var departments = new Dictionary<string, string[][]>();
            var doctors = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Output")
                {
                    break;
                }

                string[] splitedInput = input.Split();
                string department = splitedInput[0];
                string doctor = $"{splitedInput[1]} {splitedInput[2]}";
                string patient = splitedInput[3];

                if (departments.ContainsKey(department))
                {
                    AddPerson(departments, department, patient);
                }
                else
                {
                    string[][] rooms = new string[20][];

                    rooms[0] = new string[3];

                    rooms[0][0] = patient;

                    departments.Add(department, rooms);
                }

                if (doctors.ContainsKey(doctor) &&
                    !doctors[doctor].Contains(patient))
                {
                    doctors[doctor].Add(patient);
                }
                else
                {
                    List<string> patients = new List<string> {patient};

                    doctors.Add(doctor, patients);
                }
            }

            while (true)
            {
                string[] commandLine = Console.ReadLine().Split();
                string command = commandLine[0];

                if (command == "End")
                {
                    break;
                }

                if (commandLine.Length == 2 && departments.ContainsKey(command))
                {
                    int room = int.Parse(commandLine[1]);

                    if (departments[command] != null)
                    {
                        foreach (var patient in departments[command][room - 1].OrderBy(x => x))
                        {
                            if (patient != null)
                            {
                                Console.WriteLine(patient);
                            }
                        }
                    }
                }
                else if (departments.ContainsKey(command))
                {
                    foreach (var room in departments[command])
                    {
                        if (room != null)
                        {
                            foreach (var patient in room)
                            {
                                if (patient != null)
                                {
                                    Console.WriteLine(patient);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else if (doctors.ContainsKey($"{commandLine[0]} {commandLine[1]}"))
                {
                    string doctorName = $"{commandLine[0]} {commandLine[1]}";

                    foreach (var patient in doctors[doctorName].OrderBy(x => x))
                    {
                        Console.WriteLine(patient);
                    }
                }
            } 
        }

        private static void AddPerson(Dictionary<string, string[][]> departments, string department, string patient)
        {
            for (int room = 0; room < 20; room++)
            {
                if (departments[department][room] == null)
                {
                    departments[department][room] = new string[3];
                }

                if (departments[department][room].Any(x => x == null))
                {
                    for (int bed = 0; bed < 3; bed++)
                    {
                        if (departments[department][room][bed] == null)
                        {
                            departments[department][room][bed] = patient;
                            return;
                        }
                    }
                }
            }
        }
    }
}