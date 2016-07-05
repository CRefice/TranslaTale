namespace TranslaTale
{
    partial class BookmarksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookmarksForm));
            this.BookmarkListView = new System.Windows.Forms.ListView();
            this.LineColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TagColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.JumpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookmarkListView
            // 
            this.BookmarkListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookmarkListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LineColumn,
            this.TagColumn});
            this.BookmarkListView.FullRowSelect = true;
            this.BookmarkListView.Location = new System.Drawing.Point(12, 12);
            this.BookmarkListView.Name = "BookmarkListView";
            this.BookmarkListView.ShowGroups = false;
            this.BookmarkListView.Size = new System.Drawing.Size(315, 174);
            this.BookmarkListView.TabIndex = 0;
            this.BookmarkListView.UseCompatibleStateImageBehavior = false;
            this.BookmarkListView.View = System.Windows.Forms.View.Details;
            this.BookmarkListView.SizeChanged += new System.EventHandler(this.BookmarkListView_SizeChanged);
            this.BookmarkListView.DoubleClick += new System.EventHandler(this.BookmarkListView_DoubleClick);
            // 
            // LineColumn
            // 
            this.LineColumn.Text = "Line";
            this.LineColumn.Width = 70;
            // 
            // TagColumn
            // 
            this.TagColumn.Text = "Tag";
            this.TagColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TagColumn.Width = 230;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExitButton.Location = new System.Drawing.Point(12, 196);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Location = new System.Drawing.Point(93, 196);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // JumpButton
            // 
            this.JumpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.JumpButton.Location = new System.Drawing.Point(252, 196);
            this.JumpButton.Name = "JumpButton";
            this.JumpButton.Size = new System.Drawing.Size(75, 23);
            this.JumpButton.TabIndex = 3;
            this.JumpButton.Text = "Jump";
            this.JumpButton.UseVisualStyleBackColor = true;
            this.JumpButton.Click += new System.EventHandler(this.JumpButton_Click);
            // 
            // BookmarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 231);
            this.Controls.Add(this.JumpButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BookmarkListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookmarksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bookmarks";
            this.Load += new System.EventHandler(this.BookmarksForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView BookmarkListView;
        private System.Windows.Forms.ColumnHeader LineColumn;
        private System.Windows.Forms.ColumnHeader TagColumn;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button JumpButton;
    }
}