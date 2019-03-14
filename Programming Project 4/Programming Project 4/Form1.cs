using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Project_4
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            int COLS = 3;
            int ROWS = 3;
            string TL = "";
            string TC = "";
            string TR = "";
            string CL = "";
            string CC = "";
            string CR = "";
            string BL = "";
            string BC = "";
            string BR = "";
            int[,] gameboard = new int[COLS, ROWS];
            Random rand = new Random();
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    gameboard[i, j] = rand.Next(1); 
                }
            }
            TL = gameboard[0,0].ToString();
            TC = gameboard[0,1].ToString();
            TR = gameboard[0,2].ToString();
            CL = gameboard[1,0].ToString();
            CC = gameboard[1,1].ToString();
            CR = gameboard[1,2].ToString();
            BL = gameboard[2,0].ToString();
            BC = gameboard[2,1].ToString();
            BR = gameboard[2,2].ToString();
            topLeftLabel.Text = TL;
            topCenterLabel.Text = TC;
            topRightLabel.Text = TR;
            centerLeftLabel.Text = CL;
            centerCenterLabel.Text = CC;
            centerRightLabel.Text = CR;
            bottomLeftlabel.Text = BL;
            bottomCenterLabel.Text = BC;
            bottomRightLabel.Text = BR;


        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string CheckValue(int[,] boardLocation)
        {
            string O = "O";
            string X = "X";
            string value = boardLocation.ToString();
            if(value == "0")
            {
                return O;
            }
            return X;
        }
    }
}
