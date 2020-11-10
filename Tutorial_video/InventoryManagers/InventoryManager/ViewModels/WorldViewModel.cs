using InventoryManager.Data;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace InventoryManager.ViewModels
{
    public class WorldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string FileName { get; set; }
        public World World { get; set; }
    }
}
