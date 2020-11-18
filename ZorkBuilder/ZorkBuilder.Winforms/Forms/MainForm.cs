using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ZorkBuilder.Data;
using ZorkBuilder.Winforms.Controls;
using ZorkBuilder.Winforms.ViewModels;

namespace ZorkBuilder.Winforms.Forms
{
    public partial class MainForm : Form
    {
        private WorldViewModel mViewModel;
        private bool mIsWorldLoaded;
        private readonly Dictionary<Directions, NeighborsControl> mNeighborsControlMap;

        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;
        private WorldViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                    worldViewModelBindingSource.DataSource = mViewModel;
                }

            }
        }

        private bool IsWorldLoaded
        {
            get => mIsWorldLoaded;
            set
            {
                mIsWorldLoaded = value;
                mainTabControl.Enabled = mIsWorldLoaded;
                saveToolStripMenuItem.Enabled = IsWorldLoaded;
                saveAsToolStripMenuItem.Enabled = IsWorldLoaded;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
            IsWorldLoaded = false;
            mNeighborsControlMap = new Dictionary<Directions, NeighborsControl>
            {
                {Directions.West,westNeighborsControl},
                {Directions.East,eastNeighborsControl },
                {Directions.South,southNeighborsControl},
                {Directions.North,northNeighborsControl }
                
            };
        }


        #region Main Menu
        private void OpeningExistingGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;

                Room selectedRoom = roomsListBox.SelectedItem as Room;
                foreach (var control in mNeighborsControlMap.Values)
                {
                    control.Room = selectedRoom;
                }

                IsWorldLoaded = true;
            }

        }

        #endregion

        private void RoomAddButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room { Name = addRoomForm.RoomName };
                    Neighbors neighbors = new Neighbors { Name = addRoomForm.RoomName };
                    ViewModel.Rooms.Add(room);
                    ViewModel.Neighbors.Add(neighbors);
                }
            }
        }

        private void RoomEditButton_Click(object sender, EventArgs e)
        {
            descriptionTextBox.ReadOnly = false;
        }

        private void RoomDeleteButoon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this Room?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)roomsListBox.SelectedItem);
                // ViewModel.Neighbors.Remove((Neighbors)roomsListBox.SelectedItem);
                roomsListBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
                
            }
        }

        private void ItemAddButton_Click(object sender, EventArgs e)
        {
            using (AddItemForm addItemForm = new AddItemForm())
            {
                if (addItemForm.ShowDialog() == DialogResult.OK)
                {
                    Item item = new Item { Name = addItemForm.ItemName };
                    ViewModel.Items.Add(item);
                }
            }
        }

        private void ItemDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this Item?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Items.Remove((Item)itemListBox.SelectedItem);
                itemListBox.SelectedItem = ViewModel.Items.FirstOrDefault();
            }

        }

        private void RoomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomDeleteButoon.Enabled = roomsListBox.SelectedItem != null;
            Room selectedRoom = roomsListBox.SelectedItem as Room;
            foreach (var control in mNeighborsControlMap.Values)
            {
                control.Room = selectedRoom;
            }

        }
    }
}
