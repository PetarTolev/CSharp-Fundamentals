namespace P08_Pet_Clinic
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            List<Pet> pets = new List<Pet>();
            List<Clinic> clinics = new List<Clinic>();

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] input = Console.ReadLine().Split();

                string command = input[0];
                string petName;
                string clinicName;

                switch (command)
                {
                    case "Create":
                        if (input[1] == "Pet")
                        {
                            string name = input[2];
                            int age = int.Parse(input[3]);
                            string kind = input[4];

                            Pet pet = new Pet(name, age, kind);

                            pets.Add(pet);
                        }
                        else
                        {
                            string name = input[2];
                            int rooms = int.Parse(input[3]);

                            if (rooms % 2 == 0)
                            {
                                Console.WriteLine("Invalid Operation!");
                                break;
                            }

                            Clinic clinic = new Clinic(name, rooms);

                            clinics.Add(clinic);
                        }
                        break;

                    case "Add":
                        petName = input[1];
                        clinicName = input[2];

                        Pet petForAdd = pets.Find(x => x.Name == petName);

                        Console.WriteLine(clinics.Find(x => x.Name == clinicName).Add(petForAdd));
                        break;

                    case "Release":
                        clinicName = input[1];

                        Console.WriteLine(clinics.Find(x => x.Name == clinicName).Release());
                        break;

                    case "HasEmptyRooms":
                        clinicName = input[1];

                        Console.WriteLine(clinics.Find(x => x.Name == clinicName).HasEmptyRooms());
                        break;

                    case "Print":
                        clinicName = input[1];
                        if (input.Length == 2)
                        {
                            List<Pet> rooms = clinics.Find(x => x.Name == clinicName).PrintClinic();

                            foreach (var pet in rooms)
                            {
                                if (pet == null)
                                {
                                    Console.WriteLine("Room empty");
                                }
                                else
                                {
                                    Console.WriteLine(pet.ToString());
                                }
                            }
                            break;
                        }

                        int room = int.Parse(input[2]);

                        Pet petForPrint = clinics.Find(x => x.Name == clinicName).PrintRoom(room);

                        if (petForPrint == null)
                        {
                            Console.WriteLine("Room empty");
                        }
                        else
                        {
                            Console.WriteLine(petForPrint.ToString());
                        }
                        break;
                }
            }
        }
    }
}