using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InventoryManager.Data
{
    public class Item: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name { get; set; }
        public int Weight { get; set; }
    }
}
