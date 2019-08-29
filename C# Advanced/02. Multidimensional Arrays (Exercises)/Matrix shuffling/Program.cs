namespace Matrix_shuffling
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
            int row = inputDimensions[0];
            int col = inputDimensions[1];

            string[,] matrix = new string[row, col];

            for (int r = 0; r < row; r++)
            {
                string[] currentRow = Console.ReadLine()
                    .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);

                for (int c = 0; c < col; c++)
                {
                    matrix[r, c] = currentRow[c];
                }
            }

            while (true)
            {
                string[] inputCommand = Console.ReadLine()
                    .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);

                if (inputCommand[0] == "END")
                {
                    break;
                }

                if (inputCommand.Length < 5 || inputCommand.Length > 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int row1 = int.Parse(inputCommand[1]);
                int col1 = int.Parse(inputCommand[2]);

                int row2 = int.Parse(inputCommand[3]);
                int col2 = int.Parse(inputCommand[4]);

                if (row1 > matrix.GetLength(0)
                    || row2 > matrix.GetLength(0) 
                    || col1 > matrix.GetLength(1) 
                    || col2 > matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string reminder = matrix[row1, col1];
                matrix[row1, col1] = matrix[row2, col2];
                matrix[row2, col2] = reminder;

                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    for (int c = 0; c < matrix.GetLength(1); c++)
                    {
                        Console.Write(matrix[r, c] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
