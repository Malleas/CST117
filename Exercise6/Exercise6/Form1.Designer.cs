﻿namespace Exercise6
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
            this.rollDiceBtn = new System.Windows.Forms.Button();
            this.diceBox1 = new System.Windows.Forms.RichTextBox();
            this.diceBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rollDiceBtn
            // 
            this.rollDiceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollDiceBtn.Location = new System.Drawing.Point(12, 40);
            this.rollDiceBtn.Name = "rollDiceBtn";
            this.rollDiceBtn.Size = new System.Drawing.Size(140, 145);
            this.rollDiceBtn.TabIndex = 0;
            this.rollDiceBtn.Text = "Roll Dice!";
            this.rollDiceBtn.UseVisualStyleBackColor = true;
            this.rollDiceBtn.Click += new System.EventHandler(this.rollDiceBtn_Click);
            // 
            // diceBox1
            // 
            this.diceBox1.BackColor = System.Drawing.Color.Black;
            this.diceBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diceBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceBox1.ForeColor = System.Drawing.Color.White;
            this.diceBox1.Location = new System.Drawing.Point(172, 59);
            this.diceBox1.Name = "diceBox1";
            this.diceBox1.Size = new System.Drawing.Size(100, 96);
            this.diceBox1.TabIndex = 3;
            this.diceBox1.Text = "";
            // 
            // diceBox2
            // 
            this.diceBox2.BackColor = System.Drawing.Color.Black;
            this.diceBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diceBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceBox2.ForeColor = System.Drawing.Color.White;
            this.diceBox2.Location = new System.Drawing.Point(292, 59);
            this.diceBox2.Name = "diceBox2";
            this.diceBox2.Size = new System.Drawing.Size(100, 96);
            this.diceBox2.TabIndex = 4;
            this.diceBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.diceBox2);
            this.Controls.Add(this.diceBox1);
            this.Controls.Add(this.rollDiceBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rollDiceBtn;
        private System.Windows.Forms.RichTextBox diceBox1;
        private System.Windows.Forms.RichTextBox diceBox2;
    }
}

