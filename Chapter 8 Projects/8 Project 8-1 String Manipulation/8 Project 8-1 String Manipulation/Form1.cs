using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Project_8_1_String_Manipulation
{
    public partial class Form1 : Form
    {
        private string str;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            // assigning the string input input of tbString to str variable
            str = tbString.Text;

            // output the string on the lbOutput label and convert it to UPPER case
            lblOutput.Text = str.ToUpper();
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            str = tbString.Text;

            // Converting the string input to lower case
            lblOutput.Text = str.ToLower();
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            str = tbString.Text;

            // Returning the length of the string
            lblOutput.Text = str.Length.ToString();
        }

        private void btnSearchForUpper_Click(object sender, EventArgs e)
        {
            str = tbString.Text;

            // Create the upperCase variable
            int upperCase = 0;

            // Loop thru the string str
            // uc (uppercase) is a variable of type char
            foreach (char uc in str)
            {
                // if uc char found
                if (char.IsUpper(uc))
                {
                    // then increae upperCase variable by 1
                    upperCase++;
                }

                // Print uppercase on lbOutput
                lblOutput.Text = upperCase.ToString();
            }
        }

        private void btnSearchForLower_Click(object sender, EventArgs e)
        {
            str = tbString.Text;

            // Create the lowerCase variable
            int lowerCase = 0;

            // Loop thru the string str
            // lc (lowercase) is a variable of type char
            foreach (char lc in str)
            {
                // if lc char found
                if (char.IsLower(lc))
                {
                    // then increae lowerCase variable by 1
                    lowerCase++;
                }
                // Print lowerCase on lbOutput
                lblOutput.Text = lowerCase.ToString();
            }
        }
    }
}
