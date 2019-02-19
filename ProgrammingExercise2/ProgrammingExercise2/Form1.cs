using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingExercise2
{
    public partial class Form1 : Form
    {
        String genderType;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void femaleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if(femaleRadioBtn.Checked == true)
            {
                genderType = "Female";
            }
            else
            {
                genderType = "Male";
            }

            richTextBox1.Text = "Your choice in gender is: " + genderType;
        }

        private void maleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            genderType = "Male";
        }
    }
}
