namespace Average_Student_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var studentsGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] studentAndGrades = Console.ReadLine().Split();
                string student = studentAndGrades[0];
                double grade = double.Parse(studentAndGrades[1]);

                if (!studentsGrades.ContainsKey(student))
                {
                    List<double> grades = new List<double>();
                    grades.Add(grade);

                    studentsGrades.Add(student, grades);
                }
                else
                {
                    studentsGrades[student].Add(grade);
                }
            }

            foreach (var kvp in studentsGrades)
            {
                Console.Write($"{kvp.Key} -> ");

                foreach (var num in kvp.Value)
                {
                    Console.Write($"{num:F2} ");
                }

                Console.WriteLine($"(avg: {kvp.Value.Average():F2})");
            }
        }
    }
}
