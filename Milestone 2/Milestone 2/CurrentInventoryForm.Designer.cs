namespace Milestone_2
{
    partial class CurrentInventoryForm
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
            this.currentInvExitBtn = new System.Windows.Forms.Button();
            this.currentInventoryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // currentInvExitBtn
            // 
            this.currentInvExitBtn.Location = new System.Drawing.Point(44, 295);
            this.currentInvExitBtn.Name = "currentInvExitBtn";
            this.currentInvExitBtn.Size = new System.Drawing.Size(310, 23);
            this.currentInvExitBtn.TabIndex = 1;
            this.currentInvExitBtn.Text = "Exit";
            this.currentInvExitBtn.UseVisualStyleBackColor = true;
            this.currentInvExitBtn.Click += new System.EventHandler(this.currentInvExitBtn_Click);
            // 
            // currentInventoryRichTextBox
            // 
            this.currentInventoryRichTextBox.Location = new System.Drawing.Point(44, 27);
            this.currentInventoryRichTextBox.Name = "currentInventoryRichTextBox";
            this.currentInventoryRichTextBox.Size = new System.Drawing.Size(310, 262);
            this.currentInventoryRichTextBox.TabIndex = 2;
            this.currentInventoryRichTextBox.Text = "";
            // 
            // CurrentInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 369);
            this.Controls.Add(this.currentInventoryRichTextBox);
            this.Controls.Add(this.currentInvExitBtn);
            this.Name = "CurrentInventoryForm";
            this.Text = "CurrentInventoryForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button currentInvExitBtn;
        public System.Windows.Forms.RichTextBox currentInventoryRichTextBox;
    }
}