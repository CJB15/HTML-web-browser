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
    public partial class HistoryListForm : Form
    {
        List<historyEntry> historyList;
        public String selectedUrl { get; set; }
        public HistoryListForm(List<historyEntry> HistoryList)
        {
            InitializeComponent();
            historyList = HistoryList;

            historyListBox.DisplayMember = "historyText";
            historyListBox.DataSource = historyList;

            if (historyListBox.Items.Count != 0)
            {
                openUrlBtn.Enabled = true;
                clearHistoryBtn.Enabled = true;
            }
        }

        private void clearHistoryBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void openUrlBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void historyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUrl = (historyListBox.SelectedItem as historyEntry).historyUrl;
        }

        private void historyListBox_KeyDown(object sender, KeyEventArgs e)
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
