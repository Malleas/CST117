using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise7
{
    public partial class Form1 : Form
    {
        int sum;
        int randomSum;
        int randomNum1, randomNum2;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int input1, input2;
            if((int.TryParse(sumInput1.Text, out input1)) && (int.TryParse(sumInput2.Text, out input2)))
            {
                SumTwoInts(input1, input2);
                sumResultLabel.Text = "The sume of " + input1 + " and " + input2 + " is " + sum.ToString();
            }
            else
            {
                ErrMsg();
            }
        }
        private void avgBtn_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, num4, num5;
            if(
                (double.TryParse(dbl1InputTextBox.Text, out num1)) &&
                (double.TryParse(dbl2InputTextBox.Text, out num2)) &&
                (double.TryParse(dbl3InputTextBox.Text, out num3)) &&
                (double.TryParse(dbl4InputTextBox.Text, out num4)) &&
                (double.TryParse(dbl5InputTextBox.Text, out num5)))
            {
                double results = AverageOfFiveDoubles(num1, num2, num3, num4, num5);
                dblAvgResultLabel.Text = "The average of " + num1 + " " + num2 + " " + num3 + " " + num4 + " " + num5 +  " is " + results.ToString("n2");
            }
            else
            {
                ErrMsg(); 
            }
        }
        private void calculateRndBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            randomNum1 = rnd.Next(100);
            randomNum2 = rnd.Next(100);
            SumTwoInts(randomNum1, randomNum2);
            rndSumResultsLabel.Text = "The sume of " + randomNum1 + " and " + randomNum2 + " is " + sum.ToString();
        }
        private void divideBy3Btn_Click(object sender, EventArgs e)
        {
            int input1, input2, input3;
            if(
                (int.TryParse(devideTextBox1.Text, out input1)) &&
                (int.TryParse(devideTextBox2.Text, out input2)) &&
                (int.TryParse(devideTextBox3.Text, out input3)))
            {
                bool results = IsDivisibleBy3(input1, input2, input3);
                if (results == true)
                {
                    devideByThreeResultsLabel.Text = "True";
                }
                else
                {
                    devideByThreeResultsLabel.Text = "False";
                }
            }
            else
            {
                ErrMsg();
            }
        }
        private void shortestStringBtn_Click(object sender, EventArgs e)
        {
            
           string results = IsSmallerString(strInput1TextBox.Text, strInput2TextBox.Text);
            shortestStringResultLabel.Text = results;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double input1, input2;
            if((double.TryParse(largeDblInput1TextBox.Text, out input1)) && (double.TryParse(largeDblInput2TextBox.Text, out input2)))
            {

                double results = IsLargestInArray(input1, input2);
                largeDblResultsLabel.Text = results.ToString();
            }
        }
        private void clrBtn_Click(object sender, EventArgs e)
        {
            sumInput1.Text = "";
            sumInput2.Text = "";
            sumResultLabel.Text = "";
            dbl1InputTextBox.Text = "";
            dbl2InputTextBox.Text = "";
            dbl3InputTextBox.Text = "";
            dbl4InputTextBox.Text = "";
            dbl5InputTextBox.Text = "";
            dblAvgResultLabel.Text = "";
            rndSumResultsLabel.Text = "";
            devideTextBox1.Text = "";
            devideTextBox2.Text = "";
            devideTextBox3.Text = "";
            devideByThreeResultsLabel.Text = "";
            strInput1TextBox.Text = "";
            strInput2TextBox.Text = "";
            shortestStringResultLabel.Text = "";

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /**
         * methods
         */

        public void ErrMsg()
        {
            MessageBox.Show("Invalid Input");
        }

        public void SumTwoInts(int num1, int num2)
        {
            sum = num1 + num2;
            randomSum = randomNum1 + randomNum2;
            
        }

        public double AverageOfFiveDoubles(double num1, double num2, double num3, double num4, double num5)
        {
            double average = (num1 + num2 + num3 + num4 + num5) / 5;
            return average;
        }

        public bool IsDivisibleBy3(int num1, int num2, int num3)
        {
            if((num1+num2+num3) % 3  == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string IsSmallerString(string string1, string string2)
        {
            if(string1.Length < string2.Length)
            {
                return string1;
            }
            else
            {
                return string2;
            }
        }

       
        public double IsLargestInArray(double input)
        {
            double[] doubleArray = new double[2];
            double largestDouble = 0;
            foreach(double index in doubleArray)
            {
                if(index >= largestDouble)
                {
                    largestDouble = index;
                }
                
            }
            return largestDouble;
        }
       

       
    }
}
