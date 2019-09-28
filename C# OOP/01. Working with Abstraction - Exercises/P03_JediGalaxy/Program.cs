namespace P03_JediGalaxy
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var dimestions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var x = dimestions[0];
            var y = dimestions[1];

            var matrix = new int[x, y];

            var value = 0;

            for (int row = 0; row < x; row++)
            {
                for (int col = 0; col < y; col++)
                {
                    matrix[row, col] = value++;
                }
            }

            var command = Console.ReadLine();
            long sum = 0;

            while (command != "Let the Force be with you")
            {
                var ivoS = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var evil = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var xE = evil[0];
                var yE = evil[1];

                while (xE >= 0 && yE >= 0)
                {
                    if (xE >= 0 && xE < matrix.GetLength(0) && yE >= 0 && yE < matrix.GetLength(1))
                    {
                        matrix[xE, yE] = 0;
                    }
                    xE--;
                    yE--;
                }

                var xI = ivoS[0];
                var yI = ivoS[1];

                while (xI >= 0 && yI < matrix.GetLength(1))
                {
                    if (xI >= 0 && xI < matrix.GetLength(0) && yI >= 0 && yI < matrix.GetLength(1))
                    {
                        sum += matrix[xI, yI];
                    }

                    yI++;
                    xI--;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }
    }
}