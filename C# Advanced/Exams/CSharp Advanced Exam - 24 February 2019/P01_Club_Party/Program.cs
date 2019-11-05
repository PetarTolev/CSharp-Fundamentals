namespace P01_Club_Party
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int maximumCapacity = int.Parse(Console.ReadLine());

            string[] inputLine = Console.ReadLine().Split().Reverse().ToArray();

            Queue<char> halls = new Queue<char>();
            Queue<int> reservations = new Queue<int>();

            for (int i = 0; i < inputLine.Length; i++)
            {
                char hall;

                if (char.TryParse(inputLine[i], out hall) && hall >= 60 && hall <= 90 || hall >= 97 && hall <= 122)
                {
                    halls.Enqueue(hall);
                }
                else
                {
                    if (halls.Count > 0)
                    {
                        reservations.Enqueue(int.Parse(inputLine[i]));
                    }
                }
            }

            int n = halls.Count;

            for (int i = 0; i < n; i++)
            {
                char hall = halls.Dequeue();

                int numberOfReservation = reservations.Count;

                List<int> reservationsForPrint = new List<int>();

                for (int j = 0; j < numberOfReservation; j++)
                {
                    if (reservationsForPrint.Sum() + reservations.Peek() > maximumCapacity)
                    {
                        Console.WriteLine($"{hall} -> {string.Join(", ", reservationsForPrint)}");
                        break;
                    }

                    reservationsForPrint.Add(reservations.Dequeue());
                }
            }
        }
    }
}