namespace P01_ListyIterator
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            ListyIterator<string> list = new ListyIterator<string>(input.Split(" ").Skip(1).ToArray());

            while (true)
            {
                input = Console.ReadLine();

                switch (input)
                {
                    case "Move":
                        Console.WriteLine(list.Move());
                        break;

                    case "Print":
                        list.Print();
                        break;
                        
                    case "HasNext":
                        Console.WriteLine(list.HasNext());
                        break;

                    case "END":
                        return;
                }
            }
        }
    }
}