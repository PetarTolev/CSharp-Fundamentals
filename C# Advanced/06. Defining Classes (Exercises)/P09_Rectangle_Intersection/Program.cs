namespace P09_Rectangle_Intersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var rectengles = new Dictionary<string, Rectangle>();

            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = input[0];
            int m = input[1];

            for (int i = 0; i < n; i++)
            {
                string[] inputRectangle = Console.ReadLine().Split();

                string id = inputRectangle[0];
                int width = int.Parse(inputRectangle[1]);
                int height = int.Parse(inputRectangle[2]);
                int lineCoordinate = int.Parse(inputRectangle[3]);
                int rowCoordinate = int.Parse(inputRectangle[4]);

                Rectangle rectangle = new Rectangle(id, width, height, lineCoordinate, rowCoordinate);

                rectengles.Add(id, rectangle);
            }

            for (int i = 0; i < m; i++)
            {
                string[] checkIntersectCommand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Rectangle firstRectangle = rectengles[checkIntersectCommand[0]];
                Rectangle secondRectengle = rectengles[checkIntersectCommand[1]];

                Console.WriteLine(Rectangle.CheckForIntersectBetweenRectagles(firstRectangle, secondRectengle));
            }
        }
    }
}
