namespace P02_Tron_Racers
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char[][] matrix = new char[n][];

            int fRow = -1;
            int fCol = -1;

            int sRow = -1;
            int sCol = -1;

            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();

                if (matrix[i].Contains('f'))
                {
                    fRow = i;
                    fCol = Array.IndexOf(matrix[i], 'f');
                }
                else if(matrix[i].Contains('s'))
                {
                    sRow = i;
                    sCol = Array.IndexOf(matrix[i], 's');
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                string fCommand = command[0];
                string sCommand = command[1];
                
                fRow = MovePlayer(fCommand, fRow, fCol).Item1;
                fCol = MovePlayer(fCommand, fRow, fCol).Item2;

                sRow = MovePlayer(sCommand, sRow, sCol).Item1;
                sCol = MovePlayer(sCommand, sRow, sCol).Item2;

                fRow = IsInMatrix(fRow, n);
                fCol = IsInMatrix(fCol, n);
                sRow = IsInMatrix(sRow, n);
                sCol = IsInMatrix(sCol, n);

                if (IsDead(matrix, fRow, fCol, 'f') || IsDead(matrix, sRow, sCol, 's'))
                {
                    Console.WriteLine(string.Join(Environment.NewLine, matrix.Select(x => string.Join("", x))));
                    return;
                }
            }
        }

        private static bool IsDead(char[][] matrix, int row, int col, char player)
        {
            if (matrix[row][col] != '*')
            {
                matrix[row][col] = 'x';
                return true;
            }
            else
            {
                matrix[row][col] = player;
                return false;
            }
        }

        private static int IsInMatrix(int row, int n)
        {
            if (row < 0)
            {
                row = n - 1;
            }
            else if (row > n - 1)
            {
                row = 0;
            }

            return row;
        }

        private static Tuple<int, int> MovePlayer(string command, int row, int col)
        {
            switch (command)
            {
                case "up":
                    row--;
                    break;
                case "down":
                    row++;
                    break;
                case "left":
                    col--;
                    break;
                case "right":
                    col++;
                    break;
            }

            Tuple<int,int> tuple = new Tuple<int, int>(row, col);
            return tuple;
        }
    }
}