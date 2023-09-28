
namespace WebBrowser_cjb15_
{
    partial class AddFavForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.favNametxt = new System.Windows.Forms.TextBox();
            this.urlable = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adding the following page to your favorites:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add page nickname below, leaving blank will use the url as the nickname";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // favNametxt
            // 
            this.favNametxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favNametxt.Location = new System.Drawing.Point(12, 86);
            this.favNametxt.Name = "favNametxt";
            this.favNametxt.Size = new System.Drawing.Size(410, 20);
            this.favNametxt.TabIndex = 2;
            this.favNametxt.TextChanged += new System.EventHandler(this.favNametxt_TextChanged);
            this.favNametxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.favNametxt_KeyDown);
            // 
            // urlable
            // 
            this.urlable.AutoSize = true;
            this.urlable.Location = new System.Drawing.Point(9, 35);
            this.urlable.Name = "urlable";
            this.urlable.Size = new System.Drawing.Size(43, 13);
            this.urlable.TabIndex = 3;
            this.urlable.Text = "https://";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(16, 113);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(116, 23);
            this.confirmBtn.TabIndex = 4;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(138, 113);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(116, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddFavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 151);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.urlable);
            this.Controls.Add(this.favNametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddFavForm";
            this.Text = "Add Favorite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox favNametxt;
        private System.Windows.Forms.Label urlable;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}