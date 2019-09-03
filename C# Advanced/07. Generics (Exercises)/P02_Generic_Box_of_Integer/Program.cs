namespace P02_Generic_Box_of_Integer
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                int content = int.Parse(Console.ReadLine());
                
                Box<int> box = new Box<int>(content);

                Console.WriteLine(box.ToString());
            }
        }
    }
}
