using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TranslaTale.Text;

namespace TranslaTale
{
    public partial class FileMergeForm : Form
    {
        private enum Panel { Info, Resolve, Done }
        private Panel CurrentPanel = Panel.Info;
        private enum ConflictMode { Current, Additional, Manual }
        private ConflictMode CurrentMode;

        public string[] Buffer;
        public string[] AdditionalStrings;
        public List<Line> ConflictsList = new List<Line>();

        public FileMergeForm()
        {
            InitializeComponent();
        }

        private async Task Next()
        {
            switch (CurrentPanel)
            {
                case Panel.Info:
                    {
                        var Dialog = new OpenFileDialog()
                        {
                            Title = "Select your additional translation file...",
                            Filter = "Text files (*.txt)|*.txt"
                        };

                        if (Dialog.ShowDialog() == DialogResult.OK)
                        {
                            NextButton.Enabled = false;

                            await MergeFiles(Dialog.FileName);

                            InfoPanel.Visible = false;
                            NextButton.Enabled = true;
                            if (ConflictsList.Count > 0)
                            {
                                ConflictsModePanel.Visible = true;
                                ConflictsFoundLabel.Text = String.Format("{0} conflicts have been found.", ConflictsList.Count);
                                CurrentPanel = Panel.Resolve;
                            }
                            else
                            {
                                FinishedPanel.Visible = true;
                                NextButton.Text = "Save";
                                CurrentPanel = Panel.Done;
                            }
                        }
                    }
                    break;

                case Panel.Resolve:
                    {
                        switch (CurrentMode)
                        {
                            case ConflictMode.Current:
                                foreach (var line in ConflictsList)
                                    //The conflict line's base string is the current translation string.
                                    Buffer[line.Number] = line.BaseString;
                                break;

                            case ConflictMode.Additional:
                                foreach (var line in ConflictsList)
                                    Buffer[line.Number] = line.TranslatedString;
                                break;

                            case ConflictMode.Manual:
                                ConflictsModePanel.Visible = false;
                                SolveConflictsPanel.Visible = true;
                                SolveConflictsPanel.BringToFront();

                                FormBorderStyle = FormBorderStyle.Sizable;

                                AddConflicts();
                                return;
                        }
                        FinishUp();
                    }
                    break;

                case Panel.Done:
                    {
                        var Dialog = new SaveFileDialog()
                        {
                            Title = "Choose where to save your new translation file",
                            Filter = "Text files (*.txt)|*.txt"
                        };
                        if (Dialog.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllLines(Dialog.FileName, Buffer);
                            Close();
                        }
                    }
                    break;
            }
        }
        private async Task MergeFiles(string filePath)
        {
            AdditionalStrings = File.ReadAllLines(filePath);
            Buffer = new string[AdditionalStrings.Count()];

            await Task.Run(() =>
            {
                for (int i = 0; i < Buffer.Count(); i++)
                {
                    var CurrentLine = Lines.Get(i);

                    if (CurrentLine.IsEdited())
                    {
                        if (CurrentLine.TranslatedString == AdditionalStrings[i])
                            Buffer[i] = AdditionalStrings[i];
                        else if (CurrentLine.BaseString == AdditionalStrings[i])
                            Buffer[i] = CurrentLine.BaseString;
                        else
                            ConflictsList.Add(new Line(i, CurrentLine.TranslatedString, AdditionalStrings[i]));
                    }
                    else
                    {
                        if (CurrentLine.BaseString == AdditionalStrings[i])
                            Buffer[i] = CurrentLine.BaseString;
                        else
                            Buffer[i] = AdditionalStrings[i];
                    }
                }
            });
        }

        private void AddConflicts()
        {
            ConflictListView.Items.Clear();
            foreach (var line in ConflictsList)
            {
                ConflictListView.Items.Add(line.ToListViewItem(false));
            }
        }
        private void FinishUp()
        {
            Size = new Size(401, 324);
            FormBorderStyle = FormBorderStyle.FixedSingle;

            SolveConflictsPanel.Visible = false;
            ConflictsModePanel.Visible = false;
            FinishedPanel.Visible = true;
            NextButton.Text = "Save";
            CurrentPanel = Panel.Done;
        }

        private async void NextButton_Click(object sender, EventArgs e)
        {
            await Next();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CurrentFileButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentMode = ConflictMode.Current;
        }
        private void AdditionalFileButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentMode = ConflictMode.Additional;
        }
        private void SelectManuallyButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentMode = ConflictMode.Manual;
        }

        private void ConflictListView_SizeChanged(object sender, EventArgs e)
        {
            int ColumnWidth = (ConflictListView.Width - 100) / 2;
            ConflictListView.Columns[1].Width = ColumnWidth;
            ConflictListView.Columns[2].Width = ColumnWidth;
        }

        private void UseAdditionalButton_Click(object sender, EventArgs e)
        {
            if (ConflictListView.SelectedIndices.Count <= 0) return;

            foreach (ListViewItem item in ConflictListView.SelectedItems)
            {
                var SelectedConflict = ConflictsList[item.Index];

                Buffer[SelectedConflict.Number] = SelectedConflict.TranslatedString;
                ConflictListView.Items.Remove(item);
            }

            if (ConflictListView.Items.Count <= 0)
                FinishUp();
        }

        private void UseTranslationButton_Click(object sender, EventArgs e)
        {
            if (ConflictListView.SelectedIndices.Count <= 0) return;

            foreach (ListViewItem item in ConflictListView.SelectedItems)
            {
                var SelectedConflict = ConflictsList[item.Index];

                Buffer[SelectedConflict.Number] = SelectedConflict.BaseString;
                ConflictListView.Items.Remove(item);
            }

            if (ConflictListView.Items.Count <= 0)
                FinishUp();
        }
    }
}
