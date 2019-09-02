namespace DefiningClasses
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string input = Console.ReadLine();

                string[] splitedInput = input.Split();
                string name = splitedInput[0];
                int age = int.Parse(splitedInput[1]);

                Person person = new Person(name, age);

                family.AddMember(person);
            }

            Console.WriteLine($"{family.GetOldestMember().Name} {family.GetOldestMember().Age}");
        }
    }
}
