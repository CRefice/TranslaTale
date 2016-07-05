using System.Linq;
using System.Windows.Forms;

using TranslaTale.Bookmarks;

namespace TranslaTale
{
    public partial class AddBookmarkDialog : Form
    {
        private int Index;

        public AddBookmarkDialog(int index)
        {
            InitializeComponent();
            Index = index;
        }

        private void TagTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(TagTextBox.Text != "")
                {
                    new Bookmark(Index, TagTextBox.Text).Add();
                    Close();
                }
            }
        }
    }
}
