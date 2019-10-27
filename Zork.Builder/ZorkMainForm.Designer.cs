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
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.OpenLabel = new System.Windows.Forms.Label();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.RoomsLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.RoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WorldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.AllowNew = false;
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.ViewModels.GameViewModel);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 505);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 40);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "&Add";
            this.AddButton.UseVisualStyleBackColor = true;
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
            // OpenLabel
            // 
            this.OpenLabel.AutoSize = true;
            this.OpenLabel.Location = new System.Drawing.Point(12, 9);
            this.OpenLabel.Name = "OpenLabel";
            this.OpenLabel.Size = new System.Drawing.Size(69, 17);
            this.OpenLabel.TabIndex = 5;
            this.OpenLabel.Text = "Open File";
            // 
            // FileTextBox
            // 
            this.FileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "Filename", true));
            this.FileTextBox.Location = new System.Drawing.Point(88, 6);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.ReadOnly = true;
            this.FileTextBox.Size = new System.Drawing.Size(858, 22);
            this.FileTextBox.TabIndex = 6;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(953, 6);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(52, 23);
            this.OpenFileButton.TabIndex = 7;
            this.OpenFileButton.Text = "...";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
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
            // listBox1
            // 
            this.listBox1.DataSource = this.RoomsBindingSource;
            this.listBox1.DisplayMember = "Comparer";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(15, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(241, 404);
            this.listBox1.TabIndex = 9;
            // 
            // RoomsBindingSource
            // 
            this.RoomsBindingSource.DataMember = "Rooms";
            this.RoomsBindingSource.DataSource = this.WorldBindingSource;
            // 
            // WorldBindingSource
            // 
            this.WorldBindingSource.AllowNew = true;
            this.WorldBindingSource.DataMember = "World";
            this.WorldBindingSource.DataSource = this.GameBindingSource;
            // 
            // GameBindingSource
            // 
            this.GameBindingSource.DataMember = "Game";
            this.GameBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // ZorkMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 554);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.RoomsLabel);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.FileTextBox);
            this.Controls.Add(this.OpenLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ZorkMainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label OpenLabel;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label RoomsLabel;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource RoomsBindingSource;
        private System.Windows.Forms.BindingSource WorldBindingSource;
        private System.Windows.Forms.BindingSource GameBindingSource;
    }
}

