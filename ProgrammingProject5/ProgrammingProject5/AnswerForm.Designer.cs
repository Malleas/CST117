namespace ProgrammingProject5
{
    partial class AnswerForm
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
            this.answerlabel = new System.Windows.Forms.Label();
            this.answerFormExitBtn = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answerlabel
            // 
            this.answerlabel.AutoSize = true;
            this.answerlabel.Location = new System.Drawing.Point(119, 34);
            this.answerlabel.Name = "answerlabel";
            this.answerlabel.Size = new System.Drawing.Size(0, 13);
            this.answerlabel.TabIndex = 0;
            // 
            // answerFormExitBtn
            // 
            this.answerFormExitBtn.Location = new System.Drawing.Point(100, 75);
            this.answerFormExitBtn.Name = "answerFormExitBtn";
            this.answerFormExitBtn.Size = new System.Drawing.Size(75, 23);
            this.answerFormExitBtn.TabIndex = 1;
            this.answerFormExitBtn.Text = "Exit";
            this.answerFormExitBtn.UseVisualStyleBackColor = true;
            this.answerFormExitBtn.Click += new System.EventHandler(this.answerFormExitBtn_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(60, 55);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(0, 13);
            this.colorLabel.TabIndex = 2;
            // 
            // AnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 123);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.answerFormExitBtn);
            this.Controls.Add(this.answerlabel);
            this.Name = "AnswerForm";
            this.Text = "AnswerForm";
            this.Load += new System.EventHandler(this.AnswerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label answerlabel;
        private System.Windows.Forms.Button answerFormExitBtn;
        public System.Windows.Forms.Label colorLabel;
    }
}