namespace P04_Hospital
{
    using System.Collections.Generic;

    public class Doctor
    {
        public Doctor(string firstName, string secondName)
        {
            this.firstName = firstName;
            this.SecondName = secondName;
            this.patients = new List<string>();
        }

        public string firstName { get; private set; }

        public string SecondName { get; private set; }

        public List<string> patients { get; private set; }

        public void AddPatient(string patient)
        {
            this.patients.Add(patient);
        }
    }
}