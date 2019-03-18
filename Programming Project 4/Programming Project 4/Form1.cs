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
           
            string TL = "";
            string TC = "";
            string TR = "";
            string CL = "";
            string CC = "";
            string CR = "";
            string BL = "";
            string BC = "";
            string BR = "";
            string[] piecesArray = new string[] { TL, TC, TR, CL, CC, CR, BL, BC, BR };
            
            for (int i = 0; i < piecesArray.Length; i++)
            {
                piecesArray[i] = Foo();
                string response = CheckValue(piecesArray[i]);
                piecesArray[i] = response;
            }

            topLeftLabel.Text = piecesArray[0];
            topCenterLabel.Text = piecesArray[1];
            topRightLabel.Text = piecesArray[2];
            centerLeftLabel.Text = piecesArray[3];
            centerCenterLabel.Text = piecesArray[4];
            centerRightLabel.Text = piecesArray[5];
            bottomLeftlabel.Text = piecesArray[6];
            bottomCenterLabel.Text = piecesArray[7];
            bottomRightLabel.Text = piecesArray[8];


        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string Foo()
        {
            string response = "";
            int COLS = 3;
            int ROWS = 3;
            int[,] gameboard = new int[COLS, ROWS];
            Random rand = new Random();
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    gameboard[i, j] = rand.Next(2);
                    response = gameboard[i, j].ToString();
                    
                }
            }
            return response;
        }

        private string CheckValue(string input)
        {
                if(input == "0")
                {
                    return "O";
                }
                else
                {
                    return "X";
                }
            }
           
        }
    }

