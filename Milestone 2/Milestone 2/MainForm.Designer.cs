namespace Milestone_2
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
            this.quantityLabel = new System.Windows.Forms.Label();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.itemNumberTextBox = new System.Windows.Forms.TextBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.currentInvBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchInputTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.restockBtn = new System.Windows.Forms.Button();
            this.restockItemNumberTextInput = new System.Windows.Forms.TextBox();
            this.qtyAdjustmentTextInput = new System.Windows.Forms.TextBox();
            this.restockItemNumberKabek = new System.Windows.Forms.Label();
            this.qtyAdjustmentLabel = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.removeItemTextBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.shirtRadioBtn = new System.Windows.Forms.RadioButton();
            this.pantsRadioBtn = new System.Windows.Forms.RadioButton();
            this.otherRadioBtn = new System.Windows.Forms.RadioButton();
            this.clearEntryBtn = new System.Windows.Forms.Button();
            this.itemNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(53, 71);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Quantity";
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(105, 94);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(198, 20);
            this.colorTextBox.TabIndex = 3;
            // 
            // itemNumberTextBox
            // 
            this.itemNumberTextBox.Location = new System.Drawing.Point(105, 42);
            this.itemNumberTextBox.Name = "itemNumberTextBox";
            this.itemNumberTextBox.Size = new System.Drawing.Size(198, 20);
            this.itemNumberTextBox.TabIndex = 1;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(68, 97);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(31, 13);
            this.colorLabel.TabIndex = 9;
            this.colorLabel.Text = "Color";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(105, 68);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(198, 20);
            this.quantityTextBox.TabIndex = 2;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(72, 123);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(27, 13);
            this.sizeLabel.TabIndex = 11;
            this.sizeLabel.Text = "Size";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(105, 120);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(198, 20);
            this.sizeTextBox.TabIndex = 4;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(51, 149);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(48, 13);
            this.locationLabel.TabIndex = 13;
            this.locationLabel.Text = "Location";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(105, 146);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(198, 20);
            this.locationTextBox.TabIndex = 5;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(15, 293);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(593, 23);
            this.exitBtn.TabIndex = 19;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // currentInvBtn
            // 
            this.currentInvBtn.Location = new System.Drawing.Point(199, 204);
            this.currentInvBtn.Name = "currentInvBtn";
            this.currentInvBtn.Size = new System.Drawing.Size(104, 23);
            this.currentInvBtn.TabIndex = 11;
            this.currentInvBtn.Text = "Current Inventory";
            this.currentInvBtn.UseVisualStyleBackColor = true;
            this.currentInvBtn.Click += new System.EventHandler(this.currentInvBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(18, 261);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(104, 23);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchInputTextBox
            // 
            this.searchInputTextBox.Location = new System.Drawing.Point(128, 263);
            this.searchInputTextBox.Name = "searchInputTextBox";
            this.searchInputTextBox.Size = new System.Drawing.Size(321, 20);
            this.searchInputTextBox.TabIndex = 12;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(455, 266);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(153, 13);
            this.searchLabel.TabIndex = 22;
            this.searchLabel.Text = "Search by Item Number or Size";
            // 
            // restockBtn
            // 
            this.restockBtn.Location = new System.Drawing.Point(321, 43);
            this.restockBtn.Name = "restockBtn";
            this.restockBtn.Size = new System.Drawing.Size(75, 23);
            this.restockBtn.TabIndex = 16;
            this.restockBtn.Text = "Restock";
            this.restockBtn.UseVisualStyleBackColor = true;
            this.restockBtn.Click += new System.EventHandler(this.restockBtn_Click);
            // 
            // restockItemNumberTextInput
            // 
            this.restockItemNumberTextInput.Location = new System.Drawing.Point(402, 45);
            this.restockItemNumberTextInput.Name = "restockItemNumberTextInput";
            this.restockItemNumberTextInput.Size = new System.Drawing.Size(100, 20);
            this.restockItemNumberTextInput.TabIndex = 14;
            // 
            // qtyAdjustmentTextInput
            // 
            this.qtyAdjustmentTextInput.Location = new System.Drawing.Point(508, 45);
            this.qtyAdjustmentTextInput.Name = "qtyAdjustmentTextInput";
            this.qtyAdjustmentTextInput.Size = new System.Drawing.Size(100, 20);
            this.qtyAdjustmentTextInput.TabIndex = 15;
            // 
            // restockItemNumberKabek
            // 
            this.restockItemNumberKabek.AutoSize = true;
            this.restockItemNumberKabek.Location = new System.Drawing.Point(419, 29);
            this.restockItemNumberKabek.Name = "restockItemNumberKabek";
            this.restockItemNumberKabek.Size = new System.Drawing.Size(66, 13);
            this.restockItemNumberKabek.TabIndex = 26;
            this.restockItemNumberKabek.Text = "item Number";
            // 
            // qtyAdjustmentLabel
            // 
            this.qtyAdjustmentLabel.AutoSize = true;
            this.qtyAdjustmentLabel.Location = new System.Drawing.Point(529, 29);
            this.qtyAdjustmentLabel.Name = "qtyAdjustmentLabel";
            this.qtyAdjustmentLabel.Size = new System.Drawing.Size(58, 13);
            this.qtyAdjustmentLabel.TabIndex = 27;
            this.qtyAdjustmentLabel.Text = "Quantity + ";
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(321, 72);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 18;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // removeItemTextBox
            // 
            this.removeItemTextBox.Location = new System.Drawing.Point(402, 74);
            this.removeItemTextBox.Name = "removeItemTextBox";
            this.removeItemTextBox.Size = new System.Drawing.Size(100, 20);
            this.removeItemTextBox.TabIndex = 17;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(30, 204);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // shirtRadioBtn
            // 
            this.shirtRadioBtn.AutoSize = true;
            this.shirtRadioBtn.Location = new System.Drawing.Point(106, 172);
            this.shirtRadioBtn.Name = "shirtRadioBtn";
            this.shirtRadioBtn.Size = new System.Drawing.Size(46, 17);
            this.shirtRadioBtn.TabIndex = 6;
            this.shirtRadioBtn.TabStop = true;
            this.shirtRadioBtn.Text = "Shirt";
            this.shirtRadioBtn.UseVisualStyleBackColor = true;
            // 
            // pantsRadioBtn
            // 
            this.pantsRadioBtn.AutoSize = true;
            this.pantsRadioBtn.Location = new System.Drawing.Point(178, 172);
            this.pantsRadioBtn.Name = "pantsRadioBtn";
            this.pantsRadioBtn.Size = new System.Drawing.Size(52, 17);
            this.pantsRadioBtn.TabIndex = 7;
            this.pantsRadioBtn.TabStop = true;
            this.pantsRadioBtn.Text = "Pants";
            this.pantsRadioBtn.UseVisualStyleBackColor = true;
            // 
            // otherRadioBtn
            // 
            this.otherRadioBtn.AutoSize = true;
            this.otherRadioBtn.Location = new System.Drawing.Point(252, 172);
            this.otherRadioBtn.Name = "otherRadioBtn";
            this.otherRadioBtn.Size = new System.Drawing.Size(51, 17);
            this.otherRadioBtn.TabIndex = 8;
            this.otherRadioBtn.TabStop = true;
            this.otherRadioBtn.Text = "Other";
            this.otherRadioBtn.UseVisualStyleBackColor = true;
            // 
            // clearEntryBtn
            // 
            this.clearEntryBtn.Location = new System.Drawing.Point(115, 204);
            this.clearEntryBtn.Name = "clearEntryBtn";
            this.clearEntryBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clearEntryBtn.Size = new System.Drawing.Size(75, 23);
            this.clearEntryBtn.TabIndex = 10;
            this.clearEntryBtn.Text = "Clear";
            this.clearEntryBtn.UseVisualStyleBackColor = true;
            this.clearEntryBtn.Click += new System.EventHandler(this.clearEntryBtn_Click);
            // 
            // itemNumberLabel
            // 
            this.itemNumberLabel.AutoSize = true;
            this.itemNumberLabel.Location = new System.Drawing.Point(32, 45);
            this.itemNumberLabel.Name = "itemNumberLabel";
            this.itemNumberLabel.Size = new System.Drawing.Size(67, 13);
            this.itemNumberLabel.TabIndex = 28;
            this.itemNumberLabel.Text = "Item Number";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 327);
            this.Controls.Add(this.itemNumberLabel);
            this.Controls.Add(this.removeItemTextBox);
            this.Controls.Add(this.clearEntryBtn);
            this.Controls.Add(this.otherRadioBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.pantsRadioBtn);
            this.Controls.Add(this.qtyAdjustmentLabel);
            this.Controls.Add(this.shirtRadioBtn);
            this.Controls.Add(this.restockItemNumberKabek);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.qtyAdjustmentTextInput);
            this.Controls.Add(this.restockItemNumberTextInput);
            this.Controls.Add(this.restockBtn);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchInputTextBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.currentInvBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.itemNumberTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.colorTextBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox itemNumberTextBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button currentInvBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchInputTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button restockBtn;
        private System.Windows.Forms.TextBox restockItemNumberTextInput;
        private System.Windows.Forms.TextBox qtyAdjustmentTextInput;
        private System.Windows.Forms.Label restockItemNumberKabek;
        private System.Windows.Forms.Label qtyAdjustmentLabel;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.TextBox removeItemTextBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.RadioButton shirtRadioBtn;
        private System.Windows.Forms.RadioButton pantsRadioBtn;
        private System.Windows.Forms.RadioButton otherRadioBtn;
        private System.Windows.Forms.Button clearEntryBtn;
        private System.Windows.Forms.Label itemNumberLabel;
    }
}

