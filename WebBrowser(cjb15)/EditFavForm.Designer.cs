
namespace WebBrowser_cjb15_
{
    partial class EditFavForm
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.urlable = new System.Windows.Forms.Label();
            this.favNametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(256, 107);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(116, 23);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(12, 107);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(116, 23);
            this.confirmBtn.TabIndex = 10;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // urlable
            // 
            this.urlable.AutoSize = true;
            this.urlable.Location = new System.Drawing.Point(9, 33);
            this.urlable.Name = "urlable";
            this.urlable.Size = new System.Drawing.Size(43, 13);
            this.urlable.TabIndex = 9;
            this.urlable.Text = "https://";
            // 
            // favNametxt
            // 
            this.favNametxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favNametxt.Location = new System.Drawing.Point(12, 81);
            this.favNametxt.Name = "favNametxt";
            this.favNametxt.Size = new System.Drawing.Size(410, 20);
            this.favNametxt.TabIndex = 8;
            this.favNametxt.TextChanged += new System.EventHandler(this.favNametxt_TextChanged);
            this.favNametxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.favNametxt_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rename Page Nickname: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Editing the following favorited page:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(134, 107);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(116, 23);
            this.delBtn.TabIndex = 12;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // EditFavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 149);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.urlable);
            this.Controls.Add(this.favNametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditFavForm";
            this.Text = "Edit Favorite Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label urlable;
        private System.Windows.Forms.TextBox favNametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delBtn;
    }
}