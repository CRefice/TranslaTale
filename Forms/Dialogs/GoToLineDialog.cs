using System;
using System.Windows.Forms;

namespace TranslaTale
{
    public partial class GoToLineDialog : Form
    {
        private MainForm ParentMainForm;

        public GoToLineDialog(MainForm mainForm)
        {
            InitializeComponent();
            ParentMainForm = mainForm;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JumpButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ParentMainForm.SelectItem(int.Parse(GoToTextBox.Text)))
                {
                    ParentMainForm.Focus();
                    Close();
                }
                else
                {
                    MessageBox.Show("Line not found!", "TranslaTale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex) when (ex is FormatException)
            {
                MessageBox.Show("Invalid text!", "TranslaTale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void GoToTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                JumpButton.PerformClick();
        }
    }
}
