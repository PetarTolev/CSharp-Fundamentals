namespace P08_Pet_Clinic
{
    using System.Linq;
    using System.Collections.Generic;

    public class Clinic
    {
        private int midIndex;

        public Clinic(string name, int rooms)
        {
            this.Name = name;
            this.Rooms = new Pet[rooms];
            this.midIndex = Rooms.Length / 2;
        }

        public string Name { get; private set; }
        public Pet[] Rooms { get; private set; }

        public bool Add(Pet pet)
        {
            for (int i = 0; i <= midIndex; i++)
            {
                if (this.Rooms[midIndex - i] == null)
                {
                    this.Rooms[midIndex - i] = pet;
                    return true;
                }

                if(this.Rooms[midIndex + i] == null)
                {
                    this.Rooms[midIndex + i] = pet;
                    return true;
                }
            }

            return false;
        }

        public bool Release()
        {
            for (int i = midIndex; i < Rooms.Length - 1; i++)
            {
                if (Rooms[i] != null)
                {
                    Rooms[i] = null;
                    return true;
                }
            }

            for (int i = 0; i < midIndex; i++)
            {
                if (Rooms[i] != null)
                {
                    Rooms[i] = null;
                    return true;
                }
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            if (Rooms.Any(x => x == null))
            {
                return true;
            }

            return false;
        }

        public List<Pet> PrintClinic()
        {
            List<Pet> result = new List<Pet>();

            foreach (var room in Rooms)
            {
                result.Add(room);
            }

            return result;
        }

        public Pet PrintRoom(int roomIndex)
        {
            Pet result = Rooms[roomIndex - 1];

            return result;
        }
    }
}