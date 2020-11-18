namespace ZorkBuilder.Winforms.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingExistingGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addingRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editingRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.welcomeTabPage = new System.Windows.Forms.TabPage();
            this.newMessageTextBox = new System.Windows.Forms.TextBox();
            this.newMessageLabel = new System.Windows.Forms.Label();
            this.welcomeMessageOkButton = new System.Windows.Forms.Button();
            this.welcomeMessageEditButton = new System.Windows.Forms.Button();
            this.welcomMessageTextBox = new System.Windows.Forms.TextBox();
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currentMessageLabel = new System.Windows.Forms.Label();
            this.startLocationTabPage = new System.Windows.Forms.TabPage();
            this.currentLocationTextBox = new System.Windows.Forms.TextBox();
            this.currenLocationLabel = new System.Windows.Forms.Label();
            this.roomsListBox2 = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTabPage = new System.Windows.Forms.TabPage();
            this.roomSaveButton = new System.Windows.Forms.Button();
            this.southNeighborsControl = new ZorkBuilder.Winforms.Controls.NeighborsControl();
            this.northNeighborsControl = new ZorkBuilder.Winforms.Controls.NeighborsControl();
            this.eastNeighborsControl = new ZorkBuilder.Winforms.Controls.NeighborsControl();
            this.westNeighborsControl = new ZorkBuilder.Winforms.Controls.NeighborsControl();
            this.roomDeleteButoon = new System.Windows.Forms.Button();
            this.roomAddButton = new System.Windows.Forms.Button();
            this.roomEditButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.neighborLocationgroupBox = new System.Windows.Forms.GroupBox();
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.itemSaveButton = new System.Windows.Forms.Button();
            this.itemDeleteButton = new System.Windows.Forms.Button();
            this.itemAddButton = new System.Windows.Forms.Button();
            this.itemEditButtom = new System.Windows.Forms.Button();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.worldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.listOfNeighborsNamebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NeighborsListGroupBox = new System.Windows.Forms.GroupBox();
            this.neighborsListBox = new System.Windows.Forms.ListBox();
            this.neighborsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenuStrip.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.welcomeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            this.startLocationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.roomsTabPage.SuspendLayout();
            this.itemsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfNeighborsNamebindingSource)).BeginInit();
            this.NeighborsListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neighborsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.playToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(632, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameFileToolStripMenuItem,
            this.openingExistingGameToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameFileToolStripMenuItem
            // 
            this.newGameFileToolStripMenuItem.Name = "newGameFileToolStripMenuItem";
            this.newGameFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameFileToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.newGameFileToolStripMenuItem.Text = "New Game File";
            // 
            // openingExistingGameToolStripMenuItem
            // 
            this.openingExistingGameToolStripMenuItem.Name = "openingExistingGameToolStripMenuItem";
            this.openingExistingGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openingExistingGameToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.openingExistingGameToolStripMenuItem.Text = "Opening Existing Game";
            this.openingExistingGameToolStripMenuItem.Click += new System.EventHandler(this.OpeningExistingGameToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addingRoomToolStripMenuItem,
            this.editingRoomToolStripMenuItem,
            this.deletingToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addingRoomToolStripMenuItem
            // 
            this.addingRoomToolStripMenuItem.Name = "addingRoomToolStripMenuItem";
            this.addingRoomToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.addingRoomToolStripMenuItem.Text = "Adding Room";
            // 
            // editingRoomToolStripMenuItem
            // 
            this.editingRoomToolStripMenuItem.Name = "editingRoomToolStripMenuItem";
            this.editingRoomToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.editingRoomToolStripMenuItem.Text = "Game Welcome Message...";
            // 
            // deletingToolStripMenuItem
            // 
            this.deletingToolStripMenuItem.Name = "deletingToolStripMenuItem";
            this.deletingToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.deletingToolStripMenuItem.Text = "Player Starting Location";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.playToolStripMenuItem.Text = "Play";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.welcomeTabPage);
            this.mainTabControl.Controls.Add(this.startLocationTabPage);
            this.mainTabControl.Controls.Add(this.roomsTabPage);
            this.mainTabControl.Controls.Add(this.itemsTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 24);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(632, 343);
            this.mainTabControl.TabIndex = 1;
            // 
            // welcomeTabPage
            // 
            this.welcomeTabPage.Controls.Add(this.newMessageTextBox);
            this.welcomeTabPage.Controls.Add(this.newMessageLabel);
            this.welcomeTabPage.Controls.Add(this.welcomeMessageOkButton);
            this.welcomeTabPage.Controls.Add(this.welcomeMessageEditButton);
            this.welcomeTabPage.Controls.Add(this.welcomMessageTextBox);
            this.welcomeTabPage.Controls.Add(this.currentMessageLabel);
            this.welcomeTabPage.Location = new System.Drawing.Point(4, 22);
            this.welcomeTabPage.Name = "welcomeTabPage";
            this.welcomeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.welcomeTabPage.Size = new System.Drawing.Size(624, 317);
            this.welcomeTabPage.TabIndex = 2;
            this.welcomeTabPage.Text = "Welcome Message";
            this.welcomeTabPage.UseVisualStyleBackColor = true;
            // 
            // newMessageTextBox
            // 
            this.newMessageTextBox.Location = new System.Drawing.Point(76, 122);
            this.newMessageTextBox.Multiline = true;
            this.newMessageTextBox.Name = "newMessageTextBox";
            this.newMessageTextBox.Size = new System.Drawing.Size(475, 69);
            this.newMessageTextBox.TabIndex = 5;
            // 
            // newMessageLabel
            // 
            this.newMessageLabel.AutoSize = true;
            this.newMessageLabel.Location = new System.Drawing.Point(246, 102);
            this.newMessageLabel.Name = "newMessageLabel";
            this.newMessageLabel.Size = new System.Drawing.Size(123, 13);
            this.newMessageLabel.TabIndex = 4;
            this.newMessageLabel.Text = "New Welcome Message";
            // 
            // welcomeMessageOkButton
            // 
            this.welcomeMessageOkButton.Location = new System.Drawing.Point(325, 288);
            this.welcomeMessageOkButton.Name = "welcomeMessageOkButton";
            this.welcomeMessageOkButton.Size = new System.Drawing.Size(75, 23);
            this.welcomeMessageOkButton.TabIndex = 3;
            this.welcomeMessageOkButton.Text = "&Ok";
            this.welcomeMessageOkButton.UseVisualStyleBackColor = true;
            // 
            // welcomeMessageEditButton
            // 
            this.welcomeMessageEditButton.Location = new System.Drawing.Point(244, 288);
            this.welcomeMessageEditButton.Name = "welcomeMessageEditButton";
            this.welcomeMessageEditButton.Size = new System.Drawing.Size(75, 23);
            this.welcomeMessageEditButton.TabIndex = 2;
            this.welcomeMessageEditButton.Text = "&Edit";
            this.welcomeMessageEditButton.UseVisualStyleBackColor = true;
            // 
            // welcomMessageTextBox
            // 
            this.welcomMessageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worldViewModelBindingSource, "WelcomeMessage", true));
            this.welcomMessageTextBox.Location = new System.Drawing.Point(76, 23);
            this.welcomMessageTextBox.Multiline = true;
            this.welcomMessageTextBox.Name = "welcomMessageTextBox";
            this.welcomMessageTextBox.ReadOnly = true;
            this.welcomMessageTextBox.Size = new System.Drawing.Size(475, 69);
            this.welcomMessageTextBox.TabIndex = 1;
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(ZorkBuilder.Winforms.ViewModels.WorldViewModel);
            // 
            // currentMessageLabel
            // 
            this.currentMessageLabel.AutoSize = true;
            this.currentMessageLabel.Location = new System.Drawing.Point(246, 3);
            this.currentMessageLabel.Name = "currentMessageLabel";
            this.currentMessageLabel.Size = new System.Drawing.Size(135, 13);
            this.currentMessageLabel.TabIndex = 0;
            this.currentMessageLabel.Text = "Current Welcome Message";
            // 
            // startLocationTabPage
            // 
            this.startLocationTabPage.Controls.Add(this.currentLocationTextBox);
            this.startLocationTabPage.Controls.Add(this.currenLocationLabel);
            this.startLocationTabPage.Controls.Add(this.roomsListBox2);
            this.startLocationTabPage.Location = new System.Drawing.Point(4, 22);
            this.startLocationTabPage.Name = "startLocationTabPage";
            this.startLocationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.startLocationTabPage.Size = new System.Drawing.Size(624, 317);
            this.startLocationTabPage.TabIndex = 3;
            this.startLocationTabPage.Text = "Start Location";
            this.startLocationTabPage.UseVisualStyleBackColor = true;
            // 
            // currentLocationTextBox
            // 
            this.currentLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worldViewModelBindingSource, "StartLocation", true));
            this.currentLocationTextBox.Location = new System.Drawing.Point(156, 31);
            this.currentLocationTextBox.Name = "currentLocationTextBox";
            this.currentLocationTextBox.ReadOnly = true;
            this.currentLocationTextBox.Size = new System.Drawing.Size(177, 20);
            this.currentLocationTextBox.TabIndex = 3;
            // 
            // currenLocationLabel
            // 
            this.currenLocationLabel.AutoSize = true;
            this.currenLocationLabel.Location = new System.Drawing.Point(153, 14);
            this.currenLocationLabel.Name = "currenLocationLabel";
            this.currenLocationLabel.Size = new System.Drawing.Size(85, 13);
            this.currenLocationLabel.TabIndex = 2;
            this.currenLocationLabel.Text = "Current Location";
            // 
            // roomsListBox2
            // 
            this.roomsListBox2.DataSource = this.roomsBindingSource;
            this.roomsListBox2.DisplayMember = "Name";
            this.roomsListBox2.FormattingEnabled = true;
            this.roomsListBox2.Location = new System.Drawing.Point(0, 0);
            this.roomsListBox2.Name = "roomsListBox2";
            this.roomsListBox2.Size = new System.Drawing.Size(147, 316);
            this.roomsListBox2.TabIndex = 1;
            this.roomsListBox2.ValueMember = "Name";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // roomsTabPage
            // 
            this.roomsTabPage.Controls.Add(this.NeighborsListGroupBox);
            this.roomsTabPage.Controls.Add(this.roomSaveButton);
            this.roomsTabPage.Controls.Add(this.southNeighborsControl);
            this.roomsTabPage.Controls.Add(this.northNeighborsControl);
            this.roomsTabPage.Controls.Add(this.eastNeighborsControl);
            this.roomsTabPage.Controls.Add(this.westNeighborsControl);
            this.roomsTabPage.Controls.Add(this.roomDeleteButoon);
            this.roomsTabPage.Controls.Add(this.roomAddButton);
            this.roomsTabPage.Controls.Add(this.roomEditButton);
            this.roomsTabPage.Controls.Add(this.descriptionTextBox);
            this.roomsTabPage.Controls.Add(this.descriptionLabel);
            this.roomsTabPage.Controls.Add(this.roomNameLabel);
            this.roomsTabPage.Controls.Add(this.roomNameTextBox);
            this.roomsTabPage.Controls.Add(this.roomsListBox);
            this.roomsTabPage.Controls.Add(this.neighborLocationgroupBox);
            this.roomsTabPage.Location = new System.Drawing.Point(4, 22);
            this.roomsTabPage.Name = "roomsTabPage";
            this.roomsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.roomsTabPage.Size = new System.Drawing.Size(624, 317);
            this.roomsTabPage.TabIndex = 0;
            this.roomsTabPage.Text = "Rooms";
            this.roomsTabPage.UseVisualStyleBackColor = true;
            // 
            // roomSaveButton
            // 
            this.roomSaveButton.Location = new System.Drawing.Point(395, 288);
            this.roomSaveButton.Name = "roomSaveButton";
            this.roomSaveButton.Size = new System.Drawing.Size(75, 23);
            this.roomSaveButton.TabIndex = 12;
            this.roomSaveButton.Text = "&Save";
            this.roomSaveButton.UseVisualStyleBackColor = true;
            // 
            // southNeighborsControl
            // 
            this.southNeighborsControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.southNeighborsControl.Directions = ZorkBuilder.Data.Directions.South;
            this.southNeighborsControl.Location = new System.Drawing.Point(416, 191);
            this.southNeighborsControl.Name = "southNeighborsControl";
            this.southNeighborsControl.NeighborsName = null;
            this.southNeighborsControl.Room = null;
            this.southNeighborsControl.Size = new System.Drawing.Size(121, 48);
            this.southNeighborsControl.TabIndex = 8;
            // 
            // northNeighborsControl
            // 
            this.northNeighborsControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.northNeighborsControl.Directions = ZorkBuilder.Data.Directions.North;
            this.northNeighborsControl.Location = new System.Drawing.Point(416, 29);
            this.northNeighborsControl.Name = "northNeighborsControl";
            this.northNeighborsControl.NeighborsName = null;
            this.northNeighborsControl.Room = null;
            this.northNeighborsControl.Size = new System.Drawing.Size(121, 48);
            this.northNeighborsControl.TabIndex = 9;
            // 
            // eastNeighborsControl
            // 
            this.eastNeighborsControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eastNeighborsControl.Directions = ZorkBuilder.Data.Directions.West;
            this.eastNeighborsControl.Location = new System.Drawing.Point(340, 115);
            this.eastNeighborsControl.Name = "eastNeighborsControl";
            this.eastNeighborsControl.NeighborsName = null;
            this.eastNeighborsControl.Room = null;
            this.eastNeighborsControl.Size = new System.Drawing.Size(121, 48);
            this.eastNeighborsControl.TabIndex = 7;
            // 
            // westNeighborsControl
            // 
            this.westNeighborsControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.westNeighborsControl.Directions = ZorkBuilder.Data.Directions.East;
            this.westNeighborsControl.Location = new System.Drawing.Point(492, 115);
            this.westNeighborsControl.Name = "westNeighborsControl";
            this.westNeighborsControl.NeighborsName = null;
            this.westNeighborsControl.Room = null;
            this.westNeighborsControl.Size = new System.Drawing.Size(121, 48);
            this.westNeighborsControl.TabIndex = 6;
            // 
            // roomDeleteButoon
            // 
            this.roomDeleteButoon.Location = new System.Drawing.Point(314, 288);
            this.roomDeleteButoon.Name = "roomDeleteButoon";
            this.roomDeleteButoon.Size = new System.Drawing.Size(75, 23);
            this.roomDeleteButoon.TabIndex = 2;
            this.roomDeleteButoon.Text = "&Delete";
            this.roomDeleteButoon.UseVisualStyleBackColor = true;
            this.roomDeleteButoon.Click += new System.EventHandler(this.RoomDeleteButoon_Click);
            // 
            // roomAddButton
            // 
            this.roomAddButton.Location = new System.Drawing.Point(233, 288);
            this.roomAddButton.Name = "roomAddButton";
            this.roomAddButton.Size = new System.Drawing.Size(75, 23);
            this.roomAddButton.TabIndex = 11;
            this.roomAddButton.Text = "&Add";
            this.roomAddButton.UseVisualStyleBackColor = true;
            this.roomAddButton.Click += new System.EventHandler(this.RoomAddButton_Click);
            // 
            // roomEditButton
            // 
            this.roomEditButton.Location = new System.Drawing.Point(152, 288);
            this.roomEditButton.Name = "roomEditButton";
            this.roomEditButton.Size = new System.Drawing.Size(75, 23);
            this.roomEditButton.TabIndex = 10;
            this.roomEditButton.Text = "&Edit";
            this.roomEditButton.UseVisualStyleBackColor = true;
            this.roomEditButton.Click += new System.EventHandler(this.RoomEditButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(153, 69);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(170, 73);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(153, 51);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description";
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(153, 12);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(35, 13);
            this.roomNameLabel.TabIndex = 2;
            this.roomNameLabel.Text = "Name";
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true));
            this.roomNameTextBox.Location = new System.Drawing.Point(153, 29);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.ReadOnly = true;
            this.roomNameTextBox.Size = new System.Drawing.Size(168, 20);
            this.roomNameTextBox.TabIndex = 3;
            // 
            // roomsListBox
            // 
            this.roomsListBox.DataSource = this.roomsBindingSource;
            this.roomsListBox.DisplayMember = "Name";
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(0, 0);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(147, 316);
            this.roomsListBox.TabIndex = 0;
            this.roomsListBox.ValueMember = "Name";
            this.roomsListBox.SelectedIndexChanged += new System.EventHandler(this.RoomsListBox_SelectedIndexChanged);
            // 
            // neighborLocationgroupBox
            // 
            this.neighborLocationgroupBox.Location = new System.Drawing.Point(329, 12);
            this.neighborLocationgroupBox.Name = "neighborLocationgroupBox";
            this.neighborLocationgroupBox.Size = new System.Drawing.Size(292, 270);
            this.neighborLocationgroupBox.TabIndex = 2;
            this.neighborLocationgroupBox.TabStop = false;
            this.neighborLocationgroupBox.Text = "Neighbors";
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Controls.Add(this.itemSaveButton);
            this.itemsTabPage.Controls.Add(this.itemDeleteButton);
            this.itemsTabPage.Controls.Add(this.itemAddButton);
            this.itemsTabPage.Controls.Add(this.itemEditButtom);
            this.itemsTabPage.Controls.Add(this.weightLabel);
            this.itemsTabPage.Controls.Add(this.weightTextBox);
            this.itemsTabPage.Controls.Add(this.label1);
            this.itemsTabPage.Controls.Add(this.itemNameTextBox);
            this.itemsTabPage.Controls.Add(this.itemListBox);
            this.itemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemsTabPage.Size = new System.Drawing.Size(624, 317);
            this.itemsTabPage.TabIndex = 1;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemSaveButton
            // 
            this.itemSaveButton.Location = new System.Drawing.Point(395, 288);
            this.itemSaveButton.Name = "itemSaveButton";
            this.itemSaveButton.Size = new System.Drawing.Size(75, 23);
            this.itemSaveButton.TabIndex = 17;
            this.itemSaveButton.Text = "&Save";
            this.itemSaveButton.UseVisualStyleBackColor = true;
            // 
            // itemDeleteButton
            // 
            this.itemDeleteButton.Location = new System.Drawing.Point(314, 288);
            this.itemDeleteButton.Name = "itemDeleteButton";
            this.itemDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.itemDeleteButton.TabIndex = 16;
            this.itemDeleteButton.Text = "&Delete";
            this.itemDeleteButton.UseVisualStyleBackColor = true;
            this.itemDeleteButton.Click += new System.EventHandler(this.ItemDeleteButton_Click);
            // 
            // itemAddButton
            // 
            this.itemAddButton.Location = new System.Drawing.Point(233, 288);
            this.itemAddButton.Name = "itemAddButton";
            this.itemAddButton.Size = new System.Drawing.Size(75, 23);
            this.itemAddButton.TabIndex = 15;
            this.itemAddButton.Text = "&Add";
            this.itemAddButton.UseVisualStyleBackColor = true;
            this.itemAddButton.Click += new System.EventHandler(this.ItemAddButton_Click);
            // 
            // itemEditButtom
            // 
            this.itemEditButtom.Location = new System.Drawing.Point(152, 288);
            this.itemEditButtom.Name = "itemEditButtom";
            this.itemEditButtom.Size = new System.Drawing.Size(75, 23);
            this.itemEditButtom.TabIndex = 14;
            this.itemEditButtom.Text = "&Edit";
            this.itemEditButtom.UseVisualStyleBackColor = true;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(153, 52);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(41, 13);
            this.weightLabel.TabIndex = 13;
            this.weightLabel.Text = "Weight";
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(153, 69);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.ReadOnly = true;
            this.weightTextBox.Size = new System.Drawing.Size(168, 20);
            this.weightTextBox.TabIndex = 12;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Name", true));
            this.itemNameTextBox.Location = new System.Drawing.Point(153, 29);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.ReadOnly = true;
            this.itemNameTextBox.Size = new System.Drawing.Size(168, 20);
            this.itemNameTextBox.TabIndex = 4;
            // 
            // itemListBox
            // 
            this.itemListBox.DataSource = this.itemsBindingSource;
            this.itemListBox.DisplayMember = "Name";
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.Location = new System.Drawing.Point(0, 0);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(147, 316);
            this.itemListBox.TabIndex = 3;
            this.itemListBox.ValueMember = "Name";
            // 
            // worldBindingSource
            // 
            this.worldBindingSource.DataSource = typeof(ZorkBuilder.Data.World);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files (*json)|*.json";
            // 
            // listOfNeighborsNamebindingSource
            // 
            this.listOfNeighborsNamebindingSource.DataMember = "ListOfNeighbors";
            this.listOfNeighborsNamebindingSource.DataSource = this.roomsBindingSource;
            // 
            // NeighborsListGroupBox
            // 
            this.NeighborsListGroupBox.Controls.Add(this.neighborsListBox);
            this.NeighborsListGroupBox.Location = new System.Drawing.Point(153, 148);
            this.NeighborsListGroupBox.Name = "NeighborsListGroupBox";
            this.NeighborsListGroupBox.Size = new System.Drawing.Size(170, 134);
            this.NeighborsListGroupBox.TabIndex = 13;
            this.NeighborsListGroupBox.TabStop = false;
            this.NeighborsListGroupBox.Text = "List of Neighbors";
            // 
            // neighborsListBox
            // 
            this.neighborsListBox.DataSource = this.neighborsBindingSource;
            this.neighborsListBox.DisplayMember = "Name";
            this.neighborsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.neighborsListBox.FormattingEnabled = true;
            this.neighborsListBox.Location = new System.Drawing.Point(3, 16);
            this.neighborsListBox.Name = "neighborsListBox";
            this.neighborsListBox.Size = new System.Drawing.Size(164, 115);
            this.neighborsListBox.TabIndex = 0;
            this.neighborsListBox.ValueMember = "Name";
            // 
            // neighborsBindingSource
            // 
            this.neighborsBindingSource.DataMember = "Neighbors";
            this.neighborsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 367);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zork Builder";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.welcomeTabPage.ResumeLayout(false);
            this.welcomeTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            this.startLocationTabPage.ResumeLayout(false);
            this.startLocationTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.roomsTabPage.ResumeLayout(false);
            this.roomsTabPage.PerformLayout();
            this.itemsTabPage.ResumeLayout(false);
            this.itemsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfNeighborsNamebindingSource)).EndInit();
            this.NeighborsListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.neighborsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingExistingGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addingRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editingRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage roomsTabPage;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.Button roomDeleteButoon;
        private System.Windows.Forms.Button roomAddButton;
        private System.Windows.Forms.Button roomEditButton;
        private Controls.NeighborsControl westNeighborsControl;
        private Controls.NeighborsControl southNeighborsControl;
        private Controls.NeighborsControl northNeighborsControl;
        private Controls.NeighborsControl eastNeighborsControl;
        private System.Windows.Forms.TabPage itemsTabPage;
        private System.Windows.Forms.Button itemDeleteButton;
        private System.Windows.Forms.Button itemAddButton;
        private System.Windows.Forms.Button itemEditButtom;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.Button roomSaveButton;
        private System.Windows.Forms.Button itemSaveButton;
        private System.Windows.Forms.TabPage welcomeTabPage;
        private System.Windows.Forms.TextBox newMessageTextBox;
        private System.Windows.Forms.Label newMessageLabel;
        private System.Windows.Forms.Button welcomeMessageOkButton;
        private System.Windows.Forms.TextBox welcomMessageTextBox;
        private System.Windows.Forms.Label currentMessageLabel;
        private System.Windows.Forms.TabPage startLocationTabPage;
        private System.Windows.Forms.ListBox roomsListBox2;
        private System.Windows.Forms.TextBox currentLocationTextBox;
        private System.Windows.Forms.Label currenLocationLabel;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.BindingSource worldBindingSource;
        private System.Windows.Forms.Button welcomeMessageEditButton;
        private System.Windows.Forms.BindingSource listOfNeighborsNamebindingSource;
        private System.Windows.Forms.GroupBox neighborLocationgroupBox;
        private System.Windows.Forms.GroupBox NeighborsListGroupBox;
        private System.Windows.Forms.ListBox neighborsListBox;
        private System.Windows.Forms.BindingSource neighborsBindingSource;
    }
}

