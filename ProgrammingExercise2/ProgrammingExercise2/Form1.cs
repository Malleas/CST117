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
        String race;
        String weapon = "";
        String output;
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
            if(raceSelectionListBox.SelectedIndex != -1)
            {
                race = raceSelectionListBox.SelectedItem.ToString();
                output += "You've chosen to be a " + race + "\n";
            }
            else
            {
                MessageBox.Show("Please select a race for your hero");
            }

            if(femaleRadioBtn.Checked || maleRadioBtn.Checked != false)
            {
                if (femaleRadioBtn.Checked == true)
                {
                    genderType = "Female";
                }
                else
                {
                    genderType = "Male";
                }
                output += "who is " + genderType + "\n";
            }
            else
            {
                MessageBox.Show("Please select a gender");
            }


            Boolean isChecked = (swordCheckBox.Checked || bowCheckBox.Checked || noneCheckBox.Checked);
            if(isChecked == true)
            {
                if((swordCheckBox.Checked || bowCheckBox.Checked != false) && noneCheckBox.Checked == true)
                {
                    weapon = "Magic";
                }
                else if (swordCheckBox.Checked & bowCheckBox.Checked == true)
                {
                    weapon = "Sword and Bow";
                }
                else  if (swordCheckBox.Checked == true)
                {
                    weapon = "Sword";
                }

                else if (bowCheckBox.Checked == true)
                {
                    weapon = "Bow";
                }
                else if (noneCheckBox.Checked == true)
                {
                    weapon = "Magic";
                }
                output += "and your weapon of choice is: " + weapon + "\n";
            }
            else
            {
                MessageBox.Show("Please select only a weapon");
            }


            characterResultsRichTextBox.Text = output;
        }

        private void maleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void weaponGrpBox_Enter(object sender, EventArgs e)
        {
         
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            characterResultsRichTextBox.Text = "";
            output = "";
        }
    }
}
