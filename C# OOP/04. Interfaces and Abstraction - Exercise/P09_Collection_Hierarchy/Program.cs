namespace P09_Collection_Hierarchy
{
    using Contracts;
    using Models;
    using System;

    public class Program
    {
        public static void Main()
        {
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            string[] input = Console.ReadLine()
                .Split();
            int amountOfRemove = int.Parse(Console.ReadLine());

            AddItems(addCollection, input);
            addRemoveCollection = (AddRemoveCollection)AddItems(addRemoveCollection, input);
            myList = (MyList)AddItems(myList, input);

            RemoveItems(addRemoveCollection, amountOfRemove);
            RemoveItems(myList, amountOfRemove);
        }

        public static IAdd AddItems(IAdd addCollection, string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(addCollection.Add(input[i]) + " ");
            }

            Console.WriteLine();

            return addCollection;
        }

        public static void RemoveItems(IRemove removeCollection, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(removeCollection.Remove() + " ");
            }

            Console.WriteLine();
        }
    }
}
