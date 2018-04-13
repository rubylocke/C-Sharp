using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Project_8_4_SSN_Formatter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // validSocialSecurityNumber receives string agrument and checks if it is 
        // 9 digits long and numeric.  Returns true; else returns false
        private bool validSocialSecurityNumber(string str)
        {
            // Boolean variable set to true
            bool valid = true;

            //if the intput string = 9
            if (str.Length == 9)
            {
                // Loop thru str
                foreach (char c in str)
                {
                    // if an char in str is not a digit
                    if (!char.IsDigit(c))
                    {
                        // then set valid to false
                        valid = false;
                    }
                }
            }
            else
            {
                // then set valid to false
                valid = false;
            }
            return valid;
        }

        // socialFormat method receives value by ref, reformats and returns value by ref 
        private void socialFormat(ref string str)
        {
            // Insert at index 3 "-'
            str = str.Insert(3, "-");
            // Insert at index 6 "-"
            str = str.Insert(6, "-");
        }

        //Format as SSN
        private void btnFormat_Click(object sender, EventArgs e)
        {
            // Variable
            string str1;

            // Use Trim method to remove leading and trailing white spaces
            str1 = tbOutput.Text.Trim();

            /*
            Calling validSocialSecurityNumber method thru IF statement
            Then passing the str1 varaible to validSocialSecurityNumber method
            This method ensures that every input is valid and 9 digits long
            */
            if (validSocialSecurityNumber(str1))
            {
                // Calling socialFormat method to format the input as SSN
                // Passing the str1 varaible by ref
                socialFormat(ref str1);

                // Display the input string
                MessageBox.Show(str1);
            }
            else
            {
                // If the number entered does not contain 9 digits display "Invalid input
                MessageBox.Show("Invalid input!");
            }
        }
    }
}
