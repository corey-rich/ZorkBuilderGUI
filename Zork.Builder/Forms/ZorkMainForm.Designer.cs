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
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.RoomsLabel = new System.Windows.Forms.Label();
            this.RoomListBox = new System.Windows.Forms.ListBox();
            this.RoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WorldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RoomNameDisplay = new System.Windows.Forms.TextBox();
            this.RoomDescription = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.NeighborsTextBox = new System.Windows.Forms.Label();
            this.NeighborsListBox = new System.Windows.Forms.ListBox();
            this.NeighborsDescriptionBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 505);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 40);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "&Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(156, 505);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 40);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files (*json)|*.json";
            // 
            // RoomsLabel
            // 
            this.RoomsLabel.AutoSize = true;
            this.RoomsLabel.Location = new System.Drawing.Point(12, 59);
            this.RoomsLabel.Name = "RoomsLabel";
            this.RoomsLabel.Size = new System.Drawing.Size(52, 17);
            this.RoomsLabel.TabIndex = 8;
            this.RoomsLabel.Text = "Rooms";
            this.RoomsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoomListBox
            // 
            this.RoomListBox.DataSource = this.RoomsBindingSource;
            this.RoomListBox.DisplayMember = "Name";
            this.RoomListBox.FormattingEnabled = true;
            this.RoomListBox.ItemHeight = 16;
            this.RoomListBox.Location = new System.Drawing.Point(15, 79);
            this.RoomListBox.Name = "RoomListBox";
            this.RoomListBox.Size = new System.Drawing.Size(241, 404);
            this.RoomListBox.TabIndex = 9;
            this.RoomListBox.ValueMember = "Description";
            // 
            // RoomsBindingSource
            // 
            this.RoomsBindingSource.DataMember = "Rooms";
            this.RoomsBindingSource.DataSource = this.WorldBindingSource;
            // 
            // WorldBindingSource
            // 
            this.WorldBindingSource.DataMember = "World";
            this.WorldBindingSource.DataSource = this.GameBindingSource;
            // 
            // GameBindingSource
            // 
            this.GameBindingSource.DataMember = "Game";
            this.GameBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // RoomNameDisplay
            // 
            this.RoomNameDisplay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RoomsBindingSource, "Name", true));
            this.RoomNameDisplay.Location = new System.Drawing.Point(425, 59);
            this.RoomNameDisplay.Name = "RoomNameDisplay";
            this.RoomNameDisplay.ReadOnly = true;
            this.RoomNameDisplay.Size = new System.Drawing.Size(450, 22);
            this.RoomNameDisplay.TabIndex = 10;
            this.RoomNameDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RoomsBindingSource, "Description", true));
            this.DescriptionTextBox.Location = new System.Drawing.Point(425, 131);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(450, 202);
            this.DescriptionTextBox.TabIndex = 12;
            this.DescriptionTextBox.Text = "";
            // 
            // NeighborsTextBox
            // 
            this.NeighborsTextBox.AutoSize = true;
            this.NeighborsTextBox.Location = new System.Drawing.Point(611, 347);
            this.NeighborsTextBox.Name = "NeighborsTextBox";
            this.NeighborsTextBox.Size = new System.Drawing.Size(73, 17);
            this.NeighborsTextBox.TabIndex = 13;
            this.NeighborsTextBox.Text = "Neighbors";
            // 
            // NeighborsListBox
            // 
            this.NeighborsListBox.DisplayMember = "Key";
            this.NeighborsListBox.FormattingEnabled = true;
            this.NeighborsListBox.ItemHeight = 16;
            this.NeighborsListBox.Location = new System.Drawing.Point(425, 367);
            this.NeighborsListBox.Name = "NeighborsListBox";
            this.NeighborsListBox.Size = new System.Drawing.Size(117, 116);
            this.NeighborsListBox.TabIndex = 14;
            this.NeighborsListBox.ValueMember = "Key";
            // 
            // NeighborsDescriptionBox
            // 
            this.NeighborsDescriptionBox.Location = new System.Drawing.Point(549, 367);
            this.NeighborsDescriptionBox.Name = "NeighborsDescriptionBox";
            this.NeighborsDescriptionBox.Size = new System.Drawing.Size(326, 116);
            this.NeighborsDescriptionBox.TabIndex = 15;
            this.NeighborsDescriptionBox.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
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
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem1.Text = "File";
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.ViewModels.GameViewModel);
            // 
            // ZorkMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 554);
            this.Controls.Add(this.NeighborsDescriptionBox);
            this.Controls.Add(this.NeighborsListBox);
            this.Controls.Add(this.NeighborsTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.RoomDescription);
            this.Controls.Add(this.RoomNameDisplay);
            this.Controls.Add(this.RoomListBox);
            this.Controls.Add(this.RoomsLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ZorkMainForm";
            this.Text = "Zork Builder";
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label RoomsLabel;
        private System.Windows.Forms.ListBox RoomListBox;
        private System.Windows.Forms.TextBox RoomNameDisplay;
        private System.Windows.Forms.Label RoomDescription;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.Label NeighborsTextBox;
        private System.Windows.Forms.ListBox NeighborsListBox;
        private System.Windows.Forms.RichTextBox NeighborsDescriptionBox;
        private System.Windows.Forms.BindingSource RoomsBindingSource;
        private System.Windows.Forms.BindingSource WorldBindingSource;
        private System.Windows.Forms.BindingSource GameBindingSource;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

