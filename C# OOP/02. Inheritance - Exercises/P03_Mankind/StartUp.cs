namespace P03_Mankind
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                var studentInfo = Console.ReadLine().Split();
                var firstName = studentInfo[0];
                var lastName = studentInfo[1];
                var facultyNumber = studentInfo[2];
                var student = new Student(firstName, lastName, facultyNumber);

                var workerInfo = Console.ReadLine().Split();
                var firstWorkerName = workerInfo[0];
                var lastWorkerName = workerInfo[1];
                var salary = decimal.Parse(workerInfo[2]);
                var workingHours = decimal.Parse(workerInfo[3]);
                var worker = new Worker(firstWorkerName, lastWorkerName, salary, workingHours);
                
                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}