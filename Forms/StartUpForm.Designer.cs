namespace TranslaTale
{
    partial class StartUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUpForm));
            this.StartUpPicture = new System.Windows.Forms.PictureBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.NewProjectButton = new System.Windows.Forms.Button();
            this.ProjectListBox = new System.Windows.Forms.ListBox();
            this.RecentProjectGroup = new System.Windows.Forms.GroupBox();
            this.RecentProjectsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StartUpPicture)).BeginInit();
            this.RecentProjectGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartUpPicture
            // 
            this.StartUpPicture.BackgroundImage = global::TranslaTale.Properties.Resources.AboutSplash;
            this.StartUpPicture.Location = new System.Drawing.Point(0, 0);
            this.StartUpPicture.Name = "StartUpPicture";
            this.StartUpPicture.Size = new System.Drawing.Size(124, 257);
            this.StartUpPicture.TabIndex = 0;
            this.StartUpPicture.TabStop = false;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OpenFileButton.Location = new System.Drawing.Point(139, 25);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(206, 45);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // NewProjectButton
            // 
            this.NewProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NewProjectButton.Location = new System.Drawing.Point(139, 85);
            this.NewProjectButton.Name = "NewProjectButton";
            this.NewProjectButton.Size = new System.Drawing.Size(206, 45);
            this.NewProjectButton.TabIndex = 2;
            this.NewProjectButton.Text = "New Project";
            this.NewProjectButton.UseVisualStyleBackColor = true;
            this.NewProjectButton.Click += new System.EventHandler(this.NewProjectButton_Click);
            // 
            // ProjectListBox
            // 
            this.ProjectListBox.FormattingEnabled = true;
            this.ProjectListBox.Location = new System.Drawing.Point(9, 16);
            this.ProjectListBox.Name = "ProjectListBox";
            this.ProjectListBox.Size = new System.Drawing.Size(206, 69);
            this.ProjectListBox.Sorted = true;
            this.ProjectListBox.TabIndex = 3;
            this.ProjectListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProjectListBox_KeyDown);
            this.ProjectListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ProjectListBox_MouseDoubleClick);
            // 
            // RecentProjectGroup
            // 
            this.RecentProjectGroup.Controls.Add(this.RecentProjectsLabel);
            this.RecentProjectGroup.Controls.Add(this.ProjectListBox);
            this.RecentProjectGroup.Location = new System.Drawing.Point(130, 149);
            this.RecentProjectGroup.Name = "RecentProjectGroup";
            this.RecentProjectGroup.Size = new System.Drawing.Size(225, 91);
            this.RecentProjectGroup.TabIndex = 4;
            this.RecentProjectGroup.TabStop = false;
            // 
            // RecentProjectsLabel
            // 
            this.RecentProjectsLabel.AutoSize = true;
            this.RecentProjectsLabel.Location = new System.Drawing.Point(68, 0);
            this.RecentProjectsLabel.Name = "RecentProjectsLabel";
            this.RecentProjectsLabel.Size = new System.Drawing.Size(83, 13);
            this.RecentProjectsLabel.TabIndex = 4;
            this.RecentProjectsLabel.Text = "Recent Projects";
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 253);
            this.Controls.Add(this.RecentProjectGroup);
            this.Controls.Add(this.NewProjectButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.StartUpPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartUpForm";
            this.Text = "Welcome to TranslaTale!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartUpForm_FormClosed);
            this.Load += new System.EventHandler(this.StartUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StartUpPicture)).EndInit();
            this.RecentProjectGroup.ResumeLayout(false);
            this.RecentProjectGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox StartUpPicture;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button NewProjectButton;
        private System.Windows.Forms.ListBox ProjectListBox;
        private System.Windows.Forms.GroupBox RecentProjectGroup;
        private System.Windows.Forms.Label RecentProjectsLabel;
    }
}