namespace Bomb_the_Basement
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var rowColInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = rowColInput[0];
            int cols = rowColInput[1];

            int[][] matrix = new int[rows][];

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                matrix[rowIndex] = new int[cols];
            }

            var bombParameters = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombRow = bombParameters[0];
            int bombCol = bombParameters[1];
            int bombRadius = bombParameters[2];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    double distance = Math.Sqrt(Math.Pow(row - bombRow, 2) + Math.Pow(col - bombCol, 2));

                    if (distance <= bombRadius)
                    {
                        matrix[row][col] = 1;
                    }
                }
            }

            int[][] tempMatrix = new int[cols][];

            for (int row = 0; row < cols; row++)
            {
                tempMatrix[row] = new int[rows];

                for (int col = 0; col < rows; col++)
                {
                    tempMatrix[row][col] = matrix[col][row];
                }

                tempMatrix[row] = tempMatrix[row].OrderByDescending(x => x).ToArray();
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = tempMatrix[col][row];
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, matrix.Select(y => string.Join("", y))));
        }
    }
}
