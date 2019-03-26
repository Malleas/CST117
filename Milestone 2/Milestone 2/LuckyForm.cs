using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_2
{
    public partial class LuckyForm : Form
    {
        public LuckyForm()
        {
            InitializeComponent();
        }

        private void luckyBtn_Click(object sender, EventArgs e)
        {
            
            int[] luckyBoard = new int[3];
            Random rand = new Random();
            for (int i = 0; i < luckyBoard.Length; i++)
            {
                    luckyBoard[i] = rand.Next(8);    
            }
            int left = luckyBoard[0];
            int center = luckyBoard[1];
            int right = luckyBoard[2];
            leftLabel.Text = left.ToString();
            centerLabel.Text = center.ToString();
            rightLabel.Text = right.ToString();
            CheckForWinner(left, center, right);
        }

        private void CheckForWinner(int L, int C, int R)
        {
            if(L == 7 && C == 7 && R == 7)
            {
                luckyResultsLabel.Text = "Winner Winner Chicken Dinner!";
            }else
            {
                luckyResultsLabel.Text = "Whomp Whomp...You're Not Lucky!";
            }
        }

        private void luckyExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
