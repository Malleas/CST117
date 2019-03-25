namespace ProgrammingProject5
{
    partial class MainForm
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
            this.dayOfBirthLabel = new System.Windows.Forms.Label();
            this.monthOfBirthLabel = new System.Windows.Forms.Label();
            this.dayInputTextBox = new System.Windows.Forms.TextBox();
            this.monthInputTextBox = new System.Windows.Forms.TextBox();
            this.birthDayLabel = new System.Windows.Forms.Label();
            this.calcBdayBtn = new System.Windows.Forms.Button();
            this.mainFormExitBtn = new System.Windows.Forms.Button();
            this.blueRadioBtn = new System.Windows.Forms.RadioButton();
            this.greenRadioBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // dayOfBirthLabel
            // 
            this.dayOfBirthLabel.AutoSize = true;
            this.dayOfBirthLabel.Location = new System.Drawing.Point(70, 135);
            this.dayOfBirthLabel.Name = "dayOfBirthLabel";
            this.dayOfBirthLabel.Size = new System.Drawing.Size(50, 13);
            this.dayOfBirthLabel.TabIndex = 11;
            this.dayOfBirthLabel.Text = "Birth Day";
            // 
            // monthOfBirthLabel
            // 
            this.monthOfBirthLabel.AutoSize = true;
            this.monthOfBirthLabel.Location = new System.Drawing.Point(59, 108);
            this.monthOfBirthLabel.Name = "monthOfBirthLabel";
            this.monthOfBirthLabel.Size = new System.Drawing.Size(61, 13);
            this.monthOfBirthLabel.TabIndex = 10;
            this.monthOfBirthLabel.Text = "Birth Month";
            // 
            // dayInputTextBox
            // 
            this.dayInputTextBox.Location = new System.Drawing.Point(126, 131);
            this.dayInputTextBox.Name = "dayInputTextBox";
            this.dayInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.dayInputTextBox.TabIndex = 9;
            // 
            // monthInputTextBox
            // 
            this.monthInputTextBox.Location = new System.Drawing.Point(126, 105);
            this.monthInputTextBox.Name = "monthInputTextBox";
            this.monthInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthInputTextBox.TabIndex = 8;
            // 
            // birthDayLabel
            // 
            this.birthDayLabel.AutoSize = true;
            this.birthDayLabel.Location = new System.Drawing.Point(101, 80);
            this.birthDayLabel.Name = "birthDayLabel";
            this.birthDayLabel.Size = new System.Drawing.Size(104, 13);
            this.birthDayLabel.TabIndex = 7;
            this.birthDayLabel.Text = "Enter The Following:";
            // 
            // calcBdayBtn
            // 
            this.calcBdayBtn.Location = new System.Drawing.Point(90, 185);
            this.calcBdayBtn.Name = "calcBdayBtn";
            this.calcBdayBtn.Size = new System.Drawing.Size(115, 23);
            this.calcBdayBtn.TabIndex = 6;
            this.calcBdayBtn.Text = "Calculate Birthday";
            this.calcBdayBtn.UseVisualStyleBackColor = true;
            this.calcBdayBtn.Click += new System.EventHandler(this.luckyBtn_Click);
            // 
            // mainFormExitBtn
            // 
            this.mainFormExitBtn.Location = new System.Drawing.Point(90, 214);
            this.mainFormExitBtn.Name = "mainFormExitBtn";
            this.mainFormExitBtn.Size = new System.Drawing.Size(115, 23);
            this.mainFormExitBtn.TabIndex = 12;
            this.mainFormExitBtn.Text = "Exit";
            this.mainFormExitBtn.UseVisualStyleBackColor = true;
            this.mainFormExitBtn.Click += new System.EventHandler(this.mainFormExitBtn_Click);
            // 
            // blueRadioBtn
            // 
            this.blueRadioBtn.AutoSize = true;
            this.blueRadioBtn.Location = new System.Drawing.Point(90, 162);
            this.blueRadioBtn.Name = "blueRadioBtn";
            this.blueRadioBtn.Size = new System.Drawing.Size(46, 17);
            this.blueRadioBtn.TabIndex = 13;
            this.blueRadioBtn.TabStop = true;
            this.blueRadioBtn.Text = "Blue";
            this.blueRadioBtn.UseVisualStyleBackColor = true;
            // 
            // greenRadioBtn
            // 
            this.greenRadioBtn.AutoSize = true;
            this.greenRadioBtn.Location = new System.Drawing.Point(151, 162);
            this.greenRadioBtn.Name = "greenRadioBtn";
            this.greenRadioBtn.Size = new System.Drawing.Size(54, 17);
            this.greenRadioBtn.TabIndex = 14;
            this.greenRadioBtn.TabStop = true;
            this.greenRadioBtn.Text = "Green";
            this.greenRadioBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.greenRadioBtn);
            this.Controls.Add(this.blueRadioBtn);
            this.Controls.Add(this.mainFormExitBtn);
            this.Controls.Add(this.dayOfBirthLabel);
            this.Controls.Add(this.monthOfBirthLabel);
            this.Controls.Add(this.dayInputTextBox);
            this.Controls.Add(this.monthInputTextBox);
            this.Controls.Add(this.birthDayLabel);
            this.Controls.Add(this.calcBdayBtn);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayOfBirthLabel;
        private System.Windows.Forms.Label monthOfBirthLabel;
        private System.Windows.Forms.TextBox dayInputTextBox;
        private System.Windows.Forms.TextBox monthInputTextBox;
        private System.Windows.Forms.Label birthDayLabel;
        private System.Windows.Forms.Button calcBdayBtn;
        private System.Windows.Forms.Button mainFormExitBtn;
        private System.Windows.Forms.RadioButton blueRadioBtn;
        private System.Windows.Forms.RadioButton greenRadioBtn;
    }
}

