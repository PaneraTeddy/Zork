﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InventoryManager.Data
{
    [JsonConverter(typeof(PlayerConverter))]
    public class Player : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }

        public int Health { get; set; }

        public int Score { get; set; }

        [JsonProperty(PropertyName = "Inventory")]
        private List<string> InventoryNames { get; set; }

        [JsonProperty(PropertyName = "EquippedItemNames")]
        private Dictionary<EquipLocations, string> EquippedItemNames { get; set; }
        
        [JsonIgnore]
        public Dictionary<EquipLocations, Item> EquippedItems { get; set; }

        [JsonIgnore]
        public List<Item> Inventory { get; set; }

        

        public Player(string name = null, int health = 0, int score = 0, List<string> inventoryNames = null, Dictionary<EquipLocations, String> equippedItemNames = null)
        {
            Name = name;
            Health = health;
            Score = score;
            InventoryNames = inventoryNames ?? new List<string>();
            Inventory = new List<Item>();
            EquippedItemNames = equippedItemNames;
            EquippedItems = new Dictionary<EquipLocations, Item>();
        }

        public void BuildInventoryFromNames(List<Item> items)
        {
            Inventory = (from itemName in InventoryNames
                         let item = items.Find(i => i.Name.Equals(itemName, System.StringComparison.InvariantCultureIgnoreCase))
                         where item != null
                         select item).ToList();

            InventoryNames.Clear();
        }

        public void BuildEquippedItemNamesFromNames(List<Item> items)
        {
           EquippedItems = (from entry in EquippedItemNames
                         let item = items.Find(i => i.Name.Equals(entry.Value, System.StringComparison.InvariantCultureIgnoreCase))
                         where item != null
                         select (EquipLocation:entry.Key, Item:item)).
                         ToDictionary(pair => pair.EquipLocation, pair => pair.Item);

            EquippedItemNames.Clear();
        }

        public override string ToString() => Name;
    }

    public class PlayerConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType.IsAssignableFrom(typeof(Player));

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);
            
            string name = jsonObject["Name"].Value<string>();
            int health = jsonObject["Health"].Value<int>();
            int score = jsonObject["Score"].Value<int>();
            List<string> inventoryNames = jsonObject["Inventory"].ToObject<List<string>>();

            Dictionary<EquipLocations, string> equippedItemNames;
            if (jsonObject.TryGetValue("EquippedItems", out JToken equippedItemNamesToken))
            {
                equippedItemNames = equippedItemNamesToken.ToObject<Dictionary<EquipLocations, string>>();
            }
            else
            {
                equippedItemNames = new Dictionary<EquipLocations, string>();
            }
            return new Player(name, health, score, inventoryNames, equippedItemNames);                        
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Player player = (Player)value;
            JToken equippedItemNamesToken = JToken.FromObject(player.EquippedItems.ToDictionary(pair => pair.Value.Name), serializer);
            
            JObject playerObject = new JObject
            {
                { nameof(Player.Name), player.Name },
                { nameof(Player.Health), player.Health },
                { nameof(Player.Score), player.Score },
                { nameof(Player.EquippedItems), equippedItemNamesToken },
                { nameof(Player.Inventory), JToken.FromObject(player.Inventory.Select(item => item.Name), serializer)},
            };

            playerObject.WriteTo(writer);
        }
    }
}