using System;
using System.Windows.Forms;
using Zork.Common;
using Newtonsoft.Json;
using System.IO;
using Zork.Builder.ViewModels;

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

        private GameViewModel mViewModel;

        private void OpenWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;
            }
        }
    }
}
