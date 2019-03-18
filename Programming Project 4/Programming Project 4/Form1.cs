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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        { 
            int COLS = 3;
            int ROWS = 3;
            string[,] gameboard = new string[COLS, ROWS];
            Random rand = new Random();
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    int currentValue = rand.Next(2);
                    if (currentValue == 0)
                    {
                        gameboard[i, j] = "O";
                    }
                    else
                    {
                        gameboard[i, j] = "X";
                    }

                }
            } 
            string TL = gameboard[0,0];
            string TC = gameboard[0,1];
            string TR = gameboard[0,2];
            string CL = gameboard[1,0];
            string CC = gameboard[1,1];
            string CR = gameboard[1,2];
            string BL = gameboard[2,0];
            string BC = gameboard[2,1];
            string BR = gameboard[2,2];
            topLeftLabel.Text = TL;
            topCenterLabel.Text = TC;
            topRightLabel.Text = TR;
            centerLeftLabel.Text = CL;
            centerCenterLabel.Text = CC;
            centerRightLabel.Text = CR;
            bottomLeftlabel.Text = BL;
            bottomCenterLabel.Text = BC;
            bottomRightLabel.Text = BR;
            bool oWinner = CheckForOWinner(TL, TC, TR, CL, CC, CR, BL, BC, BR);
            bool xWinner = CheckForXWinner(TL, TC, TR, CL, CC, CR, BL, BC, BR);
            if (oWinner)
            {
                winnerLabel.Text = "O Wins!";
            }else if (xWinner)
            {
                winnerLabel.Text = "X Wins!";
            }else if(!oWinner && !xWinner)
            {
                winnerLabel.Text = "Cats";
            }

            

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckForOWinner(string TL, string TC, string TR, string CL, string CC, string CR, string BL, string BC, string BR)
        {
            if ((TL == "O" && TC == "O" && TR == "O") ||
               (CL == "O" && CC == "O" && CR == "O") ||
               (BL == "O" && BC == "O" && BR == "O") ||
               (TL == "O" && CL == "O" && BL == "O") ||
               (TC == "O" && CC == "O" && BC == "O") ||
               (TR == "O" && CR == "O" && BR == "O") ||
               (TL == "O" && CC == "O" && BR == "O") ||
               (BL == "O" && CC == "O" && TR == "O"))
            {
                return true;
            }
            return false;

        }

        private bool CheckForXWinner(string TL, string TC, string TR, string CL, string CC, string CR, string BL, string BC, string BR)
        {
            if ((TL == "X" && TC == "X" && TR == "X") ||
               (CL == "X" && CC == "X" && CR == "X") ||
               (BL == "X" && BC == "X" && BR == "X") ||
               (TL == "X" && CL == "X" && BL == "X") ||
               (TC == "X" && CC == "X" && BC == "X") ||
               (TR == "X" && CR == "X" && BR == "X") ||
               (TL == "X" && CC == "X" && BR == "X") ||
               (BL == "X" && CC == "X" && TR == "X"))
            {
                return true;
            }
            return false;
        }
    }
}

