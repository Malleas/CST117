namespace Exercise4
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
            this.calculateValueBtn = new System.Windows.Forms.Button();
            this.enterValueLabel = new System.Windows.Forms.Label();
            this.enterValueTextBox = new System.Windows.Forms.TextBox();
            this.convertedSecondsTextBox = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.timeElapsedLabel = new System.Windows.Forms.Label();
            this.unitOfMeasureOutputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateValueBtn
            // 
            this.calculateValueBtn.Location = new System.Drawing.Point(192, 129);
            this.calculateValueBtn.Name = "calculateValueBtn";
            this.calculateValueBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateValueBtn.TabIndex = 0;
            this.calculateValueBtn.Text = "Calculate";
            this.calculateValueBtn.UseVisualStyleBackColor = true;
            this.calculateValueBtn.Click += new System.EventHandler(this.calculateValueBtn_Click);
            // 
            // enterValueLabel
            // 
            this.enterValueLabel.AutoSize = true;
            this.enterValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterValueLabel.Location = new System.Drawing.Point(34, 68);
            this.enterValueLabel.Name = "enterValueLabel";
            this.enterValueLabel.Size = new System.Drawing.Size(208, 20);
            this.enterValueLabel.TabIndex = 1;
            this.enterValueLabel.Text = "Enter a value of seconds";
            // 
            // enterValueTextBox
            // 
            this.enterValueTextBox.Location = new System.Drawing.Point(248, 68);
            this.enterValueTextBox.Name = "enterValueTextBox";
            this.enterValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.enterValueTextBox.TabIndex = 2;
            // 
            // convertedSecondsTextBox
            // 
            this.convertedSecondsTextBox.Location = new System.Drawing.Point(248, 103);
            this.convertedSecondsTextBox.Name = "convertedSecondsTextBox";
            this.convertedSecondsTextBox.Size = new System.Drawing.Size(43, 20);
            this.convertedSecondsTextBox.TabIndex = 3;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(273, 129);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // timeElapsedLabel
            // 
            this.timeElapsedLabel.AutoSize = true;
            this.timeElapsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeElapsedLabel.Location = new System.Drawing.Point(125, 103);
            this.timeElapsedLabel.Name = "timeElapsedLabel";
            this.timeElapsedLabel.Size = new System.Drawing.Size(117, 20);
            this.timeElapsedLabel.TabIndex = 5;
            this.timeElapsedLabel.Text = "Time Elapsed";
            // 
            // unitOfMeasureOutputTextBox
            // 
            this.unitOfMeasureOutputTextBox.Location = new System.Drawing.Point(297, 103);
            this.unitOfMeasureOutputTextBox.Name = "unitOfMeasureOutputTextBox";
            this.unitOfMeasureOutputTextBox.Size = new System.Drawing.Size(51, 20);
            this.unitOfMeasureOutputTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 261);
            this.Controls.Add(this.unitOfMeasureOutputTextBox);
            this.Controls.Add(this.timeElapsedLabel);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.convertedSecondsTextBox);
            this.Controls.Add(this.enterValueTextBox);
            this.Controls.Add(this.enterValueLabel);
            this.Controls.Add(this.calculateValueBtn);
            this.Name = "Form1";
            this.Text = "Second Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateValueBtn;
        private System.Windows.Forms.Label enterValueLabel;
        private System.Windows.Forms.TextBox enterValueTextBox;
        private System.Windows.Forms.TextBox convertedSecondsTextBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label timeElapsedLabel;
        private System.Windows.Forms.TextBox unitOfMeasureOutputTextBox;
    }
}

