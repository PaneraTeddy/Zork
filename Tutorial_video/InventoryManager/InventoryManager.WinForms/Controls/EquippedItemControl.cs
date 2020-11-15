﻿using InventoryManager.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryManager.WinForms.Controls
{
    public partial class EquippedItemControl : UserControl
    {
        private EquipLocations mEquipLoction;
        private Player mPlayer;
        private static readonly Item NoItem = new Item() { Name = "None" };
        public Player Player
        {
            get => mPlayer;
            set
            {
                if (mPlayer != value)
                {
                    mPlayer = value;

                    if (mPlayer != null)
                    {
                        var inventory = new List<Item>(mPlayer.Inventory);
                        inventory.Insert(0, NoItem);
                        equippedItemComboBox.SelectedIndexChanged -= EquippedItemComboBox_SelectedIndexChanged;

                        equippedItemComboBox.DataSource = inventory;
                        EquippedItem = mPlayer.EquippedItems.TryGetValue(EquipLocation, out Item equippedItem)? equippedItem: NoItem;

                        equippedItemComboBox.SelectedIndexChanged += EquippedItemComboBox_SelectedIndexChanged;

                    }
                    else 
                    {
                        equippedItemComboBox.DataSource = null;
                    }
                }
            }
        }
        public EquipLocations EquipLocation
        {
            get => mEquipLoction;
            set
            {
                mEquipLoction = value;
                equipLocationTextBox.Text = mEquipLoction.ToString();
            }
        }

        public Item EquippedItem
        { 
            get => (Item)equippedItemComboBox.SelectedItem; 
            set => equippedItemComboBox.SelectedItem = value; 
        }
        public EquippedItemControl()
        {
            InitializeComponent();
        }

        private void EquippedItemComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (mPlayer != null)
            {
                Item equippedItem = EquippedItem;
                if (equippedItem == NoItem)
                {
                    mPlayer.EquippedItems.Remove(EquipLocation);
                }
                else 
                {
                    mPlayer.EquippedItems[EquipLocation] = equippedItem;
                }
            }
        }
    }
}
