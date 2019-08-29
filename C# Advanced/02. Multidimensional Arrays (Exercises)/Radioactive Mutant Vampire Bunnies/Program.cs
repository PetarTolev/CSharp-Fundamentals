namespace Radioactive_Mutant_Vampire_Bunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] matrixDimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rows = matrixDimensions[0];
            int cols = matrixDimensions[1];

            char[][] lair = new char[rows][];

            int playerRow = -1;
            int playerCol = -1;

            for (int i = 0; i < rows; i++)
            {
                char[] line = Console.ReadLine().ToCharArray();

                lair[i] = line;

                if (line.Contains('P'))
                {
                    playerRow = i;
                    playerCol = Array.IndexOf(line, 'P');

                    lair[playerRow][playerCol] = '.';
                }
            }

            char[] commands = Console.ReadLine().ToCharArray();

            string result = "";
            bool isGameOver = false;


            foreach (var command in commands)
            {
                if (isGameOver)
                {
                    break;
                }

                if (lair[playerRow][playerCol] == 'B')
                {
                    result = $"dead: {playerRow} {playerCol}";

                    isGameOver = true;
                    break;
                }

                switch (command)
                {
                    case 'U':
                        playerRow--;
                        break;
                    case 'D':
                        playerRow++;
                        break;
                    case 'L':
                        playerCol--;
                        break;
                    case 'R':
                        playerCol++;
                        break;
                }

                if (IsInLair(playerRow, playerCol, rows, cols) == false)
                {
                    switch (command)
                    {
                        case 'U':
                            playerRow++;
                            break;
                        case 'D':
                            playerRow--;
                            break;
                        case 'L':
                            playerCol++;
                            break;
                        case 'R':
                            playerCol--;
                            break;
                    }

                    result = $"won: {playerRow} {playerCol}";
                    
                    isGameOver = true;
                }

                if (lair[playerRow][playerCol] == 'B')
                {
                    result = $"dead: {playerRow} {playerCol}";

                    isGameOver = true;
                }

                SpreadBunnies(lair, rows, cols);
            }

            Console.WriteLine(string.Join(Environment.NewLine, lair.Select(x => string.Join("", x))));
            Console.WriteLine(result);
        }

        private static void SpreadBunnies(char[][] lair, int rows, int cols)
        {
            List<int[]> bunnyCoordinates = new List<int[]>();

            for (int row = 0; row < lair.Length; row++)
            {
                for (int col = 0; col < lair[row].Length; col++)
                {
                    if (lair[row][col] == 'B')
                    {
                        bunnyCoordinates.Add(new[] {row, col});
                    }
                }
            }

            foreach (var coord in bunnyCoordinates)
            {
                int row = coord[0];
                int col = coord[1];

                if (IsInLair(row + 1, col, rows, cols))
                {
                    lair[row + 1][col] = 'B';
                }
                if (IsInLair(row - 1, col, rows, cols))
                {
                    lair[row - 1][col] = 'B';
                }
                if (IsInLair(row, col - 1, rows, cols))
                {
                    lair[row][col - 1] = 'B';
                }
                if (IsInLair(row, col + 1, rows, cols))
                {
                    lair[row][col + 1] = 'B';
                }
            }
        }

        private static bool IsInLair(int row, int col, int rows, int cols)
        {
            if (row < rows && row >= 0 && col < cols && col >= 0)
            {
                return true;
            }

            return false;
        }
    }
}