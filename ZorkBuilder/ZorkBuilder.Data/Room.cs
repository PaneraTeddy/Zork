using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ZorkBuilder.Data
{
    public class Room : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }
        public string Description { get; set; }

        [JsonProperty(PropertyName = "ListOfNeighborsName")]
        private List<string> ListOfNeighborsName { get; set; }

        [JsonProperty(PropertyName = "NeighborDirection")]
        private Dictionary<Directions, string> NeighborDirection { get; set; }

        [JsonIgnore]
        public Dictionary<Directions, Neighbors> NeighborLocation { get; set; }

        [JsonIgnore]
        public List<Neighbors> ListOfNeighbors { get; set; }

        public Room(string name = null, string description = null, List<string> listOfNeighborsName = null, Dictionary<Directions, String> neighboDirection = null)
        {
            Name = name;
            Description = description;
            ListOfNeighborsName = listOfNeighborsName ?? new List<string>();
            ListOfNeighbors = new List<Neighbors>();
            NeighborDirection = neighboDirection;
            NeighborLocation = new Dictionary<Directions, Neighbors>();


        }
        public void BuildListOfNeighborsFromNames(List<Neighbors> neighbors)
        {
            ListOfNeighbors = (from neighborsName in ListOfNeighborsName
                               let neighbor = neighbors.Find(i => i.Name.Equals(neighborsName, System.StringComparison.InvariantCultureIgnoreCase))
                               where neighbor != null
                               select neighbor).ToList();

            ListOfNeighborsName.Clear();
        }

        public void BuildNeighborLocationFromNames(List<Neighbors> neighbors)
        {
            ListOfNeighbors = (from neighborsName in ListOfNeighborsName
                               let neighbor = neighbors.Find(i => i.Name.Equals(neighborsName, System.StringComparison.InvariantCultureIgnoreCase))
                               where neighbor != null
                               select neighbor).ToList();

            ListOfNeighborsName.Clear();
        }

        public class RoomConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType) => objectType.IsAssignableFrom(typeof(Room));

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                JObject jsonObject = JObject.Load(reader);

                string name = jsonObject["Name"].Value<string>();
                string description = jsonObject["Description"].Value<string>();
                List<string> listOfneighbornames = jsonObject["ListOfNeighbor"].ToObject<List<string>>();

                Dictionary<Directions, string> neighborDirection;
                if (jsonObject.TryGetValue("EquippedItems", out JToken neighborDirectionToken))
                {
                    neighborDirection = neighborDirectionToken.ToObject<Dictionary<Directions, string>>();
                }
                else
                {
                    neighborDirection = new Dictionary<Directions, string>();
                }
                return new Room(name, description, listOfneighbornames, neighborDirection);
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                Room room = (Room)value;
                JToken equippedItemNamesToken = JToken.FromObject(room.NeighborLocation.ToDictionary(pair => pair.Value.Name), serializer);

                JObject roomObject = new JObject
            {
                { nameof(Room.Name), room.Name },
                { nameof(Room.Description), room.Description },
                { nameof(Room.NeighborLocation), equippedItemNamesToken },
                { nameof(Room.ListOfNeighbors), JToken.FromObject(room.ListOfNeighbors.Select(item => item.Name), serializer)},
            };

                roomObject.WriteTo(writer);
            }
        }
    }
}
