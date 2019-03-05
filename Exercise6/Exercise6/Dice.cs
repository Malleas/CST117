using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Dice
    {
        private int sideUp;
        private int one = 1;
        private int two = 2;
        private int three = 3;
        private int four = 4;
        private int five = 5;
        private int six = 6;
        int number = 0;


        public void Roll()
        {
            Random rand = new Random();
            number = rand.Next(6) + 1;
            if (number == 1)
            {
                sideUp = one;
            }
            else if (number == 2)
            {
                sideUp = two;
            }
            else if (number == 3)
            {
                sideUp = three;
            }
            else if (number == 4)
            {
                sideUp = four;
            }
            else if (number == 5)
            {
                sideUp = five;
            }
            else
            {
                sideUp = six;
            }

        }


        public int getSideUp()
        {
            return sideUp;
        }
    }
}
