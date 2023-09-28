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
    public partial class EditFavForm : Form
    {
        public String newName { get; set; }
        public EditFavForm(String url, String name)
        {
            InitializeComponent();
            favNametxt.Text = name;
            urlable.Text = url;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            newName = favNametxt.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void favNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void favNametxt_KeyDown(object sender, KeyEventArgs e)
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
