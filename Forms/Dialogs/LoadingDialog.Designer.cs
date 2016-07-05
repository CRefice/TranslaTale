namespace TranslaTale
{
    partial class LoadingDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingDialog));
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.LoadMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadingBar
            // 
            this.LoadingBar.Location = new System.Drawing.Point(12, 40);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(260, 23);
            this.LoadingBar.TabIndex = 0;
            // 
            // LoadMessageLabel
            // 
            this.LoadMessageLabel.AutoSize = true;
            this.LoadMessageLabel.Location = new System.Drawing.Point(12, 15);
            this.LoadMessageLabel.Name = "LoadMessageLabel";
            this.LoadMessageLabel.Size = new System.Drawing.Size(54, 13);
            this.LoadMessageLabel.TabIndex = 1;
            this.LoadMessageLabel.Text = "Loading...";
            // 
            // LoadingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 75);
            this.Controls.Add(this.LoadMessageLabel);
            this.Controls.Add(this.LoadingBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoadingDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar LoadingBar;
        private System.Windows.Forms.Label LoadMessageLabel;
    }
}