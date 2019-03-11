using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * All work is created and authored by Matt Sievers on 03/11/2019
 */

namespace Exercise8
{
    public partial class Form1 : Form
    {
        double fat;
        double carbs;
        double caloriesFromFat;
        double caloriesFromCarbs;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(fatInputTextBox.Text, out fat)) && (double.TryParse(carbsInputTextBox.Text, out carbs)))
            {
                FatCalories(fat);
                CarbCalories(carbs);
                MessageBox.Show("Fat Calories: " + caloriesFromFat + "\n"
               + "Carb Calories: " + caloriesFromCarbs);
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void FatCalories(double fat)
        {
            caloriesFromFat = fat * 9;
        }

        private void CarbCalories(double carbs)
        {
            caloriesFromCarbs = carbs * 4;
        }
    }
}
