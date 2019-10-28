using System;
using System.Windows.Forms;
using Zork.Common;
using Newtonsoft.Json;
using System.IO;
using Zork.Builder.ViewModels;
using Zork.Builder.Forms;

namespace Zork.Builder
{
    public partial class ZorkMainForm : Form
    {
        private GameViewModel ViewModel
        { 
            get => mViewModel;
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                    gameViewModelBindingSource.DataSource = mViewModel;
                }
            }
        }

        public ZorkMainForm()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();
        }

        //Trying too be able to add rooms but it isn't updating the rooms list box.
        private void AddButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room { Name = addRoomForm.RoomName };
                    ViewModel.Rooms.Add(room);
                }
            }
        }

        //Tool Strip Menu Items
        private void OpenWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewModel.SaveWorld();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Filename = saveFileDialog1.FileName;
                ViewModel.SaveWorld();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private GameViewModel mViewModel;
    }
}
