﻿namespace Milestone_2
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
            this.addBtn = new System.Windows.Forms.Button();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.clearEntryBtn = new System.Windows.Forms.Button();
            this.otherRadioBtn = new System.Windows.Forms.RadioButton();
            this.pantsRadioBtn = new System.Windows.Forms.RadioButton();
            this.shirtRadioBtn = new System.Windows.Forms.RadioButton();
            this.selectItemGroupBox = new System.Windows.Forms.GroupBox();
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.currentInvBtn = new System.Windows.Forms.Button();
            this.itemNumberLabel = new System.Windows.Forms.Label();
            this.inputGroupBox.SuspendLayout();
            this.selectItemGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(33, 106);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Quantity";
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(85, 129);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(198, 20);
            this.colorTextBox.TabIndex = 4;
            // 
            // itemNumberTextBox
            // 
            this.itemNumberTextBox.Location = new System.Drawing.Point(85, 77);
            this.itemNumberTextBox.Name = "itemNumberTextBox";
            this.itemNumberTextBox.Size = new System.Drawing.Size(198, 20);
            this.itemNumberTextBox.TabIndex = 6;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(48, 132);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(31, 13);
            this.colorLabel.TabIndex = 9;
            this.colorLabel.Text = "Color";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(85, 103);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(198, 20);
            this.quantityTextBox.TabIndex = 8;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(52, 158);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(27, 13);
            this.sizeLabel.TabIndex = 11;
            this.sizeLabel.Text = "Size";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(85, 155);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(198, 20);
            this.sizeTextBox.TabIndex = 10;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(31, 184);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(48, 13);
            this.locationLabel.TabIndex = 13;
            this.locationLabel.Text = "Location";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(85, 181);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(198, 20);
            this.locationTextBox.TabIndex = 12;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(205, 182);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 15;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.itemNumberLabel);
            this.inputGroupBox.Controls.Add(this.clearEntryBtn);
            this.inputGroupBox.Controls.Add(this.otherRadioBtn);
            this.inputGroupBox.Controls.Add(this.pantsRadioBtn);
            this.inputGroupBox.Controls.Add(this.shirtRadioBtn);
            this.inputGroupBox.Controls.Add(this.addBtn);
            this.inputGroupBox.Location = new System.Drawing.Point(3, 59);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(297, 234);
            this.inputGroupBox.TabIndex = 17;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Enter New Inventory Item";
            // 
            // clearEntryBtn
            // 
            this.clearEntryBtn.Location = new System.Drawing.Point(82, 182);
            this.clearEntryBtn.Name = "clearEntryBtn";
            this.clearEntryBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clearEntryBtn.Size = new System.Drawing.Size(75, 23);
            this.clearEntryBtn.TabIndex = 19;
            this.clearEntryBtn.Text = "Clean";
            this.clearEntryBtn.UseVisualStyleBackColor = true;
            this.clearEntryBtn.Click += new System.EventHandler(this.clearEntryBtn_Click);
            // 
            // otherRadioBtn
            // 
            this.otherRadioBtn.AutoSize = true;
            this.otherRadioBtn.Location = new System.Drawing.Point(228, 148);
            this.otherRadioBtn.Name = "otherRadioBtn";
            this.otherRadioBtn.Size = new System.Drawing.Size(51, 17);
            this.otherRadioBtn.TabIndex = 20;
            this.otherRadioBtn.TabStop = true;
            this.otherRadioBtn.Text = "Other";
            this.otherRadioBtn.UseVisualStyleBackColor = true;
            // 
            // pantsRadioBtn
            // 
            this.pantsRadioBtn.AutoSize = true;
            this.pantsRadioBtn.Location = new System.Drawing.Point(154, 148);
            this.pantsRadioBtn.Name = "pantsRadioBtn";
            this.pantsRadioBtn.Size = new System.Drawing.Size(52, 17);
            this.pantsRadioBtn.TabIndex = 18;
            this.pantsRadioBtn.TabStop = true;
            this.pantsRadioBtn.Text = "Pants";
            this.pantsRadioBtn.UseVisualStyleBackColor = true;
            // 
            // shirtRadioBtn
            // 
            this.shirtRadioBtn.AutoSize = true;
            this.shirtRadioBtn.Location = new System.Drawing.Point(82, 148);
            this.shirtRadioBtn.Name = "shirtRadioBtn";
            this.shirtRadioBtn.Size = new System.Drawing.Size(46, 17);
            this.shirtRadioBtn.TabIndex = 19;
            this.shirtRadioBtn.TabStop = true;
            this.shirtRadioBtn.Text = "Shirt";
            this.shirtRadioBtn.UseVisualStyleBackColor = true;
            // 
            // selectItemGroupBox
            // 
            this.selectItemGroupBox.Controls.Add(this.inventoryListBox);
            this.selectItemGroupBox.Location = new System.Drawing.Point(306, 59);
            this.selectItemGroupBox.Name = "selectItemGroupBox";
            this.selectItemGroupBox.Size = new System.Drawing.Size(265, 234);
            this.selectItemGroupBox.TabIndex = 0;
            this.selectItemGroupBox.TabStop = false;
            this.selectItemGroupBox.Text = "Select Item";
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.Location = new System.Drawing.Point(6, 18);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(241, 186);
            this.inventoryListBox.TabIndex = 18;
            this.inventoryListBox.SelectedIndexChanged += new System.EventHandler(this.inventoryListBox_SelectedIndexChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(264, 299);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 18;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // currentInvBtn
            // 
            this.currentInvBtn.Location = new System.Drawing.Point(85, 331);
            this.currentInvBtn.Name = "currentInvBtn";
            this.currentInvBtn.Size = new System.Drawing.Size(104, 23);
            this.currentInvBtn.TabIndex = 19;
            this.currentInvBtn.Text = "Current Inventory";
            this.currentInvBtn.UseVisualStyleBackColor = true;
            this.currentInvBtn.Click += new System.EventHandler(this.currentInvBtn_Click);
            // 
            // itemNumberLabel
            // 
            this.itemNumberLabel.AutoSize = true;
            this.itemNumberLabel.Location = new System.Drawing.Point(9, 21);
            this.itemNumberLabel.Name = "itemNumberLabel";
            this.itemNumberLabel.Size = new System.Drawing.Size(67, 13);
            this.itemNumberLabel.TabIndex = 20;
            this.itemNumberLabel.Text = "Item Number";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 419);
            this.Controls.Add(this.currentInvBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.selectItemGroupBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.itemNumberTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.inputGroupBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.selectItemGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.GroupBox selectItemGroupBox;
        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.RadioButton pantsRadioBtn;
        private System.Windows.Forms.RadioButton shirtRadioBtn;
        private System.Windows.Forms.RadioButton otherRadioBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button clearEntryBtn;
        private System.Windows.Forms.Label itemNumberLabel;
        private System.Windows.Forms.Button currentInvBtn;
    }
}

