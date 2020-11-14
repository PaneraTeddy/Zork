using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace InventoryManager.Data
{
    public class World
    {
        public List<Player> Players { get; set; }
        public List<Item> Items { get; set; }

        public World()
        {
            Players = new List<Player>();
            Items = new List<Item>();
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            foreach (Player player in Players)
            {
                player.BuildInventoryFromNames(Items);
            }
        }
    }
}
