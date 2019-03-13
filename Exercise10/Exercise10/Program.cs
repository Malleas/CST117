using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            LetterChecker checker = new LetterChecker();
            string input = File.ReadAllText("C:\\Users\\Movie Box\\Dropbox\\GCU Work\\CST-117\\CST117\\Exercise10\\Exercise10\\app_data\\inputFile.txt");
            string output = checker.StringCheker(input);
            Console.WriteLine(output);
            Console.WriteLine("Press any key to exit");
            Console.Read();
        }
    }
}
