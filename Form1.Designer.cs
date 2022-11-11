
namespace F21SC_CW1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulkDownloadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDefaultFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterFilePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHomePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCurrentPageAsHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterHomePageURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.displayWindow = new System.Windows.Forms.RichTextBox();
            this.favListBox = new System.Windows.Forms.ListBox();
            this.favDeleteButton = new System.Windows.Forms.Button();
            this.favCloseButton = new System.Windows.Forms.Button();
            this.favPanel = new System.Windows.Forms.Panel();
            this.faveEditButton = new System.Windows.Forms.Button();
            this.favNameTextBox = new System.Windows.Forms.TextBox();
            this.favGoButton = new System.Windows.Forms.Button();
            this.favAddButton = new System.Windows.Forms.Button();
            this.favURLTextBox = new System.Windows.Forms.TextBox();
            this.histListBox = new System.Windows.Forms.ListBox();
            this.histPanel = new System.Windows.Forms.Panel();
            this.histDeleteButton = new System.Windows.Forms.Button();
            this.histCloseButton = new System.Windows.Forms.Button();
            this.histGoButton = new System.Windows.Forms.Button();
            this.bulkPanel = new System.Windows.Forms.Panel();
            this.bulkCloseButton = new System.Windows.Forms.Button();
            this.bulkButton = new System.Windows.Forms.Button();
            this.bulkTextBox = new System.Windows.Forms.TextBox();
            this.homePanel = new System.Windows.Forms.Panel();
            this.homeCloseButton = new System.Windows.Forms.Button();
            this.homeSaveButton = new System.Windows.Forms.Button();
            this.homeTestBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.favPanel.SuspendLayout();
            this.histPanel.SuspendLayout();
            this.bulkPanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.forwardToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.favouritesToolStripMenuItem,
            this.historyToolStripMenuItem1,
            this.bulkDownloadToolStripMenuItem1,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // forwardToolStripMenuItem
            // 
            this.forwardToolStripMenuItem.Name = "forwardToolStripMenuItem";
            this.forwardToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.forwardToolStripMenuItem.Text = "Forward";
            this.forwardToolStripMenuItem.Click += new System.EventHandler(this.forwardToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // favouritesToolStripMenuItem
            // 
            this.favouritesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToFavouritesToolStripMenuItem,
            this.showFavouritesToolStripMenuItem});
            this.favouritesToolStripMenuItem.Name = "favouritesToolStripMenuItem";
            this.favouritesToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.favouritesToolStripMenuItem.Text = "Favourites";
            // 
            // addToFavouritesToolStripMenuItem
            // 
            this.addToFavouritesToolStripMenuItem.Name = "addToFavouritesToolStripMenuItem";
            this.addToFavouritesToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.addToFavouritesToolStripMenuItem.Text = "Add current page";
            this.addToFavouritesToolStripMenuItem.Click += new System.EventHandler(this.addToFavouritesToolStripMenuItem_Click);
            // 
            // showFavouritesToolStripMenuItem
            // 
            this.showFavouritesToolStripMenuItem.Name = "showFavouritesToolStripMenuItem";
            this.showFavouritesToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.showFavouritesToolStripMenuItem.Text = "Show Favourites";
            this.showFavouritesToolStripMenuItem.Click += new System.EventHandler(this.showFavouritesToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem1
            // 
            this.historyToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHistoryToolStripMenuItem});
            this.historyToolStripMenuItem1.Name = "historyToolStripMenuItem1";
            this.historyToolStripMenuItem1.Size = new System.Drawing.Size(70, 24);
            this.historyToolStripMenuItem1.Text = "History";
            // 
            // showHistoryToolStripMenuItem
            // 
            this.showHistoryToolStripMenuItem.Name = "showHistoryToolStripMenuItem";
            this.showHistoryToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.showHistoryToolStripMenuItem.Text = "Show History";
            this.showHistoryToolStripMenuItem.Click += new System.EventHandler(this.showHistoryToolStripMenuItem_Click);
            // 
            // bulkDownloadToolStripMenuItem1
            // 
            this.bulkDownloadToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDefaultFileToolStripMenuItem,
            this.enterFilePathToolStripMenuItem});
            this.bulkDownloadToolStripMenuItem1.Name = "bulkDownloadToolStripMenuItem1";
            this.bulkDownloadToolStripMenuItem1.Size = new System.Drawing.Size(124, 24);
            this.bulkDownloadToolStripMenuItem1.Text = "Bulk Download";
            // 
            // loadDefaultFileToolStripMenuItem
            // 
            this.loadDefaultFileToolStripMenuItem.Name = "loadDefaultFileToolStripMenuItem";
            this.loadDefaultFileToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.loadDefaultFileToolStripMenuItem.Text = "Load Default File Path";
            this.loadDefaultFileToolStripMenuItem.Click += new System.EventHandler(this.loadDefaultFileToolStripMenuItem_Click);
            // 
            // enterFilePathToolStripMenuItem
            // 
            this.enterFilePathToolStripMenuItem.Name = "enterFilePathToolStripMenuItem";
            this.enterFilePathToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.enterFilePathToolStripMenuItem.Text = "Enter File Path";
            this.enterFilePathToolStripMenuItem.Click += new System.EventHandler(this.enterFilePathToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setHomePageToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // setHomePageToolStripMenuItem
            // 
            this.setHomePageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setCurrentPageAsHomeToolStripMenuItem,
            this.enterHomePageURLToolStripMenuItem});
            this.setHomePageToolStripMenuItem.Name = "setHomePageToolStripMenuItem";
            this.setHomePageToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.setHomePageToolStripMenuItem.Text = "Set Home Page";
            // 
            // setCurrentPageAsHomeToolStripMenuItem
            // 
            this.setCurrentPageAsHomeToolStripMenuItem.Name = "setCurrentPageAsHomeToolStripMenuItem";
            this.setCurrentPageAsHomeToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.setCurrentPageAsHomeToolStripMenuItem.Text = "Set current page as home";
            this.setCurrentPageAsHomeToolStripMenuItem.Click += new System.EventHandler(this.setCurrentPageAsHomeToolStripMenuItem_Click);
            // 
            // enterHomePageURLToolStripMenuItem
            // 
            this.enterHomePageURLToolStripMenuItem.Name = "enterHomePageURLToolStripMenuItem";
            this.enterHomePageURLToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.enterHomePageURLToolStripMenuItem.Text = "Enter Home Page URL";
            this.enterHomePageURLToolStripMenuItem.Click += new System.EventHandler(this.enterHomePageURLToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // searchBar
            // 
            this.searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBar.Location = new System.Drawing.Point(12, 31);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(695, 22);
            this.searchBar.TabIndex = 1;
            this.searchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBar_KeyPress);
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Location = new System.Drawing.Point(713, 31);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_click);
            // 
            // displayWindow
            // 
            this.displayWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayWindow.Location = new System.Drawing.Point(12, 69);
            this.displayWindow.Name = "displayWindow";
            this.displayWindow.Size = new System.Drawing.Size(776, 369);
            this.displayWindow.TabIndex = 3;
            this.displayWindow.Text = "";
            this.displayWindow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.displayWindow_MouseClick);
            // 
            // favListBox
            // 
            this.favListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favListBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.favListBox.FormattingEnabled = true;
            this.favListBox.ItemHeight = 16;
            this.favListBox.Location = new System.Drawing.Point(12, 31);
            this.favListBox.Name = "favListBox";
            this.favListBox.Size = new System.Drawing.Size(357, 276);
            this.favListBox.TabIndex = 4;
            // 
            // favDeleteButton
            // 
            this.favDeleteButton.Location = new System.Drawing.Point(188, 112);
            this.favDeleteButton.Name = "favDeleteButton";
            this.favDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.favDeleteButton.TabIndex = 5;
            this.favDeleteButton.Text = "Delete";
            this.favDeleteButton.UseVisualStyleBackColor = true;
            this.favDeleteButton.Click += new System.EventHandler(this.favDeleteButton_Click);
            // 
            // favCloseButton
            // 
            this.favCloseButton.Location = new System.Drawing.Point(269, 112);
            this.favCloseButton.Name = "favCloseButton";
            this.favCloseButton.Size = new System.Drawing.Size(75, 23);
            this.favCloseButton.TabIndex = 6;
            this.favCloseButton.Text = "Close";
            this.favCloseButton.UseVisualStyleBackColor = true;
            this.favCloseButton.Click += new System.EventHandler(this.favCloseButton_Click);
            // 
            // favPanel
            // 
            this.favPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.favPanel.Controls.Add(this.faveEditButton);
            this.favPanel.Controls.Add(this.favNameTextBox);
            this.favPanel.Controls.Add(this.favGoButton);
            this.favPanel.Controls.Add(this.favAddButton);
            this.favPanel.Controls.Add(this.favURLTextBox);
            this.favPanel.Controls.Add(this.favCloseButton);
            this.favPanel.Controls.Add(this.favDeleteButton);
            this.favPanel.Location = new System.Drawing.Point(12, 300);
            this.favPanel.Name = "favPanel";
            this.favPanel.Size = new System.Drawing.Size(357, 138);
            this.favPanel.TabIndex = 7;
            // 
            // faveEditButton
            // 
            this.faveEditButton.Location = new System.Drawing.Point(26, 83);
            this.faveEditButton.Name = "faveEditButton";
            this.faveEditButton.Size = new System.Drawing.Size(111, 23);
            this.faveEditButton.TabIndex = 11;
            this.faveEditButton.Text = "Edit Favourite";
            this.faveEditButton.UseVisualStyleBackColor = true;
            this.faveEditButton.Click += new System.EventHandler(this.faveEditButton_Click);
            // 
            // favNameTextBox
            // 
            this.favNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favNameTextBox.Location = new System.Drawing.Point(26, 16);
            this.favNameTextBox.Name = "favNameTextBox";
            this.favNameTextBox.Size = new System.Drawing.Size(298, 22);
            this.favNameTextBox.TabIndex = 10;
            this.favNameTextBox.Text = "Enter Associate name here.";
            this.favNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.favNameTextBox_MouseClick);
            // 
            // favGoButton
            // 
            this.favGoButton.Location = new System.Drawing.Point(26, 112);
            this.favGoButton.Name = "favGoButton";
            this.favGoButton.Size = new System.Drawing.Size(75, 23);
            this.favGoButton.TabIndex = 9;
            this.favGoButton.Text = "Go";
            this.favGoButton.UseVisualStyleBackColor = true;
            this.favGoButton.Click += new System.EventHandler(this.favGoButton_Click);
            // 
            // favAddButton
            // 
            this.favAddButton.Location = new System.Drawing.Point(107, 112);
            this.favAddButton.Name = "favAddButton";
            this.favAddButton.Size = new System.Drawing.Size(75, 23);
            this.favAddButton.TabIndex = 8;
            this.favAddButton.Text = "Add";
            this.favAddButton.UseVisualStyleBackColor = true;
            this.favAddButton.Click += new System.EventHandler(this.favAddButton_Click);
            // 
            // favURLTextBox
            // 
            this.favURLTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favURLTextBox.Location = new System.Drawing.Point(26, 44);
            this.favURLTextBox.Name = "favURLTextBox";
            this.favURLTextBox.Size = new System.Drawing.Size(298, 22);
            this.favURLTextBox.TabIndex = 7;
            this.favURLTextBox.Text = "Enter URL here. ";
            this.favURLTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.favTextBoxURL_MouseClick);
            // 
            // histListBox
            // 
            this.histListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histListBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.histListBox.FormattingEnabled = true;
            this.histListBox.ItemHeight = 16;
            this.histListBox.Location = new System.Drawing.Point(396, 31);
            this.histListBox.Name = "histListBox";
            this.histListBox.Size = new System.Drawing.Size(392, 340);
            this.histListBox.TabIndex = 8;
            // 
            // histPanel
            // 
            this.histPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.histPanel.Controls.Add(this.histDeleteButton);
            this.histPanel.Controls.Add(this.histCloseButton);
            this.histPanel.Controls.Add(this.histGoButton);
            this.histPanel.Location = new System.Drawing.Point(396, 363);
            this.histPanel.Name = "histPanel";
            this.histPanel.Size = new System.Drawing.Size(392, 75);
            this.histPanel.TabIndex = 9;
            // 
            // histDeleteButton
            // 
            this.histDeleteButton.Location = new System.Drawing.Point(130, 28);
            this.histDeleteButton.Name = "histDeleteButton";
            this.histDeleteButton.Size = new System.Drawing.Size(136, 23);
            this.histDeleteButton.TabIndex = 2;
            this.histDeleteButton.Text = "Delete All History";
            this.histDeleteButton.UseVisualStyleBackColor = true;
            this.histDeleteButton.Click += new System.EventHandler(this.histDeleteButton_Click);
            // 
            // histCloseButton
            // 
            this.histCloseButton.Location = new System.Drawing.Point(296, 28);
            this.histCloseButton.Name = "histCloseButton";
            this.histCloseButton.Size = new System.Drawing.Size(75, 23);
            this.histCloseButton.TabIndex = 1;
            this.histCloseButton.Text = "Close";
            this.histCloseButton.UseVisualStyleBackColor = true;
            this.histCloseButton.Click += new System.EventHandler(this.histCloseButton_Click);
            // 
            // histGoButton
            // 
            this.histGoButton.Location = new System.Drawing.Point(20, 28);
            this.histGoButton.Name = "histGoButton";
            this.histGoButton.Size = new System.Drawing.Size(75, 23);
            this.histGoButton.TabIndex = 0;
            this.histGoButton.Text = "Go";
            this.histGoButton.UseVisualStyleBackColor = true;
            this.histGoButton.Click += new System.EventHandler(this.histGoButton_Click);
            // 
            // bulkPanel
            // 
            this.bulkPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bulkPanel.Controls.Add(this.bulkCloseButton);
            this.bulkPanel.Controls.Add(this.bulkButton);
            this.bulkPanel.Controls.Add(this.bulkTextBox);
            this.bulkPanel.Location = new System.Drawing.Point(272, 31);
            this.bulkPanel.Name = "bulkPanel";
            this.bulkPanel.Size = new System.Drawing.Size(307, 72);
            this.bulkPanel.TabIndex = 10;
            // 
            // bulkCloseButton
            // 
            this.bulkCloseButton.Location = new System.Drawing.Point(189, 38);
            this.bulkCloseButton.Name = "bulkCloseButton";
            this.bulkCloseButton.Size = new System.Drawing.Size(75, 23);
            this.bulkCloseButton.TabIndex = 2;
            this.bulkCloseButton.Text = "Close";
            this.bulkCloseButton.UseVisualStyleBackColor = true;
            this.bulkCloseButton.Click += new System.EventHandler(this.bulkCloseButton_Click);
            // 
            // bulkButton
            // 
            this.bulkButton.Location = new System.Drawing.Point(52, 38);
            this.bulkButton.Name = "bulkButton";
            this.bulkButton.Size = new System.Drawing.Size(75, 23);
            this.bulkButton.TabIndex = 1;
            this.bulkButton.Text = "Go";
            this.bulkButton.UseVisualStyleBackColor = true;
            this.bulkButton.Click += new System.EventHandler(this.bulkButton_Click);
            // 
            // bulkTextBox
            // 
            this.bulkTextBox.Location = new System.Drawing.Point(20, 10);
            this.bulkTextBox.Name = "bulkTextBox";
            this.bulkTextBox.Size = new System.Drawing.Size(272, 22);
            this.bulkTextBox.TabIndex = 0;
            this.bulkTextBox.Text = "Enter file path here. Format: \"\\\\file.txt\"";
            this.bulkTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bulkTextBox_MouseClick);
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.homePanel.Controls.Add(this.homeCloseButton);
            this.homePanel.Controls.Add(this.homeSaveButton);
            this.homePanel.Controls.Add(this.homeTestBox);
            this.homePanel.Location = new System.Drawing.Point(493, 30);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(307, 73);
            this.homePanel.TabIndex = 3;
            // 
            // homeCloseButton
            // 
            this.homeCloseButton.Location = new System.Drawing.Point(189, 41);
            this.homeCloseButton.Name = "homeCloseButton";
            this.homeCloseButton.Size = new System.Drawing.Size(75, 23);
            this.homeCloseButton.TabIndex = 2;
            this.homeCloseButton.Text = "close";
            this.homeCloseButton.UseVisualStyleBackColor = true;
            this.homeCloseButton.Click += new System.EventHandler(this.homeCloseButton_Click);
            // 
            // homeSaveButton
            // 
            this.homeSaveButton.Location = new System.Drawing.Point(52, 41);
            this.homeSaveButton.Name = "homeSaveButton";
            this.homeSaveButton.Size = new System.Drawing.Size(75, 23);
            this.homeSaveButton.TabIndex = 1;
            this.homeSaveButton.Text = "Save";
            this.homeSaveButton.UseVisualStyleBackColor = true;
            this.homeSaveButton.Click += new System.EventHandler(this.homeSaveButton_Click);
            // 
            // homeTestBox
            // 
            this.homeTestBox.Location = new System.Drawing.Point(20, 12);
            this.homeTestBox.Name = "homeTestBox";
            this.homeTestBox.Size = new System.Drawing.Size(272, 22);
            this.homeTestBox.TabIndex = 0;
            this.homeTestBox.Text = "Enter Home URL here.";
            this.homeTestBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.homeTestBox_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.bulkPanel);
            this.Controls.Add(this.histPanel);
            this.Controls.Add(this.histListBox);
            this.Controls.Add(this.favPanel);
            this.Controls.Add(this.favListBox);
            this.Controls.Add(this.displayWindow);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Go Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.favPanel.ResumeLayout(false);
            this.favPanel.PerformLayout();
            this.histPanel.ResumeLayout(false);
            this.bulkPanel.ResumeLayout(false);
            this.bulkPanel.PerformLayout();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bulkDownloadToolStripMenuItem1;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.RichTextBox displayWindow;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setHomePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setCurrentPageAsHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToFavouritesToolStripMenuItem;
        private System.Windows.Forms.ListBox favListBox;
        private System.Windows.Forms.ToolStripMenuItem showFavouritesToolStripMenuItem;
        private System.Windows.Forms.Button favDeleteButton;
        private System.Windows.Forms.Button favCloseButton;
        private System.Windows.Forms.Panel favPanel;
        private System.Windows.Forms.Button favAddButton;
        private System.Windows.Forms.TextBox favURLTextBox;
        private System.Windows.Forms.Button favGoButton;
        private System.Windows.Forms.ToolStripMenuItem showHistoryToolStripMenuItem;
        private System.Windows.Forms.ListBox histListBox;
        private System.Windows.Forms.Panel histPanel;
        private System.Windows.Forms.Button histDeleteButton;
        private System.Windows.Forms.Button histCloseButton;
        private System.Windows.Forms.Button histGoButton;
        private System.Windows.Forms.Panel bulkPanel;
        private System.Windows.Forms.Button bulkButton;
        private System.Windows.Forms.TextBox bulkTextBox;
        private System.Windows.Forms.ToolStripMenuItem loadDefaultFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterFilePathToolStripMenuItem;
        private System.Windows.Forms.Button bulkCloseButton;
        private System.Windows.Forms.TextBox favNameTextBox;
        private System.Windows.Forms.Button faveEditButton;
        private System.Windows.Forms.ToolStripMenuItem enterHomePageURLToolStripMenuItem;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Button homeCloseButton;
        private System.Windows.Forms.Button homeSaveButton;
        private System.Windows.Forms.TextBox homeTestBox;
    }
}

