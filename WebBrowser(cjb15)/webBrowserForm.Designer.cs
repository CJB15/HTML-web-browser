
namespace WebBrowser_cjb15_
{
    partial class webBrowserForm
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
            this.urlBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.favBtn = new System.Windows.Forms.Button();
            this.reBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.bulkBtn = new System.Windows.Forms.Button();
            this.htmlTextBox = new System.Windows.Forms.RichTextBox();
            this.headerLable = new System.Windows.Forms.Label();
            this.viewFavBtn = new System.Windows.Forms.Button();
            this.titleLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlBox.Location = new System.Drawing.Point(126, 12);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(846, 20);
            this.urlBox.TabIndex = 0;
            this.urlBox.TextChanged += new System.EventHandler(this.urlBox_TextChanged);
            this.urlBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlBox_KeyDown);
            // 
            // searchBtn
            // 
            this.searchBtn.Enabled = false;
            this.searchBtn.Location = new System.Drawing.Point(12, 6);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(108, 30);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // historyBtn
            // 
            this.historyBtn.Enabled = false;
            this.historyBtn.Location = new System.Drawing.Point(354, 42);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(108, 30);
            this.historyBtn.TabIndex = 2;
            this.historyBtn.Text = "View History";
            this.historyBtn.UseVisualStyleBackColor = true;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // favBtn
            // 
            this.favBtn.Enabled = false;
            this.favBtn.Location = new System.Drawing.Point(126, 42);
            this.favBtn.Name = "favBtn";
            this.favBtn.Size = new System.Drawing.Size(108, 30);
            this.favBtn.TabIndex = 3;
            this.favBtn.Text = "Add to Favourites";
            this.favBtn.UseVisualStyleBackColor = true;
            this.favBtn.Click += new System.EventHandler(this.favBtn_Click);
            // 
            // reBtn
            // 
            this.reBtn.Enabled = false;
            this.reBtn.Location = new System.Drawing.Point(12, 42);
            this.reBtn.Name = "reBtn";
            this.reBtn.Size = new System.Drawing.Size(108, 30);
            this.reBtn.TabIndex = 4;
            this.reBtn.Text = "Reload Page";
            this.reBtn.UseVisualStyleBackColor = true;
            this.reBtn.Click += new System.EventHandler(this.reBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Enabled = false;
            this.homeBtn.Location = new System.Drawing.Point(468, 42);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(108, 30);
            this.homeBtn.TabIndex = 5;
            this.homeBtn.Text = "Set Home Page";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // bulkBtn
            // 
            this.bulkBtn.Enabled = false;
            this.bulkBtn.Location = new System.Drawing.Point(582, 42);
            this.bulkBtn.Name = "bulkBtn";
            this.bulkBtn.Size = new System.Drawing.Size(108, 30);
            this.bulkBtn.TabIndex = 6;
            this.bulkBtn.Text = "Bulk Download";
            this.bulkBtn.UseVisualStyleBackColor = true;
            this.bulkBtn.Click += new System.EventHandler(this.bulkBtn_Click);
            // 
            // htmlTextBox
            // 
            this.htmlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.htmlTextBox.Location = new System.Drawing.Point(12, 95);
            this.htmlTextBox.Name = "htmlTextBox";
            this.htmlTextBox.Size = new System.Drawing.Size(960, 554);
            this.htmlTextBox.TabIndex = 9;
            this.htmlTextBox.Text = "";
            this.htmlTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.htmlTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.htmlTextBox_KeyDown);
            // 
            // headerLable
            // 
            this.headerLable.AutoSize = true;
            this.headerLable.Location = new System.Drawing.Point(696, 51);
            this.headerLable.Name = "headerLable";
            this.headerLable.Size = new System.Drawing.Size(54, 13);
            this.headerLable.TabIndex = 7;
            this.headerLable.Text = "Loading...";
            this.headerLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // viewFavBtn
            // 
            this.viewFavBtn.Enabled = false;
            this.viewFavBtn.Location = new System.Drawing.Point(240, 42);
            this.viewFavBtn.Name = "viewFavBtn";
            this.viewFavBtn.Size = new System.Drawing.Size(108, 30);
            this.viewFavBtn.TabIndex = 10;
            this.viewFavBtn.Text = "View Favourites";
            this.viewFavBtn.UseVisualStyleBackColor = true;
            this.viewFavBtn.Click += new System.EventHandler(this.viewFavBtn_Click);
            // 
            // titleLable
            // 
            this.titleLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLable.AutoSize = true;
            this.titleLable.Location = new System.Drawing.Point(13, 79);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(0, 13);
            this.titleLable.TabIndex = 11;
            // 
            // webBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.viewFavBtn);
            this.Controls.Add(this.htmlTextBox);
            this.Controls.Add(this.headerLable);
            this.Controls.Add(this.bulkBtn);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.reBtn);
            this.Controls.Add(this.favBtn);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.urlBox);
            this.Name = "webBrowserForm";
            this.Text = "Web Browser";
            this.Load += new System.EventHandler(this.webBrowserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Button favBtn;
        private System.Windows.Forms.Button reBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button bulkBtn;
        private System.Windows.Forms.RichTextBox htmlTextBox;
        private System.Windows.Forms.Label headerLable;
        private System.Windows.Forms.Button viewFavBtn;
        private System.Windows.Forms.Label titleLable;
    }
}

