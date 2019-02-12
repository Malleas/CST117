using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1Assignment3
{
    public partial class CalculateAreaOfACircle : Form
    {
        
        public CalculateAreaOfACircle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculatedAreaOutputBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void calculateRadiusBtn_Click(object sender, EventArgs e)
        {
            double radius;
            double area;
            radius = double.Parse(radiusInputBox.Text);
            area = (Math.PI * (radius * radius));
            calculatedAreaOutputBox.Text = area.ToString();
        }
    }
}
