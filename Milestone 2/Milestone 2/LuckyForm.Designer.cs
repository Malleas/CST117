namespace Milestone_2
{
    partial class LuckyForm
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
            this.rightLabel = new System.Windows.Forms.Label();
            this.centerLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.firstResultTextBox = new System.Windows.Forms.RichTextBox();
            this.thirdResultTextBox = new System.Windows.Forms.RichTextBox();
            this.secondResultTextBox = new System.Windows.Forms.RichTextBox();
            this.luckyBtn = new System.Windows.Forms.Button();
            this.luckyResultsLabel = new System.Windows.Forms.Label();
            this.luckyExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLabel.Location = new System.Drawing.Point(174, 26);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(0, 55);
            this.rightLabel.TabIndex = 38;
            // 
            // centerLabel
            // 
            this.centerLabel.AutoSize = true;
            this.centerLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.centerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerLabel.Location = new System.Drawing.Point(109, 26);
            this.centerLabel.Name = "centerLabel";
            this.centerLabel.Size = new System.Drawing.Size(0, 55);
            this.centerLabel.TabIndex = 37;
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.leftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftLabel.Location = new System.Drawing.Point(45, 25);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(0, 55);
            this.leftLabel.TabIndex = 33;
            // 
            // firstResultTextBox
            // 
            this.firstResultTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.firstResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstResultTextBox.Location = new System.Drawing.Point(44, 27);
            this.firstResultTextBox.Name = "firstResultTextBox";
            this.firstResultTextBox.Size = new System.Drawing.Size(57, 55);
            this.firstResultTextBox.TabIndex = 34;
            this.firstResultTextBox.Text = "";
            // 
            // thirdResultTextBox
            // 
            this.thirdResultTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.thirdResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.thirdResultTextBox.Location = new System.Drawing.Point(170, 27);
            this.thirdResultTextBox.Name = "thirdResultTextBox";
            this.thirdResultTextBox.Size = new System.Drawing.Size(57, 55);
            this.thirdResultTextBox.TabIndex = 36;
            this.thirdResultTextBox.Text = "";
            // 
            // secondResultTextBox
            // 
            this.secondResultTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.secondResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondResultTextBox.Location = new System.Drawing.Point(107, 27);
            this.secondResultTextBox.Name = "secondResultTextBox";
            this.secondResultTextBox.Size = new System.Drawing.Size(57, 55);
            this.secondResultTextBox.TabIndex = 35;
            this.secondResultTextBox.Text = "";
            // 
            // luckyBtn
            // 
            this.luckyBtn.Location = new System.Drawing.Point(44, 101);
            this.luckyBtn.Name = "luckyBtn";
            this.luckyBtn.Size = new System.Drawing.Size(183, 23);
            this.luckyBtn.TabIndex = 39;
            this.luckyBtn.Text = "Do You Feel Lucky?";
            this.luckyBtn.UseVisualStyleBackColor = true;
            this.luckyBtn.Click += new System.EventHandler(this.luckyBtn_Click);
            // 
            // luckyResultsLabel
            // 
            this.luckyResultsLabel.AutoSize = true;
            this.luckyResultsLabel.Location = new System.Drawing.Point(46, 85);
            this.luckyResultsLabel.Name = "luckyResultsLabel";
            this.luckyResultsLabel.Size = new System.Drawing.Size(0, 13);
            this.luckyResultsLabel.TabIndex = 40;
            // 
            // luckyExitBtn
            // 
            this.luckyExitBtn.Location = new System.Drawing.Point(44, 130);
            this.luckyExitBtn.Name = "luckyExitBtn";
            this.luckyExitBtn.Size = new System.Drawing.Size(183, 23);
            this.luckyExitBtn.TabIndex = 41;
            this.luckyExitBtn.Text = "Nope, Not Today!";
            this.luckyExitBtn.UseVisualStyleBackColor = true;
            this.luckyExitBtn.Click += new System.EventHandler(this.luckyExitBtn_Click);
            // 
            // LuckyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 155);
            this.Controls.Add(this.luckyExitBtn);
            this.Controls.Add(this.luckyResultsLabel);
            this.Controls.Add(this.luckyBtn);
            this.Controls.Add(this.rightLabel);
            this.Controls.Add(this.centerLabel);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.firstResultTextBox);
            this.Controls.Add(this.thirdResultTextBox);
            this.Controls.Add(this.secondResultTextBox);
            this.Name = "LuckyForm";
            this.Text = "LuckyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label centerLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.RichTextBox firstResultTextBox;
        private System.Windows.Forms.RichTextBox thirdResultTextBox;
        private System.Windows.Forms.RichTextBox secondResultTextBox;
        private System.Windows.Forms.Button luckyBtn;
        private System.Windows.Forms.Label luckyResultsLabel;
        private System.Windows.Forms.Button luckyExitBtn;
    }
}