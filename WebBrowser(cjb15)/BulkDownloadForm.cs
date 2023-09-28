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
    public partial class BulkDownloadForm : Form
    {
        public String filelocation { get; set; }

        public BulkDownloadForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            filelocation = fileLocationTextBox.Text;
            this.Close();
        }

        private void fileLocationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileLocationTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                confirmBtn_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                cancelBtn_Click(sender, e);
            }
        }
    }
}
