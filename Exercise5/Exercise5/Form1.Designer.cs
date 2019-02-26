namespace Exercise5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.termsLabel = new System.Windows.Forms.Label();
            this.apxValueOfPiLabel = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.termsTextBox = new System.Windows.Forms.TextBox();
            this.piValueLabel = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.blahBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            // 
            // termsLabel
            // 
            this.termsLabel.AutoSize = true;
            this.termsLabel.Location = new System.Drawing.Point(12, 34);
            this.termsLabel.Name = "termsLabel";
            this.termsLabel.Size = new System.Drawing.Size(131, 13);
            this.termsLabel.TabIndex = 1;
            this.termsLabel.Text = "Enter the number of terms:";
            // 
            // apxValueOfPiLabel
            // 
            this.apxValueOfPiLabel.AutoSize = true;
            this.apxValueOfPiLabel.Location = new System.Drawing.Point(12, 172);
            this.apxValueOfPiLabel.Name = "apxValueOfPiLabel";
            this.apxValueOfPiLabel.Size = new System.Drawing.Size(38, 13);
            this.apxValueOfPiLabel.TabIndex = 2;
            this.apxValueOfPiLabel.Text = "label3 ";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(11, 79);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(112, 43);
            this.calculateBtn.TabIndex = 3;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // termsTextBox
            // 
            this.termsTextBox.Location = new System.Drawing.Point(149, 27);
            this.termsTextBox.Name = "termsTextBox";
            this.termsTextBox.Size = new System.Drawing.Size(100, 20);
            this.termsTextBox.TabIndex = 4;
            // 
            // piValueLabel
            // 
            this.piValueLabel.AutoSize = true;
            this.piValueLabel.Location = new System.Drawing.Point(12, 221);
            this.piValueLabel.Name = "piValueLabel";
            this.piValueLabel.Size = new System.Drawing.Size(35, 13);
            this.piValueLabel.TabIndex = 5;
            this.piValueLabel.Text = "label4";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(137, 79);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(112, 43);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // blahBtn
            // 
            this.blahBtn.Location = new System.Drawing.Point(137, 142);
            this.blahBtn.Name = "blahBtn";
            this.blahBtn.Size = new System.Drawing.Size(112, 43);
            this.blahBtn.TabIndex = 7;
            this.blahBtn.Text = "Blah";
            this.blahBtn.UseVisualStyleBackColor = true;
            this.blahBtn.Click += new System.EventHandler(this.blahBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.blahBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.piValueLabel);
            this.Controls.Add(this.termsTextBox);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.apxValueOfPiLabel);
            this.Controls.Add(this.termsLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Approximate Pi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label termsLabel;
        private System.Windows.Forms.Label apxValueOfPiLabel;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox termsTextBox;
        private System.Windows.Forms.Label piValueLabel;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button blahBtn;
    }
}

