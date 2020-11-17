using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ZorkBuilder.Data
{
    public class Neighbors : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name { get; set; }
    }
}
