using System;
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
                        WelcomeMessage = "Welcome to Zork!";
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                        Items = new BindingList<Item>(Array.Empty<Item>());
                        WelcomeMessage = null;
                    }
                }
            }
        }

    }

}
