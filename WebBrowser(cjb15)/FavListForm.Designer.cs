
namespace WebBrowser_cjb15_
{
    partial class FavListForm
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
            this.favListBox = new System.Windows.Forms.ListBox();
            this.openUrlBtn = new System.Windows.Forms.Button();
            this.editFavBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // favListBox
            // 
            this.favListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favListBox.FormattingEnabled = true;
            this.favListBox.Location = new System.Drawing.Point(15, 12);
            this.favListBox.Name = "favListBox";
            this.favListBox.Size = new System.Drawing.Size(318, 394);
            this.favListBox.TabIndex = 0;
            this.favListBox.SelectedIndexChanged += new System.EventHandler(this.favListBox_SelectedIndexChanged);
            this.favListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.favListBox_KeyDown);
            // 
            // openUrlBtn
            // 
            this.openUrlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openUrlBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.openUrlBtn.Enabled = false;
            this.openUrlBtn.Location = new System.Drawing.Point(15, 415);
            this.openUrlBtn.Name = "openUrlBtn";
            this.openUrlBtn.Size = new System.Drawing.Size(75, 23);
            this.openUrlBtn.TabIndex = 2;
            this.openUrlBtn.Text = "Open Page";
            this.openUrlBtn.UseVisualStyleBackColor = true;
            this.openUrlBtn.Click += new System.EventHandler(this.openUrlBtn_Click);
            // 
            // editFavBtn
            // 
            this.editFavBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editFavBtn.Enabled = false;
            this.editFavBtn.Location = new System.Drawing.Point(96, 415);
            this.editFavBtn.Name = "editFavBtn";
            this.editFavBtn.Size = new System.Drawing.Size(75, 23);
            this.editFavBtn.TabIndex = 3;
            this.editFavBtn.Text = "Edit";
            this.editFavBtn.UseVisualStyleBackColor = true;
            this.editFavBtn.Click += new System.EventHandler(this.editFavBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeBtn.Location = new System.Drawing.Point(177, 415);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // FavListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 450);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.editFavBtn);
            this.Controls.Add(this.openUrlBtn);
            this.Controls.Add(this.favListBox);
            this.Name = "FavListForm";
            this.Text = "Favourite List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox favListBox;
        private System.Windows.Forms.Button openUrlBtn;
        private System.Windows.Forms.Button editFavBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}