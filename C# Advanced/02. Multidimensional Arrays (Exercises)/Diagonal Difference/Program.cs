namespace Diagonal_Difference
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] currentRow = Console.ReadLine().Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int sumFirstDiagonal = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumFirstDiagonal += matrix[i, i];
            }

            int sumSecondDiagonal = 0;
            int count = 0;
            int r = 0;
            int c = matrix.GetLength(0) - 1;

            while (count != matrix.GetLength(0))
            {
                sumSecondDiagonal += matrix[r, c];
                r++;
                c--;
                count++;
            }

            Console.WriteLine(Math.Abs(sumFirstDiagonal - sumSecondDiagonal));
        }
    }
}
