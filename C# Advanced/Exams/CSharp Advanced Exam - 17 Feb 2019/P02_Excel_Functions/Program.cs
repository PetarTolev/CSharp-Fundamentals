namespace P02_Excel_Functions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            string[] inputHeader = Console.ReadLine().Split(", ", StringSplitOptions.None);
            int numberOfCols = inputHeader.Length;

            string[][] matrix = new string[numberOfRows][];

            matrix[0] = new string[numberOfCols];

            for (int i = 0; i < numberOfCols; i++)
            {
                matrix[0][i] = inputHeader[i];
            }

            for (int rowIndex = 1; rowIndex < numberOfRows; rowIndex++)
            {
                string[] line = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                matrix[rowIndex] = new string[numberOfCols];

                for (int colIndex = 0; colIndex < numberOfCols; colIndex++)
                {
                    matrix[rowIndex][colIndex] = line[colIndex];
                }
            }

            string[] commandProps = Console.ReadLine().Split();

            string command = commandProps[0];
            string header = commandProps[1];

            int index = inputHeader.ToList().IndexOf(header);

            switch (command)
            {
                case "hide":


                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        List<string> arr = matrix[i].ToList();
                        arr.RemoveAt(index);

                        matrix[i] = arr.ToArray();
                    }

                    break;

                case "sort":

                    var ordered = matrix.Skip(1).OrderBy(x => x[index]).ToArray();

                    for (int i = 1; i < matrix.GetLength(0); i++)
                    {
                        matrix[i] = ordered[i - 1];
                    }
                    break;

                case "filter":
                    string value = commandProps[2];

                    Console.WriteLine(string.Join(" | ", inputHeader));
                    for (int i = 1; i < matrix.GetLength(0); i++)
                    {
                        if (matrix[i][index] == value)
                        {
                            Console.WriteLine(string.Join(" | ", matrix[i]));

                        }
                    }
                    return;
            }

            Console.WriteLine(string.Join(Environment.NewLine, matrix.Select(x => string.Join(" | ", x))));
        }
    }
}