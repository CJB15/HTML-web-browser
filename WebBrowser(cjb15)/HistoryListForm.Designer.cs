
namespace WebBrowser_cjb15_
{
    partial class HistoryListForm
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.openUrlBtn = new System.Windows.Forms.Button();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.clearHistoryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeBtn.Location = new System.Drawing.Point(177, 412);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // openUrlBtn
            // 
            this.openUrlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openUrlBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.openUrlBtn.Enabled = false;
            this.openUrlBtn.Location = new System.Drawing.Point(15, 412);
            this.openUrlBtn.Name = "openUrlBtn";
            this.openUrlBtn.Size = new System.Drawing.Size(75, 23);
            this.openUrlBtn.TabIndex = 8;
            this.openUrlBtn.Text = "Open Page";
            this.openUrlBtn.UseVisualStyleBackColor = true;
            this.openUrlBtn.Click += new System.EventHandler(this.openUrlBtn_Click);
            // 
            // historyListBox
            // 
            this.historyListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.Location = new System.Drawing.Point(15, 12);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(421, 394);
            this.historyListBox.TabIndex = 6;
            this.historyListBox.SelectedIndexChanged += new System.EventHandler(this.historyListBox_SelectedIndexChanged);
            this.historyListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.historyListBox_KeyDown);
            // 
            // clearHistoryBtn
            // 
            this.clearHistoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearHistoryBtn.Enabled = false;
            this.clearHistoryBtn.Location = new System.Drawing.Point(96, 412);
            this.clearHistoryBtn.Name = "clearHistoryBtn";
            this.clearHistoryBtn.Size = new System.Drawing.Size(75, 23);
            this.clearHistoryBtn.TabIndex = 11;
            this.clearHistoryBtn.Text = "Clear History";
            this.clearHistoryBtn.UseVisualStyleBackColor = true;
            this.clearHistoryBtn.Click += new System.EventHandler(this.clearHistoryBtn_Click);
            // 
            // HistoryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.clearHistoryBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.openUrlBtn);
            this.Controls.Add(this.historyListBox);
            this.Name = "HistoryListForm";
            this.Text = "Browsing History";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button openUrlBtn;
        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.Button clearHistoryBtn;
    }
}