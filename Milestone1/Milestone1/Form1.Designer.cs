namespace Milestone1
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.dobMonthBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.dobDayBox = new System.Windows.Forms.TextBox();
            this.dobYearBox = new System.Windows.Forms.TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.createUserBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(20, 59);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(12, 163);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(65, 13);
            this.dobLabel.TabIndex = 1;
            this.dobLabel.Text = "Date of brith";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(45, 111);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(19, 85);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(51, 137);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "Age";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(83, 52);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // dobMonthBox
            // 
            this.dobMonthBox.Location = new System.Drawing.Point(83, 156);
            this.dobMonthBox.Name = "dobMonthBox";
            this.dobMonthBox.Size = new System.Drawing.Size(30, 20);
            this.dobMonthBox.TabIndex = 8;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(83, 130);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(30, 20);
            this.ageTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(83, 104);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 10;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(83, 78);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 11;
            // 
            // dobDayBox
            // 
            this.dobDayBox.Location = new System.Drawing.Point(118, 156);
            this.dobDayBox.Name = "dobDayBox";
            this.dobDayBox.Size = new System.Drawing.Size(30, 20);
            this.dobDayBox.TabIndex = 12;
            // 
            // dobYearBox
            // 
            this.dobYearBox.Location = new System.Drawing.Point(153, 156);
            this.dobYearBox.Name = "dobYearBox";
            this.dobYearBox.Size = new System.Drawing.Size(30, 20);
            this.dobYearBox.TabIndex = 13;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(43, 20);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(129, 29);
            this.welcomeLabel.TabIndex = 14;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // createUserBtn
            // 
            this.createUserBtn.Location = new System.Drawing.Point(108, 182);
            this.createUserBtn.Name = "createUserBtn";
            this.createUserBtn.Size = new System.Drawing.Size(75, 23);
            this.createUserBtn.TabIndex = 15;
            this.createUserBtn.Text = "Create User";
            this.createUserBtn.UseVisualStyleBackColor = true;
            this.createUserBtn.Click += new System.EventHandler(this.createUserBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 230);
            this.Controls.Add(this.createUserBtn);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.dobYearBox);
            this.Controls.Add(this.dobDayBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.dobMonthBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox dobMonthBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox dobDayBox;
        private System.Windows.Forms.TextBox dobYearBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button createUserBtn;
    }
}

