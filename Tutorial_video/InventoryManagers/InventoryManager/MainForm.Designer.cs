namespace InventoryManager
{
    partial class MainForm
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
            System.Windows.Forms.Label FileLabel;
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.FilenameTextBox = new System.Windows.Forms.TextBox();
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.PlayersTagPage = new System.Windows.Forms.TabPage();
            this.ScoretextBox = new System.Windows.Forms.TextBox();
            this.Scorelabel2 = new System.Windows.Forms.Label();
            this.HealthtextBox = new System.Windows.Forms.TextBox();
            this.PlayerHealthlabel1 = new System.Windows.Forms.Label();
            this.PlayernametextBox = new System.Windows.Forms.TextBox();
            this.Playerlabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.AddplayerButton = new System.Windows.Forms.Button();
            this.playersListBox = new System.Windows.Forms.ListBox();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemsTagPage = new System.Windows.Forms.TabPage();
            this.ItemsDeleteButton = new System.Windows.Forms.Button();
            this.ItemsAddButton = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            FileLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.PlayersTagPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldBindingSource)).BeginInit();
            this.ItemsTagPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FileLabel
            // 
            FileLabel.AutoSize = true;
            FileLabel.Location = new System.Drawing.Point(12, 18);
            FileLabel.Name = "FileLabel";
            FileLabel.Size = new System.Drawing.Size(23, 13);
            FileLabel.TabIndex = 1;
            FileLabel.Text = "File";
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(760, 13);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(28, 23);
            this.SelectFileButton.TabIndex = 0;
            this.SelectFileButton.Text = "...";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // FilenameTextBox
            // 
            this.FilenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worldViewModelBindingSource, "FileName", true));
            this.FilenameTextBox.Location = new System.Drawing.Point(41, 14);
            this.FilenameTextBox.Name = "FilenameTextBox";
            this.FilenameTextBox.ReadOnly = true;
            this.FilenameTextBox.Size = new System.Drawing.Size(713, 20);
            this.FilenameTextBox.TabIndex = 2;
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(InventoryManager.ViewModels.WorldViewModel);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files(*json)|*.json";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.PlayersTagPage);
            this.mainTabControl.Controls.Add(this.ItemsTagPage);
            this.mainTabControl.Location = new System.Drawing.Point(12, 40);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(776, 399);
            this.mainTabControl.TabIndex = 3;
            // 
            // PlayersTagPage
            // 
            this.PlayersTagPage.Controls.Add(this.ScoretextBox);
            this.PlayersTagPage.Controls.Add(this.Scorelabel2);
            this.PlayersTagPage.Controls.Add(this.HealthtextBox);
            this.PlayersTagPage.Controls.Add(this.PlayerHealthlabel1);
            this.PlayersTagPage.Controls.Add(this.PlayernametextBox);
            this.PlayersTagPage.Controls.Add(this.Playerlabel);
            this.PlayersTagPage.Controls.Add(this.deleteButton);
            this.PlayersTagPage.Controls.Add(this.AddplayerButton);
            this.PlayersTagPage.Controls.Add(this.playersListBox);
            this.PlayersTagPage.Location = new System.Drawing.Point(4, 22);
            this.PlayersTagPage.Name = "PlayersTagPage";
            this.PlayersTagPage.Padding = new System.Windows.Forms.Padding(3);
            this.PlayersTagPage.Size = new System.Drawing.Size(768, 373);
            this.PlayersTagPage.TabIndex = 0;
            this.PlayersTagPage.Text = "Players";
            this.PlayersTagPage.UseVisualStyleBackColor = true;
            // 
            // ScoretextBox
            // 
            this.ScoretextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Score", true));
            this.ScoretextBox.Location = new System.Drawing.Point(212, 103);
            this.ScoretextBox.Name = "ScoretextBox";
            this.ScoretextBox.Size = new System.Drawing.Size(251, 20);
            this.ScoretextBox.TabIndex = 17;
            // 
            // Scorelabel2
            // 
            this.Scorelabel2.AutoSize = true;
            this.Scorelabel2.Location = new System.Drawing.Point(209, 86);
            this.Scorelabel2.Name = "Scorelabel2";
            this.Scorelabel2.Size = new System.Drawing.Size(35, 13);
            this.Scorelabel2.TabIndex = 16;
            this.Scorelabel2.Text = "&Score";
            // 
            // HealthtextBox
            // 
            this.HealthtextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Health", true));
            this.HealthtextBox.Location = new System.Drawing.Point(212, 63);
            this.HealthtextBox.Name = "HealthtextBox";
            this.HealthtextBox.Size = new System.Drawing.Size(251, 20);
            this.HealthtextBox.TabIndex = 15;
            // 
            // PlayerHealthlabel1
            // 
            this.PlayerHealthlabel1.AutoSize = true;
            this.PlayerHealthlabel1.Location = new System.Drawing.Point(209, 46);
            this.PlayerHealthlabel1.Name = "PlayerHealthlabel1";
            this.PlayerHealthlabel1.Size = new System.Drawing.Size(38, 13);
            this.PlayerHealthlabel1.TabIndex = 14;
            this.PlayerHealthlabel1.Text = "&Health";
            // 
            // PlayernametextBox
            // 
            this.PlayernametextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Name", true));
            this.PlayernametextBox.Location = new System.Drawing.Point(213, 23);
            this.PlayernametextBox.Name = "PlayernametextBox";
            this.PlayernametextBox.Size = new System.Drawing.Size(251, 20);
            this.PlayernametextBox.TabIndex = 13;
            // 
            // Playerlabel
            // 
            this.Playerlabel.AutoSize = true;
            this.Playerlabel.Location = new System.Drawing.Point(210, 6);
            this.Playerlabel.Name = "Playerlabel";
            this.Playerlabel.Size = new System.Drawing.Size(35, 13);
            this.Playerlabel.TabIndex = 12;
            this.Playerlabel.Text = "&Name";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(110, 344);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // AddplayerButton
            // 
            this.AddplayerButton.Location = new System.Drawing.Point(18, 344);
            this.AddplayerButton.Name = "AddplayerButton";
            this.AddplayerButton.Size = new System.Drawing.Size(75, 23);
            this.AddplayerButton.TabIndex = 1;
            this.AddplayerButton.Text = "&Add";
            this.AddplayerButton.UseVisualStyleBackColor = true;
            // 
            // playersListBox
            // 
            this.playersListBox.DataSource = this.playersBindingSource;
            this.playersListBox.DisplayMember = "Name";
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.Location = new System.Drawing.Point(6, 6);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(198, 329);
            this.playersListBox.TabIndex = 0;
            this.playersListBox.ValueMember = "Health";
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.worldBindingSource;
            // 
            // worldBindingSource
            // 
            this.worldBindingSource.DataMember = "World";
            this.worldBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // ItemsTagPage
            // 
            this.ItemsTagPage.Controls.Add(this.ItemsDeleteButton);
            this.ItemsTagPage.Controls.Add(this.ItemsAddButton);
            this.ItemsTagPage.Controls.Add(this.ItemsListBox);
            this.ItemsTagPage.Location = new System.Drawing.Point(4, 22);
            this.ItemsTagPage.Name = "ItemsTagPage";
            this.ItemsTagPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTagPage.Size = new System.Drawing.Size(768, 373);
            this.ItemsTagPage.TabIndex = 1;
            this.ItemsTagPage.Text = "Items";
            this.ItemsTagPage.UseVisualStyleBackColor = true;
            // 
            // ItemsDeleteButton
            // 
            this.ItemsDeleteButton.Location = new System.Drawing.Point(110, 344);
            this.ItemsDeleteButton.Name = "ItemsDeleteButton";
            this.ItemsDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ItemsDeleteButton.TabIndex = 5;
            this.ItemsDeleteButton.Text = "&Delete";
            this.ItemsDeleteButton.UseVisualStyleBackColor = true;
            // 
            // ItemsAddButton
            // 
            this.ItemsAddButton.Location = new System.Drawing.Point(18, 344);
            this.ItemsAddButton.Name = "ItemsAddButton";
            this.ItemsAddButton.Size = new System.Drawing.Size(75, 23);
            this.ItemsAddButton.TabIndex = 4;
            this.ItemsAddButton.Text = "&Add";
            this.ItemsAddButton.UseVisualStyleBackColor = true;
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.DataSource = this.itemsBindingSource;
            this.ItemsListBox.DisplayMember = "Name";
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(6, 6);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(198, 329);
            this.ItemsListBox.TabIndex = 3;
            this.ItemsListBox.ValueMember = "Name";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.worldBindingSource;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 451);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.FilenameTextBox);
            this.Controls.Add(FileLabel);
            this.Controls.Add(this.SelectFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Inventory Manager";
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.PlayersTagPage.ResumeLayout(false);
            this.PlayersTagPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldBindingSource)).EndInit();
            this.ItemsTagPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.TextBox FilenameTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage PlayersTagPage;
        private System.Windows.Forms.Button AddplayerButton;
        private System.Windows.Forms.ListBox playersListBox;
        private System.Windows.Forms.TabPage ItemsTagPage;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.BindingSource worldBindingSource;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.Button ItemsDeleteButton;
        private System.Windows.Forms.Button ItemsAddButton;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.TextBox ScoretextBox;
        private System.Windows.Forms.Label Scorelabel2;
        private System.Windows.Forms.TextBox HealthtextBox;
        private System.Windows.Forms.Label PlayerHealthlabel1;
        private System.Windows.Forms.TextBox PlayernametextBox;
        private System.Windows.Forms.Label Playerlabel;
    }
}

