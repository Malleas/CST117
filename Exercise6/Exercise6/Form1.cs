using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Exercise6
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

        private void rollDiceBtn_Click(object sender, EventArgs e)
        {
            Dice dice1 = new Dice();
            Dice dice2 = new Dice();
            int rollOfDice1;
            int rollOfDice2;
            int counter = 0;
            do
            {
                dice1.Roll();
                rollOfDice1 = dice1.getSideUp();
                dice2.Roll();
                rollOfDice2 = dice2.getSideUp();
                counter++;
            } while ((rollOfDice1 != 1) && (rollOfDice2 != 1));

            diceRoll1Label.Text = rollOfDice1.ToString();
            diceRoll2Label.Text = rollOfDice2.ToString();

            MessageBox.Show("It took " + counter.ToString() + " rolls to roll snake eyes!");


        }


    }
}
