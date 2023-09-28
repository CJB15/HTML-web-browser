using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser_cjb15_
{
    public partial class FavListForm : Form
    {
        List<favEntry> favList;
        public String selectedUrl { get; set; }
        public FavListForm(List<favEntry> FavList)
        {
            InitializeComponent();
            favList = FavList;

            favListBox.DisplayMember = "favName";
            favListBox.DataSource = favList;

            if (favListBox.Items.Count != 0)
            {
                openUrlBtn.Enabled = true;
                editFavBtn.Enabled = true;
            }
        }

        private void favListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUrl = (favListBox.SelectedItem as favEntry).favUrl;
        }

        private void openUrlBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void editFavBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void favListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && openUrlBtn.Enabled == true)
            {
                openUrlBtn_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                closeBtn_Click(sender, e);
            }
        }
    }
}
