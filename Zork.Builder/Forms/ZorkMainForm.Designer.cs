namespace Zork.Builder
{
    partial class ZorkMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.RoomListBox = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RoomDescription = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.NorthNeighborsControl = new Zork.Builder.Controls.NeighborsControl();
            this.NeighborsLabel = new System.Windows.Forms.Label();
            this.SouthNeighborsControl = new Zork.Builder.Controls.NeighborsControl();
            this.WestNeighborsControl = new Zork.Builder.Controls.NeighborsControl();
            this.EastNeighborsControl = new Zork.Builder.Controls.NeighborsControl();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RoomsLabel = new System.Windows.Forms.Label();
            this.RoomNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files (*json)|*.json";
            // 
            // RoomListBox
            // 
            this.RoomListBox.DataSource = this.roomsBindingSource;
            this.RoomListBox.DisplayMember = "Name";
            this.RoomListBox.FormattingEnabled = true;
            this.RoomListBox.ItemHeight = 16;
            this.RoomListBox.Location = new System.Drawing.Point(15, 79);
            this.RoomListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoomListBox.Name = "RoomListBox";
            this.RoomListBox.Size = new System.Drawing.Size(241, 404);
            this.RoomListBox.TabIndex = 9;
            this.RoomListBox.ValueMember = "Description";
            this.RoomListBox.SelectedIndexChanged += new System.EventHandler(this.RoomListBox_SelectedIndexChanged);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataSource = typeof(Zork.Common.Room);
            // 
            // RoomDescription
            // 
            this.RoomDescription.AutoSize = true;
            this.RoomDescription.Location = new System.Drawing.Point(611, 111);
            this.RoomDescription.Name = "RoomDescription";
            this.RoomDescription.Size = new System.Drawing.Size(79, 17);
            this.RoomDescription.TabIndex = 11;
            this.RoomDescription.Text = "Description";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DescriptionTextBox.Location = new System.Drawing.Point(425, 130);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(449, 171);
            this.DescriptionTextBox.TabIndex = 12;
            this.DescriptionTextBox.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1015, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWorldToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // openWorldToolStripMenuItem
            // 
            this.openWorldToolStripMenuItem.Name = "openWorldToolStripMenuItem";
            this.openWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openWorldToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.openWorldToolStripMenuItem.Text = "&Open World...";
            this.openWorldToolStripMenuItem.Click += new System.EventHandler(this.OpenWorldToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(231, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click_1);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "World Files (*.json)|*.json";
            this.SaveFileDialog.Title = "Save World";
            // 
            // NorthNeighborsControl
            // 
            this.NorthNeighborsControl.Directions = Zork.Common.Directions.North;
            this.NorthNeighborsControl.Location = new System.Drawing.Point(549, 323);
            this.NorthNeighborsControl.Name = "NorthNeighborsControl";
            this.NorthNeighborsControl.Neighbors = null;
            this.NorthNeighborsControl.Room = null;
            this.NorthNeighborsControl.Size = new System.Drawing.Size(229, 60);
            this.NorthNeighborsControl.TabIndex = 17;
            // 
            // NeighborsLabel
            // 
            this.NeighborsLabel.AutoSize = true;
            this.NeighborsLabel.Location = new System.Drawing.Point(617, 303);
            this.NeighborsLabel.Name = "NeighborsLabel";
            this.NeighborsLabel.Size = new System.Drawing.Size(73, 17);
            this.NeighborsLabel.TabIndex = 18;
            this.NeighborsLabel.Text = "Neighbors";
            // 
            // SouthNeighborsControl
            // 
            this.SouthNeighborsControl.Directions = Zork.Common.Directions.South;
            this.SouthNeighborsControl.Location = new System.Drawing.Point(549, 455);
            this.SouthNeighborsControl.Name = "SouthNeighborsControl";
            this.SouthNeighborsControl.Neighbors = null;
            this.SouthNeighborsControl.Room = null;
            this.SouthNeighborsControl.Size = new System.Drawing.Size(229, 60);
            this.SouthNeighborsControl.TabIndex = 19;
            // 
            // WestNeighborsControl
            // 
            this.WestNeighborsControl.Directions = Zork.Common.Directions.West;
            this.WestNeighborsControl.Location = new System.Drawing.Point(425, 389);
            this.WestNeighborsControl.Name = "WestNeighborsControl";
            this.WestNeighborsControl.Neighbors = null;
            this.WestNeighborsControl.Room = null;
            this.WestNeighborsControl.Size = new System.Drawing.Size(229, 60);
            this.WestNeighborsControl.TabIndex = 20;
            // 
            // EastNeighborsControl
            // 
            this.EastNeighborsControl.Directions = Zork.Common.Directions.East;
            this.EastNeighborsControl.Location = new System.Drawing.Point(660, 389);
            this.EastNeighborsControl.Name = "EastNeighborsControl";
            this.EastNeighborsControl.Neighbors = null;
            this.EastNeighborsControl.Room = null;
            this.EastNeighborsControl.Size = new System.Drawing.Size(229, 60);
            this.EastNeighborsControl.TabIndex = 21;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(15, 491);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(88, 39);
            this.AddButton.TabIndex = 22;
            this.AddButton.Text = "&Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click_1);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(168, 491);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(88, 39);
            this.DeleteButton.TabIndex = 23;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // RoomsLabel
            // 
            this.RoomsLabel.AutoSize = true;
            this.RoomsLabel.Location = new System.Drawing.Point(15, 57);
            this.RoomsLabel.Name = "RoomsLabel";
            this.RoomsLabel.Size = new System.Drawing.Size(52, 17);
            this.RoomsLabel.TabIndex = 24;
            this.RoomsLabel.Text = "Rooms";
            // 
            // RoomNameTextBox
            // 
            this.RoomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RoomNameTextBox.Location = new System.Drawing.Point(425, 57);
            this.RoomNameTextBox.Name = "RoomNameTextBox";
            this.RoomNameTextBox.Size = new System.Drawing.Size(449, 22);
            this.RoomNameTextBox.TabIndex = 25;
            // 
            // ZorkMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 554);
            this.Controls.Add(this.RoomNameTextBox);
            this.Controls.Add(this.RoomsLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EastNeighborsControl);
            this.Controls.Add(this.WestNeighborsControl);
            this.Controls.Add(this.SouthNeighborsControl);
            this.Controls.Add(this.NeighborsLabel);
            this.Controls.Add(this.NorthNeighborsControl);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.RoomDescription);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.RoomListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ZorkMainForm";
            this.Text = "Zork Builder";
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox RoomListBox;
        private System.Windows.Forms.Label RoomDescription;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private Controls.NeighborsControl NorthNeighborsControl;
        private System.Windows.Forms.Label NeighborsLabel;
        private Controls.NeighborsControl SouthNeighborsControl;
        private Controls.NeighborsControl WestNeighborsControl;
        private Controls.NeighborsControl EastNeighborsControl;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label RoomsLabel;
        private System.Windows.Forms.TextBox RoomNameTextBox;
    }
}

