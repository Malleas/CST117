namespace Milestone_2
{
    partial class SearchInventoryForm
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
            this.searchResultsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.searchResultsExitBtn = new System.Windows.Forms.Button();
            this.searchResultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchResultsRichTextBox
            // 
            this.searchResultsRichTextBox.Location = new System.Drawing.Point(12, 41);
            this.searchResultsRichTextBox.Name = "searchResultsRichTextBox";
            this.searchResultsRichTextBox.Size = new System.Drawing.Size(260, 130);
            this.searchResultsRichTextBox.TabIndex = 0;
            this.searchResultsRichTextBox.Text = "";
            // 
            // searchResultsExitBtn
            // 
            this.searchResultsExitBtn.Location = new System.Drawing.Point(12, 177);
            this.searchResultsExitBtn.Name = "searchResultsExitBtn";
            this.searchResultsExitBtn.Size = new System.Drawing.Size(260, 23);
            this.searchResultsExitBtn.TabIndex = 1;
            this.searchResultsExitBtn.Text = "Exit";
            this.searchResultsExitBtn.UseVisualStyleBackColor = true;
            this.searchResultsExitBtn.Click += new System.EventHandler(this.searchResultsExitBtn_Click);
            // 
            // searchResultsLabel
            // 
            this.searchResultsLabel.AutoSize = true;
            this.searchResultsLabel.Location = new System.Drawing.Point(101, 25);
            this.searchResultsLabel.Name = "searchResultsLabel";
            this.searchResultsLabel.Size = new System.Drawing.Size(79, 13);
            this.searchResultsLabel.TabIndex = 2;
            this.searchResultsLabel.Text = "Search Results";
            // 
            // SearchInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.searchResultsLabel);
            this.Controls.Add(this.searchResultsExitBtn);
            this.Controls.Add(this.searchResultsRichTextBox);
            this.Name = "SearchInventoryForm";
            this.Text = "SearchInventoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchResultsExitBtn;
        private System.Windows.Forms.Label searchResultsLabel;
        public System.Windows.Forms.RichTextBox searchResultsRichTextBox;
    }
}