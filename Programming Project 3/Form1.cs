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
            
            StreamReader fileSelected;
            openFile.ShowDialog();
            string lower;
            string first;
            string last;
            string longest = "";
            int maxLength;
            string mostVowels = "";
            int vowels;
            int maxVowels = 0;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileSelected = File.OpenText(openFile.FileName);
                lower = fileSelected.ReadLine().ToLower();
                string[] sorted = lower.Split(' ');
                Array.Sort(sorted);
                first = sorted[0];
                last = sorted[sorted.Length - 1];
                int currentStringLength = 0;
                foreach (string s in sorted)
                {
                    
                    if (s.Length > currentStringLength)
                    {
                        longest = s;
                        currentStringLength = s.Length;
                    }

                    vowels = 0;

                    for (int i = 0; i < s.Length; i++)
                    {
                        
                        if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                        {
                            vowels++;
                        }


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
               
            } else
            {
                MessageBox.Show("No file selected.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputToFile;
            saveFile.ShowDialog();

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
