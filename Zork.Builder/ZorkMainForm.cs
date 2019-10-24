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
        private WorldViewModel ViewModel
        { 
            get => mViewModel; 
            set => mViewModel = value; 
        }

        public ZorkMainForm()
        {
            InitializeComponent();

            //Player player = new Player();
            
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;
            }
        }

        private WorldViewModel mViewModel;
    }
}
