namespace Squares_in_Matrix
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] inputDimensions = Console.ReadLine().Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = inputDimensions[0];
            int col = inputDimensions[1];

            int[,] matrix = new int[row, col];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                char[] currentRow = Console.ReadLine().Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = currentRow[c];
                }
            }

            int count = 0;
            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 1; c++)
                {
                    if (matrix[r, c] == matrix[r, c + 1]
                        && matrix[r, c] == matrix[r + 1, c]
                        && matrix[r, c] == matrix[r + 1, c + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
