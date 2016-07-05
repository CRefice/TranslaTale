namespace TranslaTale
{
    partial class ProjectSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectSettingsForm));
            this.ProjectPictureBox = new System.Windows.Forms.PictureBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.BaseFileTextBox = new System.Windows.Forms.TextBox();
            this.TransFileTextBox = new System.Windows.Forms.TextBox();
            this.ImagePathTextBox = new System.Windows.Forms.TextBox();
            this.CleanGameTextBox = new System.Windows.Forms.TextBox();
            this.CompileGameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BaseFileLabel = new System.Windows.Forms.Label();
            this.TransFileLabel = new System.Windows.Forms.Label();
            this.ImagePathLabel = new System.Windows.Forms.Label();
            this.CleanGameLabel = new System.Windows.Forms.Label();
            this.CompileGameLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CompileGameButton = new System.Windows.Forms.Button();
            this.BaseFileButton = new System.Windows.Forms.Button();
            this.CleanGameButton = new System.Windows.Forms.Button();
            this.ImagePathButton = new System.Windows.Forms.Button();
            this.TransFileButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BrowsePathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.BrowseFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectPictureBox)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjectPictureBox
            // 
            this.ProjectPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProjectPictureBox.Image = global::TranslaTale.Properties.Resources.AboutSplash2;
            this.ProjectPictureBox.InitialImage = null;
            this.ProjectPictureBox.Location = new System.Drawing.Point(0, 0);
            this.ProjectPictureBox.Name = "ProjectPictureBox";
            this.ProjectPictureBox.Size = new System.Drawing.Size(100, 249);
            this.ProjectPictureBox.TabIndex = 0;
            this.ProjectPictureBox.TabStop = false;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(41, 41);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(336, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // BaseFileTextBox
            // 
            this.BaseFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseFileTextBox.Location = new System.Drawing.Point(110, 88);
            this.BaseFileTextBox.Name = "BaseFileTextBox";
            this.BaseFileTextBox.Size = new System.Drawing.Size(256, 20);
            this.BaseFileTextBox.TabIndex = 2;
            // 
            // TransFileTextBox
            // 
            this.TransFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TransFileTextBox.Location = new System.Drawing.Point(110, 117);
            this.TransFileTextBox.Name = "TransFileTextBox";
            this.TransFileTextBox.Size = new System.Drawing.Size(256, 20);
            this.TransFileTextBox.TabIndex = 3;
            // 
            // ImagePathTextBox
            // 
            this.ImagePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePathTextBox.Location = new System.Drawing.Point(110, 145);
            this.ImagePathTextBox.Name = "ImagePathTextBox";
            this.ImagePathTextBox.Size = new System.Drawing.Size(256, 20);
            this.ImagePathTextBox.TabIndex = 4;
            // 
            // CleanGameTextBox
            // 
            this.CleanGameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CleanGameTextBox.Location = new System.Drawing.Point(110, 174);
            this.CleanGameTextBox.Name = "CleanGameTextBox";
            this.CleanGameTextBox.Size = new System.Drawing.Size(256, 20);
            this.CleanGameTextBox.TabIndex = 5;
            // 
            // CompileGameTextBox
            // 
            this.CompileGameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CompileGameTextBox.Location = new System.Drawing.Point(110, 202);
            this.CompileGameTextBox.Name = "CompileGameTextBox";
            this.CompileGameTextBox.Size = new System.Drawing.Size(256, 20);
            this.CompileGameTextBox.TabIndex = 6;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(38, 25);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name:";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BaseFileLabel
            // 
            this.BaseFileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseFileLabel.AutoSize = true;
            this.BaseFileLabel.Location = new System.Drawing.Point(54, 91);
            this.BaseFileLabel.Name = "BaseFileLabel";
            this.BaseFileLabel.Size = new System.Drawing.Size(50, 13);
            this.BaseFileLabel.TabIndex = 8;
            this.BaseFileLabel.Text = "Base file:";
            this.BaseFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TransFileLabel
            // 
            this.TransFileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TransFileLabel.AutoSize = true;
            this.TransFileLabel.Location = new System.Drawing.Point(26, 120);
            this.TransFileLabel.Name = "TransFileLabel";
            this.TransFileLabel.Size = new System.Drawing.Size(78, 13);
            this.TransFileLabel.TabIndex = 9;
            this.TransFileLabel.Text = "Translation file:";
            this.TransFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ImagePathLabel
            // 
            this.ImagePathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePathLabel.AutoSize = true;
            this.ImagePathLabel.Location = new System.Drawing.Point(41, 148);
            this.ImagePathLabel.Name = "ImagePathLabel";
            this.ImagePathLabel.Size = new System.Drawing.Size(63, 13);
            this.ImagePathLabel.TabIndex = 10;
            this.ImagePathLabel.Text = "Image path:";
            this.ImagePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CleanGameLabel
            // 
            this.CleanGameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CleanGameLabel.AutoSize = true;
            this.CleanGameLabel.Location = new System.Drawing.Point(14, 177);
            this.CleanGameLabel.Name = "CleanGameLabel";
            this.CleanGameLabel.Size = new System.Drawing.Size(90, 13);
            this.CleanGameLabel.TabIndex = 11;
            this.CleanGameLabel.Text = "Clean game path:";
            this.CleanGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CompileGameLabel
            // 
            this.CompileGameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CompileGameLabel.AutoSize = true;
            this.CompileGameLabel.Location = new System.Drawing.Point(16, 205);
            this.CompileGameLabel.Name = "CompileGameLabel";
            this.CompileGameLabel.Size = new System.Drawing.Size(88, 13);
            this.CompileGameLabel.TabIndex = 12;
            this.CompileGameLabel.Text = "Compilation path:";
            this.CompileGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainPanel.Controls.Add(this.CompileGameButton);
            this.MainPanel.Controls.Add(this.BaseFileLabel);
            this.MainPanel.Controls.Add(this.NameTextBox);
            this.MainPanel.Controls.Add(this.TransFileLabel);
            this.MainPanel.Controls.Add(this.NameLabel);
            this.MainPanel.Controls.Add(this.BaseFileTextBox);
            this.MainPanel.Controls.Add(this.ImagePathTextBox);
            this.MainPanel.Controls.Add(this.CleanGameLabel);
            this.MainPanel.Controls.Add(this.BaseFileButton);
            this.MainPanel.Controls.Add(this.TransFileTextBox);
            this.MainPanel.Controls.Add(this.CleanGameButton);
            this.MainPanel.Controls.Add(this.ImagePathButton);
            this.MainPanel.Controls.Add(this.CompileGameLabel);
            this.MainPanel.Controls.Add(this.TransFileButton);
            this.MainPanel.Controls.Add(this.CleanGameTextBox);
            this.MainPanel.Controls.Add(this.ImagePathLabel);
            this.MainPanel.Controls.Add(this.CompileGameTextBox);
            this.MainPanel.Location = new System.Drawing.Point(97, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(411, 249);
            this.MainPanel.TabIndex = 13;
            // 
            // CompileGameButton
            // 
            this.CompileGameButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CompileGameButton.Location = new System.Drawing.Point(372, 202);
            this.CompileGameButton.Name = "CompileGameButton";
            this.CompileGameButton.Size = new System.Drawing.Size(25, 20);
            this.CompileGameButton.TabIndex = 21;
            this.CompileGameButton.Text = "...";
            this.CompileGameButton.UseVisualStyleBackColor = true;
            this.CompileGameButton.Click += new System.EventHandler(this.CompileGameButton_Click);
            // 
            // BaseFileButton
            // 
            this.BaseFileButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BaseFileButton.Location = new System.Drawing.Point(372, 88);
            this.BaseFileButton.Name = "BaseFileButton";
            this.BaseFileButton.Size = new System.Drawing.Size(25, 20);
            this.BaseFileButton.TabIndex = 17;
            this.BaseFileButton.Text = "...";
            this.BaseFileButton.UseVisualStyleBackColor = true;
            this.BaseFileButton.Click += new System.EventHandler(this.BaseFileButton_Click);
            // 
            // CleanGameButton
            // 
            this.CleanGameButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CleanGameButton.Location = new System.Drawing.Point(372, 174);
            this.CleanGameButton.Name = "CleanGameButton";
            this.CleanGameButton.Size = new System.Drawing.Size(25, 20);
            this.CleanGameButton.TabIndex = 20;
            this.CleanGameButton.Text = "...";
            this.CleanGameButton.UseVisualStyleBackColor = true;
            this.CleanGameButton.Click += new System.EventHandler(this.CleanGameButton_Click);
            // 
            // ImagePathButton
            // 
            this.ImagePathButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ImagePathButton.Location = new System.Drawing.Point(372, 145);
            this.ImagePathButton.Name = "ImagePathButton";
            this.ImagePathButton.Size = new System.Drawing.Size(25, 20);
            this.ImagePathButton.TabIndex = 19;
            this.ImagePathButton.Text = "...";
            this.ImagePathButton.UseVisualStyleBackColor = true;
            this.ImagePathButton.Click += new System.EventHandler(this.ImagePathButton_Click);
            // 
            // TransFileButton
            // 
            this.TransFileButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TransFileButton.Location = new System.Drawing.Point(372, 117);
            this.TransFileButton.Name = "TransFileButton";
            this.TransFileButton.Size = new System.Drawing.Size(25, 20);
            this.TransFileButton.TabIndex = 18;
            this.TransFileButton.Text = "...";
            this.TransFileButton.UseVisualStyleBackColor = true;
            this.TransFileButton.Click += new System.EventHandler(this.TransFileButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExitButton.Location = new System.Drawing.Point(12, 255);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(421, 255);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BrowseFileDialog
            // 
            this.BrowseFileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // ProjectSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 284);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ProjectPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1080, 323);
            this.MinimumSize = new System.Drawing.Size(524, 323);
            this.Name = "ProjectSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Project Settings";
            this.Load += new System.EventHandler(this.ProjectSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectPictureBox)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ProjectPictureBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox BaseFileTextBox;
        private System.Windows.Forms.TextBox TransFileTextBox;
        private System.Windows.Forms.TextBox ImagePathTextBox;
        private System.Windows.Forms.TextBox CleanGameTextBox;
        private System.Windows.Forms.TextBox CompileGameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label BaseFileLabel;
        private System.Windows.Forms.Label TransFileLabel;
        private System.Windows.Forms.Label ImagePathLabel;
        private System.Windows.Forms.Label CleanGameLabel;
        private System.Windows.Forms.Label CompileGameLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button CompileGameButton;
        private System.Windows.Forms.Button CleanGameButton;
        private System.Windows.Forms.Button ImagePathButton;
        private System.Windows.Forms.Button TransFileButton;
        private System.Windows.Forms.Button BaseFileButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.FolderBrowserDialog BrowsePathDialog;
        private System.Windows.Forms.OpenFileDialog BrowseFileDialog;
    }
}