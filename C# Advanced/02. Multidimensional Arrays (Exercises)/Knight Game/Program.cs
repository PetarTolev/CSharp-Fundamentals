namespace Knight_Game
{
    using System;
    
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char[][] matrix = new char[n][];

            for (int rowIndex = 0; rowIndex < n; rowIndex++)
            {
                matrix[rowIndex] = Console.ReadLine().ToCharArray();
            }

            int removedHorses = 0;

            while (true)
            {
                int knightRow = -1;
                int knightCow = -1;
                int maxAttacked = 0;

                for (int rowIndex = 0; rowIndex < n; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < n; colIndex++)
                    {
                        if (matrix[rowIndex][colIndex] == 'K')
                        {
                            int tempAttack = CountAtacks(matrix, rowIndex, colIndex);

                            if (tempAttack > maxAttacked)
                            {
                                maxAttacked = tempAttack;
                                knightRow = rowIndex;
                                knightCow = colIndex;
                            }
                        }
                    }
                }

                if (maxAttacked > 0)
                {
                    matrix[knightRow][knightCow] = '0';
                    removedHorses++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(removedHorses);
        }

        private static int CountAtacks(char[][] matrix, int rowIndex, int colIndex)
        {
            int attacks = 0;

            if (IsInMatrix(rowIndex - 1, colIndex - 2, matrix.Length) && matrix[rowIndex - 1][colIndex - 2] == 'K')
            {
                attacks++;
            }

            if (IsInMatrix(rowIndex - 2, colIndex - 1, matrix.Length) && matrix[rowIndex - 2][colIndex - 1] == 'K')
            {
                attacks++;
            }

            if (IsInMatrix(rowIndex - 1, colIndex + 2, matrix.Length) && matrix[rowIndex - 1][colIndex + 2] == 'K')
            {
                attacks++;
            }

            if (IsInMatrix(rowIndex - 2, colIndex + 1, matrix.Length) && matrix[rowIndex - 2][colIndex + 1] == 'K')
            {
                attacks++;
            }

            if (IsInMatrix(rowIndex + 1, colIndex - 2, matrix.Length) && matrix[rowIndex + 1][colIndex - 2] == 'K')
            {
                attacks++;
            }

            if (IsInMatrix(rowIndex + 2, colIndex - 1, matrix.Length) && matrix[rowIndex + 2][colIndex - 1] == 'K')
            {
                attacks++;
            }

            if (IsInMatrix(rowIndex + 1, colIndex + 2, matrix.Length) && matrix[rowIndex + 1][colIndex + 2] == 'K')
            {
                attacks++;
            }

            if (IsInMatrix(rowIndex + 2, colIndex + 1, matrix.Length) && matrix[rowIndex + 2][colIndex + 1] == 'K')
            {
                attacks++;
            }

            return attacks;
        }

        private static bool IsInMatrix(int rowIndex, int colIndex, int matrixLength)
        {
            return rowIndex >= 0 && rowIndex < matrixLength && colIndex >= 0 && colIndex < matrixLength;
        }
    }
}