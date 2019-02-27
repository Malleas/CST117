using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                    string text;
                    StreamReader inputFile;
                    inputFile = File.OpenText(openFile.FileName);

                    while (!inputFile.EndOfStream)
                    {
                        text = inputFile.ReadLine();
                        
                        string[] stringArray = text.Split(' ');
                        Array.Sort(stringArray);
                        toLowerCaseTextBox.Text = text.ToString().ToLower();

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

                        int vowelCount = 0;
                        int currentCount = 0;
                        string mostVowels = "";
                        foreach(string item in stringArray)
                        {
                            currentCount = Regex.Matches(item, @"[aeiou]").Count;
                            if(currentCount > vowelCount)
                            {
                                vowelCount = currentCount;
                                mostVowels = item;
                            }
                            
                            
                        }
                        mostVowelsTextBox.Text = mostVowels;

                        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "outPutStats.txt"));
                        outputFile.WriteLine("To lowercase: " + "\n\n" + toLowerCaseTextBox.Text);
                        outputFile.WriteLine("\n\n");
                        outputFile.WriteLine("First word alphabetically is: " + firstWordTextBox.Text);
                        outputFile.WriteLine("\n\n");
                        outputFile.WriteLine("Last word alphabetically is: " + lastWordTextBox.Text);
                        outputFile.WriteLine("\n\n");
                        outputFile.WriteLine("The longest word is: " + longestWordTextBox.Text);
                        outputFile.WriteLine("\n\n");
                        outputFile.WriteLine("The word with the most vowels is: " + mostVowelsTextBox.Text);

                        outputFile.Close();
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
