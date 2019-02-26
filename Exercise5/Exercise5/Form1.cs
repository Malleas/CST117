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
            int terms = int.Parse(termsTextBox.Text);
            
            int constant = 4;
           
            
            int i; 
            for (i = 1; i < terms; i++)
            {
                int currentIndex = i;
                double piValue = 0;
                double negativeInput = 0;
                double positiveInput = 0;
                if (currentIndex % 2 != 0)
                {
                    negativeInput = constant / (currentIndex + 2);
                    MessageBox.Show(negativeInput.ToString("n5"));
                    piValue -= negativeInput;
                    MessageBox.Show(piValue.ToString("n10"));
                }
                else
                {
                    positiveInput = constant / ((currentIndex / currentIndex) + currentIndex);
                    piValue += positiveInput;
                    
                }
                
                
                
                //piValueLabel.Text =foo.ToString();
                
               
            }
            apxValueOfPiLabel.Text = ("Approximate value of Pi after " + terms + " terms is: ");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            termsTextBox.Text = "";
            piValueLabel.Text = "";
        }

        private void blahBtn_Click(object sender, EventArgs e)
        {
            float foo = (4 - 4/3 + 4/5 - 4/7 + 4/9);
            decimal bar = 4 - 4 / 3;
            piValueLabel.Text = bar.ToString("n5");
        }
    }
}
