namespace TranslaTale
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.ReplaceTextBox = new System.Windows.Forms.TextBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.ReplaceLabel = new System.Windows.Forms.Label();
            this.CaseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.ResultsGroup = new System.Windows.Forms.GroupBox();
            this.ResultListView = new System.Windows.Forms.ListView();
            this.LineColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BaseTextColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TranslationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchButton = new System.Windows.Forms.Button();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.BaseTextRadioButton = new System.Windows.Forms.RadioButton();
            this.BothRadioButton = new System.Windows.Forms.RadioButton();
            this.TranslationRadioButton = new System.Windows.Forms.RadioButton();
            this.UseRegexBox = new System.Windows.Forms.CheckBox();
            this.ResultsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReplaceTextBox
            // 
            this.ReplaceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReplaceTextBox.Location = new System.Drawing.Point(110, 52);
            this.ReplaceTextBox.Name = "ReplaceTextBox";
            this.ReplaceTextBox.Size = new System.Drawing.Size(286, 20);
            this.ReplaceTextBox.TabIndex = 1;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Location = new System.Drawing.Point(110, 16);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(286, 20);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(33, 19);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(71, 13);
            this.SearchLabel.TabIndex = 9;
            this.SearchLabel.Text = "Search Term:";
            // 
            // ReplaceLabel
            // 
            this.ReplaceLabel.AutoSize = true;
            this.ReplaceLabel.Location = new System.Drawing.Point(29, 55);
            this.ReplaceLabel.Name = "ReplaceLabel";
            this.ReplaceLabel.Size = new System.Drawing.Size(75, 13);
            this.ReplaceLabel.TabIndex = 10;
            this.ReplaceLabel.Text = "Replace With:";
            // 
            // CaseSensitiveCheckBox
            // 
            this.CaseSensitiveCheckBox.AutoSize = true;
            this.CaseSensitiveCheckBox.Location = new System.Drawing.Point(18, 119);
            this.CaseSensitiveCheckBox.Name = "CaseSensitiveCheckBox";
            this.CaseSensitiveCheckBox.Size = new System.Drawing.Size(96, 17);
            this.CaseSensitiveCheckBox.TabIndex = 5;
            this.CaseSensitiveCheckBox.Text = "Case Sensitive";
            this.CaseSensitiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResultsGroup
            // 
            this.ResultsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsGroup.Controls.Add(this.ResultListView);
            this.ResultsGroup.Location = new System.Drawing.Point(12, 148);
            this.ResultsGroup.Name = "ResultsGroup";
            this.ResultsGroup.Size = new System.Drawing.Size(402, 210);
            this.ResultsGroup.TabIndex = 8;
            this.ResultsGroup.TabStop = false;
            this.ResultsGroup.Text = "Search Results";
            // 
            // ResultListView
            // 
            this.ResultListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LineColumn,
            this.BaseTextColumn,
            this.TranslationColumn});
            this.ResultListView.FullRowSelect = true;
            this.ResultListView.Location = new System.Drawing.Point(6, 19);
            this.ResultListView.MultiSelect = false;
            this.ResultListView.Name = "ResultListView";
            this.ResultListView.Size = new System.Drawing.Size(390, 185);
            this.ResultListView.TabIndex = 0;
            this.ResultListView.UseCompatibleStateImageBehavior = false;
            this.ResultListView.View = System.Windows.Forms.View.Details;
            this.ResultListView.SizeChanged += new System.EventHandler(this.ResultListView_SizeChanged);
            this.ResultListView.Click += new System.EventHandler(this.ResultListView_Click);
            // 
            // LineColumn
            // 
            this.LineColumn.Text = "Line";
            this.LineColumn.Width = 70;
            // 
            // BaseTextColumn
            // 
            this.BaseTextColumn.Text = "Base Text";
            this.BaseTextColumn.Width = 148;
            // 
            // TranslationColumn
            // 
            this.TranslationColumn.Text = "Translated Text";
            this.TranslationColumn.Width = 147;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(321, 115);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReplaceButton.Location = new System.Drawing.Point(240, 115);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(75, 23);
            this.ReplaceButton.TabIndex = 7;
            this.ReplaceButton.Text = "Replace";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // BaseTextRadioButton
            // 
            this.BaseTextRadioButton.AutoSize = true;
            this.BaseTextRadioButton.Location = new System.Drawing.Point(18, 87);
            this.BaseTextRadioButton.Name = "BaseTextRadioButton";
            this.BaseTextRadioButton.Size = new System.Drawing.Size(73, 17);
            this.BaseTextRadioButton.TabIndex = 2;
            this.BaseTextRadioButton.Text = "Base Text";
            this.BaseTextRadioButton.UseVisualStyleBackColor = true;
            // 
            // BothRadioButton
            // 
            this.BothRadioButton.AutoSize = true;
            this.BothRadioButton.Checked = true;
            this.BothRadioButton.Location = new System.Drawing.Point(201, 87);
            this.BothRadioButton.Name = "BothRadioButton";
            this.BothRadioButton.Size = new System.Drawing.Size(47, 17);
            this.BothRadioButton.TabIndex = 4;
            this.BothRadioButton.TabStop = true;
            this.BothRadioButton.Text = "Both";
            this.BothRadioButton.UseVisualStyleBackColor = true;
            // 
            // TranslationRadioButton
            // 
            this.TranslationRadioButton.AutoSize = true;
            this.TranslationRadioButton.Location = new System.Drawing.Point(96, 87);
            this.TranslationRadioButton.Name = "TranslationRadioButton";
            this.TranslationRadioButton.Size = new System.Drawing.Size(99, 17);
            this.TranslationRadioButton.TabIndex = 3;
            this.TranslationRadioButton.Text = "Translated Text";
            this.TranslationRadioButton.UseVisualStyleBackColor = true;
            // 
            // UseRegexBox
            // 
            this.UseRegexBox.AutoSize = true;
            this.UseRegexBox.Location = new System.Drawing.Point(120, 119);
            this.UseRegexBox.Name = "UseRegexBox";
            this.UseRegexBox.Size = new System.Drawing.Size(79, 17);
            this.UseRegexBox.TabIndex = 11;
            this.UseRegexBox.Text = "Use Regex";
            this.UseRegexBox.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 370);
            this.Controls.Add(this.UseRegexBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.TranslationRadioButton);
            this.Controls.Add(this.BothRadioButton);
            this.Controls.Add(this.BaseTextRadioButton);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ResultsGroup);
            this.Controls.Add(this.CaseSensitiveCheckBox);
            this.Controls.Add(this.ReplaceLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ReplaceTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search and Replace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResultsGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReplaceTextBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label ReplaceLabel;
        private System.Windows.Forms.CheckBox CaseSensitiveCheckBox;
        private System.Windows.Forms.GroupBox ResultsGroup;
        private System.Windows.Forms.ListView ResultListView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ReplaceButton;
        private System.Windows.Forms.ColumnHeader LineColumn;
        private System.Windows.Forms.ColumnHeader BaseTextColumn;
        private System.Windows.Forms.ColumnHeader TranslationColumn;
        private System.Windows.Forms.RadioButton BaseTextRadioButton;
        private System.Windows.Forms.RadioButton BothRadioButton;
        private System.Windows.Forms.RadioButton TranslationRadioButton;
        private System.Windows.Forms.CheckBox UseRegexBox;
    }
}