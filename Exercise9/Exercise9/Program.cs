//use for IC08
//Lydia's code
//Corrected by Matt Sievers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST117_IC08_console
{
    /**
     * upated class to be Static and Internal to match the Set class
     * class Program
     */
    internal static class Program
    {

        /**
         * Missing the public needed for a main method
         * static void Main(string[] args)
         */ 
        public static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            /**
             * removed the unneeded console log of A.union(B) as this is repeated on line 48.
             * The logic of Union() was sound, but was returning the value of B
             */ 
            A.Union(B);

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            /**
             * Added a Console.Readline to give the ability to read the output
             */ 
            Console.ReadLine();

        }
    }
}
 