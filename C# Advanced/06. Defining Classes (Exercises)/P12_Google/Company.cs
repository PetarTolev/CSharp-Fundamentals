using System;

namespace P12_Google
{
    public class Company
    {
        public Company(string companyName, string department, decimal salary)
        {
            this.CompanyName = companyName;
            this.Department = department;
            this.Salary = salary;
        }

        public string CompanyName { get; set; }

        public string Department { get; set; }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"Company:{Environment.NewLine}{this.CompanyName} {this.Department} {this.Salary:F2}";
        }
    }
}
