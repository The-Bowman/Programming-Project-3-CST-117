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

namespace Programming_Project_3
{
    public partial class instructionLabel : Form
    {
        public instructionLabel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //setting up variables to process file
            StreamReader fileSelected;          
            string lower;
            string first;
            string last;
            string longest = "";
            int maxLength;
            string mostVowels = "";
            int vowels;
            int maxVowels = 0;

            //determines if a file was selected to process
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileSelected = File.OpenText(openFile.FileName); //opens file
                lower = fileSelected.ReadLine().ToLower(); //converts string to lower case
                string[] sorted = lower.Split(' '); //splits string into an array, delimiting at each space between words
                Array.Sort(sorted); //Array class method to sort the array alphabetically
                first = sorted[0]; //stores first index of string array
                last = sorted[sorted.Length - 1]; //stores last index of string array
                int currentStringLength = 0;

                //loops through each "word" in the array
                foreach (string s in sorted)
                {
                    //checks length of string against highest, assigns new highest to the current word if it is longer
                    if (s.Length > currentStringLength)
                    {
                        longest = s;
                        currentStringLength = s.Length;
                    }

                    vowels = 0; //resets vowel count

                    //loops through each character of the "word" checking for vowels
                    for (int i = 0; i < s.Length; i++)
                    {
                        
                        //vowel check
                        if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                        {
                            vowels++; //iterates vowels
                        }

                        //checks if nuber of vowels of the current word is greater than the highest, assigns new string to highest vowel count if true
                        if (vowels > maxVowels)
                        {
                            maxVowels = vowels;
                            mostVowels = s;
                        }

                    }

                }

                maxLength = currentStringLength;

                displayText.Text = "The contenst of the file in lower case reads:\n" + lower + "\n\n"+ "The first and last words, alphabetically:\n"  +"First: " + first +
                    " / Last: " + last + "\n\n" +"This is the longest word in the file:\n" + longest + ": The number of letters: " + currentStringLength + "\n\n" + 
                    "The word with the most vowels is:\n" + mostVowels;

                fileSelected.Close();
            } else
            {
                MessageBox.Show("No file selected.");
            }

            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //closes program
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputToFile;
            
            //allows user to save file to their specified location
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    outputToFile = File.CreateText(saveFile.FileName);
                    outputToFile.WriteLine(displayText.Text);
                    outputToFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                MessageBox.Show("Saving has been canceled.");
            }

            
        }
    }
}
