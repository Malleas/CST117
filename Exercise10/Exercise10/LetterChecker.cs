using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class LetterChecker
    {
        public string StringCheker(string input)
        {
            int count = 0;
            string[] stringArray = input.Split(' ');
       //     string response =
       //         "There are " + stringArray.Length + " words to check" + "\n" + 
       //         "The amount of words that end in e are: " + count_E +
       //         "\n" + "and the amount of words that end in t is: " + count_T;
            foreach (string word in stringArray)
            {
                
                char last = CheckForPunctuation(word);
                bool eCheck = last.Equals('e');
                bool tcheck =last.Equals('t');
                if(eCheck || tcheck)
                {
                    count++;
                }
            }
            string response =
                "There are " + stringArray.Length + " words to check" + "\n" +
                "The amount of words that end in e or a t are: " + count ;
            return response;
        }

        private char CheckForPunctuation(string word)
        {
            
            char last = word[word.Length - 1];
            bool isPunctuation = char.IsPunctuation(last);
            if (isPunctuation)
            {
                char newLast = word[word.Length - 2];
                return newLast;
            }
            else return last;
            
        }
 
    }
}
