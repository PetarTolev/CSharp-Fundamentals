namespace Sum_Matrix_Elements
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

            for (int i = 0; i < rows; i++)
            {
                int[] inputArr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = inputArr[j];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));

            int sum = 0;
            foreach (var m in matrix)
            {
                sum += m;
            }

            Console.WriteLine(sum);
        }
    }
}
