using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProject5
{
    public partial class MainForm : Form
    {
        AnswerForm answerForm = new AnswerForm();
        public MainForm()
        {
            InitializeComponent();
        }

        private void luckyBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(monthInputTextBox.Text) && !string.IsNullOrWhiteSpace(dayInputTextBox.Text))
            {
                int monthInput = int.Parse(monthInputTextBox.Text);
                int dayInput = int.Parse(dayInputTextBox.Text);
                double answer = CalculateAge(monthInput, dayInput);
                if(blueRadioBtn.Checked == true )
                {
                    answerForm.colorLabel.Text = "You have chosen Blue, proceed";
                }else 
                {
                    answerForm.colorLabel.Text = "You have chosen Green, you may pass!";
                }
                answerForm.answerlabel.Text = answer.ToString("n2");
                answerForm.ShowDialog();
            }else
            {
                MessageBox.Show("Input left blank" + "\n" + "Data needed for both boxes");
            }
           
        }

        private double CalculateAge(int monthInput, int dayInput)
        {
            int baseNumber = 7;
            int equation1 = (baseNumber * monthInput);
            int equation2 = equation1 - 1;
            int equation3 = equation2 * 13;
            int equation4 = equation3 + dayInput;
            int equation5 = equation4 + 3;
            int equation6 = equation5 * 11;
            int equation7 = equation6 - monthInput;
            int equation8 = equation7 - dayInput;
            double equation9 = equation8 / 10;
            double equation10 = equation9 + 11;
            double equation11 = equation10 / 100;
            return equation11;
        }

        private void mainFormExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
