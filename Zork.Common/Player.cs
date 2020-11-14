﻿using Newtonsoft.Json;
using Zork.Common;

namespace Zork.Common
{
    public class Player
    {
        public int Moves { get; set; }
        public World World { get; }

        [JsonIgnore]
        public Room Location { get; private set; }

        [JsonIgnore]
        public string LocationName
        {
            get
            {
                return Location?.Name;
            }
            set
            {
                Location = World?.RoomsByName.GetValueOrDefault(value);
            }
        }

        public Player(World world, string startingLocation)
        {
            World = world;
            LocationName = startingLocation;
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room destination);
            if (isValidMove)
            {
                Location = destination;
            }

            return isValidMove;
        }
    }
    public enum Directions
    {
        North,
        South,
        East,
        West,
        Northeast,
        Southeast,
        Northwest,
        Southwest,
        Up,
        Down
    }
}
