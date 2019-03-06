namespace Milestone_2
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.entryTextBox = new System.Windows.Forms.TextBox();
            this.itemNumberLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemNumberTextBox = new System.Windows.Forms.TextBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(123, 246);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // entryTextBox
            // 
            this.entryTextBox.Location = new System.Drawing.Point(193, 57);
            this.entryTextBox.Name = "entryTextBox";
            this.entryTextBox.Size = new System.Drawing.Size(198, 20);
            this.entryTextBox.TabIndex = 1;
            this.entryTextBox.TextChanged += new System.EventHandler(this.entryTextBox_TextChanged);
            // 
            // itemNumberLabel
            // 
            this.itemNumberLabel.AutoSize = true;
            this.itemNumberLabel.Location = new System.Drawing.Point(120, 60);
            this.itemNumberLabel.Name = "itemNumberLabel";
            this.itemNumberLabel.Size = new System.Drawing.Size(67, 13);
            this.itemNumberLabel.TabIndex = 3;
            this.itemNumberLabel.Text = "Item Number";
            this.itemNumberLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(141, 129);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Quantity";
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(193, 152);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(198, 20);
            this.colorTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Item Number";
            // 
            // itemNumberTextBox
            // 
            this.itemNumberTextBox.Location = new System.Drawing.Point(193, 100);
            this.itemNumberTextBox.Name = "itemNumberTextBox";
            this.itemNumberTextBox.Size = new System.Drawing.Size(198, 20);
            this.itemNumberTextBox.TabIndex = 6;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(156, 155);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(31, 13);
            this.colorLabel.TabIndex = 9;
            this.colorLabel.Text = "Color";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(193, 126);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(198, 20);
            this.quantityTextBox.TabIndex = 8;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(160, 181);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(27, 13);
            this.sizeLabel.TabIndex = 11;
            this.sizeLabel.Text = "Size";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(193, 178);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(198, 20);
            this.sizeTextBox.TabIndex = 10;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(139, 207);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(48, 13);
            this.locationLabel.TabIndex = 13;
            this.locationLabel.Text = "Location";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(193, 204);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(198, 20);
            this.locationTextBox.TabIndex = 12;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(218, 246);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(316, 246);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 15;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 419);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemNumberTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.itemNumberLabel);
            this.Controls.Add(this.entryTextBox);
            this.Controls.Add(this.searchBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox entryTextBox;
        private System.Windows.Forms.Label itemNumberLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemNumberTextBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addBtn;
    }
}

