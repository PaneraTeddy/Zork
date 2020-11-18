using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using ZorkBuilder.Data;

namespace ZorkBuilder.Winforms.ViewModels
{
    public class WorldViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private World mWorld;
        public string Filename { get; set; }
        public string WelcomeMessage { get; set; }
        public string StartLocation { get; set; }

        public BindingList<Neighbors> Neighbors{ get; set; }

        public BindingList<Room> Rooms { get; set; }

        public BindingList<Item> Items { get; set; }

        public World World
        {
            set
            {
                if (mWorld != value)
                {
                    mWorld = value;
                    if (mWorld != null)
                    {
                        Rooms = new BindingList<Room>(mWorld.Rooms);
                        Items = new BindingList<Item>(mWorld.Items);
                        Neighbors = new BindingList<Neighbors>(mWorld.Neighbors);
                        WelcomeMessage = "Welcome to Zork!";
                        StartLocation = "West of House";

                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                        Items = new BindingList<Item>(Array.Empty<Item>());
                        Neighbors = new BindingList<Neighbors>(Array.Empty<Neighbors>());
                        WelcomeMessage = null;
                    }
                }
            }
        }
        public WorldViewModel(World world = null) => World = world;
        public void SaveWorld()
        {
            if (string.IsNullOrEmpty(Filename))
            {
                throw new InvalidProgramException("Filename expected.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamWriter = new StreamWriter(Filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, mWorld);
            }
        }
        public void RemoveNeighbors(Neighbors neighbors)
        {
            foreach (Room room in Rooms)
            {
                room.ListOfNeighbors.Remove(neighbors);
            }

            Neighbors.Remove(neighbors);
        }
    }

}
