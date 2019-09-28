namespace P04_Hospital
{
    using System.Linq;

    public class Department
    {
        public Department(string name)
        {
            this.Name = name;
            this.Rooms = new Room[20];

        }

        public string Name { get; private set; }

        public Room[] Rooms { get; private set; }

        public bool IsThereEmptyRooms()
        {
            return Rooms.Any(x => x != null);
        }
    }
}