namespace P04_Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Programs
    {
        public static void Main()
        {
            var doctors = new List<Doctor>();
            var departments = new List<Department>();

            string command = Console.ReadLine();

            while (command != "Output")
            {
                string[] tokens = command.Split();
                var departamentName = tokens[0];

                var firstName = tokens[1];
                var secondName = tokens[2];
                var doctorName = tokens[1] + " " + tokens[2];

                var patient = tokens[3];

                if (!doctors.Any(x => x.firstName == firstName && x.SecondName == secondName))
                {
                    Doctor doctor = new Doctor(firstName, secondName);

                    doctors.Add(doctor);
                }

                if (departments.All(x => x.Name != departamentName))
                {
                    Department department = new Department(departamentName);

                    departments.Add(department);
                }

                var imaMqsto = departments.First(x => x.Name == departamentName).IsThereEmptyRooms();

                if (imaMqsto)
                {
                    int staq = 0;

                    doctors.First(x => x.firstName == firstName && x.SecondName == secondName).AddPatient(patient);

                    for (int st = 0; st < departments.First(x => x.Name == departamentName).Rooms.Length; st++)
                    {
                        if (departments.First(x => x.Name == departamentName).Rooms.Length < 3)
                        {
                            staq = st;
                            break;
                        }
                    }
                    departments.First(x => x.Name == departamentName).Rooms[staq].AddPatientAtBed(patient, staq);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            //while (command != "End")
            //{
            //    string[] args = command.Split();

            //    if (args.Length == 1)
            //    {
            //        Console.WriteLine(string.Join("\n", departments[args[0]].Where(x => x.Count > 0).SelectMany(x => x)));
            //    }
            //    else if (args.Length == 2 && int.TryParse(args[1], out int staq))
            //    {
            //        Console.WriteLine(string.Join("\n", departments[args[0]][staq - 1].OrderBy(x => x)));
            //    }
            //    else
            //    {
            //        Console.WriteLine(string.Join("\n", doctors[args[0] + args[1]].OrderBy(x => x)));
            //    }
            //    command = Console.ReadLine();
            //}
        }
    }
}