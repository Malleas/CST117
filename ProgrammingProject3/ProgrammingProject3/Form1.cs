using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProject3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
           
            try {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string foo;
                    StreamReader inputFile;
                    inputFile = File.OpenText(openFile.FileName);

                    while (!inputFile.EndOfStream)
                    {
                        foo = inputFile.ReadLine();
                        
                        string[] stringArray = foo.Split(' ');
                        Array.Sort(stringArray);
                        resultsTextBox.Text = foo.ToString().ToLower();

                        firstWordTextBox.Text = stringArray[0];
                        lastWordTextBox.Text = stringArray[stringArray.Length - 1];
                        /**
                         * the following find the longest word was found and used from:
                         * Unknown, M. (1 year ago, Find The Longest Word in String Array), 
                         * https://www.csharp-console-examples.com/loop/foreach-statement/find-the-longest-word-in-string-array/
                         */
                        string longestWrod = "";
                        int wordCount = 0;
                        foreach (string item in stringArray)
                        {
                            if (item.Length > wordCount)
                            {
                                wordCount = item.Length;
                                longestWrod = item;
                            }
                        }
                        longestWordTextBox.Text = longestWrod;

                        int letterA = 0;
                        int letterE = 0;
                        int letterI = 0;
                        int letterO = 0;
                        int letterU = 0;
                        int vowelCount = 0;
                        int currentCount = 0;
                        string mostVowels = "";
                        foreach(string item in stringArray)
                        {
                            if (item.Contains("a") || item.Contains("e") || item.Contains("i") || item.Contains("o") || item.Contains("u")){
                                vowelCount ++;
                            }else if (item.Contains("e"))
                            {
                                letterE += 1;
                            }else if (item.Contains("i"))
                            {
                                letterI += 1;
                            }else if (item.Contains("o"))
                            {
                                letterO += 1;
                            }else if(item.Contains("u")){
                                letterU += 1;
                            }
                            currentCount = (letterA + letterE + letterI + letterO + letterU);
                            if (currentCount > vowelCount)
                            {
                                vowelCount = currentCount;
                                mostVowels = item;
                            }
                            
                            
                        }
                        mostVowelsTextBox.Text = mostVowels;
                    }
                    
                }

              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           
        }
    }
}
