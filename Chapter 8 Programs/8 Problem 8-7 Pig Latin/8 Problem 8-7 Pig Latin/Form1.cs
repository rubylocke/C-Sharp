using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Problem_8_7_Pig_Latin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPigLatinConverter_Click(object sender, EventArgs e)
        {
            string strAy = "ay";
            // Declare variable that will capture the letter you are dealing with
            char letter;
            // Have a variable for the letter being captured for future use
            char letterSaved = ' ';

            //String that you get in
            string str = tbInputSentence.Text;

            // String you write out
            string str1 = "";

            // bool value to say if on First letter of string
            bool firstLetter = true;

            for (int i = 0; i < str.Length; i++)
            {
                letter = str[i];

                if (firstLetter)
                {
                    letterSaved = letter;
                    firstLetter = false;
                }
                else
                {
                    if (char.IsWhiteSpace(letter))
                    {
                        str1 += letterSaved;
                        firstLetter = true;
                        str1 += strAy;
                        str1 += letter;    // stored the space
                    }
                    else
                    {
                        str1 += letter;
                    }
                }
            }
            // Last character
            str1 += letterSaved;
            str1 += strAy;

            // Display the results
            lbOutput.Text = str1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
