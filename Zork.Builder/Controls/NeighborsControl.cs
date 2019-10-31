using System.Collections.Generic;
using System.Windows.Forms;
using Zork.Common;

namespace Zork.Builder.Controls
{
    public partial class NeighborsControl : UserControl
    {
        public Room Room
        {
            get => mRoom;
            set
            {
                if (mRoom != value)
                {
                    mRoom = value;
                    if(mRoom != null)
                    {
                        var roomNeighbors = new List<Room>(mRoom.RoomNeighbors);
                        roomNeighbors.Insert(0, NoNeighbor);

                        NeighborsComboBox.SelectedIndexChanged -= NeighborsComboBox_SelectedIndexChanged;
                        NeighborsComboBox.DataSource = roomNeighbors;
                        Neighbors = mRoom.Neighbors.TryGetValue(Directions, out Room neighbors) ? neighbors : NoNeighbor;
                        NeighborsComboBox.SelectedIndexChanged += NeighborsComboBox_SelectedIndexChanged;
                    }
                    else
                    {
                        NeighborsComboBox.DataSource = null;
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
                NeighborsTextBox.Text = mDirections.ToString();
            }
        }

        public Room Neighbors
        {
            get => (Room)NeighborsComboBox.SelectedItem;
            set => NeighborsComboBox.SelectedItem = value;
        }
        public NeighborsControl()
        {
            InitializeComponent();
        }
        private void NeighborsComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(mRoom != null)
            {
                Room neighbors = Neighbors;
                if (neighbors == NoNeighbor)
                {
                    mRoom.Neighbors.Remove(Directions);
                }
                else
                {
                    mRoom.Neighbors[Directions] = neighbors;
                }
            }
        }

        private static readonly Room NoNeighbor = new Room() { Name = "None" };

        private Room mRoom;
        private Directions mDirections;

    }
}
