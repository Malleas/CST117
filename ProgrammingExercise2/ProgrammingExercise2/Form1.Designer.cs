﻿namespace ProgrammingExercise2
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
            this.swordCheckBox = new System.Windows.Forms.CheckBox();
            this.shapeSelectionListBox = new System.Windows.Forms.ListBox();
            this.maleRadioBtn = new System.Windows.Forms.RadioButton();
            this.axeCheckBox = new System.Windows.Forms.CheckBox();
            this.femaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.genderGrpBox = new System.Windows.Forms.GroupBox();
            this.weaponGrpBox = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bowCheckBox = new System.Windows.Forms.CheckBox();
            this.noneCheckBox = new System.Windows.Forms.CheckBox();
            this.generateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.weaponGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // swordCheckBox
            // 
            this.swordCheckBox.AutoSize = true;
            this.swordCheckBox.Location = new System.Drawing.Point(10, 22);
            this.swordCheckBox.Name = "swordCheckBox";
            this.swordCheckBox.Size = new System.Drawing.Size(56, 17);
            this.swordCheckBox.TabIndex = 0;
            this.swordCheckBox.Text = "Sword";
            this.swordCheckBox.UseVisualStyleBackColor = true;
            // 
            // shapeSelectionListBox
            // 
            this.shapeSelectionListBox.FormattingEnabled = true;
            this.shapeSelectionListBox.Items.AddRange(new object[] {
            "Human",
            "Elf",
            "Dwarf",
            "Gnome",
            "Teifling"});
            this.shapeSelectionListBox.Location = new System.Drawing.Point(2, 23);
            this.shapeSelectionListBox.Name = "shapeSelectionListBox";
            this.shapeSelectionListBox.Size = new System.Drawing.Size(200, 95);
            this.shapeSelectionListBox.TabIndex = 1;
            // 
            // maleRadioBtn
            // 
            this.maleRadioBtn.AutoSize = true;
            this.maleRadioBtn.Location = new System.Drawing.Point(12, 159);
            this.maleRadioBtn.Name = "maleRadioBtn";
            this.maleRadioBtn.Size = new System.Drawing.Size(48, 17);
            this.maleRadioBtn.TabIndex = 2;
            this.maleRadioBtn.TabStop = true;
            this.maleRadioBtn.Text = "Male";
            this.maleRadioBtn.UseVisualStyleBackColor = true;
            this.maleRadioBtn.CheckedChanged += new System.EventHandler(this.maleRadioBtn_CheckedChanged);
            // 
            // axeCheckBox
            // 
            this.axeCheckBox.AutoSize = true;
            this.axeCheckBox.Location = new System.Drawing.Point(12, 277);
            this.axeCheckBox.Name = "axeCheckBox";
            this.axeCheckBox.Size = new System.Drawing.Size(44, 17);
            this.axeCheckBox.TabIndex = 3;
            this.axeCheckBox.Text = "Axe";
            this.axeCheckBox.UseVisualStyleBackColor = true;
            // 
            // femaleRadioBtn
            // 
            this.femaleRadioBtn.AutoSize = true;
            this.femaleRadioBtn.Location = new System.Drawing.Point(12, 182);
            this.femaleRadioBtn.Name = "femaleRadioBtn";
            this.femaleRadioBtn.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioBtn.TabIndex = 4;
            this.femaleRadioBtn.TabStop = true;
            this.femaleRadioBtn.Text = "Female";
            this.femaleRadioBtn.UseVisualStyleBackColor = true;
            this.femaleRadioBtn.CheckedChanged += new System.EventHandler(this.femaleRadioBtn_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(236, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 203);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // genderGrpBox
            // 
            this.genderGrpBox.Location = new System.Drawing.Point(2, 134);
            this.genderGrpBox.Name = "genderGrpBox";
            this.genderGrpBox.Size = new System.Drawing.Size(200, 79);
            this.genderGrpBox.TabIndex = 6;
            this.genderGrpBox.TabStop = false;
            this.genderGrpBox.Text = "Gender";
            // 
            // weaponGrpBox
            // 
            this.weaponGrpBox.Controls.Add(this.noneCheckBox);
            this.weaponGrpBox.Controls.Add(this.bowCheckBox);
            this.weaponGrpBox.Controls.Add(this.swordCheckBox);
            this.weaponGrpBox.Location = new System.Drawing.Point(2, 232);
            this.weaponGrpBox.Name = "weaponGrpBox";
            this.weaponGrpBox.Size = new System.Drawing.Size(200, 114);
            this.weaponGrpBox.TabIndex = 7;
            this.weaponGrpBox.TabStop = false;
            this.weaponGrpBox.Text = "Weapon of Choice";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(280, 232);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(185, 66);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // bowCheckBox
            // 
            this.bowCheckBox.AutoSize = true;
            this.bowCheckBox.Location = new System.Drawing.Point(10, 68);
            this.bowCheckBox.Name = "bowCheckBox";
            this.bowCheckBox.Size = new System.Drawing.Size(47, 17);
            this.bowCheckBox.TabIndex = 0;
            this.bowCheckBox.Text = "Bow";
            this.bowCheckBox.UseVisualStyleBackColor = true;
            // 
            // noneCheckBox
            // 
            this.noneCheckBox.AutoSize = true;
            this.noneCheckBox.Location = new System.Drawing.Point(10, 91);
            this.noneCheckBox.Name = "noneCheckBox";
            this.noneCheckBox.Size = new System.Drawing.Size(55, 17);
            this.noneCheckBox.TabIndex = 1;
            this.noneCheckBox.Text = "None!";
            this.noneCheckBox.UseVisualStyleBackColor = true;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(331, 323);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(75, 23);
            this.generateBtn.TabIndex = 9;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 372);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.femaleRadioBtn);
            this.Controls.Add(this.axeCheckBox);
            this.Controls.Add(this.maleRadioBtn);
            this.Controls.Add(this.shapeSelectionListBox);
            this.Controls.Add(this.genderGrpBox);
            this.Controls.Add(this.weaponGrpBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.weaponGrpBox.ResumeLayout(false);
            this.weaponGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox swordCheckBox;
        private System.Windows.Forms.ListBox shapeSelectionListBox;
        private System.Windows.Forms.RadioButton maleRadioBtn;
        private System.Windows.Forms.CheckBox axeCheckBox;
        private System.Windows.Forms.RadioButton femaleRadioBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox genderGrpBox;
        private System.Windows.Forms.GroupBox weaponGrpBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox noneCheckBox;
        private System.Windows.Forms.CheckBox bowCheckBox;
        private System.Windows.Forms.Button generateBtn;
    }
}

