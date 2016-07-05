namespace TranslaTale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MainListView = new System.Windows.Forms.ListView();
            this.LineNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BaseTextColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TranslatedTextColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TextPreviewPanel = new System.Windows.Forms.Panel();
            this.FontComboBox = new System.Windows.Forms.ComboBox();
            this.FaceRadioButton = new System.Windows.Forms.RadioButton();
            this.NoFaceRadioButton = new System.Windows.Forms.RadioButton();
            this.MainSpriteFontBox = new UTSpriteFontBox.SpriteFontBox();
            this.MainMenuItemStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GoToMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompileAndRunMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ProjectSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BookmarksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBookmarkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListBookmarksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.GoToToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CompileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.TranslatedStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.UntranslatedStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TotalStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.MainTableLayout.SuspendLayout();
            this.TextPreviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSpriteFontBox)).BeginInit();
            this.MainMenuItemStrip.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTableLayout.ColumnCount = 1;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainTableLayout.Controls.Add(this.MainListView, 0, 0);
            this.MainTableLayout.Controls.Add(this.MainTextBox, 0, 1);
            this.MainTableLayout.Controls.Add(this.TextPreviewPanel, 0, 2);
            this.MainTableLayout.Location = new System.Drawing.Point(13, 62);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 4;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.Size = new System.Drawing.Size(658, 583);
            this.MainTableLayout.TabIndex = 3;
            // 
            // MainListView
            // 
            this.MainListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LineNumberColumn,
            this.BaseTextColumn,
            this.TranslatedTextColumn});
            this.MainListView.FullRowSelect = true;
            this.MainListView.GridLines = true;
            this.MainListView.HideSelection = false;
            this.MainListView.Location = new System.Drawing.Point(3, 3);
            this.MainListView.MultiSelect = false;
            this.MainListView.Name = "MainListView";
            this.MainListView.Size = new System.Drawing.Size(652, 353);
            this.MainListView.TabIndex = 4;
            this.MainListView.UseCompatibleStateImageBehavior = false;
            this.MainListView.View = System.Windows.Forms.View.Details;
            this.MainListView.SelectedIndexChanged += new System.EventHandler(this.MainListView_SelectedIndexChanged);
            this.MainListView.SizeChanged += new System.EventHandler(this.MainListView_SizeChanged);
            // 
            // LineNumberColumn
            // 
            this.LineNumberColumn.Text = "Line";
            this.LineNumberColumn.Width = 70;
            // 
            // BaseTextColumn
            // 
            this.BaseTextColumn.Text = "Base Text";
            this.BaseTextColumn.Width = 275;
            // 
            // TranslatedTextColumn
            // 
            this.TranslatedTextColumn.Text = "Translated Text";
            this.TranslatedTextColumn.Width = 275;
            // 
            // TextPreviewPanel
            // 
            this.TextPreviewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPreviewPanel.Controls.Add(this.FontComboBox);
            this.TextPreviewPanel.Controls.Add(this.FaceRadioButton);
            this.TextPreviewPanel.Controls.Add(this.NoFaceRadioButton);
            this.TextPreviewPanel.Controls.Add(this.MainSpriteFontBox);
            this.TextPreviewPanel.Location = new System.Drawing.Point(3, 382);
            this.TextPreviewPanel.Name = "TextPreviewPanel";
            this.TextPreviewPanel.Size = new System.Drawing.Size(652, 198);
            this.TextPreviewPanel.TabIndex = 7;
            // 
            // FontComboBox
            // 
            this.FontComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FontComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.FontComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontComboBox.FormattingEnabled = true;
            this.FontComboBox.Items.AddRange(new object[] {
            "Standard",
            "Sans",
            "Papyrus"});
            this.FontComboBox.Location = new System.Drawing.Point(519, 8);
            this.FontComboBox.Name = "FontComboBox";
            this.FontComboBox.Size = new System.Drawing.Size(121, 21);
            this.FontComboBox.TabIndex = 9;
            this.FontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontComboBox_SelectedIndexChanged);
            // 
            // FaceRadioButton
            // 
            this.FaceRadioButton.AutoSize = true;
            this.FaceRadioButton.Location = new System.Drawing.Point(83, 12);
            this.FaceRadioButton.Name = "FaceRadioButton";
            this.FaceRadioButton.Size = new System.Drawing.Size(113, 17);
            this.FaceRadioButton.TabIndex = 8;
            this.FaceRadioButton.Text = "Text Box with face";
            this.FaceRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoFaceRadioButton
            // 
            this.NoFaceRadioButton.AutoSize = true;
            this.NoFaceRadioButton.Checked = true;
            this.NoFaceRadioButton.Location = new System.Drawing.Point(10, 12);
            this.NoFaceRadioButton.Name = "NoFaceRadioButton";
            this.NoFaceRadioButton.Size = new System.Drawing.Size(67, 17);
            this.NoFaceRadioButton.TabIndex = 7;
            this.NoFaceRadioButton.TabStop = true;
            this.NoFaceRadioButton.Text = "Text Box";
            this.NoFaceRadioButton.UseVisualStyleBackColor = true;
            this.NoFaceRadioButton.CheckedChanged += new System.EventHandler(this.NoFaceRadioButton_CheckedChanged);
            // 
            // MainSpriteFontBox
            // 
            this.MainSpriteFontBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MainSpriteFontBox.CurrentSpriteFont = UTSpriteFontBox.SpriteFontBox.SpriteFonts.BitOperator;
            this.MainSpriteFontBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("MainSpriteFontBox.ErrorImage")));
            this.MainSpriteFontBox.FontPath = "";
            this.MainSpriteFontBox.Image = ((System.Drawing.Image)(resources.GetObject("MainSpriteFontBox.Image")));
            this.MainSpriteFontBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("MainSpriteFontBox.InitialImage")));
            this.MainSpriteFontBox.Location = new System.Drawing.Point(33, 39);
            this.MainSpriteFontBox.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.MainSpriteFontBox.MinimumSize = new System.Drawing.Size(578, 152);
            this.MainSpriteFontBox.Name = "MainSpriteFontBox";
            this.MainSpriteFontBox.ShowCommands = false;
            this.MainSpriteFontBox.ShowFaces = false;
            this.MainSpriteFontBox.Size = new System.Drawing.Size(578, 152);
            this.MainSpriteFontBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MainSpriteFontBox.TabIndex = 6;
            // 
            // MainMenuItemStrip
            // 
            this.MainMenuItemStrip.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuItemStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainMenuItemStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.EditMenuItem,
            this.ProjectMenuItem,
            this.BookmarksMenuItem,
            this.ToolsMenuItem,
            this.HelpMenuItem});
            this.MainMenuItemStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MainMenuItemStrip.Location = new System.Drawing.Point(10, 10);
            this.MainMenuItemStrip.Name = "MainMenuItemStrip";
            this.MainMenuItemStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainMenuItemStrip.Size = new System.Drawing.Size(664, 24);
            this.MainMenuItemStrip.TabIndex = 4;
            this.MainMenuItemStrip.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenuItem,
            this.SaveMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "File";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenMenuItem.Size = new System.Drawing.Size(155, 22);
            this.OpenMenuItem.Text = "Open...";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenProjectMenuItem_Click);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveMenuItem.Size = new System.Drawing.Size(155, 22);
            this.SaveMenuItem.Text = "Save";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchMenuItem,
            this.GoToMenuItem});
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditMenuItem.Text = "Edit";
            // 
            // SearchMenuItem
            // 
            this.SearchMenuItem.Name = "SearchMenuItem";
            this.SearchMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.SearchMenuItem.Size = new System.Drawing.Size(179, 22);
            this.SearchMenuItem.Text = "Search...";
            this.SearchMenuItem.Click += new System.EventHandler(this.SearchMenuItem_Click);
            // 
            // GoToMenuItem
            // 
            this.GoToMenuItem.Name = "GoToMenuItem";
            this.GoToMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.GoToMenuItem.Size = new System.Drawing.Size(179, 22);
            this.GoToMenuItem.Text = "Go to Line...";
            this.GoToMenuItem.Click += new System.EventHandler(this.GoToMenuItem_Click);
            // 
            // ProjectMenuItem
            // 
            this.ProjectMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompileMenuItem,
            this.CompileAndRunMenuItem,
            this.toolStripSeparator4,
            this.ProjectSettingsMenuItem});
            this.ProjectMenuItem.Name = "ProjectMenuItem";
            this.ProjectMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ProjectMenuItem.Text = "Project";
            // 
            // CompileMenuItem
            // 
            this.CompileMenuItem.Name = "CompileMenuItem";
            this.CompileMenuItem.Size = new System.Drawing.Size(166, 22);
            this.CompileMenuItem.Text = "Compile";
            this.CompileMenuItem.Click += new System.EventHandler(this.CompileMenuItem_Click);
            // 
            // CompileAndRunMenuItem
            // 
            this.CompileAndRunMenuItem.Name = "CompileAndRunMenuItem";
            this.CompileAndRunMenuItem.Size = new System.Drawing.Size(166, 22);
            this.CompileAndRunMenuItem.Text = "Compile and Run";
            this.CompileAndRunMenuItem.Click += new System.EventHandler(this.CompileAndRunMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(163, 6);
            // 
            // ProjectSettingsMenuItem
            // 
            this.ProjectSettingsMenuItem.Name = "ProjectSettingsMenuItem";
            this.ProjectSettingsMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ProjectSettingsMenuItem.Text = "Project Settings...";
            this.ProjectSettingsMenuItem.Click += new System.EventHandler(this.ProjectSettingsMenuItem_Click);
            // 
            // BookmarksMenuItem
            // 
            this.BookmarksMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBookmarkMenuItem,
            this.ListBookmarksMenuItem});
            this.BookmarksMenuItem.Name = "BookmarksMenuItem";
            this.BookmarksMenuItem.Size = new System.Drawing.Size(78, 20);
            this.BookmarksMenuItem.Text = "Bookmarks";
            // 
            // AddBookmarkMenuItem
            // 
            this.AddBookmarkMenuItem.Enabled = false;
            this.AddBookmarkMenuItem.Name = "AddBookmarkMenuItem";
            this.AddBookmarkMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.AddBookmarkMenuItem.Size = new System.Drawing.Size(196, 22);
            this.AddBookmarkMenuItem.Text = "Add Bookmark";
            this.AddBookmarkMenuItem.Click += new System.EventHandler(this.AddBookmarkMenuItem_Click);
            // 
            // ListBookmarksMenuItem
            // 
            this.ListBookmarksMenuItem.Name = "ListBookmarksMenuItem";
            this.ListBookmarksMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.ListBookmarksMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ListBookmarksMenuItem.Text = "List Bookmarks";
            this.ListBookmarksMenuItem.Click += new System.EventHandler(this.ListBookmarksMenuItem_Click);
            // 
            // ToolsMenuItem
            // 
            this.ToolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mergeFilesToolStripMenuItem});
            this.ToolsMenuItem.Name = "ToolsMenuItem";
            this.ToolsMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ToolsMenuItem.Text = "Tools";
            // 
            // mergeFilesToolStripMenuItem
            // 
            this.mergeFilesToolStripMenuItem.Name = "mergeFilesToolStripMenuItem";
            this.mergeFilesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.mergeFilesToolStripMenuItem.Text = "Merge Files";
            this.mergeFilesToolStripMenuItem.Click += new System.EventHandler(this.MergeFilesToolStripMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpMenuItem.Text = "Help";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AboutMenuItem.Text = "About";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripButton,
            this.SaveToolStripButton,
            this.toolStripSeparator1,
            this.SearchToolStripButton,
            this.GoToToolStripButton,
            this.toolStripSeparator2,
            this.CompileToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(10, 34);
            this.MainToolStrip.Margin = new System.Windows.Forms.Padding(10);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.MainToolStrip.Size = new System.Drawing.Size(664, 25);
            this.MainToolStrip.TabIndex = 5;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // OpenToolStripButton
            // 
            this.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolStripButton.Image = global::TranslaTale.Properties.Resources.OpenIcon;
            this.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripButton.Name = "OpenToolStripButton";
            this.OpenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.OpenToolStripButton.Text = "Open File";
            this.OpenToolStripButton.ToolTipText = "Open...";
            this.OpenToolStripButton.Click += new System.EventHandler(this.OpenToolStripButton_Click);
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStripButton.Image = global::TranslaTale.Properties.Resources.SaveIcon;
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SaveToolStripButton.Text = "Save File";
            this.SaveToolStripButton.ToolTipText = "Save...";
            this.SaveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // SearchToolStripButton
            // 
            this.SearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchToolStripButton.Image = global::TranslaTale.Properties.Resources.SearchIcon;
            this.SearchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchToolStripButton.Name = "SearchToolStripButton";
            this.SearchToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SearchToolStripButton.Text = "Search & Replace";
            this.SearchToolStripButton.ToolTipText = "Search and Replace";
            this.SearchToolStripButton.Click += new System.EventHandler(this.SearchToolStripButton_Click);
            // 
            // GoToToolStripButton
            // 
            this.GoToToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GoToToolStripButton.Image = global::TranslaTale.Properties.Resources.StepIcon;
            this.GoToToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoToToolStripButton.Name = "GoToToolStripButton";
            this.GoToToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.GoToToolStripButton.Text = "Go to Line...";
            this.GoToToolStripButton.Click += new System.EventHandler(this.GoToToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // CompileToolStripButton
            // 
            this.CompileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CompileToolStripButton.Image = global::TranslaTale.Properties.Resources.PlayIcon;
            this.CompileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CompileToolStripButton.Name = "CompileToolStripButton";
            this.CompileToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CompileToolStripButton.Text = "toolStripButton1";
            this.CompileToolStripButton.ToolTipText = "Compile and Run";
            this.CompileToolStripButton.Click += new System.EventHandler(this.CompileToolStripButton_Click);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.AllowMerge = false;
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TranslatedStatusLabel,
            this.UntranslatedStatusLabel,
            this.TotalStatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(10, 643);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(664, 24);
            this.MainStatusStrip.SizingGrip = false;
            this.MainStatusStrip.TabIndex = 6;
            // 
            // TranslatedStatusLabel
            // 
            this.TranslatedStatusLabel.AutoSize = false;
            this.TranslatedStatusLabel.BackColor = System.Drawing.Color.LightGreen;
            this.TranslatedStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.TranslatedStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.TranslatedStatusLabel.Name = "TranslatedStatusLabel";
            this.TranslatedStatusLabel.Size = new System.Drawing.Size(50, 19);
            this.TranslatedStatusLabel.Text = "0";
            this.TranslatedStatusLabel.Click += new System.EventHandler(this.TranslatedStatusLabel_Click);
            // 
            // UntranslatedStatusLabel
            // 
            this.UntranslatedStatusLabel.AutoSize = false;
            this.UntranslatedStatusLabel.BackColor = System.Drawing.Color.LightSalmon;
            this.UntranslatedStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.UntranslatedStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.UntranslatedStatusLabel.Name = "UntranslatedStatusLabel";
            this.UntranslatedStatusLabel.Size = new System.Drawing.Size(50, 19);
            this.UntranslatedStatusLabel.Text = "0";
            this.UntranslatedStatusLabel.Click += new System.EventHandler(this.UntranslatedStatusLabel_Click);
            // 
            // TotalStatusLabel
            // 
            this.TotalStatusLabel.AutoSize = false;
            this.TotalStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TotalStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.TotalStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.TotalStatusLabel.Name = "TotalStatusLabel";
            this.TotalStatusLabel.Size = new System.Drawing.Size(50, 19);
            this.TotalStatusLabel.Text = "0";
            this.TotalStatusLabel.Click += new System.EventHandler(this.TotalStatusLabel_Click);
            // 
            // MainTextBox
            // 
            this.MainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MainTextBox.Location = new System.Drawing.Point(3, 362);
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.Size = new System.Drawing.Size(652, 23);
            this.MainTextBox.TabIndex = 5;
            this.MainTextBox.TextChanged += new System.EventHandler(this.MainTextBox_TextChanged);
            this.MainTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainTextBox_KeyDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 677);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.MainTableLayout);
            this.Controls.Add(this.MainMenuItemStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenuItemStrip;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TranslaTale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.MainTableLayout.ResumeLayout(false);
            this.MainTableLayout.PerformLayout();
            this.TextPreviewPanel.ResumeLayout(false);
            this.TextPreviewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSpriteFontBox)).EndInit();
            this.MainMenuItemStrip.ResumeLayout(false);
            this.MainMenuItemStrip.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.ListView MainListView;
        private System.Windows.Forms.ColumnHeader LineNumberColumn;
        private System.Windows.Forms.ColumnHeader BaseTextColumn;
        private System.Windows.Forms.ColumnHeader TranslatedTextColumn;
        private System.Windows.Forms.MenuStrip MainMenuItemStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton OpenToolStripButton;
        private System.Windows.Forms.ToolStripButton SaveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProjectSettingsMenuItem;
        private System.Windows.Forms.ToolStripButton SearchToolStripButton;
        private System.Windows.Forms.ToolStripButton GoToToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GoToMenuItem;
        private System.Windows.Forms.Panel TextPreviewPanel;
        private System.Windows.Forms.ComboBox FontComboBox;
        private System.Windows.Forms.RadioButton FaceRadioButton;
        private System.Windows.Forms.RadioButton NoFaceRadioButton;
        private UTSpriteFontBox.SpriteFontBox MainSpriteFontBox;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel TranslatedStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel UntranslatedStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel TotalStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem BookmarksMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddBookmarkMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListBookmarksMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton CompileToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem CompileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CompileAndRunMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeFilesToolStripMenuItem;
        private System.Windows.Forms.TextBox MainTextBox;
    }
}