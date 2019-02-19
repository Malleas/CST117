using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateValueBtn_Click(object sender, EventArgs e)
        {
            double input;
           if (double.TryParse(enterValueTextBox.Text, out input)){

                if (input >= 60 && input <= 3599)
                {
                    double convertSecondsToMins = (input / 60);
                    convertedSecondsTextBox.Text = convertSecondsToMins.ToString("n2");
                    unitOfMeasureOutputTextBox.Text = "Mins";
                }
                else if (input >= 3600 && input <= 86399)
                {
                    double convertedSecondsToHours = ((input / 60) / 60);
                    convertedSecondsTextBox.Text = convertedSecondsToHours.ToString("n2");
                    unitOfMeasureOutputTextBox.Text = "Hours";
                }
                else if (input >= 86400)
                {
                    double convertedSecondsToDays = (((input / 24) / 60) / 60);
                    convertedSecondsTextBox.Text = convertedSecondsToDays.ToString("n2");
                    unitOfMeasureOutputTextBox.Text = "Days";
                }
                else if (input < 60)
                {
                    convertedSecondsTextBox.Text = input.ToString("n2");
                    unitOfMeasureOutputTextBox.Text = "Seconds";
                }

            }
            else
            {
                MessageBox.Show("Enter a valid value");
            }
           

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            enterValueTextBox.Text = "";
            convertedSecondsTextBox.Text = "";
            unitOfMeasureOutputTextBox.Text = "";
        }
    }
}
