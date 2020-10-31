﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
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
            string mostVowels;
            int vowels = 0;
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

                displayText.Text = lower + "\n" + first + " " + last + "\n" + longest;

            } else
            {
                MessageBox.Show("NOPE");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}