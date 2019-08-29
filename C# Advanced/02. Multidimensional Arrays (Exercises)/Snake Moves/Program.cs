namespace Snake_Moves
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] inputDimension = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int row = inputDimension[0];
            int col = inputDimension[1];

            char[,] matrix = new char[row, col];

            string inputWord = Console.ReadLine();

            Queue<char> copyWord = new Queue<char>();

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (copyWord.Count == 0)
                    {
                        copyWord = new Queue<char>(inputWord);
                    }
                    
                    matrix[r, c] = copyWord.Dequeue();
                }
            }

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    Console.Write(matrix[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
