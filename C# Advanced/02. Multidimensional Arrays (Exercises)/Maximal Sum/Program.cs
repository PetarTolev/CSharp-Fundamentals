namespace Maximal_Sum
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] inputDimensions = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = inputDimensions[0];
            int m = inputDimensions[1];

            int[,] matrix = new int[n, m];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] inputRow = Console.ReadLine()
                    .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = inputRow[c];
                }
            }

            int sumOfSquare = 0;
            int currentSum = 0;

            int rowOfSquare = 0;
            int colOfSquare = 0;

            for (int r = 0; r < matrix.GetLength(0) - 2; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 2; c++)
                {
                    currentSum += matrix[r, c] + matrix[r, c + 1] + matrix[r, c + 2]
                                 + matrix[r + 1, c] + matrix[r + 1, c + 1] + matrix[r + 1, c + 2]
                                 + matrix[r + 2, c] + matrix[r + 2, c + 1] + matrix[r + 2, c + 2];

                    if (currentSum > sumOfSquare)
                    {
                        sumOfSquare = currentSum;
                        rowOfSquare = r;
                        colOfSquare = c;
                    }
                    currentSum = 0;
                }
            }

            Console.WriteLine($"Sum = {sumOfSquare}");

            for (int r = rowOfSquare; r < rowOfSquare + 3; r++)
            {
                for (int c = colOfSquare; c < colOfSquare + 3; c++)
                {
                    Console.Write(matrix[r, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
