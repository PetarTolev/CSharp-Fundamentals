namespace Square_with_Maximum_Sum
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var inputDimensons = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = inputDimensons[0];
            int cols = inputDimensons[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int sumOfSquare = 0;
            int maxRowIndex = 0;
            int maxColIndex = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum =
                        matrix[row, col] +
                        matrix[row + 1, col] +
                        matrix[row, col + 1] +
                        matrix[row + 1, col + 1];

                    if (sum == sumOfSquare)
                    {
                        continue;
                    }

                    if (sum > sumOfSquare)
                    {
                        sumOfSquare = sum;
                        maxRowIndex = row;
                        maxColIndex = col;
                    }
                }
            }

            for (int row = maxRowIndex; row <= maxRowIndex + 1; row++)
            {
                for (int col = maxColIndex; col <= maxColIndex + 1; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(sumOfSquare);
        }
    }
}
