namespace P04_Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] peopleFromInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            string[] productsFromInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var p in peopleFromInput)
            {
                string[] personProps = p.Split('=');
                string name = personProps[0];
                decimal money = decimal.Parse(personProps[1]);
                try
                {
                    Person person = new Person(name, money);

                    people.Add(person);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }

            }

            foreach (var pr in productsFromInput)
            {
                string[] productProps = pr.Split('=');
                string name = productProps[0];
                decimal cost = decimal.Parse(productProps[1]);

                try
                {
                    Product product = new Product(name, cost);

                    products.Add(product);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                string[] tokens = command.Split();
                string personName = tokens[0];
                string productName = tokens[1];

                if (people.Any(x => x.Name == personName) && products.Any(x => x.Name == productName))
                {
                    Person person = people.First(x => x.Name == personName);
                    Product product = products.Find(x => x.Name == productName);

                    Console.WriteLine(person.BuyProduct(product));
                }
            }

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
