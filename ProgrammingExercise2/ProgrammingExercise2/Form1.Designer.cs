namespace ProgrammingExercise2
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
            this.raceSelectionListBox = new System.Windows.Forms.ListBox();
            this.maleRadioBtn = new System.Windows.Forms.RadioButton();
            this.femaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.genderGrpBox = new System.Windows.Forms.GroupBox();
            this.weaponGrpBox = new System.Windows.Forms.GroupBox();
            this.noneCheckBox = new System.Windows.Forms.CheckBox();
            this.bowCheckBox = new System.Windows.Forms.CheckBox();
            this.characterResultsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
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
            // raceSelectionListBox
            // 
            this.raceSelectionListBox.FormattingEnabled = true;
            this.raceSelectionListBox.Items.AddRange(new object[] {
            "Human",
            "Elf",
            "Dwarf",
            "Gnome",
            "Teifling"});
            this.raceSelectionListBox.Location = new System.Drawing.Point(2, 23);
            this.raceSelectionListBox.Name = "raceSelectionListBox";
            this.raceSelectionListBox.Size = new System.Drawing.Size(200, 95);
            this.raceSelectionListBox.TabIndex = 1;
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
            this.weaponGrpBox.Size = new System.Drawing.Size(200, 95);
            this.weaponGrpBox.TabIndex = 7;
            this.weaponGrpBox.TabStop = false;
            this.weaponGrpBox.Text = "Weapon of Choice - Select only 1";
            this.weaponGrpBox.Enter += new System.EventHandler(this.weaponGrpBox_Enter);
            // 
            // noneCheckBox
            // 
            this.noneCheckBox.AutoSize = true;
            this.noneCheckBox.Location = new System.Drawing.Point(10, 68);
            this.noneCheckBox.Name = "noneCheckBox";
            this.noneCheckBox.Size = new System.Drawing.Size(55, 17);
            this.noneCheckBox.TabIndex = 1;
            this.noneCheckBox.Text = "None!";
            this.noneCheckBox.UseVisualStyleBackColor = true;
            // 
            // bowCheckBox
            // 
            this.bowCheckBox.AutoSize = true;
            this.bowCheckBox.Location = new System.Drawing.Point(10, 45);
            this.bowCheckBox.Name = "bowCheckBox";
            this.bowCheckBox.Size = new System.Drawing.Size(47, 17);
            this.bowCheckBox.TabIndex = 0;
            this.bowCheckBox.Text = "Bow";
            this.bowCheckBox.UseVisualStyleBackColor = true;
            // 
            // characterResultsRichTextBox
            // 
            this.characterResultsRichTextBox.Location = new System.Drawing.Point(280, 232);
            this.characterResultsRichTextBox.Name = "characterResultsRichTextBox";
            this.characterResultsRichTextBox.Size = new System.Drawing.Size(185, 66);
            this.characterResultsRichTextBox.TabIndex = 8;
            this.characterResultsRichTextBox.Text = "";
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(280, 318);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(75, 23);
            this.generateBtn.TabIndex = 9;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(390, 318);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 372);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.characterResultsRichTextBox);
            this.Controls.Add(this.femaleRadioBtn);
            this.Controls.Add(this.maleRadioBtn);
            this.Controls.Add(this.raceSelectionListBox);
            this.Controls.Add(this.genderGrpBox);
            this.Controls.Add(this.weaponGrpBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.weaponGrpBox.ResumeLayout(false);
            this.weaponGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox swordCheckBox;
        private System.Windows.Forms.ListBox raceSelectionListBox;
        private System.Windows.Forms.RadioButton maleRadioBtn;
        private System.Windows.Forms.RadioButton femaleRadioBtn;
        private System.Windows.Forms.GroupBox genderGrpBox;
        private System.Windows.Forms.GroupBox weaponGrpBox;
        private System.Windows.Forms.RichTextBox characterResultsRichTextBox;
        private System.Windows.Forms.CheckBox noneCheckBox;
        private System.Windows.Forms.CheckBox bowCheckBox;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}

