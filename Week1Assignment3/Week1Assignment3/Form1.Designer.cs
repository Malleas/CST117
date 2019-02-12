namespace Week1Assignment3
{
    partial class CalculateAreaOfACircle
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
            this.enterNumberLabel = new System.Windows.Forms.Label();
            this.radiusInputBox = new System.Windows.Forms.TextBox();
            this.calculateRadiusBtn = new System.Windows.Forms.Button();
            this.calculatedAreaOutputBox = new System.Windows.Forms.TextBox();
            this.areaOfCircleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterNumberLabel
            // 
            this.enterNumberLabel.AutoSize = true;
            this.enterNumberLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterNumberLabel.Location = new System.Drawing.Point(12, 45);
            this.enterNumberLabel.Name = "enterNumberLabel";
            this.enterNumberLabel.Size = new System.Drawing.Size(209, 13);
            this.enterNumberLabel.TabIndex = 0;
            this.enterNumberLabel.Text = "Enter a number to find the radius of a circle";
            this.enterNumberLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // radiusInputBox
            // 
            this.radiusInputBox.Location = new System.Drawing.Point(227, 38);
            this.radiusInputBox.Name = "radiusInputBox";
            this.radiusInputBox.Size = new System.Drawing.Size(100, 20);
            this.radiusInputBox.TabIndex = 1;
            this.radiusInputBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // calculateRadiusBtn
            // 
            this.calculateRadiusBtn.Location = new System.Drawing.Point(145, 88);
            this.calculateRadiusBtn.Name = "calculateRadiusBtn";
            this.calculateRadiusBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateRadiusBtn.TabIndex = 2;
            this.calculateRadiusBtn.Text = "Calculate";
            this.calculateRadiusBtn.UseVisualStyleBackColor = true;
            this.calculateRadiusBtn.Click += new System.EventHandler(this.calculateRadiusBtn_Click);
            // 
            // calculatedAreaOutputBox
            // 
            this.calculatedAreaOutputBox.Location = new System.Drawing.Point(227, 90);
            this.calculatedAreaOutputBox.Name = "calculatedAreaOutputBox";
            this.calculatedAreaOutputBox.Size = new System.Drawing.Size(100, 20);
            this.calculatedAreaOutputBox.TabIndex = 3;
            this.calculatedAreaOutputBox.TextChanged += new System.EventHandler(this.calculatedAreaOutputBox_TextChanged);
            // 
            // areaOfCircleLabel
            // 
            this.areaOfCircleLabel.AutoSize = true;
            this.areaOfCircleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.areaOfCircleLabel.Location = new System.Drawing.Point(235, 74);
            this.areaOfCircleLabel.Name = "areaOfCircleLabel";
            this.areaOfCircleLabel.Size = new System.Drawing.Size(78, 13);
            this.areaOfCircleLabel.TabIndex = 4;
            this.areaOfCircleLabel.Text = "Area of a circle";
            // 
            // CalculateAreaOfACircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 161);
            this.Controls.Add(this.areaOfCircleLabel);
            this.Controls.Add(this.calculatedAreaOutputBox);
            this.Controls.Add(this.calculateRadiusBtn);
            this.Controls.Add(this.radiusInputBox);
            this.Controls.Add(this.enterNumberLabel);
            this.Name = "CalculateAreaOfACircle";
            this.Text = "Calculate Area - Circle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterNumberLabel;
        private System.Windows.Forms.TextBox radiusInputBox;
        private System.Windows.Forms.Button calculateRadiusBtn;
        private System.Windows.Forms.TextBox calculatedAreaOutputBox;
        private System.Windows.Forms.Label areaOfCircleLabel;
    }
}

