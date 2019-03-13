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
                double[] doubleArray = new double[2];
                doubleArray[0] = input1;
                doubleArray[1] = input2;
                double results = IsLargestInArray(doubleArray);
                largeDblResultsLabel.Text = "The largest Double in the array is: " + results.ToString();
            }
            else
            {
                ErrMsg();
            }
        }
        private void _50RandomIntsBtn_Click(object sender, EventArgs e)
        {
            string results = _50RandomInts();
            _50RandomIntsResultsRichTextBox.Text = results;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bool input1, input2;
            if((bool.TryParse(boolValueInput1TextBox.Text, out input1)) && (bool.TryParse(boolValueInput2TextBox.Text, out input2))){
                bool results = CompareValues(input1, input2);
                boolValueResultsLabel.Text = results.ToString();
            }
            else
            {
                ErrMsg();
            }
            
        }
        private void intAndDblCalculateBtn_Click(object sender, EventArgs e)
        {
            int intInput;
            double dblInput;
            if((int.TryParse(_intInputTextBox.Text, out intInput)) && (double.TryParse(_dblInputTextBox.Text, out dblInput))){
                string results = SumofIntAndDouble(intInput, dblInput);
                intAndDblSumResultLabel.Text = "The sum of int " + intInput + " and double " + dblInput + "\n" + " is " + results;
            }
        }
        private void _2DarrayCalcBtn_Click(object sender, EventArgs e)
        {
            int[,] intArray = new int[3, 2] { {15,3}, {7,2}, {102, 18} };
            string results = _2DArrayAverageCalc(intArray);
            _2dArrayResultsLabel.Text = "The average of the 2d array is: " + results;
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
            largeDblInput1.Text = "";
            largeDblInput2.Text = "";
            largeDblResultsLabel.Text = "";
            _50RandomIntsResultsRichTextBox.Text = "";
            boolValueInput1TextBox.Text = "";
            boolValueInput2TextBox.Text = "";
            boolValueResultsLabel.Text = "";
            _2dArrayResultsLabel.Text = "";

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

       
        public double IsLargestInArray(double[] doubleArray)
        {
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

        public string _50RandomInts()
        {
            Random rand = new Random();
            int[] intArray = new int[50];
            StringBuilder sb = new StringBuilder();
            string results = "";
            for(int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rand.Next(500);
                int currentValue = intArray[i];
                sb.Append(currentValue + ", ");

            }
            return sb.ToString(); ;
        }

        public bool CompareValues(bool value1, bool value2)
        {
            bool input1 = value1;
            bool input2 = value2;
            if(input1 && input2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string SumofIntAndDouble(int intInput, double dblInput)
        {
            string sum = (intInput + dblInput).ToString("n2");
            return sum;
        }

        public string _2DArrayAverageCalc(int[,] intArray)
        {
            double totalAverage = 0;
            double total = 0;
            for(int i = 0; i < intArray.GetLength(0); i++)
            {
                for(int j = 0; j < intArray.GetLength(1); j++)
                {
                    total += intArray[i, j];
                    totalAverage = total / 6;
                }
            }
            return totalAverage.ToString("n2");
        }

       
    }
}
