namespace Exercise8
{
    partial class Form1
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
            this.calculateBtn = new System.Windows.Forms.Button();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.fatInputTextBox = new System.Windows.Forms.TextBox();
            this.carbsInputTextBox = new System.Windows.Forms.TextBox();
            this.fatLabel = new System.Windows.Forms.Label();
            this.carbsLabel = new System.Windows.Forms.Label();
            this.inputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(12, 165);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(200, 41);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.carbsInputTextBox);
            this.inputGroupBox.Controls.Add(this.fatLabel);
            this.inputGroupBox.Controls.Add(this.carbsLabel);
            this.inputGroupBox.Controls.Add(this.fatInputTextBox);
            this.inputGroupBox.Location = new System.Drawing.Point(12, 32);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(200, 127);
            this.inputGroupBox.TabIndex = 1;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Fat & Calorie Input";
            // 
            // fatInputTextBox
            // 
            this.fatInputTextBox.Location = new System.Drawing.Point(89, 30);
            this.fatInputTextBox.Name = "fatInputTextBox";
            this.fatInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.fatInputTextBox.TabIndex = 0;
            // 
            // carbsInputTextBox
            // 
            this.carbsInputTextBox.Location = new System.Drawing.Point(89, 80);
            this.carbsInputTextBox.Name = "carbsInputTextBox";
            this.carbsInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.carbsInputTextBox.TabIndex = 1;
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Location = new System.Drawing.Point(12, 33);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(59, 13);
            this.fatLabel.TabIndex = 4;
            this.fatLabel.Text = "Fat (grams)";
            // 
            // carbsLabel
            // 
            this.carbsLabel.AutoSize = true;
            this.carbsLabel.Location = new System.Drawing.Point(12, 83);
            this.carbsLabel.Name = "carbsLabel";
            this.carbsLabel.Size = new System.Drawing.Size(71, 13);
            this.carbsLabel.TabIndex = 5;
            this.carbsLabel.Text = "Carbs (grams)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 261);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.inputGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.TextBox carbsInputTextBox;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label carbsLabel;
        private System.Windows.Forms.TextBox fatInputTextBox;
    }
}

