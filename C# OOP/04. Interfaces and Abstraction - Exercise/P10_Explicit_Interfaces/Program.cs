namespace P10_Explicit_Interfaces
{
    using System;

    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] splitedInput = input
                    .Split();
                string name = splitedInput[0];
                string country = splitedInput[1];
                int age = int.Parse(splitedInput[2]);

                IPerson person = new Citizen(name, country, age);
                IResident resident = new Citizen(name, country, age);

                Console.WriteLine(resident.GetName());
                Console.WriteLine(person.GetName());
            }
        }
    }
}
