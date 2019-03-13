using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lydia's code - find the errors!
//Corrected by Matt Sievers
namespace CST117_IC08_console
{
    /**
     * IDE offered some assistance on updating the class to be internal class
     * An internal class just makes it only accessible to the current project, just a simple code clean up. 
     * class Set
     */
    internal class Set
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
            foreach (var t in elements)
                /**
                 * this can be converted to a foreach loop.
                 * for (int i = 0; i < elements.Count; i++)
                 */
            {
                /** 
                 * If statement was missing {} again, moved the bool check within them
                 * moved the return false to outside the if statement
                 */ 
                if (val == t)
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
            /**
             * updated the string and int to var
             * string str = "";
             * foreach (int i in elements)
             */
            var str = "";
            foreach (var i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        /**
         * since we done need to return a value, method signature needed to be updated to retrun void
         * updated union to Union to match method syntax
         * public Set union(Set rhs)
         */

        public void Union(Set rhs)
        {
            /**
             * updated for loop to a for each
             * for (int i = 0; i < rhs.elements.Count; i++)
             */
            foreach (var t in rhs.elements)
            {
                this.addElement(t);
            }
            /**
             * This is just returning the input to this method and is not needed.
             * retunr rhs
             */ 
        }
    }
}