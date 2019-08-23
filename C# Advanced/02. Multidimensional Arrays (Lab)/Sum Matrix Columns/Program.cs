namespace Sum_Matrix_Columns
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] inputDimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = inputDimensions[0];
            int cols = inputDimensions[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            for (int col = 0; col < cols; col++)
            {
                int sumOfCol = 0;

                for (int row = 0; row < rows; row++)
                {
                    sumOfCol += matrix[row, col];
                }

                Console.WriteLine(sumOfCol);
            }
        }
    }
}
