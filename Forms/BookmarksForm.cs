using System;
using System.Windows.Forms;

using TranslaTale.Bookmarks;

namespace TranslaTale
{
    public partial class BookmarksForm : Form
    {
        private MainForm ParentMainForm;
        private Bookmark[] BookmarkList = Bookmark.GetList();

        public BookmarksForm(MainForm parent)
        {
            InitializeComponent();
            ParentMainForm = parent;
        }

        private void BookmarksForm_Load(object sender, EventArgs e)
        {
            foreach (Bookmark bookmark in BookmarkList)
            {
                BookmarkListView.Items.Add(new ListViewItem(bookmark.ToString()));
            }
        }

        private void JumpButton_Click(object sender, EventArgs e)
        {
            if (BookmarkListView.SelectedIndices.Count > 0)
            {
                ParentMainForm.SelectItem(int.Parse(BookmarkListView.SelectedItems[0].SubItems[0].Text));
                Close();
            }
        }
        private void BookmarkListView_DoubleClick(object sender, EventArgs e)
        {
            JumpButton.PerformClick();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (BookmarkListView.SelectedIndices.Count > 0)
            {
                Bookmark.Remove(BookmarkListView.SelectedIndices[0]);
                BookmarkListView.Items.RemoveAt(BookmarkListView.SelectedIndices[0]);
                BookmarkListView.Focus();
            }
        }
        private void BookmarkListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (BookmarkListView.SelectedIndices.Count > 0)
            {
                if (e.KeyCode == Keys.Delete)
                    DeleteButton.PerformClick();
            }
            Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BookmarkListView_SizeChanged(object sender, EventArgs e)
        {
            int ColumnWidth = BookmarkListView.Width - BookmarkListView.Columns[0].Width - 15;
            BookmarkListView.Columns[1].Width = ColumnWidth;
        }
    }
}
