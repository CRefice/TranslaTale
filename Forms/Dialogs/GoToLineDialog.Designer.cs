namespace TranslaTale
{
    partial class GoToLineDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoToLineDialog));
            this.ExitButton = new System.Windows.Forms.Button();
            this.JumpButton = new System.Windows.Forms.Button();
            this.GoToTextBox = new System.Windows.Forms.TextBox();
            this.LineNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 58);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // JumpButton
            // 
            this.JumpButton.Location = new System.Drawing.Point(148, 58);
            this.JumpButton.Name = "JumpButton";
            this.JumpButton.Size = new System.Drawing.Size(75, 23);
            this.JumpButton.TabIndex = 1;
            this.JumpButton.Text = "Jump";
            this.JumpButton.UseVisualStyleBackColor = true;
            this.JumpButton.Click += new System.EventHandler(this.JumpButton_Click);
            // 
            // GoToTextBox
            // 
            this.GoToTextBox.Location = new System.Drawing.Point(12, 32);
            this.GoToTextBox.Name = "GoToTextBox";
            this.GoToTextBox.Size = new System.Drawing.Size(211, 20);
            this.GoToTextBox.TabIndex = 0;
            this.GoToTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToTextBox_KeyDown);
            // 
            // LineNumberLabel
            // 
            this.LineNumberLabel.AutoSize = true;
            this.LineNumberLabel.Location = new System.Drawing.Point(12, 16);
            this.LineNumberLabel.Name = "LineNumberLabel";
            this.LineNumberLabel.Size = new System.Drawing.Size(70, 13);
            this.LineNumberLabel.TabIndex = 3;
            this.LineNumberLabel.Text = "Line Number:";
            // 
            // GoToLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 93);
            this.Controls.Add(this.LineNumberLabel);
            this.Controls.Add(this.GoToTextBox);
            this.Controls.Add(this.JumpButton);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GoToLineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jump to...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button JumpButton;
        private System.Windows.Forms.TextBox GoToTextBox;
        private System.Windows.Forms.Label LineNumberLabel;
    }
}