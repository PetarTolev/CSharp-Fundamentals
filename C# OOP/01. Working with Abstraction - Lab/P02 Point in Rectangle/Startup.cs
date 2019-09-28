namespace P02_Point_in_Rectangle
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            var topLeftgPoint = new Point(input[0], input[1]);
            var bottomRightPoint = new Point(input[2], input[3]);

            var rectangle = new Rectangle(topLeftgPoint, bottomRightPoint);

            var numCommandLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCommandLines; i++)
            {
                var inputCoordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();

                Point point = new Point(inputCoordinates[0], inputCoordinates[1]);

                Console.WriteLine(rectangle.Contains(point));
            }
        }
    }
}