namespace Jagged_Array_Modification
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] inputArr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] inputRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                inputArr[i] = inputRow;
            }

            while (true)
            {
                string inputCommand = Console.ReadLine();

                if (inputCommand == "END")
                {
                    break;
                }

                string[] splitedCommand = inputCommand.Split().ToArray();
                string command = splitedCommand[0];
                int row = int.Parse(splitedCommand[1]);
                int col = int.Parse(splitedCommand[2]);
                int value = int.Parse(splitedCommand[3]);

                if (row > inputArr.Length - 1 || row < 0 || col > inputArr[row].Length || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
            
                if (command == "Add")
                {
                    inputArr[row][col] += value;
                }
                else if (command == "Subtract")
                {
                    inputArr[row][col] -= value;
                }
            }

            foreach (var arr in inputArr)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}
