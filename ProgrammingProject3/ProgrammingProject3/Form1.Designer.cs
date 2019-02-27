namespace ProgrammingProject3
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
            this.resultsTextBox = new System.Windows.Forms.RichTextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.convertToLowerLabel = new System.Windows.Forms.Label();
            this.firstSortedWordLabel = new System.Windows.Forms.Label();
            this.firstWordTextBox = new System.Windows.Forms.TextBox();
            this.lastWordTextBox = new System.Windows.Forms.TextBox();
            this.lastWordLabel = new System.Windows.Forms.Label();
            this.longestWordTextBox = new System.Windows.Forms.TextBox();
            this.longestWordLabel = new System.Windows.Forms.Label();
            this.mostVowelsLabel = new System.Windows.Forms.Label();
            this.mostVowelsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(220, 109);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.Size = new System.Drawing.Size(220, 145);
            this.resultsTextBox.TabIndex = 0;
            this.resultsTextBox.Text = "";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(469, 109);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(133, 50);
            this.openFileBtn.TabIndex = 2;
            this.openFileBtn.Text = "Open File";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // convertToLowerLabel
            // 
            this.convertToLowerLabel.AutoSize = true;
            this.convertToLowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertToLowerLabel.Location = new System.Drawing.Point(81, 164);
            this.convertToLowerLabel.Name = "convertToLowerLabel";
            this.convertToLowerLabel.Size = new System.Drawing.Size(133, 40);
            this.convertToLowerLabel.TabIndex = 3;
            this.convertToLowerLabel.Text = "Convert To Lower\r\nCase Result";
            this.convertToLowerLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // firstSortedWordLabel
            // 
            this.firstSortedWordLabel.AutoSize = true;
            this.firstSortedWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstSortedWordLabel.Location = new System.Drawing.Point(31, 260);
            this.firstSortedWordLabel.Name = "firstSortedWordLabel";
            this.firstSortedWordLabel.Size = new System.Drawing.Size(183, 20);
            this.firstSortedWordLabel.TabIndex = 4;
            this.firstSortedWordLabel.Text = "First Word Alphabetically";
            // 
            // firstWordTextBox
            // 
            this.firstWordTextBox.Location = new System.Drawing.Point(220, 260);
            this.firstWordTextBox.Name = "firstWordTextBox";
            this.firstWordTextBox.Size = new System.Drawing.Size(220, 20);
            this.firstWordTextBox.TabIndex = 7;
            // 
            // lastWordTextBox
            // 
            this.lastWordTextBox.Location = new System.Drawing.Point(220, 286);
            this.lastWordTextBox.Name = "lastWordTextBox";
            this.lastWordTextBox.Size = new System.Drawing.Size(220, 20);
            this.lastWordTextBox.TabIndex = 8;
            // 
            // lastWordLabel
            // 
            this.lastWordLabel.AutoSize = true;
            this.lastWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastWordLabel.Location = new System.Drawing.Point(31, 286);
            this.lastWordLabel.Name = "lastWordLabel";
            this.lastWordLabel.Size = new System.Drawing.Size(183, 20);
            this.lastWordLabel.TabIndex = 9;
            this.lastWordLabel.Text = "Last Word Alphabetically";
            // 
            // longestWordTextBox
            // 
            this.longestWordTextBox.Location = new System.Drawing.Point(220, 312);
            this.longestWordTextBox.Name = "longestWordTextBox";
            this.longestWordTextBox.Size = new System.Drawing.Size(220, 20);
            this.longestWordTextBox.TabIndex = 10;
            // 
            // longestWordLabel
            // 
            this.longestWordLabel.AutoSize = true;
            this.longestWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longestWordLabel.Location = new System.Drawing.Point(105, 312);
            this.longestWordLabel.Name = "longestWordLabel";
            this.longestWordLabel.Size = new System.Drawing.Size(109, 20);
            this.longestWordLabel.TabIndex = 11;
            this.longestWordLabel.Text = "Longest Word";
            // 
            // mostVowelsLabel
            // 
            this.mostVowelsLabel.AutoSize = true;
            this.mostVowelsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostVowelsLabel.Location = new System.Drawing.Point(105, 336);
            this.mostVowelsLabel.Name = "mostVowelsLabel";
            this.mostVowelsLabel.Size = new System.Drawing.Size(99, 20);
            this.mostVowelsLabel.TabIndex = 12;
            this.mostVowelsLabel.Text = "Most Vowels";
            // 
            // mostVowelsTextBox
            // 
            this.mostVowelsTextBox.Location = new System.Drawing.Point(220, 338);
            this.mostVowelsTextBox.Name = "mostVowelsTextBox";
            this.mostVowelsTextBox.Size = new System.Drawing.Size(220, 20);
            this.mostVowelsTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 435);
            this.Controls.Add(this.mostVowelsTextBox);
            this.Controls.Add(this.mostVowelsLabel);
            this.Controls.Add(this.longestWordLabel);
            this.Controls.Add(this.longestWordTextBox);
            this.Controls.Add(this.lastWordLabel);
            this.Controls.Add(this.lastWordTextBox);
            this.Controls.Add(this.firstWordTextBox);
            this.Controls.Add(this.firstSortedWordLabel);
            this.Controls.Add(this.convertToLowerLabel);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.resultsTextBox);
            this.Name = "Form1";
            this.Text = "Read A File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox resultsTextBox;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Label convertToLowerLabel;
        private System.Windows.Forms.Label firstSortedWordLabel;
        private System.Windows.Forms.TextBox firstWordTextBox;
        private System.Windows.Forms.TextBox lastWordTextBox;
        private System.Windows.Forms.Label lastWordLabel;
        private System.Windows.Forms.TextBox longestWordTextBox;
        private System.Windows.Forms.Label longestWordLabel;
        private System.Windows.Forms.Label mostVowelsLabel;
        private System.Windows.Forms.TextBox mostVowelsTextBox;
    }
}

