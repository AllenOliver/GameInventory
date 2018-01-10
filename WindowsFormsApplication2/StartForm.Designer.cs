namespace WindowsFormsApplication2
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showALLGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ebayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceChartingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewGames = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxGameTitle = new System.Windows.Forms.TextBox();
            this.comboBoxConsole = new System.Windows.Forms.ComboBox();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.webToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkOutToolStripMenuItem,
            this.showALLGamesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // showALLGamesToolStripMenuItem
            // 
            this.showALLGamesToolStripMenuItem.Name = "showALLGamesToolStripMenuItem";
            this.showALLGamesToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.showALLGamesToolStripMenuItem.Text = "Show ALL Games";
            this.showALLGamesToolStripMenuItem.Click += new System.EventHandler(this.showALLGamesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemsToolStripMenuItem,
            this.removeItemsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addItemsToolStripMenuItem
            // 
            this.addItemsToolStripMenuItem.Name = "addItemsToolStripMenuItem";
            this.addItemsToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.addItemsToolStripMenuItem.Text = "Add Items";
            this.addItemsToolStripMenuItem.Click += new System.EventHandler(this.addItemsToolStripMenuItem_Click);
            // 
            // removeItemsToolStripMenuItem
            // 
            this.removeItemsToolStripMenuItem.Name = "removeItemsToolStripMenuItem";
            this.removeItemsToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.removeItemsToolStripMenuItem.Text = "Remove Items";
            this.removeItemsToolStripMenuItem.Click += new System.EventHandler(this.removeItemsToolStripMenuItem_Click);
            // 
            // webToolStripMenuItem
            // 
            this.webToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ebayToolStripMenuItem,
            this.gameStopToolStripMenuItem,
            this.priceChartingToolStripMenuItem});
            this.webToolStripMenuItem.Name = "webToolStripMenuItem";
            this.webToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.webToolStripMenuItem.Text = "Web";
            // 
            // ebayToolStripMenuItem
            // 
            this.ebayToolStripMenuItem.Name = "ebayToolStripMenuItem";
            this.ebayToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.ebayToolStripMenuItem.Text = "Ebay";
            this.ebayToolStripMenuItem.Click += new System.EventHandler(this.ebayToolStripMenuItem_Click);
            // 
            // gameStopToolStripMenuItem
            // 
            this.gameStopToolStripMenuItem.Name = "gameStopToolStripMenuItem";
            this.gameStopToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.gameStopToolStripMenuItem.Text = "GameStop";
            this.gameStopToolStripMenuItem.Click += new System.EventHandler(this.gameStopToolStripMenuItem_Click);
            // 
            // priceChartingToolStripMenuItem
            // 
            this.priceChartingToolStripMenuItem.Name = "priceChartingToolStripMenuItem";
            this.priceChartingToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.priceChartingToolStripMenuItem.Text = "Price Charting";
            this.priceChartingToolStripMenuItem.Click += new System.EventHandler(this.priceChartingToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem,
            this.developerWebsiteToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // developerWebsiteToolStripMenuItem
            // 
            this.developerWebsiteToolStripMenuItem.Name = "developerWebsiteToolStripMenuItem";
            this.developerWebsiteToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.developerWebsiteToolStripMenuItem.Text = "Developer Website";
            this.developerWebsiteToolStripMenuItem.Click += new System.EventHandler(this.developerWebsiteToolStripMenuItem_Click);
            // 
            // listViewGames
            // 
            this.listViewGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewGames.Location = new System.Drawing.Point(12, 164);
            this.listViewGames.Name = "listViewGames";
            this.listViewGames.Size = new System.Drawing.Size(745, 343);
            this.listViewGames.TabIndex = 1;
            this.listViewGames.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Console";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Location";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(672, 51);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxGameTitle
            // 
            this.textBoxGameTitle.Location = new System.Drawing.Point(12, 95);
            this.textBoxGameTitle.MaxLength = 25;
            this.textBoxGameTitle.Name = "textBoxGameTitle";
            this.textBoxGameTitle.Size = new System.Drawing.Size(171, 22);
            this.textBoxGameTitle.TabIndex = 6;
            // 
            // comboBoxConsole
            // 
            this.comboBoxConsole.AutoCompleteCustomSource.AddRange(new string[] {
            "NES",
            "SNES",
            "N64",
            "GameCube",
            "Wii",
            "Wii U",
            "Switch",
            "GBA",
            "Gameboy",
            "DS",
            "3DS",
            "PS1",
            "PS2",
            "PS3",
            "PS4",
            "PSP",
            "PS Vita",
            "Xbox",
            "Xbox 360",
            "Xbox One",
            "TurboGrafx 16",
            "3DO",
            "Atari Jaguar"});
            this.comboBoxConsole.FormattingEnabled = true;
            this.comboBoxConsole.Location = new System.Drawing.Point(269, 95);
            this.comboBoxConsole.Name = "comboBoxConsole";
            this.comboBoxConsole.Size = new System.Drawing.Size(154, 24);
            this.comboBoxConsole.TabIndex = 7;
            this.comboBoxConsole.SelectedIndexChanged += new System.EventHandler(this.comboBoxConsole_SelectedIndexChanged);
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.AutoCompleteCustomSource.AddRange(new string[] {
            "Elizabethton"});
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(507, 95);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLocation.TabIndex = 8;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(672, 96);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.checkOutToolStripMenuItem.Text = "Check Out";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 586);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.comboBoxConsole);
            this.Controls.Add(this.textBoxGameTitle);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewGames);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Inventory PLUS ULTRA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ebayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceChartingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerWebsiteToolStripMenuItem;
        private System.Windows.Forms.ListView listViewGames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxGameTitle;
        private System.Windows.Forms.ComboBox comboBoxConsole;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ToolStripMenuItem addItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showALLGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
    }
}

