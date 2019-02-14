using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            String firstName = firstNameTextBox.Text;
            String lastName = lastNameTextBox.Text;
            String email = emailTextBox.Text;
            int age = int.Parse(ageTextBox.Text);
            int dateOfBirthMonth = int.Parse(dobMonthBox.Text);
            int dateOfBirthDay = int.Parse(dobDayBox.Text);
            int dateOfBirthYear = int.Parse(dobYearBox.Text);
            String userId = Guid.NewGuid().ToString();
            MessageBox.Show("Your name is: " + firstName + " " + lastName + "\n" +
                "Your Date of birth is: " + dateOfBirthMonth + "-" + dateOfBirthDay + "-" + dateOfBirthYear + "\n" +
                "Your User ID is: " + userId);
        }
    }
}
