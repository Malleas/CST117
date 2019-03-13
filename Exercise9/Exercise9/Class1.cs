using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lydia's code - find the errors!
//Corrected by Matt Sievers
namespace CST117_IC08_console
{
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            /**
             * Missing {} after the if statement, moved the return within the if statement
             * if (containsElement(val)) return false;
             */ 
            if (containsElement(val))
            {
                return false;
            }
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                /** 
                 * If statement was missing {} again, moved the bool check within them
                 * moved the return false to outside the if statement
                 */ 
                if (val == elements[i])
                {
                    return true;
                }

                //        else
                //            return false;
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {

            for (int i = 0; i < rhs.elements.Count; i++)
            {
                this.addElement(rhs.elements[i]);
            }
            return rhs;
        }
    }
}