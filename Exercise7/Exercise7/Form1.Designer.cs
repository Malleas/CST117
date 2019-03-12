namespace Exercise7
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
            this.sumInput1 = new System.Windows.Forms.TextBox();
            this.sumInput2 = new System.Windows.Forms.TextBox();
            this.sumInt1label = new System.Windows.Forms.Label();
            this.sumInt2Label = new System.Windows.Forms.Label();
            this.sumGroupBox = new System.Windows.Forms.GroupBox();
            this.sumResultLabel = new System.Windows.Forms.Label();
            this.dbl1InputTextBox = new System.Windows.Forms.TextBox();
            this.dbl2InputTextBox = new System.Windows.Forms.TextBox();
            this.dbl3InputTextBox = new System.Windows.Forms.TextBox();
            this.dbl4InputTextBox = new System.Windows.Forms.TextBox();
            this.dbl5InputTextBox = new System.Windows.Forms.TextBox();
            this.avgBtn = new System.Windows.Forms.Button();
            this.dbl1InputLabel = new System.Windows.Forms.Label();
            this.dbl2InputLabel = new System.Windows.Forms.Label();
            this.dbl3InputLabel = new System.Windows.Forms.Label();
            this.dbl4InputLabel = new System.Windows.Forms.Label();
            this.dbl5InputLabel = new System.Windows.Forms.Label();
            this.dblAvgResultLabel = new System.Windows.Forms.Label();
            this.avgGroupBox = new System.Windows.Forms.GroupBox();
            this.clrBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rndSumResultsLabel = new System.Windows.Forms.Label();
            this.calculateRndBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.devideTextBox2 = new System.Windows.Forms.TextBox();
            this.devideByThreeResultsLabel = new System.Windows.Forms.Label();
            this.devideTextBox1 = new System.Windows.Forms.TextBox();
            this.divideBy3Btn = new System.Windows.Forms.Button();
            this.devideTextBox3 = new System.Windows.Forms.TextBox();
            this.devideLabel3 = new System.Windows.Forms.Label();
            this.devideLabel2 = new System.Windows.Forms.Label();
            this.devideLabel1 = new System.Windows.Forms.Label();
            this.shortestStringGroupBox = new System.Windows.Forms.GroupBox();
            this.strInput2TextBox = new System.Windows.Forms.TextBox();
            this.strInput1TextBox = new System.Windows.Forms.TextBox();
            this.shortestStringBtn = new System.Windows.Forms.Button();
            this.strLabel2 = new System.Windows.Forms.Label();
            this.strLable1 = new System.Windows.Forms.Label();
            this.shortestStringResultLabel = new System.Windows.Forms.Label();
            this.sumGroupBox.SuspendLayout();
            this.avgGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.shortestStringGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(12, 30);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // sumInput1
            // 
            this.sumInput1.Location = new System.Drawing.Point(96, 33);
            this.sumInput1.Name = "sumInput1";
            this.sumInput1.Size = new System.Drawing.Size(32, 20);
            this.sumInput1.TabIndex = 1;
            // 
            // sumInput2
            // 
            this.sumInput2.Location = new System.Drawing.Point(134, 33);
            this.sumInput2.Name = "sumInput2";
            this.sumInput2.Size = new System.Drawing.Size(32, 20);
            this.sumInput2.TabIndex = 2;
            // 
            // sumInt1label
            // 
            this.sumInt1label.AutoSize = true;
            this.sumInt1label.Location = new System.Drawing.Point(93, 17);
            this.sumInt1label.Name = "sumInt1label";
            this.sumInt1label.Size = new System.Drawing.Size(28, 13);
            this.sumInt1label.TabIndex = 3;
            this.sumInt1label.Text = "Int 1";
            // 
            // sumInt2Label
            // 
            this.sumInt2Label.AutoSize = true;
            this.sumInt2Label.Location = new System.Drawing.Point(134, 17);
            this.sumInt2Label.Name = "sumInt2Label";
            this.sumInt2Label.Size = new System.Drawing.Size(28, 13);
            this.sumInt2Label.TabIndex = 4;
            this.sumInt2Label.Text = "Int 2";
            // 
            // sumGroupBox
            // 
            this.sumGroupBox.Controls.Add(this.sumResultLabel);
            this.sumGroupBox.Controls.Add(this.sumInt2Label);
            this.sumGroupBox.Controls.Add(this.sumInput2);
            this.sumGroupBox.Controls.Add(this.sumInt1label);
            this.sumGroupBox.Controls.Add(this.calculateBtn);
            this.sumGroupBox.Controls.Add(this.sumInput1);
            this.sumGroupBox.Location = new System.Drawing.Point(2, 12);
            this.sumGroupBox.Name = "sumGroupBox";
            this.sumGroupBox.Size = new System.Drawing.Size(200, 92);
            this.sumGroupBox.TabIndex = 5;
            this.sumGroupBox.TabStop = false;
            this.sumGroupBox.Text = "Sum of 2 numbers";
            // 
            // sumResultLabel
            // 
            this.sumResultLabel.AutoSize = true;
            this.sumResultLabel.Location = new System.Drawing.Point(10, 65);
            this.sumResultLabel.Name = "sumResultLabel";
            this.sumResultLabel.Size = new System.Drawing.Size(0, 13);
            this.sumResultLabel.TabIndex = 6;
            // 
            // dbl1InputTextBox
            // 
            this.dbl1InputTextBox.Location = new System.Drawing.Point(93, 15);
            this.dbl1InputTextBox.Name = "dbl1InputTextBox";
            this.dbl1InputTextBox.Size = new System.Drawing.Size(100, 20);
            this.dbl1InputTextBox.TabIndex = 6;
            // 
            // dbl2InputTextBox
            // 
            this.dbl2InputTextBox.Location = new System.Drawing.Point(93, 36);
            this.dbl2InputTextBox.Name = "dbl2InputTextBox";
            this.dbl2InputTextBox.Size = new System.Drawing.Size(100, 20);
            this.dbl2InputTextBox.TabIndex = 7;
            // 
            // dbl3InputTextBox
            // 
            this.dbl3InputTextBox.Location = new System.Drawing.Point(93, 58);
            this.dbl3InputTextBox.Name = "dbl3InputTextBox";
            this.dbl3InputTextBox.Size = new System.Drawing.Size(100, 20);
            this.dbl3InputTextBox.TabIndex = 8;
            // 
            // dbl4InputTextBox
            // 
            this.dbl4InputTextBox.Location = new System.Drawing.Point(93, 80);
            this.dbl4InputTextBox.Name = "dbl4InputTextBox";
            this.dbl4InputTextBox.Size = new System.Drawing.Size(100, 20);
            this.dbl4InputTextBox.TabIndex = 9;
            // 
            // dbl5InputTextBox
            // 
            this.dbl5InputTextBox.Location = new System.Drawing.Point(93, 101);
            this.dbl5InputTextBox.Name = "dbl5InputTextBox";
            this.dbl5InputTextBox.Size = new System.Drawing.Size(100, 20);
            this.dbl5InputTextBox.TabIndex = 10;
            // 
            // avgBtn
            // 
            this.avgBtn.Location = new System.Drawing.Point(6, 22);
            this.avgBtn.Name = "avgBtn";
            this.avgBtn.Size = new System.Drawing.Size(39, 99);
            this.avgBtn.TabIndex = 11;
            this.avgBtn.Text = "Avg";
            this.avgBtn.UseVisualStyleBackColor = true;
            this.avgBtn.Click += new System.EventHandler(this.avgBtn_Click);
            // 
            // dbl1InputLabel
            // 
            this.dbl1InputLabel.AutoSize = true;
            this.dbl1InputLabel.Location = new System.Drawing.Point(52, 22);
            this.dbl1InputLabel.Name = "dbl1InputLabel";
            this.dbl1InputLabel.Size = new System.Drawing.Size(32, 13);
            this.dbl1InputLabel.TabIndex = 12;
            this.dbl1InputLabel.Text = "Dbl 1";
            // 
            // dbl2InputLabel
            // 
            this.dbl2InputLabel.AutoSize = true;
            this.dbl2InputLabel.Location = new System.Drawing.Point(52, 43);
            this.dbl2InputLabel.Name = "dbl2InputLabel";
            this.dbl2InputLabel.Size = new System.Drawing.Size(32, 13);
            this.dbl2InputLabel.TabIndex = 13;
            this.dbl2InputLabel.Text = "Dbl 2";
            // 
            // dbl3InputLabel
            // 
            this.dbl3InputLabel.AutoSize = true;
            this.dbl3InputLabel.Location = new System.Drawing.Point(52, 65);
            this.dbl3InputLabel.Name = "dbl3InputLabel";
            this.dbl3InputLabel.Size = new System.Drawing.Size(32, 13);
            this.dbl3InputLabel.TabIndex = 14;
            this.dbl3InputLabel.Text = "Dbl 3";
            // 
            // dbl4InputLabel
            // 
            this.dbl4InputLabel.AutoSize = true;
            this.dbl4InputLabel.Location = new System.Drawing.Point(52, 87);
            this.dbl4InputLabel.Name = "dbl4InputLabel";
            this.dbl4InputLabel.Size = new System.Drawing.Size(32, 13);
            this.dbl4InputLabel.TabIndex = 15;
            this.dbl4InputLabel.Text = "Dbl 4";
            // 
            // dbl5InputLabel
            // 
            this.dbl5InputLabel.AutoSize = true;
            this.dbl5InputLabel.Location = new System.Drawing.Point(52, 108);
            this.dbl5InputLabel.Name = "dbl5InputLabel";
            this.dbl5InputLabel.Size = new System.Drawing.Size(32, 13);
            this.dbl5InputLabel.TabIndex = 16;
            this.dbl5InputLabel.Text = "Dbl 5";
            // 
            // dblAvgResultLabel
            // 
            this.dblAvgResultLabel.AutoSize = true;
            this.dblAvgResultLabel.Location = new System.Drawing.Point(10, 138);
            this.dblAvgResultLabel.Name = "dblAvgResultLabel";
            this.dblAvgResultLabel.Size = new System.Drawing.Size(0, 13);
            this.dblAvgResultLabel.TabIndex = 17;
            // 
            // avgGroupBox
            // 
            this.avgGroupBox.Controls.Add(this.dbl2InputTextBox);
            this.avgGroupBox.Controls.Add(this.dblAvgResultLabel);
            this.avgGroupBox.Controls.Add(this.dbl1InputTextBox);
            this.avgGroupBox.Controls.Add(this.avgBtn);
            this.avgGroupBox.Controls.Add(this.dbl5InputLabel);
            this.avgGroupBox.Controls.Add(this.dbl3InputTextBox);
            this.avgGroupBox.Controls.Add(this.dbl4InputLabel);
            this.avgGroupBox.Controls.Add(this.dbl4InputTextBox);
            this.avgGroupBox.Controls.Add(this.dbl3InputLabel);
            this.avgGroupBox.Controls.Add(this.dbl5InputTextBox);
            this.avgGroupBox.Controls.Add(this.dbl2InputLabel);
            this.avgGroupBox.Controls.Add(this.dbl1InputLabel);
            this.avgGroupBox.Location = new System.Drawing.Point(2, 110);
            this.avgGroupBox.Name = "avgGroupBox";
            this.avgGroupBox.Size = new System.Drawing.Size(200, 154);
            this.avgGroupBox.TabIndex = 7;
            this.avgGroupBox.TabStop = false;
            this.avgGroupBox.Text = "Average of 5 numbers";
            // 
            // clrBtn
            // 
            this.clrBtn.Location = new System.Drawing.Point(8, 421);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(837, 23);
            this.clrBtn.TabIndex = 18;
            this.clrBtn.Text = "Clear All Fields";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(8, 447);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(837, 23);
            this.exitBtn.TabIndex = 19;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rndSumResultsLabel);
            this.groupBox1.Controls.Add(this.calculateRndBtn);
            this.groupBox1.Location = new System.Drawing.Point(208, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 84);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sum of 2 random numbers";
            // 
            // rndSumResultsLabel
            // 
            this.rndSumResultsLabel.AutoSize = true;
            this.rndSumResultsLabel.Location = new System.Drawing.Point(10, 50);
            this.rndSumResultsLabel.Name = "rndSumResultsLabel";
            this.rndSumResultsLabel.Size = new System.Drawing.Size(0, 13);
            this.rndSumResultsLabel.TabIndex = 6;
            // 
            // calculateRndBtn
            // 
            this.calculateRndBtn.Location = new System.Drawing.Point(13, 19);
            this.calculateRndBtn.Name = "calculateRndBtn";
            this.calculateRndBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateRndBtn.TabIndex = 0;
            this.calculateRndBtn.Text = "Calculate";
            this.calculateRndBtn.UseVisualStyleBackColor = true;
            this.calculateRndBtn.Click += new System.EventHandler(this.calculateRndBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.devideTextBox2);
            this.groupBox2.Controls.Add(this.devideByThreeResultsLabel);
            this.groupBox2.Controls.Add(this.devideTextBox1);
            this.groupBox2.Controls.Add(this.divideBy3Btn);
            this.groupBox2.Controls.Add(this.devideTextBox3);
            this.groupBox2.Controls.Add(this.devideLabel3);
            this.groupBox2.Controls.Add(this.devideLabel2);
            this.groupBox2.Controls.Add(this.devideLabel1);
            this.groupBox2.Location = new System.Drawing.Point(208, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Divisible by 3";
            // 
            // devideTextBox2
            // 
            this.devideTextBox2.Location = new System.Drawing.Point(93, 36);
            this.devideTextBox2.Name = "devideTextBox2";
            this.devideTextBox2.Size = new System.Drawing.Size(100, 20);
            this.devideTextBox2.TabIndex = 7;
            // 
            // devideByThreeResultsLabel
            // 
            this.devideByThreeResultsLabel.AutoSize = true;
            this.devideByThreeResultsLabel.Location = new System.Drawing.Point(10, 83);
            this.devideByThreeResultsLabel.Name = "devideByThreeResultsLabel";
            this.devideByThreeResultsLabel.Size = new System.Drawing.Size(0, 13);
            this.devideByThreeResultsLabel.TabIndex = 17;
            // 
            // devideTextBox1
            // 
            this.devideTextBox1.Location = new System.Drawing.Point(93, 15);
            this.devideTextBox1.Name = "devideTextBox1";
            this.devideTextBox1.Size = new System.Drawing.Size(100, 20);
            this.devideTextBox1.TabIndex = 6;
            // 
            // divideBy3Btn
            // 
            this.divideBy3Btn.Location = new System.Drawing.Point(2, 22);
            this.divideBy3Btn.Name = "divideBy3Btn";
            this.divideBy3Btn.Size = new System.Drawing.Size(44, 56);
            this.divideBy3Btn.TabIndex = 11;
            this.divideBy3Btn.Text = "Do It";
            this.divideBy3Btn.UseVisualStyleBackColor = true;
            this.divideBy3Btn.Click += new System.EventHandler(this.divideBy3Btn_Click);
            // 
            // devideTextBox3
            // 
            this.devideTextBox3.Location = new System.Drawing.Point(93, 58);
            this.devideTextBox3.Name = "devideTextBox3";
            this.devideTextBox3.Size = new System.Drawing.Size(100, 20);
            this.devideTextBox3.TabIndex = 8;
            // 
            // devideLabel3
            // 
            this.devideLabel3.AutoSize = true;
            this.devideLabel3.Location = new System.Drawing.Point(52, 65);
            this.devideLabel3.Name = "devideLabel3";
            this.devideLabel3.Size = new System.Drawing.Size(28, 13);
            this.devideLabel3.TabIndex = 14;
            this.devideLabel3.Text = "Int 3";
            // 
            // devideLabel2
            // 
            this.devideLabel2.AutoSize = true;
            this.devideLabel2.Location = new System.Drawing.Point(52, 43);
            this.devideLabel2.Name = "devideLabel2";
            this.devideLabel2.Size = new System.Drawing.Size(28, 13);
            this.devideLabel2.TabIndex = 13;
            this.devideLabel2.Text = "Int 2";
            // 
            // devideLabel1
            // 
            this.devideLabel1.AutoSize = true;
            this.devideLabel1.Location = new System.Drawing.Point(52, 22);
            this.devideLabel1.Name = "devideLabel1";
            this.devideLabel1.Size = new System.Drawing.Size(28, 13);
            this.devideLabel1.TabIndex = 12;
            this.devideLabel1.Text = "Int 1";
            // 
            // shortestStringGroupBox
            // 
            this.shortestStringGroupBox.Controls.Add(this.strInput2TextBox);
            this.shortestStringGroupBox.Controls.Add(this.shortestStringResultLabel);
            this.shortestStringGroupBox.Controls.Add(this.strInput1TextBox);
            this.shortestStringGroupBox.Controls.Add(this.shortestStringBtn);
            this.shortestStringGroupBox.Controls.Add(this.strLabel2);
            this.shortestStringGroupBox.Controls.Add(this.strLable1);
            this.shortestStringGroupBox.Location = new System.Drawing.Point(2, 270);
            this.shortestStringGroupBox.Name = "shortestStringGroupBox";
            this.shortestStringGroupBox.Size = new System.Drawing.Size(200, 100);
            this.shortestStringGroupBox.TabIndex = 19;
            this.shortestStringGroupBox.TabStop = false;
            this.shortestStringGroupBox.Text = "Shortest String";
            // 
            // strInput2TextBox
            // 
            this.strInput2TextBox.Location = new System.Drawing.Point(55, 36);
            this.strInput2TextBox.Name = "strInput2TextBox";
            this.strInput2TextBox.Size = new System.Drawing.Size(138, 20);
            this.strInput2TextBox.TabIndex = 7;
            // 
            // strInput1TextBox
            // 
            this.strInput1TextBox.Location = new System.Drawing.Point(55, 15);
            this.strInput1TextBox.Name = "strInput1TextBox";
            this.strInput1TextBox.Size = new System.Drawing.Size(138, 20);
            this.strInput1TextBox.TabIndex = 6;
            // 
            // shortestStringBtn
            // 
            this.shortestStringBtn.Location = new System.Drawing.Point(9, 57);
            this.shortestStringBtn.Name = "shortestStringBtn";
            this.shortestStringBtn.Size = new System.Drawing.Size(44, 39);
            this.shortestStringBtn.TabIndex = 11;
            this.shortestStringBtn.Text = "Do It";
            this.shortestStringBtn.UseVisualStyleBackColor = true;
            this.shortestStringBtn.Click += new System.EventHandler(this.shortestStringBtn_Click);
            // 
            // strLabel2
            // 
            this.strLabel2.AutoSize = true;
            this.strLabel2.Location = new System.Drawing.Point(10, 39);
            this.strLabel2.Name = "strLabel2";
            this.strLabel2.Size = new System.Drawing.Size(43, 13);
            this.strLabel2.TabIndex = 13;
            this.strLabel2.Text = "String 2";
            // 
            // strLable1
            // 
            this.strLable1.AutoSize = true;
            this.strLable1.Location = new System.Drawing.Point(10, 18);
            this.strLable1.Name = "strLable1";
            this.strLable1.Size = new System.Drawing.Size(43, 13);
            this.strLable1.TabIndex = 12;
            this.strLable1.Text = "String 1";
            // 
            // shortestStringResultLabel
            // 
            this.shortestStringResultLabel.AutoSize = true;
            this.shortestStringResultLabel.Location = new System.Drawing.Point(59, 71);
            this.shortestStringResultLabel.Name = "shortestStringResultLabel";
            this.shortestStringResultLabel.Size = new System.Drawing.Size(0, 13);
            this.shortestStringResultLabel.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 471);
            this.Controls.Add(this.shortestStringGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.avgGroupBox);
            this.Controls.Add(this.sumGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sumGroupBox.ResumeLayout(false);
            this.sumGroupBox.PerformLayout();
            this.avgGroupBox.ResumeLayout(false);
            this.avgGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.shortestStringGroupBox.ResumeLayout(false);
            this.shortestStringGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox sumInput1;
        private System.Windows.Forms.TextBox sumInput2;
        private System.Windows.Forms.Label sumInt1label;
        private System.Windows.Forms.Label sumInt2Label;
        private System.Windows.Forms.GroupBox sumGroupBox;
        private System.Windows.Forms.Label sumResultLabel;
        private System.Windows.Forms.TextBox dbl1InputTextBox;
        private System.Windows.Forms.TextBox dbl2InputTextBox;
        private System.Windows.Forms.TextBox dbl3InputTextBox;
        private System.Windows.Forms.TextBox dbl4InputTextBox;
        private System.Windows.Forms.TextBox dbl5InputTextBox;
        private System.Windows.Forms.Button avgBtn;
        private System.Windows.Forms.Label dbl1InputLabel;
        private System.Windows.Forms.Label dbl2InputLabel;
        private System.Windows.Forms.Label dbl3InputLabel;
        private System.Windows.Forms.Label dbl4InputLabel;
        private System.Windows.Forms.Label dbl5InputLabel;
        private System.Windows.Forms.Label dblAvgResultLabel;
        private System.Windows.Forms.GroupBox avgGroupBox;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label rndSumResultsLabel;
        private System.Windows.Forms.Button calculateRndBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox devideTextBox2;
        private System.Windows.Forms.Label devideByThreeResultsLabel;
        private System.Windows.Forms.TextBox devideTextBox1;
        private System.Windows.Forms.Button divideBy3Btn;
        private System.Windows.Forms.TextBox devideTextBox3;
        private System.Windows.Forms.Label devideLabel3;
        private System.Windows.Forms.Label devideLabel2;
        private System.Windows.Forms.Label devideLabel1;
        private System.Windows.Forms.GroupBox shortestStringGroupBox;
        private System.Windows.Forms.TextBox strInput2TextBox;
        private System.Windows.Forms.Label shortestStringResultLabel;
        private System.Windows.Forms.TextBox strInput1TextBox;
        private System.Windows.Forms.Button shortestStringBtn;
        private System.Windows.Forms.Label strLabel2;
        private System.Windows.Forms.Label strLable1;
    }
}

