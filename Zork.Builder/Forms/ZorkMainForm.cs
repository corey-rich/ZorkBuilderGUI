using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Linq;
using Newtonsoft.Json;
using Zork.Builder.ViewModels;
using Zork.Builder.Forms;
using Zork.Common;
using System.Collections.Generic;
using Zork.Builder.Controls;

namespace Zork.Builder
{
    public partial class ZorkMainForm : Form, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

        public ZorkMainForm()
        {
            InitializeComponent();
            mViewModel = new GameViewModel();
            isWorldLoaded = false;
            mNeighborsControlMap = new Dictionary<Directions, NeighborsControl>
            {
                { Directions.North, NorthNeighborsControl },
                { Directions.South, SouthNeighborsControl },
                { Directions.East, EastNeighborsControl },
                { Directions.West, WestNeighborsControl },
            };
        }

        private bool isWorldLoaded 
        {   
            get => mIsWorldLoaded;
            set
            {
                mIsWorldLoaded = value;
                AddButton.Enabled = mIsWorldLoaded;
            }
        }

        #region Menu Strip Items
        //Tool Strip Menu Items
        private void OpenWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                mViewModel.World = game.World;
                roomsBindingSource.DataSource = mViewModel.Rooms;
                mViewModel.Filename = openFileDialog.FileName;
                isWorldLoaded = true;

                Room selectedRoom = RoomListBox.SelectedItem as Room;
                foreach (var control in mNeighborsControlMap.Values)
                {
                    control.Room = selectedRoom;
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) => mViewModel.SaveWorld();
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                mViewModel.Filename = SaveFileDialog.FileName;
                mViewModel.SaveWorld();
            }
        }

        private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        #endregion Menu Strip Items


        #region Add/Delete Buttons
        private void AddButton_Click_1(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room { Name = addRoomForm.RoomName };
                    mViewModel.Rooms.Add(room);
                }
            }
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this Room?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mViewModel.Rooms.Remove((Room)RoomListBox.SelectedItem);
                RoomListBox.SelectedItem = mViewModel.Rooms.FirstOrDefault();
            }
        }
        #endregion

        private void RoomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteButton.Enabled = RoomListBox.SelectedItem != null;

            Room selectedRoom = RoomListBox.SelectedItem as Room;
            foreach (var control in mNeighborsControlMap.Values)
            {
                control.Room = selectedRoom;
            }
        }

        private readonly Dictionary<Directions, NeighborsControl> mNeighborsControlMap;
        private bool mIsWorldLoaded;
        private GameViewModel mViewModel;

    }
}
