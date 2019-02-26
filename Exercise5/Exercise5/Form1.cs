using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise5
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int terms; //User entry and the length of the for loop
            if (int.TryParse(termsTextBox.Text, out terms))
            {
                double constant = 4; //constant used for the equation, all parts are 4/n
                double piValue = 0; //starting value of PI
                int count = 1; //Count to keep track of n to increment it through the loop
                int i;
                for (i = 0; i < terms; i++)
                {
                    if (i % 2 == 0)//check if value is even
                    {
                        piValue += constant / (i + count);
                    }
                    else
                    {
                        piValue -= constant / (i + count);
                    }
                    count++;
                }
                apxValueOfPiLabel.Text = ("Approximate value of Pi after " + terms + " terms is: ");
                piValueLabel.Text = piValue.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Entry" + "\n" + "Please use numbers only");
            }
        }
           

        private void button1_Click(object sender, EventArgs e)
        {
            termsTextBox.Text = "";
            piValueLabel.Text = "";
        }
    }
}
