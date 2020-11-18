using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ZorkBuilder.Data
{
    [JsonConverter(typeof(RoomConverter))]
    public class Room : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }

        public string Description { get; set; }

        [JsonProperty(PropertyName = "ListOfNeighbors")]
        private List<string> ListOfNeighborsNames { get; set; }

        [JsonProperty(PropertyName = "NeighborLocations")]
        private Dictionary<Directions, string> NeighborLocationNames { get; set; }

        [JsonIgnore]
        public Dictionary<Directions, Neighbors> NeighborLocations { get; set; }

        [JsonIgnore]
        public List<Neighbors> ListOfNeighbors { get; set; }

        public Room(string name = null, string description = null, List<string> listOfNeighborsNames = null, Dictionary<Directions, String> neighborLocationNames = null)
        {
            Name = name;
            Description = description;
            ListOfNeighborsNames = listOfNeighborsNames ?? new List<string>();
            ListOfNeighbors = new List<Neighbors>();
            NeighborLocationNames = neighborLocationNames;
            NeighborLocations = new Dictionary<Directions, Neighbors>();
        }

        public void BuildListOfNeighborsFromNames(List<Neighbors> neighbors)
        {
            ListOfNeighbors = (from neighborName in ListOfNeighborsNames
                               let neighbor = neighbors.Find(i => i.Name.Equals(neighborName, System.StringComparison.InvariantCultureIgnoreCase))
                               where neighbor != null
                               select neighbor).ToList();

            ListOfNeighborsNames.Clear();
        }

        public void BuildNeighborLocationNamesFromNames(List<Neighbors> neighbors)
        {
            NeighborLocations = (from entry in NeighborLocationNames
                                 let neighbor = neighbors.Find(i => i.Name.Equals(entry.Value, System.StringComparison.InvariantCultureIgnoreCase))
                                 where neighbor != null
                                 select (EquipLocation: entry.Key, Neighbors: neighbor)).
                          ToDictionary(pair => pair.EquipLocation, pair => pair.Neighbors);

            NeighborLocationNames.Clear();
        }

        public override string ToString() => Name;
    }

    public class RoomConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType.IsAssignableFrom(typeof(Room));

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);

            string name = jsonObject["Name"].Value<string>();
            string description = jsonObject["Description"].Value<string>();
            List<string> listOfNeighborsNames = jsonObject["ListOfNeighbors"].ToObject<List<string>>();

            Dictionary<Directions, string> neighborLocationNames;
            if (jsonObject.TryGetValue("NeighborLocations", out JToken neighborLocationNamesToken))
            {
                neighborLocationNames = neighborLocationNamesToken.ToObject<Dictionary<Directions, string>>();
            }
            else
            {
                neighborLocationNames = new Dictionary<Directions, string>();
            }
            return new Room(name, description, listOfNeighborsNames, neighborLocationNames);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Room room = (Room)value;
            JToken neighborLocationNamesToken = JToken.FromObject(room.NeighborLocations.ToDictionary(pair => pair.Value.Name), serializer);

            JObject playerObject = new JObject
            {
                { nameof(Room.Name), room.Name },
                { nameof(Room.Description), room.Description },
                { nameof(Room.NeighborLocations), neighborLocationNamesToken },
                { nameof(Room.ListOfNeighbors), JToken.FromObject(room.ListOfNeighbors.Select(neighbor => neighbor.Name), serializer)},
            };

            playerObject.WriteTo(writer);
        }
    }
}