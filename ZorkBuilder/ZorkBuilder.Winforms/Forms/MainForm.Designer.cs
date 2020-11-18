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
            this.label2 = new System.Windows.Forms.Label();
            this.welcomeMessageOkButton = new System.Windows.Forms.Button();
            this.welcomeMessageEditButton = new System.Windows.Forms.Button();
            this.welcomMessageTextBox = new System.Windows.Forms.TextBox();
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currentMessageLabel = new System.Windows.Forms.Label();
            this.roomsTabPage = new System.Windows.Forms.TabPage();
            this.StartLocationGroupBox = new System.Windows.Forms.GroupBox();
            this.startLocationTextBox = new System.Windows.Forms.TextBox();
            this.NeighborsListGroupBox = new System.Windows.Forms.GroupBox();
            this.neighborsListBox = new System.Windows.Forms.ListBox();
            this.listOfNeighborsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomSaveButton = new System.Windows.Forms.Button();
            this.northNeighborsControl = new ZorkBuilder.Winforms.Controls.NeighborsControl();
            this.roomDeleteButoon = new System.Windows.Forms.Button();
            this.roomAddButton = new System.Windows.Forms.Button();
            this.roomEditButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.neighborLocationgroupBox = new System.Windows.Forms.GroupBox();
            this.eastNeighborsControl = new ZorkBuilder.Winforms.Controls.NeighborsControl();
            this.westNeighborsControl = new ZorkBuilder.Winforms.Controls.NeighborsControl();
            this.southNeighborsControl = new ZorkBuilder.Winforms.Controls.NeighborsControl();
            this.neighborsItemsTabPage = new System.Windows.Forms.TabPage();
            this.itemsGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemWeightLabel = new System.Windows.Forms.Label();
            this.itemWeightextBox = new System.Windows.Forms.TextBox();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.neighborsGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteNeighborButton = new System.Windows.Forms.Button();
            this.neighborsNameListBox = new System.Windows.Forms.ListBox();
            this.neighborsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.neighborNameLabel = new System.Windows.Forms.Label();
            this.neighborNametextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainMenuStrip.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.welcomeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            this.roomsTabPage.SuspendLayout();
            this.StartLocationGroupBox.SuspendLayout();
            this.NeighborsListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfNeighborsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.neighborLocationgroupBox.SuspendLayout();
            this.neighborsItemsTabPage.SuspendLayout();
            this.itemsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.neighborsGroupBox.SuspendLayout();
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
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
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
            this.mainTabControl.Controls.Add(this.roomsTabPage);
            this.mainTabControl.Controls.Add(this.neighborsItemsTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 24);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(632, 343);
            this.mainTabControl.TabIndex = 1;
            // 
            // welcomeTabPage
            // 
            this.welcomeTabPage.Controls.Add(this.label2);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
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
            // roomsTabPage
            // 
            this.roomsTabPage.Controls.Add(this.StartLocationGroupBox);
            this.roomsTabPage.Controls.Add(this.NeighborsListGroupBox);
            this.roomsTabPage.Controls.Add(this.roomSaveButton);
            this.roomsTabPage.Controls.Add(this.northNeighborsControl);
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
            // StartLocationGroupBox
            // 
            this.StartLocationGroupBox.Controls.Add(this.startLocationTextBox);
            this.StartLocationGroupBox.Location = new System.Drawing.Point(329, 203);
            this.StartLocationGroupBox.Name = "StartLocationGroupBox";
            this.StartLocationGroupBox.Size = new System.Drawing.Size(292, 76);
            this.StartLocationGroupBox.TabIndex = 14;
            this.StartLocationGroupBox.TabStop = false;
            this.StartLocationGroupBox.Text = "Start Location";
            // 
            // startLocationTextBox
            // 
            this.startLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worldViewModelBindingSource, "StartLocation", true));
            this.startLocationTextBox.Location = new System.Drawing.Point(87, 28);
            this.startLocationTextBox.Name = "startLocationTextBox";
            this.startLocationTextBox.ReadOnly = true;
            this.startLocationTextBox.Size = new System.Drawing.Size(121, 20);
            this.startLocationTextBox.TabIndex = 0;
            this.startLocationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.neighborsListBox.DataSource = this.listOfNeighborsBindingSource;
            this.neighborsListBox.DisplayMember = "Name";
            this.neighborsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.neighborsListBox.FormattingEnabled = true;
            this.neighborsListBox.Location = new System.Drawing.Point(3, 16);
            this.neighborsListBox.Name = "neighborsListBox";
            this.neighborsListBox.Size = new System.Drawing.Size(164, 115);
            this.neighborsListBox.TabIndex = 0;
            this.neighborsListBox.ValueMember = "Name";
            // 
            // listOfNeighborsBindingSource
            // 
            this.listOfNeighborsBindingSource.DataMember = "ListOfNeighbors";
            this.listOfNeighborsBindingSource.DataSource = this.roomsBindingSource;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.worldViewModelBindingSource;
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
            this.roomsListBox.ValueMember = "Description";
            this.roomsListBox.SelectedIndexChanged += new System.EventHandler(this.RoomsListBox_SelectedIndexChanged);
            // 
            // neighborLocationgroupBox
            // 
            this.neighborLocationgroupBox.Controls.Add(this.eastNeighborsControl);
            this.neighborLocationgroupBox.Controls.Add(this.westNeighborsControl);
            this.neighborLocationgroupBox.Controls.Add(this.southNeighborsControl);
            this.neighborLocationgroupBox.Location = new System.Drawing.Point(329, 12);
            this.neighborLocationgroupBox.Name = "neighborLocationgroupBox";
            this.neighborLocationgroupBox.Size = new System.Drawing.Size(292, 185);
            this.neighborLocationgroupBox.TabIndex = 2;
            this.neighborLocationgroupBox.TabStop = false;
            this.neighborLocationgroupBox.Text = "Neighbors";
            // 
            // eastNeighborsControl
            // 
            this.eastNeighborsControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eastNeighborsControl.Directions = ZorkBuilder.Data.Directions.West;
            this.eastNeighborsControl.Location = new System.Drawing.Point(6, 71);
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
            this.westNeighborsControl.Location = new System.Drawing.Point(165, 71);
            this.westNeighborsControl.Name = "westNeighborsControl";
            this.westNeighborsControl.NeighborsName = null;
            this.westNeighborsControl.Room = null;
            this.westNeighborsControl.Size = new System.Drawing.Size(121, 48);
            this.westNeighborsControl.TabIndex = 6;
            // 
            // southNeighborsControl
            // 
            this.southNeighborsControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.southNeighborsControl.Directions = ZorkBuilder.Data.Directions.South;
            this.southNeighborsControl.Location = new System.Drawing.Point(87, 125);
            this.southNeighborsControl.Name = "southNeighborsControl";
            this.southNeighborsControl.NeighborsName = null;
            this.southNeighborsControl.Room = null;
            this.southNeighborsControl.Size = new System.Drawing.Size(121, 48);
            this.southNeighborsControl.TabIndex = 8;
            // 
            // neighborsItemsTabPage
            // 
            this.neighborsItemsTabPage.Controls.Add(this.itemsGroupBox);
            this.neighborsItemsTabPage.Controls.Add(this.neighborsGroupBox);
            this.neighborsItemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.neighborsItemsTabPage.Name = "neighborsItemsTabPage";
            this.neighborsItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.neighborsItemsTabPage.Size = new System.Drawing.Size(624, 317);
            this.neighborsItemsTabPage.TabIndex = 3;
            this.neighborsItemsTabPage.Text = "Neighbors & Items";
            this.neighborsItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsGroupBox
            // 
            this.itemsGroupBox.Controls.Add(this.deleteItemButton);
            this.itemsGroupBox.Controls.Add(this.addItemButton);
            this.itemsGroupBox.Controls.Add(this.itemsListBox);
            this.itemsGroupBox.Controls.Add(this.itemWeightLabel);
            this.itemsGroupBox.Controls.Add(this.itemWeightextBox);
            this.itemsGroupBox.Controls.Add(this.itemNameLabel);
            this.itemsGroupBox.Controls.Add(this.itemNameTextBox);
            this.itemsGroupBox.Location = new System.Drawing.Point(314, 0);
            this.itemsGroupBox.Name = "itemsGroupBox";
            this.itemsGroupBox.Size = new System.Drawing.Size(310, 311);
            this.itemsGroupBox.TabIndex = 3;
            this.itemsGroupBox.TabStop = false;
            this.itemsGroupBox.Text = "Items";
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(88, 282);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(75, 23);
            this.deleteItemButton.TabIndex = 22;
            this.deleteItemButton.Text = "&Delete";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(7, 282);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 21;
            this.addItemButton.Text = "&Add";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // itemsListBox
            // 
            this.itemsListBox.DataSource = this.itemsBindingSource;
            this.itemsListBox.DisplayMember = "Name";
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(6, 15);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(157, 264);
            this.itemsListBox.TabIndex = 19;
            this.itemsListBox.ValueMember = "Name";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // itemWeightLabel
            // 
            this.itemWeightLabel.AutoSize = true;
            this.itemWeightLabel.Location = new System.Drawing.Point(179, 56);
            this.itemWeightLabel.Name = "itemWeightLabel";
            this.itemWeightLabel.Size = new System.Drawing.Size(41, 13);
            this.itemWeightLabel.TabIndex = 17;
            this.itemWeightLabel.Text = "Weight";
            // 
            // itemWeightextBox
            // 
            this.itemWeightextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Weight", true));
            this.itemWeightextBox.Location = new System.Drawing.Point(179, 73);
            this.itemWeightextBox.Name = "itemWeightextBox";
            this.itemWeightextBox.ReadOnly = true;
            this.itemWeightextBox.Size = new System.Drawing.Size(111, 20);
            this.itemWeightextBox.TabIndex = 16;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(179, 16);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(35, 13);
            this.itemNameLabel.TabIndex = 15;
            this.itemNameLabel.Text = "Name";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Weight", true));
            this.itemNameTextBox.Location = new System.Drawing.Point(179, 33);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.ReadOnly = true;
            this.itemNameTextBox.Size = new System.Drawing.Size(111, 20);
            this.itemNameTextBox.TabIndex = 14;
            // 
            // neighborsGroupBox
            // 
            this.neighborsGroupBox.Controls.Add(this.deleteNeighborButton);
            this.neighborsGroupBox.Controls.Add(this.neighborsNameListBox);
            this.neighborsGroupBox.Controls.Add(this.neighborNameLabel);
            this.neighborsGroupBox.Controls.Add(this.neighborNametextBox);
            this.neighborsGroupBox.Location = new System.Drawing.Point(3, 0);
            this.neighborsGroupBox.Name = "neighborsGroupBox";
            this.neighborsGroupBox.Size = new System.Drawing.Size(305, 314);
            this.neighborsGroupBox.TabIndex = 2;
            this.neighborsGroupBox.TabStop = false;
            this.neighborsGroupBox.Text = "Neighbors";
            // 
            // deleteNeighborButton
            // 
            this.deleteNeighborButton.Location = new System.Drawing.Point(87, 285);
            this.deleteNeighborButton.Name = "deleteNeighborButton";
            this.deleteNeighborButton.Size = new System.Drawing.Size(75, 23);
            this.deleteNeighborButton.TabIndex = 20;
            this.deleteNeighborButton.Text = "&Delete";
            this.deleteNeighborButton.UseVisualStyleBackColor = true;
            this.deleteNeighborButton.Click += new System.EventHandler(this.DeleteNeighborButton_Click);
            // 
            // neighborsNameListBox
            // 
            this.neighborsNameListBox.DataSource = this.neighborsBindingSource;
            this.neighborsNameListBox.DisplayMember = "Name";
            this.neighborsNameListBox.FormattingEnabled = true;
            this.neighborsNameListBox.Location = new System.Drawing.Point(4, 16);
            this.neighborsNameListBox.Name = "neighborsNameListBox";
            this.neighborsNameListBox.Size = new System.Drawing.Size(158, 264);
            this.neighborsNameListBox.TabIndex = 18;
            this.neighborsNameListBox.ValueMember = "Name";
            // 
            // neighborsBindingSource
            // 
            this.neighborsBindingSource.DataMember = "Neighbors";
            this.neighborsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // neighborNameLabel
            // 
            this.neighborNameLabel.AutoSize = true;
            this.neighborNameLabel.Location = new System.Drawing.Point(177, 16);
            this.neighborNameLabel.Name = "neighborNameLabel";
            this.neighborNameLabel.Size = new System.Drawing.Size(35, 13);
            this.neighborNameLabel.TabIndex = 17;
            this.neighborNameLabel.Text = "Name";
            // 
            // neighborNametextBox
            // 
            this.neighborNametextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.neighborsBindingSource, "Name", true));
            this.neighborNametextBox.Location = new System.Drawing.Point(177, 33);
            this.neighborNametextBox.Name = "neighborNametextBox";
            this.neighborNametextBox.ReadOnly = true;
            this.neighborNametextBox.Size = new System.Drawing.Size(111, 20);
            this.neighborNametextBox.TabIndex = 16;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files (*json)|*.json";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "World files (*.json)|*.json";
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
            this.roomsTabPage.ResumeLayout(false);
            this.roomsTabPage.PerformLayout();
            this.StartLocationGroupBox.ResumeLayout(false);
            this.StartLocationGroupBox.PerformLayout();
            this.NeighborsListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listOfNeighborsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.neighborLocationgroupBox.ResumeLayout(false);
            this.neighborsItemsTabPage.ResumeLayout(false);
            this.itemsGroupBox.ResumeLayout(false);
            this.itemsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.neighborsGroupBox.ResumeLayout(false);
            this.neighborsGroupBox.PerformLayout();
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
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.Button roomSaveButton;
        private System.Windows.Forms.TabPage welcomeTabPage;
        private System.Windows.Forms.Button welcomeMessageOkButton;
        private System.Windows.Forms.TextBox welcomMessageTextBox;
        private System.Windows.Forms.Label currentMessageLabel;
        private System.Windows.Forms.TabPage neighborsItemsTabPage;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.Button welcomeMessageEditButton;
        private System.Windows.Forms.GroupBox neighborLocationgroupBox;
        private System.Windows.Forms.GroupBox NeighborsListGroupBox;
        private System.Windows.Forms.ListBox neighborsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox StartLocationGroupBox;
        private System.Windows.Forms.TextBox startLocationTextBox;
        private System.Windows.Forms.BindingSource listOfNeighborsBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.GroupBox itemsGroupBox;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.Label itemWeightLabel;
        private System.Windows.Forms.TextBox itemWeightextBox;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.GroupBox neighborsGroupBox;
        private System.Windows.Forms.Button deleteNeighborButton;
        private System.Windows.Forms.ListBox neighborsNameListBox;
        private System.Windows.Forms.BindingSource neighborsBindingSource;
        private System.Windows.Forms.Label neighborNameLabel;
        private System.Windows.Forms.TextBox neighborNametextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

