using System;
using System.Windows.Forms;

namespace Zork.Builder.Forms
{
    public partial class AddRoomForm : Form
    {
        public string RoomName
        {
            get => RoomNameTextBox.Text;
            set => RoomNameTextBox.Text = value;
        }

        public string RoomDescription
        {
            get => DescriptionTextBox.Text;
            set => DescriptionTextBox.Text = value;
        }
        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void RoomNameTextBox_TextChanged(object sender, EventArgs e)
        {
            OKButton.Enabled = !string.IsNullOrEmpty(RoomName);
        }
    }
}
