namespace P04_Hospital
{
    public class Room
    {
        public string[] Beds { get; set; } = new string[3];

        public void AddPatientAtBed(string patient, int position)
        {
            Beds[position] = patient;
        }
    }
}