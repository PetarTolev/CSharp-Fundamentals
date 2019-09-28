namespace P03_Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get => this.weekSalary;

            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get => this.workHoursPerDay;

            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workHoursPerDay = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"First Name: {base.FirstName}");
            result.AppendLine($"Last Name: {base.LastName}");
            result.AppendLine($"Week Salary: {this.WeekSalary:f2}");
            result.AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}");

            decimal salaryPerHour = this.WeekSalary / (5 * this.WorkHoursPerDay);
            result.AppendLine($"Salary per hour: {salaryPerHour:f2}");

            return result.ToString().TrimEnd();
        }
    }
}