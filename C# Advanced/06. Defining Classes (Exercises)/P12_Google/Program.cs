namespace P12_Google
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var persons = new Dictionary<string, Person>();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "End")
                {
                    break;
                }

                string[] splitedInputLine = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string personName = splitedInputLine[0];
                string type = splitedInputLine[1];

                if (persons.ContainsKey(personName))
                {
                    switch (type)
                    {
                        case "company":
                            Company company = CreateCompany(splitedInputLine);

                            persons[personName].Company = company;
                            break;
                        case "pokemon":
                            Pokemon pokemon = CreatePokemon(splitedInputLine);

                            persons[personName].Pokemons.Add(pokemon);
                            break;
                        case "car":
                            Car car = CreateCar(splitedInputLine);

                            persons[personName].Car = car;
                            break;
                        case "children":
                            Children children = CreateChildren(splitedInputLine);

                            persons[personName].Childrens.Add(children);
                            break;
                        case "parents":
                            Parent parent = CreateParent(splitedInputLine);

                            persons[personName].Parents.Add(parent);
                            break;
                    }
                }
                else
                {
                    Person person = new Person();

                    switch (type)
                    {
                        case "company":
                            Company company = CreateCompany(splitedInputLine);

                            person.Company = company;
                            break;
                        case "pokemon":
                            Pokemon pokemon = CreatePokemon(splitedInputLine);

                            person.Pokemons.Add(pokemon);
                            break;
                        case "car":
                            Car car = CreateCar(splitedInputLine);

                            person.Car = car;
                            break;
                        case "children":
                            Children children = CreateChildren(splitedInputLine);

                            person.Childrens.Add(children);
                            break;
                        case "parents":
                            Parent parent = CreateParent(splitedInputLine);

                            person.Parents.Add(parent);
                            break;
                    }

                    persons.Add(personName, person);
                }
            }

            string inputPersonForPrint = Console.ReadLine();

            Person personForPrint = persons[inputPersonForPrint];

            Console.WriteLine(inputPersonForPrint);

            if (personForPrint.Company == null)
            {
                Console.WriteLine("Company:");
            }
            else
            {
                Console.WriteLine(personForPrint.Company.ToString());
            }

            if (personForPrint.Car == null)
            {
                Console.WriteLine("Car:");   
            }
            else
            {
                Console.WriteLine(personForPrint.Car.ToString());
            }

            if (personForPrint.Pokemons == null)
            {
                Console.WriteLine("Pokemon:");
            }
            else
            {
                Console.WriteLine("Pokemon:");

                foreach (var pokemon in personForPrint.Pokemons)
                {
                    Console.WriteLine(pokemon.ToString());
                }
            }

            if (personForPrint.Parents == null)
            {
                Console.WriteLine("Parents:");
            }
            else
            {
                Console.WriteLine("Parents:");

                foreach (var parent in personForPrint.Parents)
                {
                    Console.WriteLine(parent.ToString());
                }
            }

            if (personForPrint.Childrens == null)
            {
                Console.WriteLine("Children:");
            }
            else
            {
                Console.WriteLine("Children:");

                foreach (var children in personForPrint.Childrens)
                {
                    Console.WriteLine(children.ToString());
                }
            }
        }

        public static Car CreateCar(string[] splitedInputLine)
        {
            string carModel = splitedInputLine[2];
            int carSpeed = int.Parse(splitedInputLine[3]);

            Car car = new Car(carModel, carSpeed);

            return car;
        }

        public static Children CreateChildren(string[] splitedInputLine)
        {
            string childrenName = splitedInputLine[2];
            string childrenBirthday = splitedInputLine[3];

            Children children = new Children(childrenName, childrenBirthday);

            return children;
        }

        public static Parent CreateParent(string[] splitedInputLine)
        {
            string parentName = splitedInputLine[2];
            string parentBirthDay = splitedInputLine[3];

            Parent parent = new Parent(parentName, parentBirthDay);

            return parent;
        }

        public static Pokemon CreatePokemon(string[] splitedInputLine)
        {
            string pokemonName = splitedInputLine[2];
            string pokemonType = splitedInputLine[3];

            Pokemon pokemon = new Pokemon(pokemonName, pokemonType);

            return pokemon;
        }

        public static Company CreateCompany(string[] splitedInputLine)
        {
            string companyName = splitedInputLine[2];
            string depertment = splitedInputLine[3];
            decimal salary = decimal.Parse(splitedInputLine[4]);

            Company company = new Company(companyName, depertment, salary);

            return company;
        }
    }
}
