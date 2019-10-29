using System;
using System.Windows.Forms;
using Zork.Common;
using Newtonsoft.Json;
using System.IO;
using Zork.Builder.ViewModels;
using Zork.Builder.Forms;
using System.ComponentModel;

namespace Zork.Builder
{
    public partial class ZorkMainForm : Form, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ZorkMainForm()
        {
            InitializeComponent();
            mViewModel = new GameViewModel();
        }

        //Trying too be able to add rooms but it isn't updating the rooms list box.
        private void AddButton_Click(object sender, EventArgs e)
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

        //Tool Strip Menu Items
        private void OpenWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                mViewModel.World = game.World;
                roomsBindingSource.DataSource = mViewModel.Rooms;
                mViewModel.Filename = openFileDialog.FileName;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mViewModel.SaveWorld();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                mViewModel.Filename = saveFileDialog1.FileName;
                mViewModel.SaveWorld();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private GameViewModel mViewModel;
    }
}
