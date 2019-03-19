namespace Milestone_2
{
    partial class CurrentInventory
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
            this.currentInvListBox = new System.Windows.Forms.ListBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.getInvBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentInvListBox
            // 
            this.currentInvListBox.FormattingEnabled = true;
            this.currentInvListBox.Location = new System.Drawing.Point(28, 12);
            this.currentInvListBox.Name = "currentInvListBox";
            this.currentInvListBox.Size = new System.Drawing.Size(285, 251);
            this.currentInvListBox.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(176, 269);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(137, 23);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // getInvBtn
            // 
            this.getInvBtn.Location = new System.Drawing.Point(28, 269);
            this.getInvBtn.Name = "getInvBtn";
            this.getInvBtn.Size = new System.Drawing.Size(137, 23);
            this.getInvBtn.TabIndex = 2;
            this.getInvBtn.Text = "Get Inventory";
            this.getInvBtn.UseVisualStyleBackColor = true;
            this.getInvBtn.Click += new System.EventHandler(this.getInvBtn_Click);
            // 
            // CurrentInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 305);
            this.Controls.Add(this.getInvBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.currentInvListBox);
            this.Name = "CurrentInventory";
            this.Text = "CurrentInventory";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox currentInvListBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button getInvBtn;
    }
}