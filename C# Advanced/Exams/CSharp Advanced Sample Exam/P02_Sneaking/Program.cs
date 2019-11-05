namespace P02_Sneaking
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            char[][] room = new char[numberOfLines][];

            int samRow = -1;
            int samCol = -1;

            for (int i = 0; i < numberOfLines; i++)
            {
                char[] line = Console.ReadLine().ToCharArray();

                room[i] = line;

                if (room[i].Contains('S'))
                {
                    samRow = i;
                    samCol = Array.FindIndex(room[i], x => x == 'S');
                    room[samRow][samCol] = '.';
                }
            }

            char[] commands = Console.ReadLine().ToCharArray();

            foreach (var command in commands)
            {
                MoveEnemies(room);

                if (room[samRow].Contains('b') && Array.IndexOf(room[samRow], 'b') < samCol ||
                    room[samRow].Contains('d') && Array.IndexOf(room[samRow], 'd') > samCol)
                {
                    room[samRow][samCol] = 'X';
                    Console.WriteLine($"Sam died at {samRow}, {samCol}");
                    break;
                }

                switch (command)
                {
                    case 'U':
                        samRow--;
                        break;
                    case 'D':
                        samRow++;
                        break;
                    case 'R':
                        samCol++;
                        break;
                    case 'L':
                        samCol--;
                        break;
                }

                if (room[samRow][samCol] == 'b' || room[samRow][samCol] == 'd')
                {
                    room[samRow][samCol] = '.';
                }

                if (room[samRow].Contains('N'))
                {
                    int index = Array.IndexOf(room[samRow], 'N');
                    room[samRow][index] = 'X';
                    room[samRow][samCol] = 'S';
                    Console.WriteLine("Nikoladze killed!");
                    break;
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, room.Select(x => string.Join("", x))));
        }

        private static void MoveEnemies(char[][] room)
        {
            for (int i = 0; i < room.Length; i++)
            {
                int rowLength = room[i].Length;

                if (room[i].Contains('b') && Array.IndexOf(room[i], 'b') < rowLength - 1)
                {
                    int index = Array.IndexOf(room[i], 'b');
                    room[i][index] = '.';
                    room[i][index + 1] = 'b';
                }
                else if (room[i].Contains('b') && Array.IndexOf(room[i], 'b') == rowLength - 1)
                {
                    room[i][rowLength - 1] = 'd';
                }
                else if (room[i].Contains('d') && Array.IndexOf(room[i], 'd') > 0)
                {
                    int index = Array.IndexOf(room[i], 'd');
                    room[i][index] = '.';
                    room[i][index - 1] = 'd';
                }
                else if (room[i].Contains('d') && Array.IndexOf(room[i], 'd') == 0)
                {
                    room[i][0] = 'b';
                }
            }
        }
    }
}