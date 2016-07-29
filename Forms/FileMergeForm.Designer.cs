namespace TranslaTale
{
    partial class FileMergeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileMergeForm));
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.InfoLabel1 = new System.Windows.Forms.Label();
            this.TitleLabel1 = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ConflictsModePanel = new System.Windows.Forms.Panel();
            this.ConflictsFoundLabel = new System.Windows.Forms.Label();
            this.SelectManuallyButton = new System.Windows.Forms.RadioButton();
            this.AdditionalFileButton = new System.Windows.Forms.RadioButton();
            this.CurrentFileButton = new System.Windows.Forms.RadioButton();
            this.InfoLabel2 = new System.Windows.Forms.Label();
            this.TitleLabel2 = new System.Windows.Forms.Label();
            this.FinishedPanel = new System.Windows.Forms.Panel();
            this.InfoLabel3 = new System.Windows.Forms.Label();
            this.TitleLabel3 = new System.Windows.Forms.Label();
            this.SolveConflictsPanel = new System.Windows.Forms.Panel();
            this.UseTranslationButton = new System.Windows.Forms.Button();
            this.UseAdditionalButton = new System.Windows.Forms.Button();
            this.ConflictListView = new System.Windows.Forms.ListView();
            this.LineColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurrentStringColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdditionalLineColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.ConflictsModePanel.SuspendLayout();
            this.FinishedPanel.SuspendLayout();
            this.SolveConflictsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Image = global::TranslaTale.Properties.Resources.AboutSplash;
            this.MainPictureBox.Location = new System.Drawing.Point(0, 0);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(125, 249);
            this.MainPictureBox.TabIndex = 0;
            this.MainPictureBox.TabStop = false;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InfoPanel.Controls.Add(this.InfoLabel1);
            this.InfoPanel.Controls.Add(this.TitleLabel1);
            this.InfoPanel.Location = new System.Drawing.Point(122, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(263, 249);
            this.InfoPanel.TabIndex = 1;
            // 
            // InfoLabel1
            // 
            this.InfoLabel1.AutoSize = true;
            this.InfoLabel1.Location = new System.Drawing.Point(36, 94);
            this.InfoLabel1.Name = "InfoLabel1";
            this.InfoLabel1.Size = new System.Drawing.Size(200, 117);
            this.InfoLabel1.TabIndex = 1;
            this.InfoLabel1.Text = resources.GetString("InfoLabel1.Text");
            // 
            // TitleLabel1
            // 
            this.TitleLabel1.AutoSize = true;
            this.TitleLabel1.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TitleLabel1.Location = new System.Drawing.Point(59, 25);
            this.TitleLabel1.Name = "TitleLabel1";
            this.TitleLabel1.Size = new System.Drawing.Size(149, 33);
            this.TitleLabel1.TabIndex = 0;
            this.TitleLabel1.Text = "File Merging";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(295, 255);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next >";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 255);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ConflictsModePanel
            // 
            this.ConflictsModePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConflictsModePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConflictsModePanel.Controls.Add(this.ConflictsFoundLabel);
            this.ConflictsModePanel.Controls.Add(this.SelectManuallyButton);
            this.ConflictsModePanel.Controls.Add(this.AdditionalFileButton);
            this.ConflictsModePanel.Controls.Add(this.CurrentFileButton);
            this.ConflictsModePanel.Controls.Add(this.InfoLabel2);
            this.ConflictsModePanel.Controls.Add(this.TitleLabel2);
            this.ConflictsModePanel.Location = new System.Drawing.Point(122, 0);
            this.ConflictsModePanel.Name = "ConflictsModePanel";
            this.ConflictsModePanel.Size = new System.Drawing.Size(263, 249);
            this.ConflictsModePanel.TabIndex = 2;
            this.ConflictsModePanel.Visible = false;
            // 
            // ConflictsFoundLabel
            // 
            this.ConflictsFoundLabel.AutoSize = true;
            this.ConflictsFoundLabel.Location = new System.Drawing.Point(36, 81);
            this.ConflictsFoundLabel.Name = "ConflictsFoundLabel";
            this.ConflictsFoundLabel.Size = new System.Drawing.Size(143, 13);
            this.ConflictsFoundLabel.TabIndex = 5;
            this.ConflictsFoundLabel.Text = "0 Conflicts have been found.";
            // 
            // SelectManuallyButton
            // 
            this.SelectManuallyButton.AutoSize = true;
            this.SelectManuallyButton.Location = new System.Drawing.Point(39, 204);
            this.SelectManuallyButton.Name = "SelectManuallyButton";
            this.SelectManuallyButton.Size = new System.Drawing.Size(105, 17);
            this.SelectManuallyButton.TabIndex = 4;
            this.SelectManuallyButton.TabStop = true;
            this.SelectManuallyButton.Text = "Choose manually";
            this.SelectManuallyButton.UseVisualStyleBackColor = true;
            this.SelectManuallyButton.CheckedChanged += new System.EventHandler(this.SelectManuallyButton_CheckedChanged);
            // 
            // AdditionalFileButton
            // 
            this.AdditionalFileButton.AutoSize = true;
            this.AdditionalFileButton.Location = new System.Drawing.Point(39, 181);
            this.AdditionalFileButton.Name = "AdditionalFileButton";
            this.AdditionalFileButton.Size = new System.Drawing.Size(117, 17);
            this.AdditionalFileButton.TabIndex = 3;
            this.AdditionalFileButton.TabStop = true;
            this.AdditionalFileButton.Text = "Prefer additional file";
            this.AdditionalFileButton.UseVisualStyleBackColor = true;
            this.AdditionalFileButton.CheckedChanged += new System.EventHandler(this.AdditionalFileButton_CheckedChanged);
            // 
            // CurrentFileButton
            // 
            this.CurrentFileButton.AutoSize = true;
            this.CurrentFileButton.Location = new System.Drawing.Point(39, 158);
            this.CurrentFileButton.Name = "CurrentFileButton";
            this.CurrentFileButton.Size = new System.Drawing.Size(139, 17);
            this.CurrentFileButton.TabIndex = 2;
            this.CurrentFileButton.TabStop = true;
            this.CurrentFileButton.Text = "Prefer file currently open";
            this.CurrentFileButton.UseVisualStyleBackColor = true;
            this.CurrentFileButton.CheckedChanged += new System.EventHandler(this.CurrentFileButton_CheckedChanged);
            // 
            // InfoLabel2
            // 
            this.InfoLabel2.AutoSize = true;
            this.InfoLabel2.Location = new System.Drawing.Point(36, 124);
            this.InfoLabel2.Name = "InfoLabel2";
            this.InfoLabel2.Size = new System.Drawing.Size(138, 13);
            this.InfoLabel2.TabIndex = 1;
            this.InfoLabel2.Text = "Select how to resolve them:";
            // 
            // TitleLabel2
            // 
            this.TitleLabel2.AutoSize = true;
            this.TitleLabel2.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TitleLabel2.Location = new System.Drawing.Point(59, 25);
            this.TitleLabel2.Name = "TitleLabel2";
            this.TitleLabel2.Size = new System.Drawing.Size(149, 33);
            this.TitleLabel2.TabIndex = 0;
            this.TitleLabel2.Text = "File Merging";
            // 
            // FinishedPanel
            // 
            this.FinishedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FinishedPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FinishedPanel.Controls.Add(this.InfoLabel3);
            this.FinishedPanel.Controls.Add(this.TitleLabel3);
            this.FinishedPanel.Location = new System.Drawing.Point(122, 0);
            this.FinishedPanel.Name = "FinishedPanel";
            this.FinishedPanel.Size = new System.Drawing.Size(263, 249);
            this.FinishedPanel.TabIndex = 6;
            this.FinishedPanel.Visible = false;
            // 
            // InfoLabel3
            // 
            this.InfoLabel3.AutoSize = true;
            this.InfoLabel3.Location = new System.Drawing.Point(36, 111);
            this.InfoLabel3.Name = "InfoLabel3";
            this.InfoLabel3.Size = new System.Drawing.Size(179, 26);
            this.InfoLabel3.TabIndex = 5;
            this.InfoLabel3.Text = "All done! You can now save your file\r\nand close this dialog.";
            // 
            // TitleLabel3
            // 
            this.TitleLabel3.AutoSize = true;
            this.TitleLabel3.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TitleLabel3.Location = new System.Drawing.Point(59, 25);
            this.TitleLabel3.Name = "TitleLabel3";
            this.TitleLabel3.Size = new System.Drawing.Size(149, 33);
            this.TitleLabel3.TabIndex = 0;
            this.TitleLabel3.Text = "File Merging";
            // 
            // SolveConflictsPanel
            // 
            this.SolveConflictsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SolveConflictsPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SolveConflictsPanel.Controls.Add(this.UseTranslationButton);
            this.SolveConflictsPanel.Controls.Add(this.UseAdditionalButton);
            this.SolveConflictsPanel.Controls.Add(this.ConflictListView);
            this.SolveConflictsPanel.Location = new System.Drawing.Point(0, 0);
            this.SolveConflictsPanel.Name = "SolveConflictsPanel";
            this.SolveConflictsPanel.Padding = new System.Windows.Forms.Padding(10);
            this.SolveConflictsPanel.Size = new System.Drawing.Size(385, 288);
            this.SolveConflictsPanel.TabIndex = 7;
            this.SolveConflictsPanel.Visible = false;
            // 
            // UseTranslationButton
            // 
            this.UseTranslationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UseTranslationButton.Location = new System.Drawing.Point(13, 255);
            this.UseTranslationButton.Name = "UseTranslationButton";
            this.UseTranslationButton.Size = new System.Drawing.Size(112, 23);
            this.UseTranslationButton.TabIndex = 2;
            this.UseTranslationButton.Text = "< Use current line";
            this.UseTranslationButton.UseVisualStyleBackColor = true;
            this.UseTranslationButton.Click += new System.EventHandler(this.UseTranslationButton_Click);
            // 
            // UseAdditionalButton
            // 
            this.UseAdditionalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UseAdditionalButton.Location = new System.Drawing.Point(261, 255);
            this.UseAdditionalButton.Name = "UseAdditionalButton";
            this.UseAdditionalButton.Size = new System.Drawing.Size(112, 23);
            this.UseAdditionalButton.TabIndex = 1;
            this.UseAdditionalButton.Text = "Use additional line >";
            this.UseAdditionalButton.UseVisualStyleBackColor = true;
            this.UseAdditionalButton.Click += new System.EventHandler(this.UseAdditionalButton_Click);
            // 
            // ConflictListView
            // 
            this.ConflictListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConflictListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LineColumn,
            this.CurrentStringColumn,
            this.AdditionalLineColumn});
            this.ConflictListView.FullRowSelect = true;
            this.ConflictListView.GridLines = true;
            this.ConflictListView.Location = new System.Drawing.Point(13, 12);
            this.ConflictListView.Name = "ConflictListView";
            this.ConflictListView.Size = new System.Drawing.Size(360, 237);
            this.ConflictListView.TabIndex = 0;
            this.ConflictListView.UseCompatibleStateImageBehavior = false;
            this.ConflictListView.View = System.Windows.Forms.View.Details;
            this.ConflictListView.SizeChanged += new System.EventHandler(this.ConflictListView_SizeChanged);
            // 
            // LineColumn
            // 
            this.LineColumn.Text = "Line";
            this.LineColumn.Width = 70;
            // 
            // CurrentStringColumn
            // 
            this.CurrentStringColumn.Text = "Current Translation Line";
            this.CurrentStringColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CurrentStringColumn.Width = 130;
            // 
            // AdditionalLineColumn
            // 
            this.AdditionalLineColumn.Text = "Additional Translation Line";
            this.AdditionalLineColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdditionalLineColumn.Width = 130;
            // 
            // FileMergeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 285);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.MainPictureBox);
            this.Controls.Add(this.FinishedPanel);
            this.Controls.Add(this.SolveConflictsPanel);
            this.Controls.Add(this.ConflictsModePanel);
            this.Controls.Add(this.InfoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FileMergeForm";
            this.Text = "Merge translation files";
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ConflictsModePanel.ResumeLayout(false);
            this.ConflictsModePanel.PerformLayout();
            this.FinishedPanel.ResumeLayout(false);
            this.FinishedPanel.PerformLayout();
            this.SolveConflictsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label InfoLabel1;
        private System.Windows.Forms.Label TitleLabel1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel ConflictsModePanel;
        private System.Windows.Forms.Label TitleLabel2;
        private System.Windows.Forms.Label InfoLabel2;
        private System.Windows.Forms.RadioButton SelectManuallyButton;
        private System.Windows.Forms.RadioButton AdditionalFileButton;
        private System.Windows.Forms.RadioButton CurrentFileButton;
        private System.Windows.Forms.Label ConflictsFoundLabel;
        private System.Windows.Forms.Panel FinishedPanel;
        private System.Windows.Forms.Label InfoLabel3;
        private System.Windows.Forms.Label TitleLabel3;
        private System.Windows.Forms.Panel SolveConflictsPanel;
        private System.Windows.Forms.Button UseTranslationButton;
        private System.Windows.Forms.Button UseAdditionalButton;
        private System.Windows.Forms.ListView ConflictListView;
        private System.Windows.Forms.ColumnHeader LineColumn;
        private System.Windows.Forms.ColumnHeader CurrentStringColumn;
        private System.Windows.Forms.ColumnHeader AdditionalLineColumn;
    }
}