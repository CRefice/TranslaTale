using System;
using System.Linq;
using System.Windows.Forms;
using System.Media;
using System.Text.RegularExpressions;

using TranslaTale.Settings;
using TranslaTale.Text;
using System.Collections.Generic;

namespace TranslaTale
{
    public partial class SearchForm : Form
    {
        private MainForm ParentMainForm;
        private List<Line> ResultList;
        private bool DirtyFlag = false;

        public SearchForm(MainForm parentForm)
        {
            InitializeComponent();
            ParentMainForm = parentForm;
            ResultList = new List<Line>();
        }

        private void Search(string searchTerm)
        {
            ResultListView.Items.Clear();

            var SearchIn = BaseTextRadioButton.Checked ? SearchMode.Base : TranslationRadioButton.Checked ? SearchMode.Translation : SearchMode.Both;
            var CaseMode = CaseSensitiveCheckBox.Checked ? RegexOptions.None : RegexOptions.IgnoreCase;
            var UseRegex = UseRegexBox.Checked;

            var FoundLines = from line in Lines.LineArray
                             where line.Contains(searchTerm, SearchIn, CaseMode, !UseRegex)
                             select line;

            ResultListView.BeginUpdate();
            foreach (var line in FoundLines)
            {
                ResultList.Add(line);
                ResultListView.Items.Add(line.ToListViewItem(true));
            }
            ResultListView.EndUpdate();

            if (ResultListView.Items.Count < 1)
                MessageBox.Show("No matches found!", "TranslaTale", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                SystemSounds.Asterisk.Play();
        }
        private void Replace(string searchTerm, string replaceTerm)
        {
            if (!TranslationRadioButton.Checked)
            {
                MessageBox.Show("Can only replace in translation file!", "TranslaTale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TranslationRadioButton.Checked = true;
                return;
            }

            int ReplacedCount = 0;
            var CaseMode = CaseSensitiveCheckBox.Checked ? RegexOptions.None : RegexOptions.IgnoreCase;
            var UseRegex = UseRegexBox.Checked;

            var FoundLines = from line in Lines.LineArray
                             where line.Contains(searchTerm, SearchMode.Translation, CaseMode, !UseRegex)
                             select line;

            foreach (var line in FoundLines)
            {
                line.TranslatedString = Regex.Replace(line.TranslatedString, searchTerm, replaceTerm, CaseMode);
                ReplacedCount++;
            }

            if (ReplacedCount < 1)
                MessageBox.Show("No matches found!", "TranslaTale", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Replaced " + ReplacedCount + " matches.", "TranslaTale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DirtyFlag = true;
                Search(replaceTerm);
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            SearchTextBox.Text = SearchSettings.LastSearchTerm;
            ReplaceTextBox.Text = SearchSettings.LastReplaceTerm;
            CaseSensitiveCheckBox.Checked = SearchSettings.CaseSensitive;
            UseRegexBox.Checked = SearchSettings.RegexSearch;
        }
        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DirtyFlag)
            {
                switch (MessageBox.Show("Your translation lines have changed!\nWould you like to reload your project?",
                    "TranslaTale", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        ParentMainForm.LoadItems();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        return;
                }
            }

            SearchSettings.LastSearchTerm = SearchTextBox.Text;
            SearchSettings.LastReplaceTerm = ReplaceTextBox.Text;
            SearchSettings.CaseSensitive = CaseSensitiveCheckBox.Checked;
            SearchSettings.RegexSearch = UseRegexBox.Checked;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search(SearchTextBox.Text);
        }
        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            Replace(SearchTextBox.Text, ReplaceTextBox.Text);
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search(SearchTextBox.Text);
        }

        private void ResultListView_SizeChanged(object sender, EventArgs e)
        {
            int ColumnWidth = (ResultListView.Width - ResultListView.Columns[0].Width - 25) / 2;
            ResultListView.Columns[1].Width = ColumnWidth;
            ResultListView.Columns[2].Width = ColumnWidth;
        }

        private void ResultListView_Click(object sender, EventArgs e)
        {
            if (ResultListView.SelectedIndices.Count <= 0) return;
            ParentMainForm.SelectItem(ResultList[ResultListView.SelectedIndices[0]].Number);
        }
    }
}