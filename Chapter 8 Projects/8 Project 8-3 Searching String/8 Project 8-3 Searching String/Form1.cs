using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Project_8_3_Searching_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContain_Click(object sender, EventArgs e)
        {
            // variable
            string str;

            // str variable stores the input of the tbInPut
            str = tbInput.Text;

            // id the input string contains the word DMACC
            if (str.Contains("DMACC"))
            {
                // Display message
                MessageBox.Show("The sequence 'DMACC' was found in " + str);
            }
            else
            {
                // If not found, display notice the escapte sequence character
                // used to display " " 
                MessageBox.Show("The word \"DMACC\" not found in " + str);
            }
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            // Formatting my phone number
            MessageBox.Show(string.Format("My phone#: " + "{0:(###) ###-####}", 5159646461));

            // Formatting the date
            MessageBox.Show(string.Format("{0:yyy-dd-MM T HH:mm:ss:0000}", DateTime.Now));
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            // Creating str string variable
            string str;

            // storing the input of tbInput in str variable
            str = tbInput.Text;

            // In Substring, we extract a fragment of an existing stirng
            // Here we skip the first 2 characters and display the rest of the string
            string substr = str.Substring(2);
            MessageBox.Show(str + ", skip the fisrt two letters, " + substr);

            // Start after the second character and display 5 afterwards
            substr = str.Substring(3, 5);
            MessageBox.Show(str + ", start after the 3 character and display 5 afterwards, " + substr);
        }

        private void btnStringToChar_Click(object sender, EventArgs e)
        {
            // Creating str string variable
            string str;

            // storing the input of tbInput in str variable
            str = tbInput.Text;

            // Creating a letter variable of type char
            char letter;

            // loop thru the stirng str
            for (int index = 0; index < str.Length; index++)
            {
                //assigning the string str characters to letter variable
                letter = str[index];

                // display the letter variable
                MessageBox.Show(letter.ToString());
            }
        }

        private void btnStartsWith_Click(object sender, EventArgs e)
        {
            // Creating str string variable
            string str;

            // storing the input of tbInput in str variable
            str = tbInput.Text;

            // If the string starts with "ab"
            if (str.StartsWith("ab"))
            {
                // Display true
                MessageBox.Show("True");
                MessageBox.Show(str + ", starts with \"ab\"");
            }
            else
            {
                // If not, display false
                MessageBox.Show("False");
                MessageBox.Show(str + ", does starts with \"ab\"");
            }
        }

        private void btnEndsWith_Click(object sender, EventArgs e)
        {
            // variable
            string str;

            // storing the input of tbInput in str variable
            str = tbInput.Text;

            if (str.EndsWith("eam"))
            {
                // Display true
                MessageBox.Show("True");
                MessageBox.Show(str + ", ends with \"eam\"");
            }
            else
            {
                // If not, display false
                MessageBox.Show("False");
                MessageBox.Show(str + ", does not ends with \"eam\"");
            }
        }
    }
}
