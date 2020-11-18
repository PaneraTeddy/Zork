using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ZorkBuilder.Data
{
    public class World
    {
        public List<Room> Rooms{ get; set; }
        public List<Neighbors> Neighbors { get; set; }
        public List<Item> Items { get; set; }
        public Player player { get; set; }

        public string WelcomeMessage { get; set; }

        public World()
        {
            Rooms = new List<Room>();
            Items = new List<Item>();
            Neighbors = new List<Neighbors>();
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            foreach (Room room in Rooms)
            {
                room.BuildListOfNeighborsFromNames(Neighbors);
                room.BuildNeighborLocationNamesFromNames(Neighbors);
            }
        }
    }
}
