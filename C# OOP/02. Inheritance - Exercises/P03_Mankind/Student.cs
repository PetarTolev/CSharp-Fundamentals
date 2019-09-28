namespace P03_Mankind
{
    using System;
    using System.Text;
    using System.Linq;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get => this.facultyNumber;

            set
            {
                if (value.Any(s => !char.IsLetterOrDigit(s)) || value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"First Name: {base.FirstName}");
            result.AppendLine($"Last Name: {base.LastName}");
            result.AppendLine($"Faculty number: {this.FacultyNumber}");
            
            return result.ToString().TrimEnd();
        }
    }
}