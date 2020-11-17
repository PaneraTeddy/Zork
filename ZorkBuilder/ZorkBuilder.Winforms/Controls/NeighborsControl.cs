using System.Collections.Generic;
using System.Windows.Forms;
using ZorkBuilder.Data;

namespace ZorkBuilder.Winforms.Controls
{
    public partial class NeighborsControl : UserControl
    {
        private Directions mDirections;
        private Room mRoom;
        private static readonly Neighbors NoItem = new Neighbors() { Name = "None" };
        public Room Room
        {
            get => mRoom;
            set
            {
                if (mRoom != value)
                {
                    mRoom = value;

                    if (mRoom != null)
                    {
                        var listofneigbors = new List<Neighbors>(mRoom.ListOfNeighbors);
                        listofneigbors.Insert(0, NoItem);
                        neighborsComboBox.SelectedIndexChanged -= NeighborsComboBox_SelectedIndexChanged;

                        neighborsComboBox.DataSource = listofneigbors;
                        NeighborsName = mRoom.NeighborLocation.TryGetValue(Directions, out Neighbors neighborLocation) ? neighborLocation : NoItem;

                        neighborsComboBox.SelectedIndexChanged += NeighborsComboBox_SelectedIndexChanged;

                    }
                    else
                    {
                        neighborsComboBox.DataSource = null;
                    }
                }
            }
        }

        public Directions Directions
        {
            get => mDirections;
            set
            {
                mDirections = value;
                directionTextBox.Text = mDirections.ToString();
            }
        }

        public NeighborsControl()
        {
            InitializeComponent();
        }

        public Neighbors NeighborsName
        {
            get => (Neighbors)neighborsComboBox.SelectedItem;
            set => neighborsComboBox.SelectedItem = value;
        }

        private void NeighborsComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (mRoom != null)
            {
                Neighbors neighborsName = NeighborsName;
                if (neighborsName == NoItem)
                {
                    mRoom.NeighborLocation.Remove(Directions);
                }
                else
                {
                    mRoom.NeighborLocation[Directions] = neighborsName;
                }
            }

        }
    }
}
