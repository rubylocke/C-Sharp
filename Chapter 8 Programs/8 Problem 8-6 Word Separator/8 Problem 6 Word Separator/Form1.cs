using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Problem_6_Word_Separator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReformat_Click(object sender, EventArgs e)
        {
            // Declare variable that will capture the letter you are dealing with
            char letter;

            //String that you get in
            string str = tbInput.Text;

            // String you write out
            string str1="";

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    // Is it the first character of the string Captialize
                    if (i == 0)
                    {
                        letter = str[i];
                        str1 += letter;
                    }
                    else
                    {
                        letter = ' ';
                        str1 += letter;
                        letter = char.ToLower(str[i]);
                        str1 += letter;
                    }
                }
                else
                {
                    letter = str[i];
                    str1 += letter;
                }
            }
            lblOutput.Text = str1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
