using System;
using System.Collections.Generic;
using System.ComponentModel;
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

    }

}
