using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZorkBuilder.Data
{
    public class Player
    {
        public World World { get; }
        public string WelcomeMessage { get; set; }

        [JsonIgnore]
        // public Room Location { get; private set; }
        public string Location { get; private set; }

        // [JsonIgnore]
        //public string LocationName
        //{
        //    get
        //    {
        //        return Location?.Name;
        //    }
        //    set
        //    {
        //        Location = value;
        //    }
        //}

        public Player(World world, string startingLocation)
        {
            World = world;
            // LocationName = startingLocation;
        }

    }
}
